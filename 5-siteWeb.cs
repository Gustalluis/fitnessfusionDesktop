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
    public partial class frmSiteWeb : Form
    {
        public frmSiteWeb()
        {
            InitializeComponent();
        }
        // metodo mysql
        private void carregarpostagem()
        {
            try
            {
                banco.Conectar();
                string carregar = "select tituloPostagem, conteudoPostagem, fotoPostagem, dataPostagem, statusPostagem, categoriaPostagem FROM postagem ;";
                MySqlCommand cmd = new MySqlCommand(carregar, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSite.DataSource = dt;
                dgvSite.Columns[0].HeaderText = "TITULO";
                dgvSite.Columns[1].HeaderText = "CONTEUDO";
                dgvSite.Columns[2].HeaderText = "FOTO POSTAGEM";
                dgvSite.Columns[3].HeaderText = "DATA POSTAGEM";
                dgvSite.Columns[4].HeaderText = "STATUS";
                dgvSite.Columns[5].HeaderText = "CATEGORIA";

                dgvSite.ClearSelection();
                banco.Desconectar();


            }

            catch (Exception)
            {

                throw;
            }
        }
        private void carregarbanner()
        {
            try
            {
                banco.Conectar();
                string carregar = "select nomeBanner, fotoBanner, statusBanner, tipobanner FROM banner;";
                MySqlCommand cmd = new MySqlCommand(carregar, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSite.DataSource = dt;
                dgvSite.Columns[0].HeaderText = "NOME DO BANNER";
                dgvSite.Columns[1].HeaderText = "CONTEUDO";
                dgvSite.Columns[2].HeaderText = "FOTO POSTAGEM";
                dgvSite.Columns[3].HeaderText = "DATA POSTAGEM";
                dgvSite.Columns[4].HeaderText = "STATUS";
                dgvSite.Columns[5].HeaderText = "CATEGORIA";

                dgvSite.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Hide();
        }

        private void btnpostagem_Click(object sender, EventArgs e)
        {
            carregarpostagem(); 
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new frmMenuWeb().Show();
            Hide();
        }

        private void siteWeb_Load(object sender, EventArgs e)
        {

        }
    }
}
