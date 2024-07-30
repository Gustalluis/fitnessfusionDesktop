using MySql.Data.MySqlClient;
using Mysqlx;
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
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
                byte[] imageToByte = ftpCliente.DownloadData("ftp://u283879542.fitnessfusion@smpsistema.com.br/admin/img/funcionario/semfoto.png");
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
            try { 
            banco.Conectar();
            string query = "INSERT INTO funcionario (nomeFuncionario, cargoFuncionario, telefoneFuncionario, enderecoFuncionario, emailFuncionario, senhaFuncionario, salarioFuncionario, statusFuncionario, altFuncionario, dataCadFuncionario, fotoFuncionario) " +
                           "VALUES (@nome, @cargo, @fone, @endereco, @email, @senha, @salario, @status, @alt, @dataCad, @foto);";
            MySqlCommand cmd = new MySqlCommand(query, banco.conexaoDb);

            cmd.Parameters.AddWithValue("@nome", variaveis.nomeFuncionario);
            cmd.Parameters.AddWithValue("@cargo", variaveis.cargoFuncionario);
            cmd.Parameters.AddWithValue("@fone", variaveis.telefoneFuncionario);
            cmd.Parameters.AddWithValue("@endereco", variaveis.enderecoFuncionario);
            cmd.Parameters.AddWithValue("@email", variaveis.emailFuncionario);
            cmd.Parameters.AddWithValue("@senha", variaveis.senhaFuncionario);
            cmd.Parameters.AddWithValue("@salario", variaveis.salarioFuncionario);
            cmd.Parameters.AddWithValue("@status", variaveis.statusFuncionario);
            cmd.Parameters.AddWithValue("@dataCad", DateTime.Now); // Adicionando a data atual
            cmd.Parameters.AddWithValue("@alt", variaveis.altFuncionario);
            cmd.Parameters.AddWithValue("@foto", variaveis.fotoFuncionario);
            cmd.ExecuteNonQuery();
                MessageBox.Show("FUNCIONARIO cadastrado com sucesso", "CADASTRO DE FUNCIONARIO");
                banco.Desconectar();

                if (ValidarFTP())
                {
                    if (!string.IsNullOrEmpty(variaveis.fotoFuncionario))
                    {
                        
                        string urlEnviarArquivo = variaveis.enderecoServidorFtp + "img/funcionario/" + Path.GetFileName(variaveis.fotoFuncionario);
                        MessageBox.Show(urlEnviarArquivo);
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
                MessageBox.Show("Erro Ao inserir funcionario\n\n" + erro);
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
            variaveis.emailFuncionario = txtEmail.Text;
            variaveis.senhaFuncionario = txtSenha.Text;
            variaveis.enderecoFuncionario = txtEndereco.Text;
            variaveis.salarioFuncionario = double.Parse(txtSalario.Text);
            variaveis.statusFuncionario = cmbStatusCad.Text;
            variaveis.altFuncionario = "foto" + txtNome.Text;

            if (variaveis.funcao == "CADASTRAR")
            {
                inserirFuncionario();
                MessageBox.Show(variaveis.fotoFuncionario);


            }
            else if (variaveis.funcao == "ALTERAR")
            {
                

                if (variaveis.atFotoFuncionario == "S")
                {
                    
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
                if (result == DialogResult.OK)
                {
                    pctFoto.Image = Image.FromFile(ofdFoto.FileName);
                    variaveis.fotoFuncionario = Regex.Replace(txtNome.Text, @"\s", "").ToLower() + ".png";
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

        private void pnlCad_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
