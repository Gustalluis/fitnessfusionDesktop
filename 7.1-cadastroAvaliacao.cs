using MySql.Data.MySqlClient;
using Mysqlx;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitnessfusion
{
    public partial class frmCadastroAvaliacao : Form
    {
        public frmCadastroAvaliacao()
        {
            InitializeComponent();
            carregarCliente();
            carregarfuncionario();
            


        }

      

        private void btnSair_Click(object sender, EventArgs e)
        {
            new frmAvaliacao().Show();
            Hide();
        }


        //metodo mysql

        private void carregarCliente()
        {
            try
            {
                banco.Conectar();
                Console.WriteLine("Conexão estabelecida com sucesso para carregar clientes.");

                string planosClientes = "SELECT idCliente, nomeCliente FROM cliente;";
                MySqlCommand cmd = new MySqlCommand(planosClientes, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbAluno.DataSource = dt;
                cmbAluno.DisplayMember = "nomeCliente";
                cmbAluno.ValueMember = "idCliente";

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a listar clientes. \n\n" + erro);
            }
        }

        private void carregarfuncionario()
        {
            try
            {
                banco.Conectar();
                Console.WriteLine("Conexão estabelecida com sucesso para carregar funcionários.");

                string funcionario = "SELECT idFuncionario, nomeFuncionario FROM funcionario;";
                MySqlCommand cmd = new MySqlCommand(funcionario, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbFuncionario.DataSource = dt;
                cmbFuncionario.DisplayMember = "nomeFuncionario";
                cmbFuncionario.ValueMember = "idFuncionario";

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a listar Funcionario. \n\n" + erro);
            }
        }

            private void inserirAvaliacao() { 
        
            try
            {
                banco.Conectar();
                string inserir = "insert into avaliacaoFisica (idAvaliacaoFisica, idCliente, idFuncionario, peso, altura, medidaCorporal, descricaoAvaliacao,  dataAvaliacaoFisica) " +
                "Values (@idava, @idCliente, @idFuncionario, @peso, @altura, @medida, @descricao, @data);";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexaoDb);


                cmd.Parameters.AddWithValue("@idava", variaveis.codigoAva);
                cmd.Parameters.AddWithValue("@idFuncionario", variaveis.codigoFuncionario);
                cmd.Parameters.AddWithValue("@idCliente", variaveis.codigoCliente);
                cmd.Parameters.AddWithValue("@peso", variaveis.peso);
                cmd.Parameters.AddWithValue("@altura", variaveis.altura);
                cmd.Parameters.AddWithValue("@medida", variaveis.medida);
                cmd.Parameters.AddWithValue("@descricao", variaveis.descricao);
                cmd.Parameters.AddWithValue("@data", variaveis.data);

                cmd.ExecuteNonQuery();
                MessageBox.Show("avaliacao cadastrada com sucesso", "CADASTRO DE AVALIACAO");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar o CLIENTE.\n\n" + erro);
            }
        }

        public void carregarAvaliacao()
        {
            try
            {
                banco.Conectar();
                string carregar = "SELECT * FROM avaliacaoFisica WHERE idAvaliacaoFisica = @codigo;";
                MySqlCommand cmd = new MySqlCommand(carregar, banco.conexaoDb);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codigoAva);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    variaveis.peso = dr.GetString(3);
                    variaveis.altura = dr.GetString(4);
                    variaveis.medida = dr.GetString(5);
                    variaveis.descricao = dr.GetString(6);
                    variaveis.data = dr.GetDateTime(7);

                    txtpeso.Text = variaveis.peso;
                    txtAltura.Text = variaveis.altura;
                    txtMedida.Text = variaveis.medida;
                    txtdescricao.Text = variaveis.descricao;
                    mtbCad.Text = variaveis.data.ToShortDateString();
                }

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a avaliação.\n\n" + erro);
            }
        }

        public void editarAvaliacao()
        {
            try
            {
                banco.Conectar();
                string editar = "update avaliacaoFisica SET idCliente = " +
                    "@codCliente, idFuncionario = @codFuncionario, peso = @peso, " +
                    "altura = @altura, medidaCorporal = @medida, descricaoAvaliacao = @descricao, dataAvaliacaoFisica = @data WHERE idAvaliacaoFisica = @codigo;";
                    MySqlCommand cmd = new MySqlCommand(editar, banco.conexaoDb);

                    cmd.Parameters.AddWithValue("@codCliente", variaveis.codigoCliente);
                    cmd.Parameters.AddWithValue("@codFuncionario", variaveis.codigoFuncionario);
                    cmd.Parameters.AddWithValue("@peso", variaveis.peso);
                    cmd.Parameters.AddWithValue("@altura", variaveis.altura);
                    cmd.Parameters.AddWithValue("@medida", variaveis.medida);
                    cmd.Parameters.AddWithValue("@descricao", variaveis.descricao);
                    cmd.Parameters.AddWithValue("@data", variaveis.data);
                    cmd.Parameters.AddWithValue("@codigo", variaveis.codigoAva);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente alterado com sucesso", "CADASTRO CLIENTE");
                    banco.Desconectar();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao alterar .\n\n" + erro);
            }
        }


        private void frmCadastroAvaliacao_Load(object sender, EventArgs e)
        {
            if (variaveis.funcao == "CADASTRAR")
            {

                lblTitulo.Text = "CADASTRO CLIENTE";

            }
            else if (variaveis.funcao == "ALTERAR")
            {
                carregarAvaliacao();
                lblTitulo.Text = "ALTERAR";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            variaveis.peso = txtpeso.Text;
            variaveis.altura = txtAltura.Text;
            variaveis.data = Convert.ToDateTime(mtbCad.Text);
            variaveis.medida = txtMedida.Text;
            variaveis.descricao = txtdescricao.Text;
            variaveis.codigoFuncionario = Convert.ToInt32(cmbFuncionario.SelectedValue);
            variaveis.codigoCliente = Convert.ToInt32(cmbAluno.SelectedValue);

            if (variaveis.funcao == "CADASTRAR")
            {
                inserirAvaliacao();
                lblTitulo.Text = "CADASTRO CLIENTE";

            }
            else if (variaveis.funcao == "ALTERAR")
            {
                editarAvaliacao();
                lblTitulo.Text = "ALTERAR";
               
            }

        }
    }
}
