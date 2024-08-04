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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            carregarTela();
        }



        //mysql metodo
        private void carregarTela()
        {
            try
            {
                banco.Conectar();
                string carregar = "SELECT p.idPagamento, c.nomeCliente, c.cpfCliente, pa.nomePlano, pa.valorPlano, p.dataPagamento," +
                    " p.statusPagamento FROM pagamento p JOIN cliente c ON p.idCliente = c.idCliente JOIN planoAssinatura pa ON c.idPlano = pa.idPlano WHERE p.statusPagamento = 'PAGO' ;";
                MySqlCommand cmd = new MySqlCommand(carregar, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMenu.DataSource = dt;
                dgvMenu.Columns[0].Visible = false;
                dgvMenu.Columns[1].HeaderText = "NOME DO CLIENTE";
                dgvMenu.Columns[2].HeaderText = "CPF DO CLIENTE";
                dgvMenu.Columns[3].HeaderText = "NOME DO PLANO";
                dgvMenu.Columns[4].HeaderText = "VALOR DO PLANO";
                dgvMenu.Columns[5].HeaderText = "DATA DO PAGAMENTO";
                dgvMenu.Columns[6].HeaderText = "STATUS DO PAGAMENTO";
                

            }
            catch (Exception)
            {

                throw;
            }
        }
  


         private void btnSair_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja realmente sair do programa?", "SAIR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (resposta == DialogResult.No)
            {
                new frmMenu().Show();
                Close();
            }
            else
            {
                new frmMenu().Show();
                Close();
            }
        }
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            new frmMenuCliente().Show(this);
            Hide();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            new frmMenuFuncionario().Show(this);
            Hide();        
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnEquipamento_Click(object sender, EventArgs e)
        {
            new frmEquipamento().Show(this);
            Hide();
        }

        private void btnTreino_Click(object sender, EventArgs e)
        {
            new FrmTreino().Show(this);
            Hide();
        }

        private void btnAvalicao_Click(object sender, EventArgs e)
        {
            new frmAvaliacao().Show(this);
            Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = variaveis.usuario;
        }

        private void btnPlano_Click(object sender, EventArgs e)
        {
            new frmPlanoAssinatura().Show(this);
            Hide();
        }
    }
}
