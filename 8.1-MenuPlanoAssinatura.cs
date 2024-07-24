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
                string inserir = "insert into planoAssinatura ( nomePlano, statusPlano, valorPlano, duracaoPlano, descricaoPlano) values (@nome, @status, @valor, @duracao, @desc);";
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
        private void frmCadPlano_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           variaveis.nomePlano = txtNomePlano.Text;
            variaveis.statuscliente = cbmPlano.Text;
            variaveis.valorPlano = float.Parse(txtValor.Text);
            variaveis.duracaoPlano = int.Parse(txtDuracao.Text);
        }
    }
}
