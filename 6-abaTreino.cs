using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Macs;
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
            carregarTreino();
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

        private void CarregarTreinoNome()


        {
            try
            {
                banco.Conectar(); //Abrir o banco de dados
                string selecionar = "SELECT * FROM treino WHERE nomeTreino LIKE '%" + txtPesquisa.Text + "%' ORDER BY nomeTreino;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd); //Adaptar ao C#
                DataTable dt = new DataTable();//Criando uma estrutura da tabela
                da.Fill(dt);//Preencher a tabela (dt)

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

        private void CarregarTreinoStatus()
        {
            try
            {
                banco.Conectar(); //Abrir o banco de dados
                string selecionar = "SELECT * FROM treino WHERE statusTreino = @status ORDER BY nomeTreino;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexaoDb);
                cmd.Parameters.AddWithValue("@status", cbmCliente.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd); //Adaptar ao C#
                DataTable dt = new DataTable();//Criando uma estrutura da tabela
                da.Fill(dt);//Preencher a tabela (dt)

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
                MessageBox.Show("Erro ao selecionar o CLIENTE por STATUS.\n\n" + erro);

            }

        }

        private void ExcluirTreino()
        {
            try
            {
                banco.Conectar();
                string alterar = " UPDATE treino SET statusTreino = 'INATIVO' WHERE idTreino = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexaoDb);
                //parametros

                cmd.Parameters.AddWithValue("@codigo", variaveis.codigoTreino);


                //fim parametros
                cmd.ExecuteNonQuery();
                MessageBox.Show("Treino desativado com sucesso", "EXCLUIR TREINO");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir Treino.\n\n" + erro);

            }
        }

        private void FrmTreino_Load(object sender, EventArgs e)
        {
            dgvTreino.ClearSelection();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show(this);
            Hide();
        }

      

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR";
            new frmCadTreino().Show(this);
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.funcao = "ALTERAR";
                new frmCadTreino().Show(this);
                Hide();
            }
            else
            {
                MessageBox.Show("Para alterar selecione algo da lista");
            }

           
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
            {
                cbmCliente.Enabled = true;
                cbmCliente.Text = "TODOS";
                carregarTreino();
            }
            else
            {
                cbmCliente.Enabled = false;
                CarregarTreinoNome();

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (variaveis.linhaSelecionada >= 0)
            {
                var resposta = MessageBox.Show("Deseja mesmo excluir esse treino?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta == DialogResult.Yes)
                {
                    var resposta2 = MessageBox.Show("Tem certeza?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo);
                    if (resposta2 == DialogResult.Yes)
                    {
                        carregarTreino();
                        
                    }
                }

            }
            else
            {
                MessageBox.Show("Para excluir selecione um cliente da lista");
            }
        }

        private void dgvTreino_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codigoTreino = Convert.ToInt32(dgvTreino[0, variaveis.linhaSelecionada].Value);
            }
        }

        private void cbmCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmCliente.Text == "TODOS")
            {
                carregarTreino();

            }
            else
            {
                CarregarTreinoStatus();
            }
        }
    }
}
