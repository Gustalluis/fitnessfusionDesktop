using MySql.Data.MySqlClient;
using Mysqlx;
using Mysqlx.Crud;
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
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitnessfusion
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();

            carregarpagamento();

            carregarplanos();

            carregarTreino();


        }
        //validação ftp 
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
                byte[] imageToByte = ftpCliente.DownloadData("ftp://127.0.0.1/admin/img/cliente/semfoto.png");
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

        //FIM METODOS FOTO FTP
        // metodo mysql





        private void carregarpagamento()
        {
            try
            {
                banco.Conectar();
                string carregar = "select idPagamento, nomePagamento from pagamento;";
                MySqlCommand cmd = new MySqlCommand(carregar, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbPagamento.DataSource = dt; 
                cmbPagamento.DisplayMember = "nomePagamento";
                cmbPagamento.ValueMember = "idPagamento";

                banco.Desconectar();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao carregar a listar metodo de pagamento. \n\n" + erro);
            }
        }
       
        private void carregarplanos()

        {
            try
            {
                banco.Conectar();
                string planos = "select idPlano, nomePlano from planoAssinatura;";
                MySqlCommand cmd = new MySqlCommand(planos, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbPlano.DataSource = dt;
                cmbPlano.DisplayMember = "nomePlano";
                cmbPlano.ValueMember = "idPlano";

                banco.Desconectar();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao carregar a listar planos. \n\n" + erro);
            }
        }

        private void carregarTreino()
        {
            try
            {
                banco.Conectar();
                string treino = "select idTreino, nomeTreino from treino";
                MySqlCommand cmd = new MySqlCommand(treino, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt); 
                cmbTreino.DataSource = dt;
                cmbTreino.DisplayMember = "nomeTreino";
                cmbTreino.ValueMember = "idTreino";

                banco.Desconectar();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao carregar a listar treino. \n\n" + erro);
            }
        }

        private void InserirCliente()
        {
            try
            {
                banco.Conectar();
                string Inserir = "INSERT INTO cliente (idCliente, idPlano, idTreino, nomeCliente, cpfCliente, telefoneCliente, statusCliente, dataNascCliente, emailCliente, senhaCliente, fotoCliente, altCliente, dataCadCliente) " +
                    "VALUES (@idCliente, @idPlano, @idTreino, @nome, @cpfCliente, @telefone, @status, @datanasc, @email, @senha, @foto, @alt, @datacad);"; 
                MySqlCommand cmd = new MySqlCommand(Inserir, banco.conexaoDb);
                //parametros
                cmd.Parameters.AddWithValue("@idCliente", variaveis.codigoCliente);
                cmd.Parameters.AddWithValue("@idPlano", variaveis.codigoPlano);
                cmd.Parameters.AddWithValue("@idTreino", variaveis.codigoTreino);
                cmd.Parameters.AddWithValue("@nome", variaveis.nomecliente);
                cmd.Parameters.AddWithValue("@cpfCliente", variaveis.cpfCliente);
                cmd.Parameters.AddWithValue("@telefone", variaveis.telefonecliente);
                cmd.Parameters.AddWithValue("@status", variaveis.statuscliente);
                cmd.Parameters.AddWithValue("@datanasc", variaveis.datanasccliente);
                cmd.Parameters.AddWithValue("@email", variaveis.emailcliente);
                cmd.Parameters.AddWithValue("@senha", variaveis.senhacliente);
                cmd.Parameters.AddWithValue("@Foto", variaveis.fotocliente);
                cmd.Parameters.AddWithValue("@alt", variaveis.altcliente);
                cmd.Parameters.AddWithValue("@datacad", variaveis.dataCadCliente);

                //Fim parametros
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado com sucesso", "CADASTRO DE CLIENTE");
                banco.Desconectar();

                if (ValidarFTP())
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
                            MessageBox.Show("Foto não foi Selecionada ou existente no servidor.", "FOTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro Ao inserir Cliente\n\n" + erro);
            }

        }

        private void carregarCliente()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM cliente WHERE idCliente = @codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexaoDb);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codigoCliente);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.nomecliente = dr.GetString(3);
                    variaveis.cpfCliente = dr.GetString(4);
                    variaveis.telefonecliente = dr.GetString(5);
                    variaveis.statuscliente = dr.GetString(6);
                    variaveis.datanasccliente = dr.GetDateTime(7);
                    variaveis.emailcliente = dr.GetString(8);
                    variaveis.senhacliente = dr.GetString(9);
                    variaveis.fotocliente = dr.GetString(10).Remove(0, 8);
                    variaveis.altcliente = dr.GetString(11);
                    variaveis.dataCadCliente = dr.GetDateTime(12);

                    txtNome.Text        = variaveis.nomecliente;
                    txtcpfCliente.Text  = variaveis.cpfCliente;
                    mtbTelefone.Text    = variaveis.telefonecliente.ToString();
                    cmbStatus.Text      = variaveis.statuscliente;
                    mtbNascCliente.Text = variaveis.datanasccliente.ToShortDateString();
                    txtEmail.Text       = variaveis.emailcliente;
                    txtSenha.Text       = variaveis.senhacliente;
                    pctFoto.Image       = ByteToImage(GetImgToByte(variaveis.enderecoServidorFtp + "img/cliente/" + variaveis.fotocliente));
                    
                }


            }
            catch (Exception erro)
            {

                MessageBox.Show("erro ao carregar cliente" + erro); 
            }
        }

        private void alterarCliente()
        {
            try
            {
                banco.Conectar();
                string atualizar = "update cliente SET idTreino = @codTreino, idPlano = @codPlano, nomeCliente = @nome, cpfCliente = @cpf, telefoneCliente = @telefone, statusCliente = " +
                    "@status, dataNascCliente = @dataNasc, emailCliente = @email, senhaCliente = @senha, datacadCliente = @datacad WHERE idCliente = @codigo;";
                MySqlCommand cmd = new MySqlCommand(atualizar, banco.conexaoDb);

                cmd.Parameters.AddWithValue("@codTreino", variaveis.codigoTreino);
                cmd.Parameters.AddWithValue("@codPlano", variaveis.codigoPlano);
                cmd.Parameters.AddWithValue("@nome", variaveis.nomecliente);
                cmd.Parameters.AddWithValue("@cpf", variaveis.cpfCliente);
                cmd.Parameters.AddWithValue("@telefone", variaveis.telefonecliente);
                cmd.Parameters.AddWithValue("@status", variaveis.statuscliente);
                cmd.Parameters.AddWithValue("@dataNasc", variaveis.datanasccliente);
                cmd.Parameters.AddWithValue("@email", variaveis.emailcliente);
                cmd.Parameters.AddWithValue("@senha", variaveis.senhacliente);
                cmd.Parameters.AddWithValue("@datacad", variaveis.dataCadCliente);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codigoCliente);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente alterado com sucesso", "CADASTRO CLIENTE");
                banco.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("erro ao carregar cliente" + erro);
            }
        }

        private void alterarFotoCliente()
        {

            try
            {
                banco.Conectar();
                string alterar = " UPDATE cliente SET fotoCliente = @foto WHERE idCliente = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexaoDb);
                //parametros

                cmd.Parameters.AddWithValue("@foto", variaveis.fotocliente);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codigoCliente);


                //fim parametros
                cmd.ExecuteNonQuery();
                banco.Desconectar();

                if (ValidarFTP())
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
                            MessageBox.Show("Foto não foi Selecionada ou existente no servidor.", "FOTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar FOTO do cliente.\n\n" + erro);

            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            new frmMenuCliente().Show(this);
            Hide();
        }


        private void frmCadastro_Load(object sender, EventArgs e)
        {
            if (variaveis.funcao == "CADASTRAR") 
            {

                lblTitulo.Text = "CADASTRO CLIENTE";
               
            }
            else if (variaveis.funcao == "ALTERAR")
            {
                carregarCliente();
                lblTitulo.Text = "ALTERAR";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            variaveis.nomecliente = txtNome.Text;
            variaveis.telefonecliente = mtbTelefone.Text;
            variaveis.cpfCliente = txtcpfCliente.Text;
            variaveis.emailcliente = txtEmail.Text;
            variaveis.senhacliente = txtSenha.Text;
            variaveis.statuscliente = cmbStatus.Text;
            variaveis.altcliente = "foto" + txtNome.Text;
            variaveis.datanasccliente = Convert.ToDateTime(mtbNascCliente.Text);
            variaveis.dataCadCliente = DateTime.Now;
            variaveis.codigoPlano = Convert.ToInt32(cmbPlano.SelectedValue);
            variaveis.codigoTreino = Convert.ToInt32(cmbTreino.SelectedValue);
            variaveis.codigoPagamento = Convert.ToInt32(cmbPagamento.SelectedValue);
            

            if (variaveis.funcao == "CADASTRAR")
            {
                InserirCliente();
                lblTitulo.Text = "CADASTRO CLIENTE";

            }
            else if (variaveis.funcao == "ALTERAR")
            {
                alterarCliente();
                lblTitulo.Text = "ALTERAR";
                if (variaveis.atfotocliente == "S")
                {
                    alterarFotoCliente();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
                variaveis.fotocliente = "cliente/" + Regex.Replace(txtNome.Text, @"\s", "").ToLower() + ".png";

                if (result == DialogResult.OK)
                {
                    try
                    {
                        variaveis.atfotocliente = "S";
                        variaveis.CaminhoFotoCliente = ofdFoto.FileName;
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


