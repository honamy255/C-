using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdclienteDataSet.tbCliente' table. You can move, or remove it, as needed.
            this.tbClienteTableAdapter.Fill(this.bdclienteDataSet.tbCliente);

        }

        private void tbClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdclienteDataSet);

        }

            private void label1_Click(object sender, EventArgs e)
            {

            }

             private void cpfTextBox_TextChanged(object sender, EventArgs e)
            {

            }

            

             private void telefoneTextBox_TextChanged(object sender, EventArgs e)
             {

             }

             private void label2_Click(object sender, EventArgs e)
             {
                              }

             private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
             {

             }

             private void label3_Click(object sender, EventArgs e)
             {

             }

             private void txtpesquisar_TextChanged(object sender, EventArgs e)
             {
                 try
                 {
                     if (cbmfilrar.Text == "Código")
                     {
                         //Define a instrução Sql
                         string sql = "SELECT * FROM tbCliente WHERE codFuncionario =" + txtpesquisar.Text + "";
                         //Lê os dados da variavel sql e conectar no cn
                         frl = new SqlCommand(sql, cn);
                         //Abre conexão
                         cn.Open();
                         //Define o valor da CommandType para cmd
                         cmd.CommandType = CommandType.Text;
                         /*Representa um conjunto de comandos de dados e uma conexão de banco de dados
                          * que são usados para preencher o DataSet e atualizar um banco de dados SQL Server.*/
                         SqlDataAdapter da = new SqlDataAdapter(cmd);
                         //Representa uma tabela de dados na memória.
                         DataTable cliente = new DataTable();
                         /* Adiciona ou atualiza linhas em um DataTable para que correspondam na fonte de
                          * dados usando o DataTable.*/
                         da.Fill(cliente);
                         /*A tbClienteDataGridView recebe o DataTable cliente*/
                         tbClienteDataGridView.DataSource = cliente;
                         //Fechar a conexão
                     }
                     if (cbmfilrar.Text == "Nome")
                     {
                         //define a instrução SQL
                         string sql = "SELECT * FROM tbCliente WHERE cliente LIKE '%" + txtPesquisar.Text + "%'";
                         cmd = new SqlCommand(sql, cn);
                         cn.Open();
                         cmd.CommandType = CommandType.Text;
                         SqlDataAdapter da = new SqlDataAdapter(cmd);
                         DataTable cliente = new DataTable();
                         da.Fill(cliente);
                         tbClienteDataGridView.DataSource = cliente;
                     }
                     if (cbmfilrar.Text == "CPF")
                     {
                         //define a instrução SQL
                         string sql = "SELECT * FROM tbCliente WHERE CPF ='" + txtpesquisar.Text + "'";
                         cmd = new SqlCommand(sql, cn);
                         cn.Open();
                         cmd.CommandType = CommandType.Text;
                         SqlDataAdapter da = new SqlDataAdapter(cmd);
                         DataTable cliente = new DataTable();
                         da.Fill(cliente);
                         tbClienteDataGridView.DataSource = cliente;
                     }
                     if (cbmfilrar.Text == "")
                     {
                         //define a instrução SQL
                         string sql = "SELECT * FROM tbCliente";
                         cmd = new SqlCommand(sql, cn);
                         cn.Open();
                         cmd.CommandType = CommandType.Text;
                         SqlDataAdapter da = new SqlDataAdapter(cmd);
                         DataTable cliente = new DataTable();
                         da.Fill(cliente);
                         tbClienteDataGridView.DataSource = cliente;

                     }

                 }
                 catch (Exception ex)
                 {
                     //Caso haja uma exceção
                     MessageBox.Show(ex.Message);
                 }
                 finally
                 {
                     //Fechar a conexão
                     cn.Close();

                 }
             }

             private void groupBox1_Enter(object sender, EventArgs e)
             {
                 if ( cbmfilrar.Text == "Código") 
                 {
                     txtpesquisar.Text = "";
                 }
                 if (cbmfilrar.Text == "Nome")
                 {
                     txtpesquisar.Text = "";

                 }
                 if (cbmfilrar.Text == "CPF")
                 {
                     txtpesquisar.Text = "00000000000";
                 }
                 if (cbmfilrar.Text == "")
                 {
                     txtpesquisar.Text = "";
                 }
             }

             private void btnPesquisar_Click(object sender, EventArgs e)
             {

             }
    }
}
