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
    public partial class frmCadastroEquipamento : Form
    {
        public frmCadastroEquipamento()
        {
            InitializeComponent();
            
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            new frmEquipamento().Show();
            Hide();
        }

        //msyql metodo

        private void inserirEquip()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO equipamento (nomeEquipamento, estadoEquipamento, descricaoEquipamento) VALUES (@nomeEquip, @estadoEquip, @descricaoEquip);";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexaoDb);

                cmd.Parameters.AddWithValue("@nomeEquip", variaveis.nomeEquipamento);
                cmd.Parameters.AddWithValue("@estadoEquip", variaveis.estadoEquipamento);
                cmd.Parameters.AddWithValue("@descricaoEquip", variaveis.descricaoEquipamento);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Equipamento cadastrado com sucesso", "CADASTRO DE EQUIPAMENTO");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro Ao inserir Equipamento\n\n" + erro);
            }
        }

        private void carregarEquip()
        {
            try
            {
                banco.Conectar();
                string carregar = "select*from equipamento where idEquipamento = @codigo;";
                MySqlCommand cmd = new MySqlCommand(carregar, banco.conexaoDb);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codigoEquipamento);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.nomeEquipamento = dr.GetString(1);
                    variaveis.estadoEquipamento = dr.GetString(2);
                    variaveis.descricaoEquipamento= dr.GetString(3);

                    txtNomeEquipamento.Text = variaveis.nomeEquipamento;
                    cmbEstadoEquip.Text = variaveis.estadoEquipamento;
                    txtDescricaoEquipamento.Text = variaveis.descricaoEquipamento;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os equipamento.\n\n" + erro);
            }
        }

        private void alterarEquip()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE equipamento SET nomeEquipamento = @nome, estadoEquipamento = @estado, descricaoEquipamento = @descricao WHERE idEquipamento = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexaoDb);

                cmd.Parameters.AddWithValue("@nome", variaveis.nomeEquipamento);
                cmd.Parameters.AddWithValue("@estado", variaveis.estadoEquipamento);
                cmd.Parameters.AddWithValue("@descricao", variaveis.descricaoEquipamento);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codigoEquipamento);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Serviço EDITADO com sucesso", "EDITAR SERVIÇO");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("erro ao alterar equipamento. \n\n" + erro);
            }
        }





        private void frmCadastroEquipamento_Load(object sender, EventArgs e)
        {
            if (variaveis.funcao == "CADASTRAR")
            {

                lblTitulo.Text = "CADASTRO EQUIPAMENTO";

            }
            else if (variaveis.funcao == "ALTERAR")
            {
                
                lblTitulo.Text = "ALTERAR EQUIPAMENTO";
                carregarEquip();


            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            variaveis.nomeEquipamento = txtNomeEquipamento.Text;
            variaveis.estadoEquipamento = cmbEstadoEquip.Text;
            variaveis.descricaoEquipamento = txtDescricaoEquipamento.Text;

            if (variaveis.funcao == "CADASTRAR")
            {
                inserirEquip();

                lblTitulo.Text = "CADASTRO FUNCIONARIO";

            }
            else if (variaveis.funcao == "ALTERAR")
            {
                alterarEquip();
                lblTitulo.Text = "ALTERAR";

            }
        }
    }
}
