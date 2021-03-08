using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarteiraDeAtivos
{
    public partial class CarteiraDeAtivos : Form
    {
        public CarteiraDeAtivos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private MySqlConnectionStringBuilder Conexao()                                                              // Declarando código para conexão com banco de dados, que será utilizado diversas vezes a seguir
        {
            MySqlConnectionStringBuilder conexaoString = new MySqlConnectionStringBuilder();                        // Cria estrutura de conexão com banco de dados
            conexaoString.Server = "localhost";                                                                     // Servidor
            conexaoString.Database = "controle operações ativos";                                                   // nome do banco de dados
            conexaoString.UserID = "root";                                                                          // id usuário
            conexaoString.Password = "";                                                                            // Senha
            return conexaoString;
        }


        private void botaoComprar_Click(object sender, EventArgs e)                                                 // Código para botão COMPRAR
        {
           
            MySqlConnectionStringBuilder conexaoString = Conexao();                                                 // Faz referência ao código de conexão declarado anteriormente

            MySqlConnection conexaoBanco = new MySqlConnection(conexaoString.ToString());                           // Conexão com banco de dados
            try
            {
                conexaoBanco.Open();                                                                                // Abre a conexão com o banco de dados

                MySqlCommand comandoMySql = conexaoBanco.CreateCommand();                                           // Cria um comando SQL
                comandoMySql.CommandText = "INSERT INTO operacoes (Ativo,Quantidade,Valor,Data) " +
                    "VALUES('" + tbAtivo.Text + "', '" + tbQuantidade.Text + "', '" + tbValor.Text + "', '" + tbData.Text + "')"; // Insere dados das textbox no banco de dados
                comandoMySql.ExecuteNonQuery();

                conexaoBanco.Close();                                                                               // Fecha a conexão com o banco
                MessageBox.Show("Operação Cadastrada!");                                                            // Exibo mensagem de aviso
                atualizarLista();                                                                                   // Atualiza lista de operações após cada inserção
                tbID.Clear();                                                                                       // Limpa campos das textbox após cada inserção
                tbAtivo.Clear();
                tbQuantidade.Clear();
                tbValor.Clear();
                tbData.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel cadastrar operação!");                                            // Mensagem de erro caso não consiga realizar cadastro com banco de dados
                Console.WriteLine(ex.Message);
            }
        }

        private void botaoVender_Click(object sender, EventArgs e)                                                  //Código para botão VENDER
        {
            // Os códigos em comentário a seguir foram algumas das diversas tentativas para multiplicar os números QUANTIDADE (tbQuantidade) e VALOR (tbValor) por -1.
            // Nenhuma das tentativas teve sucesso. O banco de dados não registrava os valores decimais (ignorava . ou ,).

                //decimal vlr, qtd;

                //vlr = Convert.ToDecimal(tbValor.Text);
                //qtd = Convert.ToDecimal(tbQuantidade.Text);

                //decimal Nvalor, Nquantidade;

                //Nvalor = decimal.Negate(vlr);
                //Nquantidade = decimal.Negate(qtd);

                //// double Nquantidade, Nvalor;

                //// Nquantidade = Convert.ToDouble(tbQuantidade.Text);
                //// Nvalor = Convert.ToDouble(tbValor.Text);


            string n = "-";                                                                                         // Declarando uma variável "n" tipo string cujo único objetivo é simular um sinal de negativo "-". Gambiarra.
            
            MySqlConnectionStringBuilder conexaoString = Conexao();                                                 // Faz referência ao código de conexão declarado anteriormente

            MySqlConnection conexaoBanco = new MySqlConnection(conexaoString.ToString());                           // Conexão com banco de dados
            try
            {
                conexaoBanco.Open();                                                                                // Abre a conexão com o banco de dados

                MySqlCommand comandoMySql = conexaoBanco.CreateCommand();                                           // Cria um comando SQL
                comandoMySql.CommandText = "INSERT INTO operacoes (Ativo,Quantidade,Valor,Data) " +
                    "VALUES('" + tbAtivo.Text + "', '" + n + tbQuantidade.Text + "', '" + n + tbValor.Text + "', '" + tbData.Text + "')"; // Insere dados das textbox no banco de dados. "n" foi utilizado para fazer o papel de sinal negativo. (nas tentativas frustradas foi utilizado o Nquantidade e Nvalor aqui)
                comandoMySql.ExecuteNonQuery();

                conexaoBanco.Close();                                                                               // Fecha a conexão com o banco
                MessageBox.Show("Operação Cadastrada!");                                                            // Exibo mensagem de aviso
                atualizarLista();                                                                                   // Atualiza lista de operações após cada inserção
                tbID.Clear();                                                                                       // Limpa campos das textbox após cada inserção
                tbAtivo.Clear();                                                                                    
                tbQuantidade.Clear();
                tbValor.Clear();
                tbData.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel cadastrar operação!");                                            // Mensagem de erro caso não consiga realizar cadastro com banco de dados
                Console.WriteLine(ex.Message);
            }
        }

        private void tbAtivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarteiraDeAtivos_Load(object sender, EventArgs e)                                              // Código ao carregar carteira
        {
            atualizarLista();
        }

        private void atualizarLista()                                                                               // Código de atualizar lista
        {
            MySqlConnectionStringBuilder conexaoString = Conexao();                                                 // Faz referência ao código de conexão declarado anteriormente

            MySqlConnection conexaoBanco = new MySqlConnection(conexaoString.ToString());                           // Realiza conexão com banco de dados
            try
            {
                conexaoBanco.Open();

                MySqlCommand comandoMySql = conexaoBanco.CreateCommand();
                comandoMySql.CommandText = "SELECT * from operacoes";                                               // Seleciona e apresenta todos os dados do banco de dados
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                Lista.Rows.Clear();                                                                                 

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)Lista.Rows[0].Clone();                                   // Clona uma linha da tabela (DataGridView) - Aqui no código chamada de Lista
                    row.Cells[0].Value = reader.GetInt32(0);                                                        // ID
                    row.Cells[1].Value = reader.GetString(1);                                                       // Ativo
                    row.Cells[2].Value = reader.GetInt32(2);                                                        // Quantidade
                    row.Cells[3].Value = reader.GetDouble(3);                                                       // Valor
                    row.Cells[4].Value = reader.GetString(4);                                                       // Data
                    Lista.Rows.Add(row);                                                                            // Adiciona uma linha na tabela
                }

                conexaoBanco.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel atualizar lista!");
                Console.WriteLine(ex.Message);
            }
        }

        private void botaoAtualizar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoString = Conexao();                                                 // Faz referência ao código de conexão declarado anteriormente

            MySqlConnection conexaoBanco = new MySqlConnection(conexaoString.ToString());                           // Conexão com banco de dados
            try
            {
                conexaoBanco.Open();                                                                                // Abre a conexão com o banco de dados

                MySqlCommand comandoMySql = conexaoBanco.CreateCommand();                                           // Cria um comando SQL
                comandoMySql.CommandText = "UPDATE operacoes SET Ativo = '" + tbAtivo.Text + "', " +
                    "Quantidade = '" + tbQuantidade.Text + "', Valor = '" + tbValor.Text + "', Data = '" + tbData.Text + "' WHERE idOperacao = " + tbID.Text +""; // Atualiza, com referência ao ID de operação, todos os campos em questão, havendo ou não mudança
                comandoMySql.ExecuteNonQuery();

                conexaoBanco.Close();                                                                               // Fecha a conexão com o banco
                MessageBox.Show("Operação Atualizada!");                                                            // Exibo mensagem de aviso
                atualizarLista();                                                                                   // Atualiza lista de operações após operação de atualizar
                tbAtivo.Clear();                                                                                    // Limpa campos das textbox após operação de atualizar
                tbQuantidade.Clear();
                tbValor.Clear();
                tbData.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel atualizar operação!");                                            // Mensagem de erro caso não consiga realizar cadastro com banco de dados
                Console.WriteLine(ex.Message);
            }
        }
        private void Lista_CellContentClick(object sender, DataGridViewCellEventArgs e)                             // Código para definir o que acontece quando clica em uma célula da tabela (DataGridView)
        {
            if (Lista.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)                                          // Define que se algum valor da linha ou coluna da célula selecionada for diferente de nulo, o seguinte irá ocorrer:
            {
                Lista.CurrentRow.Selected = true;                                                                   // Seleciona linha da tabela
                tbID.Text = Lista.Rows[e.RowIndex].Cells["ColumnID"].FormattedValue.ToString();                     // Preenche a TextBox de ID com o ID da linha selecionada
                tbAtivo.Text = Lista.Rows[e.RowIndex].Cells["ColumnAtivo"].FormattedValue.ToString();               // Preenche a TextBox de Ativo com o Ativo da linha selecionada
                tbQuantidade.Text = Lista.Rows[e.RowIndex].Cells["ColumnQuantidade"].FormattedValue.ToString();     // Preenche a TextBox de Quantidade com a Quantidade da linha selecionada
                tbValor.Text = Lista.Rows[e.RowIndex].Cells["ColumnValor"].FormattedValue.ToString();               // Preenche a TextBox de Valor com o Valor da linha selecionada
                tbData.Text = Lista.Rows[e.RowIndex].Cells["ColumnData"].FormattedValue.ToString();                 // Preenche a TextBox de Data com a Data da linha selecionada
            }
        }
        private void botaoDeletar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoString = Conexao();                                                 // Faz referência ao código de conexão declarado anteriormente

            MySqlConnection conexaoBanco = new MySqlConnection(conexaoString.ToString());                           // Conexão com banco de dados
            try
            {
                conexaoBanco.Open();                                                                                // Abre a conexão com o banco de dados

                MySqlCommand comandoMySql = conexaoBanco.CreateCommand();                                           // Cria um comando SQL
                comandoMySql.CommandText = "DELETE FROM operacoes WHERE idOperacao = " + tbID.Text + "";            // Deleta da base de dados, tomando como referência o ID da operação selecionada.
                comandoMySql.ExecuteNonQuery();

                conexaoBanco.Close();                                                                               // Fecha a conexão com o banco
                MessageBox.Show("Operação Removida!");                                                              // Exibo mensagem de aviso
                atualizarLista();                                                                                   // Atualiza lista de operações após operação de deletar
                tbAtivo.Clear();                                                                                    // Limpa campos das textbox após operação de deletar
                tbQuantidade.Clear();
                tbValor.Clear();
                tbData.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel remover operação!");                                            // Mensagem de erro caso não consiga realizar cadastro com banco de dados
                Console.WriteLine(ex.Message);
            }
        }

        
    }
}
