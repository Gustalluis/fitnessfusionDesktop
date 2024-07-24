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
        }
        private void carregarAvaliacao()
        {
            try
            {
                banco.Conectar();
                string carregar = "SELECT \r\n    avaliacaoFisica.idAvaliacaoFisica, \r\n    cliente.nomeCliente, \r\n    funcionario.nomeFuncionario, \r\n    avaliacaoFisica.peso, \r\n    avaliacaoFisica.altura, \r\n    avaliacaoFisica.medidaCorporal, \r\n    avaliacaoFisica.descricaoAvaliacao, \r\n    avaliacaoFisica.dataAvaliacaoFisica \r\nFROM \r\n    avaliacaoFisica \r\nINNER JOIN \r\n    cliente ON avaliacaoFisica.idCliente = cliente.idCliente \r\nINNER JOIN \r\n    funcionario ON avaliacaoFisica.idFuncionario = funcionario.idFuncionario;";
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
        private void frmAvaliacao_Load(object sender, EventArgs e)
        {
            carregarAvaliacao();
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

     

        private void dgvAvaliacao_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codigoAva = Convert.ToInt32(dgvAvaliacao[0, variaveis.linhaSelecionada].Value);
            }
        }
    }
}
