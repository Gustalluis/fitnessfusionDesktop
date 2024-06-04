using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitnessfusion
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
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
                byte[] imageToByte = ftpcliente.DownloadData("ftp://127.0.0.1/admin/img/cliente/semimagem.png");
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
        // metodo mysql
        private void InserirCliente()
        {
            try
            {
                banco.Conectar();
                string Inserir = "insert into cliente " +
                    "(nomecliente, telefoneCliente, emailcliente, senhacliente, fotoCliente, altCliente, " +
                    "statusCliente) values (@nome, @telefone, @email, @senha, @foto, @alt, @status);";
                MySqlCommand cmd = new MySqlCommand(Inserir, banco.conexaoDb);
                //parametros
                cmd.Parameters.AddWithValue("@none", variaveis.nomecliente);
                cmd.Parameters.AddWithValue("@telefone", variaveis.telefonecliente);
                cmd.Parameters.AddWithValue("@email", variaveis.emailcliente);
                cmd.Parameters.AddWithValue("@senha", variaveis.senhacliente);
                cmd.Parameters.AddWithValue("@foto", variaveis.fotocliente);
                cmd.Parameters.AddWithValue("@alt", variaveis.altcliente);
                cmd.Parameters.AddWithValue("@status", variaveis.statuscliente);
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
       
        

        


        private void btnSair_Click(object sender, EventArgs e)
        {
            new frmMenuCliente().Show(this);
            Hide();
        }

        private void rbtnSIM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSIM.Checked)
            {
                pnlAvaliacao.Visible = true;
                btnSalvar.Visible = true;   
            }
          
        }

        private void rbtnNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNao.Checked)
            {
                pnlAvaliacao.Visible = false;
                btnSalvar.Visible = true;
            }
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            if (variaveis.funcao == "CADASTRAR") 
            {

                lblTitulo.Text = "CADASTRO CLIENTE";
               
            }
            else if (variaveis.funcao == "ALTERAR")
            {
                lblTitulo.Text = "ALTERAR";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            variaveis.nomecliente = txtNome.Text;
            variaveis.telefonecliente = mtbTelefone.Text;
            variaveis.emailcliente = txtEmail.Text;
            variaveis.senhacliente = txtSenha.Text;
            variaveis.statuscliente = cmbStatus.Text;
            variaveis.altcliente = "foto" + txtNome.Text;

            if (variaveis.funcao == "CADASTRAR")
            {
                InserirCliente();

                lblTitulo.Text = "CADASTRO CLIENTE";

            }
            else if (variaveis.funcao == "ALTERAR")
            {
                lblTitulo.Text = "ALTERAR";
            }
        }
    }

}
