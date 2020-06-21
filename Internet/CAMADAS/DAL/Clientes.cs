using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.CAMADAS.DAL
{
    public class Clientes
    {
        private string stringConexao = Conexao.getConexao();

        public List<MODEL.Clientes> Select()
        {
            List<MODEL.Clientes> listaClientes = new List<MODEL.Clientes>();
            SqlConnection conexao = new SqlConnection(stringConexao);
            string sql = "SELECT * FROM Clientes";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Clientes cliente = new MODEL.Clientes();
                    cliente.id = Convert.ToInt32(dados[0].ToString());
                    cliente.nome = dados["nome"].ToString();
                    cliente.cpf = dados["cpf"].ToString();
                    cliente.telefone = dados["telefone"].ToString();
                    cliente.idade = Convert.ToInt32(dados["idade"].ToString());

                    listaClientes.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro na execução do comando Select de Clientes...");
            }
            finally
            {
                conexao.Close();
            }
            return listaClientes;
        }

        public MODEL.Clientes SelectByID(int id)
        {
            MODEL.Clientes cliente = new MODEL.Clientes();
            SqlConnection conexao = new SqlConnection(stringConexao);
            string sql = "SELECT * FROM Clientes WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dados.Read())
                {
                    //MODEL.Clientes cliente = new MODEL.Clientes();
                    cliente.id = Convert.ToInt32(dados[0].ToString());
                    cliente.nome = dados["nome"].ToString();
                    cliente.cpf = dados["cpf"].ToString();
                    cliente.telefone = dados["telefone"].ToString();
                    cliente.idade = Convert.ToInt32(dados["idade"].ToString());

                    //listaCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro na execução do comando Select de Clientes por ID...");
            }
            finally
            {
                conexao.Close();
            }
            return cliente;
        }

        public List<MODEL.Clientes> SelectbyNome(string nome)
        {
            List<MODEL.Clientes> listaClientes = new List<MODEL.Clientes>();
            SqlConnection conexao = new SqlConnection(stringConexao);
            string sql = "SELECT * FROM Clientes WHERE (nome LIKE @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Clientes cliente = new MODEL.Clientes();
                    cliente.id = Convert.ToInt32(dados[0].ToString());
                    cliente.nome = dados["nome"].ToString();
                    cliente.cpf = dados["cpf"].ToString();
                    cliente.telefone = dados["telefone"].ToString();
                    cliente.idade = Convert.ToInt32(dados["idade"].ToString());

                    listaClientes.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro na execução do comando Select de Clientes por Nome...");
            }
            finally
            {
                conexao.Close();
            }
            return listaClientes;
        }

        public void Insert(MODEL.Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(stringConexao);
            string sql = "INSERT INTO Clientes VALUES (@nome, @cpf, @telefone, @idade);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@cpf", cliente.cpf);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("@idade", cliente.idade);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Inserção de Clientes...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(stringConexao);
            string sql = "UPDATE Clientes SET nome=@nome, cpf=@cpf, telefone=@telefone, idade=@idade ";
            sql += " WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@cpf", cliente.cpf);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("@idade", cliente.idade);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Atualização - Update de Clientes...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int idCliente)
        {
            SqlConnection conexao = new SqlConnection(stringConexao);
            string sql = "DELETE FROM Clientes WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idCliente);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Remoção - Delete de Clientes...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
