using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class frmEquipamento : Form
    {
        public frmEquipamento()
        {
            InitializeComponent();
            carregarPagamento();
        }
        //metodo mysql
       
        private void carregarPagamento()
        {
            try
            {
              
                banco.Conectar();
                string carregar = "SELECT pagamento.idPagamento, cliente.nomeCliente, cliente.cpfCliente, " +
                                  "planoAssinatura.nomePlano, planoAssinatura.valorPlano, " +
                                  "DATE_FORMAT(pagamento.dataPagamento, '%Y-%m-%d %H:%i:%s') as dataPagamento, " +
                                  "pagamento.statusPagamento " +
                                  "FROM pagamento " +
                                  "INNER JOIN cliente ON pagamento.idCliente = cliente.idCliente " +
                                  "INNER JOIN planoAssinatura ON pagamento.idPlano = planoAssinatura.idPlano;";
                
                MySqlCommand cmd = new MySqlCommand(carregar, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCaixa.DataSource = dt;
                
                dgvCaixa.Columns[0].Visible = false;  
                dgvCaixa.Columns[1].HeaderText = "NOME DO CLIENTE";
                dgvCaixa.Columns[2].HeaderText = "CPF DO CLIENTE";
                dgvCaixa.Columns[3].HeaderText = "NOME DO PLANO";
                dgvCaixa.Columns[4].HeaderText = "VALOR DO PLANO";
                dgvCaixa.Columns[5].HeaderText = "DATA DO PAGAMENTO";
                dgvCaixa.Columns[6].HeaderText = "STATUS PAGAMENTO";

               
                dgvCaixa.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                
                MessageBox.Show("Erro ao carregar pagamentos.\n\n" + erro);
            }
            verificarEAtualizarPagamentos();
        }
        private void CarregarFuncionarioStatus()
        {
            try
            {
                banco.Conectar(); //Abrir o banco de dados
                string selecionar = "SELECT pagamento.idPagamento, cliente.nomeCliente, cliente.cpfCliente, " +
                    "planoAssinatura.nomePlano, planoAssinatura.valorPlano," +
                    "DATE_FORMAT(pagamento.dataPagamento, '%Y-%m-%d %H:%i:%s') as dataPagamento," +
                    "pagamento.statusPagamento FROM pagamento INNER JOIN cliente ON pagamento.idCliente = cliente.idCliente " +
                    "INNER JOIN planoAssinatura ON pagamento.idPlano = planoAssinatura.idPlano where statusPagamento = @status ORDER BY cliente.nomeCliente;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexaoDb);
                cmd.Parameters.AddWithValue("@status", cbmCliente.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd); //Adaptar ao C#
                DataTable dt = new DataTable();//Criando uma estrutura da tabela
                da.Fill(dt);//Preencher a tabela (dt)

                dgvCaixa.DataSource = dt;

                dgvCaixa.Columns[0].Visible = false;
                dgvCaixa.Columns[1].HeaderText = "NOME DO CLIENTE";
                dgvCaixa.Columns[2].HeaderText = "CPF DO CLIENTE";
                dgvCaixa.Columns[3].HeaderText = "NOME DO PLANO";
                dgvCaixa.Columns[4].HeaderText = "VALOR DO PLANO";
                dgvCaixa.Columns[5].HeaderText = "DATA DO PAGAMENTO";
                dgvCaixa.Columns[6].HeaderText = "STATUS PAGAMENTO";


                dgvCaixa.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao selecionar o funcionario.\n\n" + erro);
            }
        }
        private void CarregarPagamentonNome()


        {
            try
            {
                banco.Conectar(); //Abrir o banco de dados
                string selecionar = "SELECT pagamento.idPagamento, cliente.nomeCliente, cliente.cpfCliente, " +
                    "planoAssinatura.nomePlano, planoAssinatura.valorPlano, DATE_FORMAT(pagamento.dataPagamento, '%Y-%m-%d %H:%i:%s') " +
                    "as dataPagamento, pagamento.statusPagamento FROM pagamento JOIN cliente ON pagamento.idCliente = cliente.idCliente JOIN" +
                    " planoAssinatura ON cliente.idPlano = planoAssinatura.idPlano WHERE cliente.nomeCliente LIKE '%" + txtPesquisa.Text + "%' ORDER BY cliente.nomeCliente;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd); //Adaptar ao C#
                DataTable dt = new DataTable();//Criando uma estrutura da tabela
                da.Fill(dt);//Preencher a tabela (dt)

                dgvCaixa.DataSource = dt;
                dgvCaixa.Columns[0].Visible = false;
                dgvCaixa.Columns[1].HeaderText = "NOME DO CLIENTE";
                dgvCaixa.Columns[2].HeaderText = "CPF DO CLIENTE";
                dgvCaixa.Columns[3].HeaderText = "NOME DO PLANO";
                dgvCaixa.Columns[4].HeaderText = "VALOR DO PLANO";
                dgvCaixa.Columns[5].HeaderText = "DATA DO PAGAMENTO";
                dgvCaixa.Columns[6].HeaderText = "STATUS PAGAMENTO";


                dgvCaixa.ClearSelection();

                //Nada selecionado
                banco.Desconectar();//Fechar db
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao selecionar o funcionario.\n\n" + erro);
            }

        }
        private void verificarEAtualizarPagamentos()
        {
            try
            {
                banco.Conectar();
                DateTime dataLimite = DateTime.Now.AddDays(-30);
                string updateQuery = "UPDATE pagamento SET statusPagamento = 'PEDENTE' WHERE dataPagamento < @dataLimite AND statusPagamento != 'PAGO';";
                MySqlCommand command = new MySqlCommand(updateQuery, banco.conexaoDb);
                command.Parameters.AddWithValue("@dataLimite", dataLimite);

                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show($"{rowsAffected} linha(s) atualizada(s) em {DateTime.Now}");

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o banco de dados.\n\n" + ex.Message);
            }
        }

    
          


        private void btnSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show(this);
            Hide();
        }
        private void frmEquipamento_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvEquipamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codigoEquipamento = Convert.ToInt32(dgvCaixa[0, variaveis.linhaSelecionada].Value);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
            {
                cbmCliente.Enabled = true;
                cbmCliente.Text = "TODOS";
                carregarPagamento();
            }
            else
            {
                cbmCliente.Enabled = false;
                CarregarPagamentonNome();

            }
        }

        private void cbmCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbmCliente.Text == "TODOS")
            {
                carregarPagamento();

            }
            else
            {
                CarregarFuncionarioStatus();
            }
        }
    }
    
}
