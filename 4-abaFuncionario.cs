using MySql.Data.MySqlClient;
using Mysqlx;
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
                string carregar = "select*from funcionario;";
                MySqlCommand cmd = new MySqlCommand(carregar, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFuncionario.DataSource = dt;
                dgvFuncionario.Columns[0].Visible = false;
                dgvFuncionario.Columns[1].HeaderText = "NOME";
                dgvFuncionario.Columns[2].HeaderText = "CARGO";
                dgvFuncionario.Columns[3].HeaderText = "TELEFONE";
                dgvFuncionario.Columns[4].HeaderText = "ENDEREÇO";
                dgvFuncionario.Columns[5].HeaderText = "EMAIL";
                dgvFuncionario.Columns[6].HeaderText = "SENHA";
                dgvFuncionario.Columns[7].HeaderText = "SALARIO";
                dgvFuncionario.Columns[8].HeaderText = "DATA DE CADASTRO";
                dgvFuncionario.Columns[9].HeaderText = "STATUS";
                dgvFuncionario.Columns[10].HeaderText = "FOTO FUNCIONARIO";
                dgvFuncionario.Columns[11].Visible = false;

                dgvFuncionario.ClearSelection();//Nada selecionado
                banco.Desconectar();//Fechar db

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao selecionar o CLIENTE.\n\n" + erro);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show(this);
            Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           
                variaveis.funcao = "CADASTRAR";         
                new frmMenuCadastroFuncionario().Show(this);
                Hide();
        }

        private void frmMenuFuncionario_Load(object sender, EventArgs e)
        {
            carregarFuncionario();
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
               variaveis.funcao = "ALTERAR";
            new frmMenuCadastroFuncionario().Show(this);
            Hide();
        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codigoFuncionario = Convert.ToInt32(dgvFuncionario[0, variaveis.linhaSelecionada].Value);
            }
        }
    } 
}
