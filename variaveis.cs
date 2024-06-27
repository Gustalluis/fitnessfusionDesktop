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
        public static int linhaSelecionada;
        //MENU

        //CLIENTES
        public static int codigoCliente, codigoPagamento, codigoPlano;
        public static string nomecliente, telefonecliente, emailcliente, senhacliente, statuscliente, altcliente, fotocliente, atFotoCliente, CaminhoFotoCliente, TreinoCliente, pagamento,cpfCliente, atfotocliente,
        PlanoCliente;
        public static DateTime dataCadCliente;
        public static DateTime dataCadPagamento;
        public static DateTime datanasccliente;
        
        //FUNCIONARIOS
        public static int codigoFuncionario;
        public static string nomeFuncionario, enderecoFuncionario, telefoneFuncionario, cargoFuncionario,
        emailFuncionario, senhaFuncionario, statusFuncionario, altFuncionario, fotoFuncionario, atFotoFuncionario, caminhoFotoFuncionario;
        public static DateTime datacadFuncionario;
        public static float salarioFuncionario;
        //EQUIPAMENTO
        public static int codigoEquipamento;
        public static string nomeEquipamento, estadoEquipamento, descricaoEquipamento;
        //TREINO
        public static int codigoTreino;
        public static string nomeTreino, descricaoTreino, duracaoTreino; 



        //ESTRUTURA FTP ONLINE
        //public static string enderecoServidorFtp = "smpsistema.com.br/admin";
        //public static string usuarioFtp = "u283879542.fitnessfusion";
        //public static string senhaFtp = "Senac@fitnessfusion01";


        //ESTRUTURA FTP LOCAL
        public static string enderecoServidorFtp = "ftp://127.0.0.1/admin/";
        public static string usuarioFtp = "fusion";
        public static string senhaFtp = "123";
        //fim estrutura

    }
}
