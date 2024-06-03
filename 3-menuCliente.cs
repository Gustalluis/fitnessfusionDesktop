using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitnessfusion
{
    public partial class frmMenuCliente : Form
    {
        public frmMenuCliente()
        {
            InitializeComponent();
        }
        private void carregarCliente()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT cliente.nomeCliente, cliente.telefoneCliente, treino.nomeTreino,  cliente.emailCliente, cliente.statusCliente, planoAssinatura.nomePlano FROM cliente INNER JOIN agendaTreino ON cliente.idCliente = agendaTreino.idCliente INNER JOIN treino ON agendaTreino.idTreino = treino.idTreino INNER JOIN inscricao ON cliente.idCliente = inscricao.idCliente INNER JOIN planoAssinatura ON inscricao.idPlano = planoAssinatura.idPlano;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;
                dgvCliente.Columns[0].HeaderText = "NOME";
                dgvCliente.Columns[1].HeaderText = "TELEFONE";
                dgvCliente.Columns[2].HeaderText = "TREINO";
                dgvCliente.Columns[3].HeaderText = "STATUS";
                dgvCliente.Columns[4].HeaderText = "EMAIL";
                dgvCliente.Columns[5].HeaderText = "PLANO";
        
                dgvCliente.ClearSelection();
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
            variaveis.funcao = "CADASTRAR";
            new frmCadastro().Show(this);
            Hide();
        }

        private void frmMenuCliente_Load(object sender, EventArgs e)
        {

            carregarCliente();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "ALTERAR";
            new frmCadastro().Show(this);
            Hide();
        }
    }
}
