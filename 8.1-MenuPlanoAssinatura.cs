using Google.Protobuf;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class frmCadPlano : Form
    {
        public frmCadPlano()
        {
            InitializeComponent();
        }
        //mysql metodo

        private void inserirPlano()
        {
            try

            {
                banco.Conectar();
                string inserir = "insert into planoAssinatura (nomePlano, statusPlano, valorPlano, duracaoPlano, descricaoPlanos) values (@nome, @status, @valor, @duracao, @desc);";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexaoDb);
                //parametros
                cmd.Parameters.AddWithValue("@nome", variaveis.nomePlano);
                cmd.Parameters.AddWithValue("@status", variaveis.statusPlano);
                cmd.Parameters.AddWithValue("@valor", variaveis.valorPlano);
                cmd.Parameters.AddWithValue("@duracao", variaveis.duracaoPlano);
                cmd.Parameters.AddWithValue("@desc", variaveis.descricaoPlano);

                cmd.ExecuteNonQuery();
                MessageBox.Show("plano cadastrado com sucesso", "CADASTRO PLANO");
                banco.Desconectar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void alterarPlano()
        {
            try
            {
                banco.Conectar();
                string alterar = "update planoAssinatura set nomePlano = @nome, statusPlano = @status, ValorPlano = @valor, duracaoPlano = @duracao, descricaoPlanos = @desc WHERE idPlano = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexaoDb);

                cmd.Parameters.AddWithValue("@nome", variaveis.nomePlano);
                cmd.Parameters.AddWithValue("@status", variaveis.statusPlano);
                cmd.Parameters.AddWithValue("@valor", variaveis.valorPlano);
                cmd.Parameters.AddWithValue("@duracao", variaveis.duracaoPlano);
                cmd.Parameters.AddWithValue("@desc", variaveis.descricaoPlano);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codigoPlano);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Plano alterado com sucesso", "CADASTRO PLANO");
                banco.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar .\n\n" + erro);
            }
        }


        private void carregarPlano()
        {
            try
            {
                banco.Conectar();
                string carregar = "SELECT * FROM planoAssinatura WHERE idPlano = @codigo;";
                MySqlCommand cmd = new MySqlCommand(carregar, banco.conexaoDb);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codigoPlano);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    variaveis.nomePlano = dr.GetString(1);
                    variaveis.statusPlano = dr.GetString(2);
                    variaveis.valorPlano = dr.GetFloat(3); 
                    variaveis.duracaoPlano = dr.GetInt32(4);
                    variaveis.descricaoPlano = dr.GetString(5);

                    txtNomePlano.Text = variaveis.nomePlano;
                    cbmPlano.Text = variaveis.statusPlano;
                    txtValor.Text = Convert.ToString(variaveis.valorPlano); 
                    txtDuracao.Text = Convert.ToString(variaveis.duracaoPlano);
                    txtDescricaoPlano.Text = variaveis.descricaoPlano;
                }

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a avaliação.\n\n" + erro);
            }
        }



        private void frmCadPlano_Load(object sender, EventArgs e)
        {

            if (variaveis.funcao == "CADASTRAR")
            {

                lblTitulo.Text = "CADASTRO PLANO";

            }
            else if (variaveis.funcao == "ALTERAR")
            {
                carregarPlano();
                lblTitulo.Text = "ALTERAR";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           variaveis.nomePlano = txtNomePlano.Text;
            variaveis.statusPlano = cbmPlano.Text;
            variaveis.valorPlano = float.Parse(txtValor.Text);
            variaveis.duracaoPlano = int.Parse(txtDuracao.Text);
            variaveis.descricaoPlano = txtDescricaoPlano.Text;

            if (variaveis.funcao == "CADASTRAR")
            {
                inserirPlano();

                lblTitulo.Text = "CADASTRO PLANO";

            }
            else if (variaveis.funcao == "ALTERAR")
            {
                alterarPlano();
                lblTitulo.Text = "ALTERAR";
               
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new frmPlanoAssinatura().Show(this);
            Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomePlano.Clear();
            txtDuracao.Clear();
            txtDescricaoPlano.Clear();
            cbmPlano.SelectedIndex = -1;
            
            txtNomePlano.Focus();
        }
    }
}
