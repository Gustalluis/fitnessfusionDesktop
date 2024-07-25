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
    public partial class frmPlanoAssinatura : Form
    {
        public frmPlanoAssinatura()
        {
            InitializeComponent();
            carregarPlano();
        }
        //metodo mysql

        private void carregarPlano()
        {
            try
            {
                banco.Conectar();
                string carregar = "select*from planoAssinatura;";
                MySqlCommand cmd = new MySqlCommand(carregar, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

               dgvPlano.DataSource = dt;
                dgvPlano.Columns[0].Visible = false;
                dgvPlano.Columns[1].HeaderText = "NOME DO PLANO";
                dgvPlano.Columns[2].HeaderText = "STATUS PLANO";
                dgvPlano.Columns[3].HeaderText = "DURAÇÃO DO PLANO";
                dgvPlano.Columns[4].HeaderText = "DESCRIÇÃO DO PLANO";
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao selecionar o plano.\n\n" + erro);
            }
        }

        private void CarregarPlanoStatus()
        {
            try
            {
                banco.Conectar(); //Abrir o banco de dados
                string selecionar = "SELECT * FROM planoAssinatura WHERE statusPlano = @status ORDER BY nomePlano;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexaoDb);
                cmd.Parameters.AddWithValue("@status", cbmPlano.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd); //Adaptar ao C#
                DataTable dt = new DataTable();//Criando uma estrutura da tabela
                da.Fill(dt);//Preencher a tabela (dt)

                dgvPlano.DataSource = dt;
                dgvPlano.Columns[0].Visible = false;
                dgvPlano.Columns[1].HeaderText = "NOME DO PLANO";
                dgvPlano.Columns[2].HeaderText = "STATUS PLANO";
                dgvPlano.Columns[3].HeaderText = "DURAÇÃO DO PLANO";
                dgvPlano.Columns[4].HeaderText = "DESCRIÇÃO DO PLANO";

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o CLIENTE por STATUS.\n\n" + erro);

            }
        }

        private void CarregarPlanonome()
        {
            try
            {
                banco.Conectar(); //Abrir o banco de dados
                string selecionar = "SELECT * FROM planoAssinatura WHERE nomePlano LIKE '%" + txtPesquisa.Text + "%' ORDER BY nomePlano;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd); //Adaptar ao C#
                DataTable dt = new DataTable();//Criando uma estrutura da tabela
                da.Fill(dt);//Preencher a tabela (dt)


                dgvPlano.DataSource = dt;
                dgvPlano.Columns[0].Visible = false;
                dgvPlano.Columns[1].HeaderText = "NOME DO PLANO";
                dgvPlano.Columns[2].HeaderText = "STATUS PLANO";
                dgvPlano.Columns[3].HeaderText = "DURAÇÃO DO PLANO";
                dgvPlano.Columns[4].HeaderText = "DESCRIÇÃO DO PLANO";

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o PLANo por NOME.\n\n" + erro);

            }
        }


        private void cbmPlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmPlano.Text == "TODOS")
            {
                carregarPlano();

            }
            else
            {
                CarregarPlanoStatus();
            }
        }

        private void frmPlanoAssinatura_Load(object sender, EventArgs e)
        {
            dgvPlano.ClearSelection();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
            {
                cbmPlano.Enabled = true;
                cbmPlano.Text = "TODOS";
                carregarPlano();
            }
            else
            {
                cbmPlano.Enabled = false;
                CarregarPlanonome();

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
            new frmCadPlano().Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "ALTERAR";
            new frmCadPlano().Show();
            Hide();
        }

        private void dgvPlano_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codigoPlano = Convert.ToInt32(dgvPlano[0, variaveis.linhaSelecionada].Value);
            }
        }
    }
}
