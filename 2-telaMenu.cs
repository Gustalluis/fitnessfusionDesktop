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
                new frmLogin().Show();
                Close();
            }
            else
            {
                new frmLogin().Show();
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
    }
}
