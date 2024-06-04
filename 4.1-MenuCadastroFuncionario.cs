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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitnessfusion
{
    public partial class frmMenuCadastroFuncionario : Form
    {
        public frmMenuCadastroFuncionario()
        {
            InitializeComponent();
        }
        //validação ftp 
        private bool validarFTP()
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

        public byte[] GetImgTobyte(string caminhoArquivoFtp)
        {
            WebClient ftpcliente = new WebClient();
            ftpcliente.Credentials = new NetworkCredential(variaveis.usuarioFtp, variaveis.senhaFtp);
            try
            {
                byte[] imageToByte = ftpcliente.DownloadData(caminhoArquivoFtp);
                return imageToByte;
            }
            catch
            {
                byte[] imageToByte = ftpcliente.DownloadData("ftp://127.0.0.1/admin/img/funcionario/semimagem.png");
                return imageToByte;
            }
        }
        // converter a imagem e byte
        public byte[] GetImgToByte(string caminhoArquivoFtp)
        {
            WebClient ftpCliente = new WebClient();
            ftpCliente.Credentials = new NetworkCredential(variaveis.usuarioFtp, variaveis.senhaFtp);
            byte[] imageTobyte = ftpCliente.DownloadData(caminhoArquivoFtp);
            return imageTobyte;
        }
        // converter a imagem de byte para imagem
        public static Bitmap byteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }


        // METODO
        private void inserirfuncionario()
        {
            try
            {
                banco.Conectar();
                string Inserir = "insert into funcionario (nomeFuncionario,cargoFuncionario, telefoneFuncionario, enderecoFuncionario, emailFuncionario, senhaFuncionario, fotoFuncionario, altFuncionario, statusFuncionario, datacadFuncionario, salarioFuncionario) " +
                "values (@nome,@cargo, @telefone, @endereco, @email, @senha, FotoFuncionario, altFuncionario, @status, @datacad,salarioFuncionario );";
                MySqlCommand cmd = new MySqlCommand(Inserir, banco.conexaoDb);
                //parametros
                cmd.Parameters.AddWithValue("@nome", variaveis.nomeFuncionario);
                cmd.Parameters.AddWithValue("@cargo", variaveis.cargoFuncionario);
                cmd.Parameters.AddWithValue("@telefone", variaveis.telefoneFuncionario);
                cmd.Parameters.AddWithValue("@endereco", variaveis.enderecoFuncionario);
                cmd.Parameters.AddWithValue("@email", variaveis.emailFuncionario);
                cmd.Parameters.AddWithValue("@senha", variaveis.senhaFuncionario);
                cmd.Parameters.AddWithValue("@fotoFuncionario", variaveis.fotoFuncionario);
                cmd.Parameters.AddWithValue("@altFuncionario", variaveis.altFuncionario);
                cmd.Parameters.AddWithValue("@status", variaveis.statusFuncionario);
                cmd.Parameters.AddWithValue("@datacad", variaveis.datacadFuncionario);
                cmd.Parameters.AddWithValue("@salarioFuncionario", variaveis.salarioFuncionario);
                //Fim parametros
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado com sucesso", "CADASTRO DE CLIENTE");
                banco.Desconectar();

                if (validarFTP())
                {
                    if (!string.IsNullOrEmpty(variaveis.fotocliente))
                    {
                        string urlEnviarArquivo = variaveis.enderecoServidorFtp + "img/cliente/" + Path.GetFileName(variaveis.fotocliente);
                        try
                        {
                            ftp.EnviarArquivoFtp(variaveis.CaminhoFotoCliente, urlEnviarArquivo, variaveis.usuarioFtp, variaveis.senhaFtp);
                        }
                        catch
                        {

                            MessageBox.Show("foto não foi selecionada ou existente no servidor.", "FOTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro Ao inserir Cliente\n\n" + erro);
            }
        }
        private void carregarFuncionario()
        {
            {
                try
                {
                    banco.Conectar();
                    string selecionar = "SELECT *FROM tbl_cliente WHERE idCliente = @codigo;";
                    MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexaoDb);
                    cmd.Parameters.AddWithValue("@codigo", variaveis.codigoFuncionario);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        variaveis.nomeFuncionario = dr.GetString(1);
                        variaveis.cargoFuncionario = dr.GetString(2);
                        variaveis.fotoFuncionario = variaveis.fotoFuncionario.Remove(0, 8);
                        variaveis.altFuncionario = dr.GetString(3);
                        variaveis.telefoneFuncionario = dr.GetString(4);
                        variaveis.enderecoFuncionario = dr.GetString(5);
                        variaveis.emailFuncionario = dr.GetString(6);
                        variaveis.senhaFuncionario = dr.GetString(7);
                        variaveis.statusFuncionario = dr.GetString(8);
                        variaveis.datacadFuncionario = dr.GetDateTime(9);
                        variaveis.salarioFuncionario = dr.GetString(10);

                        txtNome.Text = variaveis.nomeFuncionario;
                        txtCargo.Text = variaveis.cargoFuncionario;
                        mtbTelefone.Text = variaveis.telefoneFuncionario;
                        txtEndereco.Text = variaveis.enderecoFuncionario;
                        txtEmail.Text = variaveis.emailFuncionario;
                        txtSenha.Text = variaveis.senhaFuncionario;
                        cmbStatusCad.Text = variaveis.statusFuncionario;
                        //variaveis.datacadFuncionario = mtbDatacad.set;
                        txtSalario.Text = variaveis.salarioFuncionario;  
                    }
                    banco.Desconectar();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("erro ao carregar os dados do cliente. \n\n" + erro);
                }
            }
        }
        private void alterarFotoFuncionario()
        {
            try
            {
                banco.Conectar();
                string Inserir = "UPDATE tbl_cliente SET fotocliente =@n" +
                    "foto, WHERE idCliente = @codigo;";
                MySqlCommand cmd = new MySqlCommand(Inserir, banco.conexaoDb);
                //parametros
                cmd.Parameters.AddWithValue("@foto", variaveis.fotoFuncionario);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codigoFuncionario);
                //Fim parametros
                cmd.ExecuteNonQuery();
                banco.Desconectar();

                if (validarFTP())
                {
                    if (!string.IsNullOrEmpty(variaveis.fotoFuncionario))
                    {
                        string urlEnviarArquivo = variaveis.enderecoServidorFtp + "img/cliente/" + Path.GetFileName(variaveis.fotoFuncionario);
                        try
                        {
                            ftp.EnviarArquivoFtp(variaveis.CaminhoFotoCliente, urlEnviarArquivo, variaveis.usuarioFtp, variaveis.senhaFtp);
                        }
                        catch
                        {

                            MessageBox.Show("foto não foi selecionada ou existente no servidor.", "FOTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro Ao alterar Cliente\n\n" + erro);
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
            variaveis.statusFuncionario = cmbStatusCad.Text;
            variaveis.salarioFuncionario = txtSalario.Text;
            variaveis.altFuncionario = "foto" + txtNome.Text;

            if (variaveis.funcao == "CADASTRAR")
            {
                inserirfuncionario();

                lblTitulo.Text = "CADASTRO CLIENTE";

            }
            else if (variaveis.funcao == "ALTERAR")
            {
                carregarFuncionario();
                lblTitulo.Text = "ALTERAR";
                alterarFotoFuncionario();
            }

        }
    }
}
