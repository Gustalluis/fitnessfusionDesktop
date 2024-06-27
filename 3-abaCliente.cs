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
                string carregar = "SELECT cliente.idCliente, cliente.idPlano, cliente.idTreino, cliente.nomeCliente, cliente.cpfCliente, cliente.telefoneCliente, cliente.StatusCliente, cliente.dataNascCliente, cliente.emailCliente, cliente.fotoCliente, cliente.dataCadCliente, planoAssinatura.nomePlano, treino.nomeTreino " +
                    "FROM cliente INNER JOIN planoAssinatura ON cliente.idPlano = planoAssinatura.idPlano INNER JOIN treino ON cliente.idTreino = treino.idTreino;";
                MySqlCommand cmd = new MySqlCommand(carregar, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;
                dgvCliente.Columns[0].Visible = false;
                dgvCliente.Columns[1].Visible = false;
                dgvCliente.Columns[2].Visible = false;
                dgvCliente.Columns[3].HeaderText = "NOME CLIENTE";
                dgvCliente.Columns[4].HeaderText = "CPF DO CLIENTE";
                dgvCliente.Columns[5].HeaderText = "TELEFONE";
                dgvCliente.Columns[6].HeaderText = "STATUS DO CLIENTE";
                dgvCliente.Columns[7].HeaderText = "DATA DE NASCIMENTO";
                dgvCliente.Columns[8].HeaderText = "EMAIL DO CLIENTE";
                dgvCliente.Columns[9].HeaderText = "FOTO CLIENTE";
                dgvCliente.Columns[10].HeaderText = "DATA DE CADASTRO DO CLIENTE";
                dgvCliente.Columns[11].HeaderText = "TIPO DO PLANO";
                dgvCliente.Columns[12].HeaderText = "TREINO";

                dgvCliente.ClearSelection();//Nada selecionado
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
            new frmCadastro().Show(this);
            Hide();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "ALTERAR";
            new frmCadastro().Show(this);
            Hide();
        }
        private void frmMenuCliente_Load(object sender, EventArgs e)
        {

            carregarCliente();
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codigoCliente = Convert.ToInt32(dgvCliente[0, variaveis.linhaSelecionada].Value);
            }
        }
    }
}
