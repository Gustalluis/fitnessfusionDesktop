using MySql.Data.MySqlClient;
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
    public partial class frmEquipamento : Form
    {
        public frmEquipamento()
        {
            InitializeComponent();
        }
        //metodo mysql
       
        private void carregarPagamento()
        {
            try
            {
                // Establish connection to the database
                banco.Conectar();

                // SQL query to retrieve payment information with date formatted explicitly
                string carregar = "SELECT pagamento.idPagamento, cliente.nomeCliente, cliente.cpfCliente, " +
                                  "planoAssinatura.nomePlano, planoAssinatura.valorPlano, " +
                                  "DATE_FORMAT(pagamento.dataPagamento, '%Y-%m-%d %H:%i:%s') as dataPagamento, " +
                                  "pagamento.statusPagamento " +
                                  "FROM pagamento " +
                                  "INNER JOIN cliente ON pagamento.idCliente = cliente.idCliente " +
                                  "INNER JOIN planoAssinatura ON pagamento.idPlano = planoAssinatura.idPlano;";

                // Create a MySqlCommand to execute the query
                MySqlCommand cmd = new MySqlCommand(carregar, banco.conexaoDb);

                // Use MySqlDataAdapter to fill the DataTable with results from the query
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Bind the DataTable to the DataGridView
                dgvCaixa.DataSource = dt;

                // Set column headers
                dgvCaixa.Columns[0].Visible = false;  // Hide the idPagamento column
                dgvCaixa.Columns[1].HeaderText = "NOME DO CLIENTE";
                dgvCaixa.Columns[2].HeaderText = "CPF DO CLIENTE";
                dgvCaixa.Columns[3].HeaderText = "NOME DO PLANO";
                dgvCaixa.Columns[4].HeaderText = "VALOR DO PLANO";
                dgvCaixa.Columns[5].HeaderText = "DATA DO PAGAMENTO";
                dgvCaixa.Columns[6].HeaderText = "STATUS PAGAMENTO";

                // Clear any selection in the DataGridView
                dgvCaixa.ClearSelection();

                // Disconnect from the database
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                // Handle any exceptions by showing an error message box
                MessageBox.Show("Erro ao carregar pagamentos.\n\n" + erro);
            }
        }


        private void verificarEAtualizarPagamentos()
        {
            try
            {
                banco.Conectar();
                DateTime dataLimite = DateTime.Now.AddDays(-30);
                string updateQuery = "UPDATE pagamento SET statusPagamento = 'atrasado' WHERE dataPagamento < @dataLimite AND statusPagamento != 'atrasado'";
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
            carregarPagamento();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR";
            new frmCadastroEquipamento().Show(this);
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "ALTERAR";
            new frmCadastroEquipamento().Show(this);
            Hide();
        }

        private void dgvEquipamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codigoEquipamento = Convert.ToInt32(dgvCaixa[0, variaveis.linhaSelecionada].Value);
            }
        }
    }
}
