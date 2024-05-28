using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitnessfusion
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new frmMenuCliente().Show(this);
            Hide();
        }

        private void rbtnSIM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSIM.Checked)
            {
                pnlAvaliacao.Visible = true;
                btnSalvar.Visible = true;   
            }
          
        }

        private void rbtnNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNao.Checked)
            {
                pnlAvaliacao.Visible = false;
                btnSalvar.Visible = true;
            }
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            if (variaveis.funcao == "CADASTRAR") 
            {
                lblTitulo.Text = "CADASTRO CLIENTE";
            }
            else if (variaveis.funcao == "ALTERAR")
            {
                lblTitulo.Text = "ALTERAR";
            }
        }
    }
}
