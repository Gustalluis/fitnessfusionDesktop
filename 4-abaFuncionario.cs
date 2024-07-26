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
    public partial class frmMenuFuncionario : Form
    {
        public frmMenuFuncionario()
        {
            InitializeComponent();
            CarregarFuncionario();
        }

        //mysql metodo

        private void CarregarFuncionario()
        {
            try
            {
                banco.Conectar();
                string carregar = "select*from funcionario;";
                MySqlCommand cmd = new MySqlCommand(carregar, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFuncionario.DataSource = dt;
                dgvFuncionario.Columns[0].Visible = false;
                dgvFuncionario.Columns[1].HeaderText = "NOME DO FUNCIONARIO";
                dgvFuncionario.Columns[2].HeaderText = "CARGO FUNCIONARIO";
                dgvFuncionario.Columns[3].HeaderText = "TELEFONE DO FUNCIONARIO";
                dgvFuncionario.Columns[4].HeaderText = "ENDERECO DO FUNCIONARIO";
                dgvFuncionario.Columns[5].HeaderText = "EMAIL DO FUNCIONARIO";
                dgvFuncionario.Columns[6].Visible = false;
                dgvFuncionario.Columns[7].HeaderText = "SALARIO DO FUNCIONARIO";
                dgvFuncionario.Columns[8].HeaderText = "DATA DO CADASTRO";
                dgvFuncionario.Columns[9].HeaderText = "STATUS DO FUNCIONARIO";
                dgvFuncionario.Columns[10].HeaderText = "FOTO DO FUNCIONARIO";
                dgvFuncionario.Columns[11].Visible = false;

                dgvFuncionario.ClearSelection();//Nada selecionado
                banco.Desconectar();//Fechar db
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao selecionar o funcionario.\n\n" + erro);
            }
        }

        private void CarregarFuncionarioStatus()
        {
            try
            {
                banco.Conectar(); //Abrir o banco de dados
                string selecionar = "SELECT * FROM funcionario WHERE statusFuncionario = @status ORDER BY nomeFuncionario;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexaoDb);
                cmd.Parameters.AddWithValue("@status", cbmCliente.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd); //Adaptar ao C#
                DataTable dt = new DataTable();//Criando uma estrutura da tabela
                da.Fill(dt);//Preencher a tabela (dt)
                dgvFuncionario.DataSource = dt;
                dgvFuncionario.Columns[0].Visible = false;
                dgvFuncionario.Columns[1].HeaderText = "NOME DO FUNCIONARIO";
                dgvFuncionario.Columns[2].HeaderText = "CARGO FUNCIONARIO";
                dgvFuncionario.Columns[3].HeaderText = "TELEFONE DO FUNCIONARIO";
                dgvFuncionario.Columns[4].HeaderText = "ENDERECO DO FUNCIONARIO";
                dgvFuncionario.Columns[5].HeaderText = "EMAIL DO FUNCIONARIO";
                dgvFuncionario.Columns[6].Visible = false;
                dgvFuncionario.Columns[7].HeaderText = "SALARIO DO FUNCIONARIO";
                dgvFuncionario.Columns[8].HeaderText = "DATA DO CADASTRO";
                dgvFuncionario.Columns[9].HeaderText = "STATUS DO FUNCIONARIO";
                dgvFuncionario.Columns[10].HeaderText = "FOTO DO FUNCIONARIO";
                dgvFuncionario.Columns[11].Visible = false;

                dgvFuncionario.ClearSelection();//Nada selecionado
                banco.Desconectar();//Fechar db
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao selecionar o funcionario.\n\n" + erro);
            }
        }

        private void ExcluirFuncionario()
        {
            try
            {
                banco.Conectar();
                string alterar = " UPDATE funcionario SET statusFuncionario = 'INATIVO' WHERE idFuncionario = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexaoDb);
                //parametros

                cmd.Parameters.AddWithValue("@codigo", variaveis.codigoFuncionario);


                //fim parametros
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario desativado com sucesso", "EXCLUIR FUNCIONARIO");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir FUNCIONARIO.\n\n" + erro);

            }
        }

        private void CarregarFuncionarionome()


        {
            try
            {
                banco.Conectar(); //Abrir o banco de dados
                string selecionar = "SELECT * FROM funcionario WHERE nomeFuncionario LIKE '%" + txtPesquisa.Text + "%' ORDER BY nomeFuncionario;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd); //Adaptar ao C#
                DataTable dt = new DataTable();//Criando uma estrutura da tabela
                da.Fill(dt);//Preencher a tabela (dt)

                dgvFuncionario.DataSource = dt;
                dgvFuncionario.Columns[0].Visible = false;
                dgvFuncionario.Columns[1].HeaderText = "NOME DO FUNCIONARIO";
                dgvFuncionario.Columns[2].HeaderText = "CARGO FUNCIONARIO";
                dgvFuncionario.Columns[3].HeaderText = "TELEFONE DO FUNCIONARIO";
                dgvFuncionario.Columns[4].HeaderText = "ENDERECO DO FUNCIONARIO";
                dgvFuncionario.Columns[5].HeaderText = "EMAIL DO FUNCIONARIO";
                dgvFuncionario.Columns[6].Visible = false;
                dgvFuncionario.Columns[7].HeaderText = "SALARIO DO FUNCIONARIO";
                dgvFuncionario.Columns[8].HeaderText = "DATA DO CADASTRO";
                dgvFuncionario.Columns[9].HeaderText = "STATUS DO FUNCIONARIO";
                dgvFuncionario.Columns[10].HeaderText = "FOTO DO FUNCIONARIO";
                dgvFuncionario.Columns[11].Visible = false;

                dgvFuncionario.ClearSelection();//Nada selecionado
                banco.Desconectar();//Fechar db
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao selecionar o funcionario.\n\n" + erro);
            }

        }

        private void frmMenuFuncionario_Load(object sender, EventArgs e)
        {
            dgvFuncionario.ClearSelection();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR";
            new frmMenuCadastroFuncionario().Show(this);
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.funcao = "ALTERAR";
                new frmMenuCadastroFuncionario().Show(this);
                Hide();

            }
            else
            {
                MessageBox.Show("Paara alterar selecione um cliente da lista");
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
                        CarregarFuncionario();
                        ExcluirFuncionario();

                    }
                }

            }
            else
            {
                MessageBox.Show("Para excluir selecione um cliente da lista");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show(this);
            Hide();
        }

        private void cbmCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmCliente.Text == "TODOS")
            {
                CarregarFuncionario();

            }
            else
            {
                CarregarFuncionarioStatus();
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
            {
                cbmCliente.Enabled = true;
                cbmCliente.Text = "TODOS";
                CarregarFuncionario();
            }
            else
            {
                cbmCliente.Enabled = false;
                CarregarFuncionarionome();

            }
        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codigoFuncionario = Convert.ToInt32(dgvFuncionario[0, variaveis.linhaSelecionada].Value);
            }
        }
    }
}
