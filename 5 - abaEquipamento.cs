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
        private void carregarEquipamento()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT*From equipamento;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEquipamento.DataSource = dt;
                dgvEquipamento.Columns[0].Visible = false;
                dgvEquipamento.Columns[1].HeaderText = "NOME EQUIPAMENTO";
                dgvEquipamento.Columns[2].HeaderText = "ESTADO EQUIPAMENTO";
                dgvEquipamento.Columns[3].HeaderText = "DESCRIÇÃO DO EQUIPAMENTO";

                dgvEquipamento.ClearSelection();
                banco.Desconectar();

            }
            catch (Exception erro)
            {

                MessageBox.Show("erro ao carregar a tabela" + erro);
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show(this);
            Hide();
        }
        private void frmEquipamento_Load(object sender, EventArgs e)
        {
            carregarEquipamento();
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
                variaveis.codigoEquipamento = Convert.ToInt32(dgvEquipamento[0, variaveis.linhaSelecionada].Value);
            }
        }
    }
}
