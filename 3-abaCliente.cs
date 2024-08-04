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
            carregarCliente();
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

        private void CarregarClienteStatus()
        {
            try
            {
                banco.Conectar(); //Abrir o banco de dados
                string selecionar = "SELECT cliente.idCliente, cliente.idPlano, cliente.idTreino, cliente.nomeCliente, cliente.cpfCliente," +
                    " cliente.telefoneCliente, cliente.StatusCliente, cliente.dataNascCliente, cliente.emailCliente, cliente.fotoCliente," +
                    " cliente.dataCadCliente, planoAssinatura.nomePlano, treino.nomeTreino  " +
                    "FROM cliente INNER JOIN planoAssinatura ON cliente.idPlano = planoAssinatura.idPlano INNER JOIN treino ON cliente.idTreino = treino.idTreino " +
                    "WHERE statusCliente = @status ORDER BY nomeCliente;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexaoDb);
                cmd.Parameters.AddWithValue("@status", cbmCliente.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd); //Adaptar ao C#
                DataTable dt = new DataTable();//Criando uma estrutura da tabela
                da.Fill(dt);//Preencher a tabela (dt)

                dgvCliente.DataSource = dt;//Coloca a tablena na DataGridView
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
                MessageBox.Show("Erro ao selecionar o CLIENTE por STATUS.\n\n" + erro);

            }
        }

        private void ExcluirCliente()
        {
            try
            {
                banco.Conectar();
                string alterar = " UPDATE cliente SET statusCliente = 'INATIVO' WHERE idCliente = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexaoDb);
                //parametros

                cmd.Parameters.AddWithValue("@codigo", variaveis.codigoCliente);


                //fim parametros
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente desativado com sucesso", "EXCLUIR CLIENTE");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir CLIENTE.\n\n" + erro);

            }
        }

        private void CarregarClienteNome()


        {
            try
            {
                banco.Conectar(); //Abrir o banco de dados
                string selecionar = "SELECT cliente.idCliente, cliente.idPlano, cliente.idTreino, cliente.nomeCliente, cliente.cpfCliente, cliente.telefoneCliente, cliente.StatusCliente, cliente.dataNascCliente, " +
                    "cliente.emailCliente, cliente.fotoCliente, cliente.dataCadCliente, planoAssinatura.nomePlano, treino.nomeTreino FROM cliente INNER JOIN planoAssinatura ON cliente.idPlano = planoAssinatura.idPlano" +
                    " INNER JOIN treino ON cliente.idTreino = treino.idTreino WHERE cliente.nomeCliente LIKE '%" + txtPesquisa.Text + "%' ORDER BY nomeCliente;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd); //Adaptar ao C#
                DataTable dt = new DataTable();//Criando uma estrutura da tabela
                da.Fill(dt);//Preencher a tabela (dt)

                dgvCliente.DataSource = dt;//Coloca a tablena na DataGridView

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
                MessageBox.Show("Erro ao selecionar o CLIENTE por NOME.\n\n" + erro);

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
            new frmCadastro().Show();
            Hide();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.funcao = "ALTERAR";
                new frmCadastro().Show();
                Hide();

            }
            else
            {
                MessageBox.Show("Paara alterar selecione um cliente da lista");
            }
            
        }
        private void frmMenuCliente_Load(object sender, EventArgs e)
        {

            dgvCliente.ClearSelection();
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {

                variaveis.codigoCliente = Convert.ToInt32(dgvCliente[0, variaveis.linhaSelecionada].Value);
            }
            else
            {
                MessageBox.Show("selecione uma linha por favor");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (variaveis.linhaSelecionada >= 0)
            {
                var resposta = MessageBox.Show("Deseja mesmo excluir esse cliente?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta == DialogResult.Yes)
                {
                    var resposta2 = MessageBox.Show("Tem certeza? Essa ação não poderá ser alterada", "CONFIRMAÇÃO", MessageBoxButtons.YesNo);
                    if (resposta2 == DialogResult.Yes)
                    {
                        ExcluirCliente();
                        carregarCliente();
                    }
                }

            }
            else
            {
                MessageBox.Show("Para excluir selecione um cliente da lista");
            }

        }

        private void cbmCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmCliente.Text == "TODOS")
            {
                carregarCliente();

            }
            else
            {
                CarregarClienteStatus();
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
            {
                cbmCliente.Enabled = true;
                cbmCliente.Text = "TODOS";
                carregarCliente();
            }
            else
            {
                cbmCliente.Enabled = false;
                CarregarClienteNome();

            }
        }
    }
}
