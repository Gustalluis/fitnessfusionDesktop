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
    public partial class _3 : Form
    {
        public _3()
        {
            InitializeComponent();
        }

        //metodo mysql

        private void inserirPagamento()
        {
            banco.Conectar();
            string inserir = "insert into pagamento (idPagamento, idCliente, idPlano, metodoPagamento, statusPagamento) VALUES (@idpaga, @idCliente, @idPlano, @metodo, @status);";
            MySqlCommand cmd = new MySqlCommand(inserir, banco.conexaoDb);

            cmd.Parameters.AddWithValue("@idpaga", variaveis.codigoPagamento);
            cmd.Parameters.AddWithValue("@idCliente", variaveis.codigoCliente);
            cmd.Parameters.AddWithValue("@idPlano", variaveis.codigoPlano);
            cmd.Parameters.AddWithValue("@metodo", variaveis.metododepagamento);
            cmd.Parameters.AddWithValue("@status", variaveis.statusPagamento);


        }

        private void _3_Load(object sender, EventArgs e)
        {

        }
    }
}
