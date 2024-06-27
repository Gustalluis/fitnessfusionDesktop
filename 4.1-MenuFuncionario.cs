using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Mysqlx;

namespace fitnessfusion
{
    public partial class frmMenuCadastroFuncionario : Form
    {
        public frmMenuCadastroFuncionario()
        {
            InitializeComponent();
        }
        /*VALIDAÇÃO FTP*/
        private bool ValidarFTP()
        {
            if (string.IsNullOrEmpty(variaveis.enderecoServidorFtp) || string.IsNullOrEmpty(variaveis.usuarioFtp) || string.IsNullOrEmpty(variaveis.senhaFtp))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /*CONVERTER A IMAGEM EM BYTE*/
        public byte[] GetImgToByte(string caminhoArquivoFtp)
        {
            WebClient ftpCliente = new WebClient();
            ftpCliente.Credentials = new NetworkCredential(variaveis.usuarioFtp, variaveis.senhaFtp);
            try
            {
                byte[] imageToByte = ftpCliente.DownloadData(caminhoArquivoFtp);
                return imageToByte;
            }
            catch
            {
                byte[] imageToByte = ftpCliente.DownloadData("ftp://127.0.0.1/admin/img/funcionario/semfoto.png");
                return imageToByte;
            }

        }

        /*CONVERTER A IMAGEM DE BYTE para IMAGEM*/
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
        // METODO mysql 

        private void inserirFuncionario()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO funcionario (nomeFuncionario, cargoFuncionario, telefoneFuncionario, enderecoFuncionario, emailFuncionario, senhaFuncionario, salarioFuncionario, dataCadFuncionario, statusFuncionario, fotoFuncionario, altFuncionario) " +
                    "VALUES (@nome, @cargo, @telefone, @endereco, @email, @senha, @salario, @dataCad, @status, @foto, @alt);";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexaoDb);

                cmd.Parameters.AddWithValue("@nome", variaveis.nomeFuncionario);
                cmd.Parameters.AddWithValue("@cargo", variaveis.cargoFuncionario);
                cmd.Parameters.AddWithValue("@telefone", variaveis.telefoneFuncionario);
                cmd.Parameters.AddWithValue("@endereco", variaveis.enderecoFuncionario);
                cmd.Parameters.AddWithValue("@email", variaveis.emailFuncionario);
                cmd.Parameters.AddWithValue("@senha", variaveis.senhaFuncionario);
                cmd.Parameters.AddWithValue("@salario", variaveis.salarioFuncionario);
                cmd.Parameters.AddWithValue("@dataCad", variaveis.datacadFuncionario);
                cmd.Parameters.AddWithValue("@status", variaveis.statusFuncionario);
                cmd.Parameters.AddWithValue("@foto", variaveis.fotoFuncionario);
                cmd.Parameters.AddWithValue("@alt", variaveis.altFuncionario);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario cadastrado com sucesso", "CADASTRO");
                banco.Desconectar();

                if (ValidarFTP())
                {
                    if (!string.IsNullOrEmpty(variaveis.fotoFuncionario))
                    {
                        string urlEnviarArquivo = variaveis.enderecoServidorFtp + "img/funcionario/" + Path.GetFileName(variaveis.fotoFuncionario);
                        try
                        {
                            ftp.EnviarArquivoFtp(variaveis.caminhoFotoFuncionario, urlEnviarArquivo, variaveis.usuarioFtp, variaveis.senhaFtp);
                        }
                        catch
                        {
                            MessageBox.Show("Foto não foi Selecionada ou existente no servidor.", "FOTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro Ao inserir Funcionario\n\n" + erro);
            }
        }

        private void carregarfuncionario()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM funcionario WHERE idFuncionario = @codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexaoDb);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codigoFuncionario);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.nomeFuncionario = dr.GetString(1);
                    variaveis.cargoFuncionario = dr.GetString(2);
                    variaveis.telefoneFuncionario = dr.GetString(3);
                    variaveis.enderecoFuncionario = dr.GetString(4);
                    variaveis.emailFuncionario = dr.GetString(5);
                    variaveis.senhaFuncionario = dr.GetString(6);
                    variaveis.salarioFuncionario = dr.GetFloat(7);
                    variaveis.statusFuncionario = dr.GetString(9);
                    variaveis.fotoFuncionario = dr.GetString(10).Remove(0, 12);
                    variaveis.altFuncionario = dr.GetString(11);


