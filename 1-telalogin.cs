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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //metodo mysql 

       private void Login()
{
    try
    {
        banco.Conectar();
        string selecionar = @"SELECT nomeFuncionario, emailFuncionario, senhaFuncionario 
                              FROM funcionario 
                              WHERE emailFuncionario = @Email 
                                AND senhaFuncionario = @Senha 
                                AND statusFuncionario = @Status;";
        MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexaoDb);
        
        // Parâmetros
        cmd.Parameters.AddWithValue("@Email", variaveis.usuario);
        cmd.Parameters.AddWithValue("@Senha", variaveis.senha);
        cmd.Parameters.AddWithValue("@Status", "ATIVO");
        
        MySqlDataReader reader = cmd.ExecuteReader();
        if (reader.Read())
        {
            // Certifique-se de que os índices das colunas estão corretos
            variaveis.usuario = reader.GetString("nomeFuncionario");
            variaveis.especialidade = reader.GetString("emailFuncionario"); // Exemplo: alterar para a coluna correta
            
            new frmMenu().Show();
            Hide();
        }
        else
        {
            variaveis.tentativa += 1;
            if (variaveis.tentativa >= 3)
            {
                MessageBox.Show("Número máximo de tentativas excedido. O aplicativo será fechado.");
                Application.Exit();
            }
            else
            {
                MessageBox.Show($"ACESSO NEGADO\n\nVocê tem mais {3 - variaveis.tentativa} tentativa(s)");
                txtEmail.Clear();
                txtSenha.Clear();
                txtEmail.Focus();
            }
        }
        
        reader.Close(); // Fechar o reader após o uso
        banco.Desconectar();
    }
    catch (Exception erro) 
    {
        MessageBox.Show("Erro ao efetuar o LOGIN: " + erro.Message);
    }
}

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.BackgroundImage = Properties.Resources.sair1;
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.BackgroundImage = Properties.Resources.sair;
        }

        private void btnEntrar_MouseEnter(object sender, EventArgs e)
        {
            btnEntrar.BackgroundImage = Properties.Resources.btnEntrar1;
        }

        private void btnEntrar_MouseLeave(object sender, EventArgs e)
        {
            btnEntrar.BackgroundImage = Properties.Resources.btnEntrar;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja realmente Encerrar a aplicação?", "ENCERRAR", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            variaveis.usuario = txtEmail.Text;
            variaveis.senha = txtSenha.Text;
            if (variaveis.usuario == "" && variaveis.senha == "")
            {
                variaveis.especialidade = "";
                new frmMenu().Show();
                Hide();
            }
            else
            {
                Login();
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
