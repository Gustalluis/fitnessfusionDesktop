using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnessfusion
{
    public static class variaveis
    {
        //GERAL
        public static string funcao;
        public static int LinhaSelecionada;
        //MENU

        //CLIENTES
        public static int codigoCliente;
        public static string nomecliente,telefonecliente, emailcliente, senhacliente, statuscliente, altcliente, fotocliente, atFotoCliente, CaminhoFotoCliente;
        public static DateTime dataCadCliente;
        //FUNCIONARIOS

        //ESTRUTURA FTP
        public static string enderecoServidorFtp = "smpsistema.com.br";
        public static string usuarioFtp = "u283879542.fitnessfusion";
        public static string senhaFtp = "Senac@fitnessfusion01";
        //fim estrutura

    }
}
