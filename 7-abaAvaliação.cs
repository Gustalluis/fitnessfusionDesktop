using MySql.Data.MySqlClient;
using Mysqlx;
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
    public partial class frmAvaliacao : Form
    {
        public frmAvaliacao()
        {
            InitializeComponent();
            carregarAvaliacao();
        }
        private void carregarAvaliacao()
        {
            try
            {
                banco.Conectar();
                string carregar = "SELECT \r\n    avaliacaoFisica.idAvaliacaoFisica, \r\n    cliente.nomeCliente, \r\n    funcionario.nomeFuncionario, \r\n    avaliacaoFisica.peso, \r\n " +
                    "   avaliacaoFisica.altura, \r\n    avaliacaoFisica.medidaCorporal, \r\n    avaliacaoFisica.descricaoAvaliacao, \r\n    avaliacaoFisica.dataAvaliacaoFisica \r\nFROM \r\n  " +
                    "  avaliacaoFisica \r\nINNER JOIN \r\n    cliente ON avaliacaoFisica.idCliente = cliente.idCliente \r\nINNER JOIN \r\n    funcionario ON avaliacaoFisica.idFuncionario = funcionario.idFuncionario;";
                MySqlCommand cmd = new MySqlCommand(carregar, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvAvaliacao.DataSource = dt;
                dgvAvaliacao.Columns[0].Visible = false;
                dgvAvaliacao.Columns[1].HeaderText = "NOME DO CLIENTE";
                dgvAvaliacao.Columns[2].HeaderText = "NOME DO FUNCIONARIO";
                dgvAvaliacao.Columns[3].HeaderText = "PESO DO CLIENTE";
                dgvAvaliacao.Columns[4].HeaderText = "ALTURA DO CLIENTE";
                dgvAvaliacao.Columns[5].HeaderText = "MEDIDA CORPORAL";
                dgvAvaliacao.Columns[6].HeaderText = "DESCRICAO DA AVALIAÇÃO";
                dgvAvaliacao.Columns[7].HeaderText = "DATA DA AVALIAÇÃO";

                dgvAvaliacao.ClearSelection();//Nada selecionado
                banco.Desconectar();//Fechar db
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o avaliação.\n\n" + erro);
            }
            
            
        }

        private void CarregarAvaStatus()
        {
            try
            {
                banco.Conectar(); //Abrir o banco de dados
                string selecionar = "SELECT avaliacaoFisica.idAvaliacaoFisica, cliente.nomeCliente, funcionario.nomeFuncionario, " +
                    "avaliacaoFisica.peso, avaliacaoFisica.altura, avaliacaoFisica.medidaCorporal, avaliacaoFisica.descricaoAvaliacao," +
                    " avaliacaoFisica.dataAvaliacaoFisica FROM  avaliacaoFisica INNER JOIN cliente ON avaliacaoFisica.idCliente = cliente.idCliente INNER JOIN " +
                    " funcionario ON avaliacaoFisica.idFuncionario = funcionario.idFuncionario WHERE statusAvaliacao = @status ORDER BY descricaoAvaliacao;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexaoDb);
                cmd.Parameters.AddWithValue("@status", cbmCliente.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd); //Adaptar ao C#
                DataTable dt = new DataTable();//Criando uma estrutura da tabela
                da.Fill(dt);//Preencher a tabela (dt)

                dgvAvaliacao.DataSource = dt;
                dgvAvaliacao.Columns[0].Visible = false;
                dgvAvaliacao.Columns[1].HeaderText = "NOME DO CLIENTE";
                dgvAvaliacao.Columns[2].HeaderText = "NOME DO FUNCIONARIO";
                dgvAvaliacao.Columns[3].HeaderText = "PESO DO CLIENTE";
                dgvAvaliacao.Columns[4].HeaderText = "ALTURA DO CLIENTE";
                dgvAvaliacao.Columns[5].HeaderText = "MEDIDA CORPORAL";
                dgvAvaliacao.Columns[6].HeaderText = "DESCRICAO DA AVALIAÇÃO";
                dgvAvaliacao.Columns[7].HeaderText = "DATA DA AVALIAÇÃO";

                dgvAvaliacao.ClearSelection();//Nada selecionado
                banco.Desconectar();//Fechar db

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o CLIENTE por STATUS.\n\n" + erro);

            }
        }

        private void ExcluirAvaliacao()
        {
            try
            {
                banco.Conectar();
                string alterar = " UPDATE avaliacaoFisica SET statusAvaliacao = 'INATIVO' WHERE idAvaliacaoFisica = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexaoDb);
                //parametros

                cmd.Parameters.AddWithValue("@codigo", variaveis.codigoAva);


                //fim parametros
                cmd.ExecuteNonQuery();
                MessageBox.Show(" desativado com sucesso", "EXCLUIR AVALIAÇÃO");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir.\n\n" + erro);

            }
        }
        private void CarregarAvaliacaoNome()


        {
            try
            {
                banco.Conectar(); //Abrir o banco de dados
                string selecionar = "SELECT avaliacaoFisica.idAvaliacaoFisica, cliente.nomeCliente, funcionario.nomeFuncionario," +
                    "avaliacaoFisica.peso, avaliacaoFisica.altura, avaliacaoFisica.medidaCorporal, avaliacaoFisica.descricaoAvaliacao," +
                    " avaliacaoFisica.dataAvaliacaoFisica FROM  avaliacaoFisica INNER JOIN cliente ON avaliacaoFisica.idCliente = cliente.idCliente INNER JOIN" +
                    " funcionario ON avaliacaoFisica.idFuncionario = funcionario.idFuncionario" +
                    " WHERE nomeFuncionario LIKE '%" + txtPesquisa.Text + "%' ORDER BY funcionario.nomeFuncionario AND cliente.nomeCliente;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexaoDb);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd); //Adaptar ao C#
                DataTable dt = new DataTable();//Criando uma estrutura da tabela
                da.Fill(dt);//Preencher a tabela (dt)

                dgvAvaliacao.DataSource = dt;
                dgvAvaliacao.Columns[0].Visible = false;
                dgvAvaliacao.Columns[1].HeaderText = "NOME DO CLIENTE";
                dgvAvaliacao.Columns[2].HeaderText = "NOME DO FUNCIONARIO";
                dgvAvaliacao.Columns[3].HeaderText = "PESO DO CLIENTE";
                dgvAvaliacao.Columns[4].HeaderText = "ALTURA DO CLIENTE";
                dgvAvaliacao.Columns[5].HeaderText = "MEDIDA CORPORAL";
                dgvAvaliacao.Columns[6].HeaderText = "DESCRICAO DA AVALIAÇÃO";
                dgvAvaliacao.Columns[7].HeaderText = "DATA DA AVALIAÇÃO";

                dgvAvaliacao.ClearSelection();//Nada selecionado
                banco.Desconectar();//Fechar db

               

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o CLIENTE por NOME.\n\n" + erro);

            }
        }

        //fim dos metodos
        private void frmAvaliacao_Load(object sender, EventArgs e)
        {
            dgvAvaliacao.ClearSelection();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR";
            new frmCadastroAvaliacao().Show(this);
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.funcao = "ALTERAR";
                new frmCadastroAvaliacao().Show(this);
                Hide();
            }
            else
            {
                MessageBox.Show("Paara alterar selecione um cliente da lista");
            }
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show(this);
            Hide();
        }

     

       

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
            {
                cbmCliente.Enabled = true;
                cbmCliente.Text = "TODOS";
                carregarAvaliacao();
            }
            else
            {
                cbmCliente.Enabled = false;
                CarregarAvaliacaoNome();

            }
        }

        private void cbmCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmCliente.Text == "TODOS")
            {
                carregarAvaliacao();

            }
            else
            {
                CarregarAvaStatus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (variaveis.linhaSelecionada >= 0)
            {
                var resposta = MessageBox.Show("Deseja mesmo excluir?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta == DialogResult.Yes)
                {
                    var resposta2 = MessageBox.Show("Tem certeza?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo);
                    if (resposta2 == DialogResult.Yes)
                    {
                        ExcluirAvaliacao();
                        carregarAvaliacao();
                    }
                }

            }
            else
            {
                MessageBox.Show("Para excluir selecione um cliente da lista");
            }
        }

        private void dgvAvaliacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {

                variaveis.codigoAva = Convert.ToInt32(dgvAvaliacao[0, variaveis.linhaSelecionada].Value);
            }
            else
            {
                MessageBox.Show("selecione uma linha por favor");
            }
        }
    }
}
