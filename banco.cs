using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitnessfusion
{
    public static class banco
    {
        //Metodos de ligação com banco de dados
        //Temos o metodo com banco local

        /* public static string
         * db = "SERVER=localhost"; +
         * "USER=(nome do usuario)"; +
         * "DATABASE=(nome do banco de dados)";
        */

        //Temos o metodo com banco online

        public static string db =
            "SERVER=smpsistema.com.br;" +
            "USER=u283879542_fitnessfusion;" +
            "PASSWORD=Senac@fitnessfusion01;" +
            "DATABASE=u283879542_fitnessfusion;" +
            "SSL MODE=none";

        public static MySqlConnection conexaoDb;

        //METODO PARA ABRIR CONEXÂO COM O BANCO DE DADOS
        public static void Conectar()
        {
            try
            {
                conexaoDb = new MySqlConnection(db);
                conexaoDb.Open();
            }
            catch
            {
                MessageBox.Show("Erro ao tentar conectar com o banco de dados!");
            }
        }

        //METODO PARA FECHAR CONEXÂO COM O BANCO DE DADOS

        public static void Desconectar()
        {
            try
            {
                conexaoDb = new MySqlConnection(db);
                conexaoDb.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao desconectar do banco de dados");
            }
        }

    }
}
