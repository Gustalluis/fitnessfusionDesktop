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
    public partial class frmMenuFuncionario : Form
    {
        public frmMenuFuncionario()
        {
            InitializeComponent();
        }

        private void carregarFuncionario()
        {
            try
            {
                banco.Conectar();
                string selecionar = "select nomeFuncionario, telefoneFuncionario, cargoFuncionario, statusFuncionario, enderecoFuncionario emailFuncionario, dataCadFuncionario, salarioFuncionario from funcionario;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFuncionario.DataSource = dt;
                dgvFuncionario.Columns[0].HeaderText = "NOME";
                dgvFuncionario.Columns[1].HeaderText = "TELEFONE";
                dgvFuncionario.Columns[2].HeaderText = "CARGO";
                dgvFuncionario.Columns[3].HeaderText = "STATUS";
                dgvFuncionario.Columns[4].HeaderText = "ENDERECO";
                dgvFuncionario.Columns[5].HeaderText = "EMAIL";
                dgvFuncionario.Columns[5].HeaderText = "DATA CADASTRO";
                dgvFuncionario.Columns[5].HeaderText = "SALARIO";

                dgvFuncionario.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao tentar se conectar com o banco de dados" + erro);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show(this);
            Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new frmMenuCadastroFuncionario().Show(this);
            Hide();
        }

        private void frmMenuFuncionario_Load(object sender, EventArgs e)
        {
            carregarFuncionario();
        }
    }
}
