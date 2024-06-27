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
    public partial class FrmTreino : Form
    {
        public FrmTreino()
        {
            InitializeComponent();
        }
        private void carregarTreino()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT*From treino;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvTreino.DataSource = dt;
                dgvTreino.Columns[0].Visible = false;
                dgvTreino.Columns[1].HeaderText = "NOME TREINO";
                dgvTreino.Columns[2].HeaderText = "DURAÇÃO TREINO";
                dgvTreino.Columns[3].HeaderText = "DESCRIÇÃO TREINO";

                dgvTreino.ClearSelection();
                banco.Desconectar();

            }
            catch (Exception erro)
            {

                MessageBox.Show("erro ao carregar a tabela" + erro);
            }
        }
        private void FrmTreino_Load(object sender, EventArgs e)
        {
            carregarTreino();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show(this);
            Hide();
        }

        private void dgvTreino_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codigoTreino = Convert.ToInt32(dgvTreino[0, variaveis.linhaSelecionada].Value);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR";
            new frmCadTreino().Show(this);
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "ALTERAR";
            new frmCadTreino().Show(this);
            Hide();
        }
    }
}