                    txtNome.Text = variaveis.nomeFuncionario;
                    txtCargo.Text = variaveis.cargoFuncionario;
                    mtbTelefone.Text = variaveis.telefoneFuncionario;
                    txtEndereco.Text = variaveis.enderecoFuncionario;
                    txtEmail.Text = variaveis.emailFuncionario;
                    txtSenha.Text = variaveis.senhaFuncionario;
                    txtSalario.Text = Convert.ToString(variaveis.salarioFuncionario);
                    cmbStatusCad.Text = variaveis.statusFuncionario;
                    pctFoto.Image = ByteToImage(GetImgToByte(variaveis.enderecoServidorFtp + "img/funcionario/" + variaveis.fotoFuncionario));

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar .\n\n" + erro);
            }
        }

        private void alterarFuncionario()
        {
            try
            {
                banco.Conectar();
                string alterar = "update funcionario set nomeFuncionario = @nome, cargoFuncionario = @cargo, telefoneFuncionario = @telefone, enderecoFuncionario = @endereco," +
               " emailFuncionario = @email, senhaFuncionario = @senha, salarioFuncionario = @salario, statusFuncionario = @status, altFuncionario = @alt WHERE idFuncionario = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexaoDb);

                cmd.Parameters.AddWithValue("@nome", variaveis.nomeFuncionario);
                cmd.Parameters.AddWithValue("@cargo", variaveis.cargoFuncionario);
                cmd.Parameters.AddWithValue("@telefone", variaveis.telefoneFuncionario);
                cmd.Parameters.AddWithValue("@endereco", variaveis.enderecoFuncionario);
                cmd.Parameters.AddWithValue("@email", variaveis.emailFuncionario);
                cmd.Parameters.AddWithValue("@senha", variaveis.senhaFuncionario);
                cmd.Parameters.AddWithValue("@salario", variaveis.salarioFuncionario);
                cmd.Parameters.AddWithValue("@status", variaveis.statusFuncionario);
                cmd.Parameters.AddWithValue("@alt", variaveis.altFuncionario);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codigoFuncionario);

                cmd.ExecuteNonQuery();
                MessageBox.Show("funcionario alterado com sucesso", "CADASTRO FUNCIONARIO");
                banco.Desconectar();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao alterar .\n\n" + erro);
            }
        }

        private void alterarFotoFuncionario()
        {
            try
            {
                banco.Conectar();
                string alterar = " UPDATE funcionario SET fotoFuncionario = @foto WHERE idFuncionario = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexaoDb);
                //parametros

                cmd.Parameters.AddWithValue("@foto", variaveis.fotoFuncionario);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codigoFuncionario);


                //fim parametros
                cmd.ExecuteNonQuery();
                banco.Desconectar();

                if (ValidarFTP())
                {
                    if (!string.IsNullOrEmpty(variaveis.fotoFuncionario))
                    {
                        string urlEnviarArquivo = variaveis.enderecoServidorFtp + "img/funcionario/" + Path.GetFileName(variaveis.fotoFuncionario);
                        try
                        {
                            ftp.EnviarArquivoFtp(variaveis.caminhoFotoFuncionario, urlEnviarArquivo, variaveis.usuarioFtp, variaveis.senhaFtp);
                        }
                        catch
                        {
                            MessageBox.Show("Foto não foi Selecionada ou existente no servidor.", "FOTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar FOTO do funcionario.\n\n" + erro);

            }

        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            new frmMenuFuncionario().Show(this);
            Hide();
        }
        private void frmMenuCadastroFuncionario_Load(object sender, EventArgs e)
        {
            if (variaveis.funcao == "CADASTRAR")
            {
                lblTitulo.Text = "CADASTRO FUNCIONARIO";


            }
            else if (variaveis.funcao == "ALTERAR")
            {
                carregarfuncionario();
                lblTitulo.Text = "ALTERAR FUNCIONARIO";

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            variaveis.nomeFuncionario = txtNome.Text;
            variaveis.cargoFuncionario = txtCargo.Text;
            variaveis.telefoneFuncionario = mtbTelefone.Text;
            variaveis.enderecoFuncionario = txtEndereco.Text;
            variaveis.emailFuncionario = txtEmail.Text;
            variaveis.senhaFuncionario = txtSenha.Text;
            variaveis.salarioFuncionario = float.Parse(txtSalario.Text);
            variaveis.datacadFuncionario = DateTime.Now;
            variaveis.statusFuncionario = cmbStatusCad.Text;
            variaveis.altFuncionario = "foto" + txtNome.Text;

            if (variaveis.funcao == "CADASTRAR")
            {
                inserirFuncionario();
                lblTitulo.Text = "CADASTRO FUNCIONARIO";

            }
            else if (variaveis.funcao == "ALTERAR")
            {
                alterarFuncionario();
                lblTitulo.Text = "ALTERAR FUNCIONARIO";
                if (variaveis.atFotoFuncionario == "S")
                {
                    alterarFotoFuncionario();
                }

            }

        }

        private void btnAddFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofdFoto = new OpenFileDialog();
                ofdFoto.Multiselect = false;
                ofdFoto.FileName = "";
                ofdFoto.InitialDirectory = @"C:";
                ofdFoto.Title = "SELECIONE UMA FOTO";
                ofdFoto.Filter = "JPG ou PNG (*.jpg ou (*.png)|*.jpg;*.png";
                ofdFoto.CheckFileExists = true;
                ofdFoto.CheckPathExists = true;
                ofdFoto.RestoreDirectory = true;

                DialogResult result = ofdFoto.ShowDialog();
                pctFoto.Image = Image.FromFile(ofdFoto.FileName);
                variaveis.fotoFuncionario = "funcionario/" + Regex.Replace(txtNome.Text, @"\s", "").ToLower() + ".png";

                if (result == DialogResult.OK)
                {
                    try
                    {
                        variaveis.atFotoFuncionario = "S";
                        variaveis.caminhoFotoFuncionario = ofdFoto.FileName;
                    }
                    catch (SecurityException erro)
                    {
                        MessageBox.Show("Erro de segurança - Fale com o admin \n Messagem: " + erro + "\n Detalhe: " + erro.StackTrace);
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Você não tem permissão. \n Detalhe: " + erro);
                    }
                }
                btnSalvar.Focus();
            }
            catch
            {
                btnSalvar.Focus();
            }
        }
    }
}
