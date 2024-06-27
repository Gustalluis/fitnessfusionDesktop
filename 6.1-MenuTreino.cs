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
    public partial class frmCadTreino : Form
    {
        public frmCadTreino()
        {
            InitializeComponent();
        }
        //MÉTODO MYSQL
        public void inserirTreino()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO treino (nomeTreino, duracaoTreino, descricaoTreino) VALUES (@nomeTreino, @duracaoTreino, @descricaoTreino);";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexaoDb);

                cmd.Parameters.AddWithValue("@nomeTreino", variaveis.nomeTreino);
                cmd.Parameters.AddWithValue("@duracaoTreino", variaveis.duracaoTreino);
                cmd.Parameters.AddWithValue("@descricaoTreino", variaveis.descricaoTreino);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Treino cadastrado com sucesso", "CADASTRO DE TREINO");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro Ao inserir Treino\n\n" + erro);
            }
        }

        public void carregarTreino()
            
        {
            try
            {
                banco.Conectar();
                string carregar = "select*from treino where idTreino = @codigo;";
                MySqlCommand cmd = new MySqlCommand(carregar, banco.conexaoDb);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codigoTreino);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.nomeTreino = dr.GetString(1);
                    variaveis.duracaoTreino = dr.GetString(2);
                    variaveis.descricaoTreino = dr.GetString(3);

                    txtNomeTreino.Text = variaveis.nomeTreino;
                    cmbduracaoTreino.Text = variaveis.duracaoTreino;
                    txtDescricaoTreino.Text = variaveis.descricaoTreino;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar o treino.\n\n" + erro);
            }
        }


        private void alterarTreino()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE treino SET nometreino = @nome, duracaoTreino = @duracao, descricaoTreino = @descricao WHERE idTreino = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexaoDb);

                cmd.Parameters.AddWithValue("@nome", variaveis.nomeTreino);
                cmd.Parameters.AddWithValue("@duracao", variaveis.duracaoTreino);
                cmd.Parameters.AddWithValue("@descricao", variaveis.descricaoTreino);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codigoTreino);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Serviço EDITADO com sucesso", "EDITAR SERVIÇO");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("erro ao alterar equipamento. \n\n" + erro);
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            new FrmTreino().Show(this);
            Hide();
        }

        private void frmCadTreino_Load(object sender, EventArgs e)
        {
            if (variaveis.funcao == "CADASTRAR")
            {

                lblTitulo.Text = "CADASTRO TREINO";

            }
            else if (variaveis.funcao == "ALTERAR")
            {
                carregarTreino();

                lblTitulo.Text = "ALTERAR TREINO";
                


            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            variaveis.nomeTreino = txtNomeTreino.Text;
            variaveis.duracaoTreino = cmbduracaoTreino.Text;
            variaveis.descricaoTreino = txtDescricaoTreino.Text;

            if (variaveis.funcao == "CADASTRAR")
            {
                inserirTreino();

                lblTitulo.Text = "CADASTRO FUNCIONARIO";

            }
            else if (variaveis.funcao == "ALTERAR")
            {
                alterarTreino();
                lblTitulo.Text = "ALTERAR";

            }
        }
    }
}
