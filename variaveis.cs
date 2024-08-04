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
       
        //CLIENTES
        public static int codigoCliente, codigoPagamento, codigoPlano, pagamentoCliente;
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
        public static double salarioFuncionario;
        //EQUIPAMENTO
        public static int codigoEquipamento;
        public static string nomeEquipamento, estadoEquipamento, descricaoEquipamento;
        //TREINO
        public static int codigoTreino;
        public static string nomeTreino, descricaoTreino, duracaoTreino, statusTreino;
        //AVALIAÇÃO
        public static int codigoAva;
        public static string peso, altura, medida, descricao, statusAvaliacao;
        public static DateTime data;

        //LOGIN
        public static int tentativa;
        public static string usuario, senha, especialidade, nomeUsuario;

        //pagamento
        public static int novoId;
        public static string statusPagamento, metododepagamento;
        //PLANO ASSINATURA
        public static string nomePlano, descricaoPlano, statusPlano;
        public static int duracaoPlano;
        public static float valorPlano;

        //ESTRUTURA FTP ONLINE
        //public static string enderecoServidorFtp = "smpsistema.com.br/admin";
        //public static string usuarioFtp = "u283879542.fitnessfusion";
        //public static string senhaFtp = "Senac@fitnessfusion01";


        //ESTRUTURA FTP LOCAL
        public static string enderecoServidorFtp = "ftp://u283879542.fitnessfusion@smpsistema.com.br/dashboard/";
        public static string usuarioFtp = "u283879542.fitnessfusion";
        public static string senhaFtp = "Senac@fitnessfusion01";
        //fim estrutura

    }
}
