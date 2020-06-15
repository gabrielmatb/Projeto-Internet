using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.CAMADAS.DAL
{
    public class ClienteRoteador
    {
        private string stringConexao = Conexao.getConexao();

        public List<MODEL.ClienteRoteador> Select()
        {
            List<MODEL.ClienteRoteador> listaClienteRoteador = new List<MODEL.ClienteRoteador>();
            SqlConnection conexao = new SqlConnection(stringConexao);
            string sql = "SELECT * FROM ClienteRoteador";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.ClienteRoteador clienteRoteador = new MODEL.ClienteRoteador();
                    clienteRoteador.id = Convert.ToInt32(dados["id"].ToString());
                    clienteRoteador.clienteID = Convert.ToInt32(dados["clienteID"].ToString());
                    clienteRoteador.roteadorID = Convert.ToInt32(dados["roteadorID"].ToString());
                    clienteRoteador.dataInicio = Convert.ToDateTime(dados["dataInicio"].ToString());
                    clienteRoteador.dataFim = Convert.ToDateTime(dados["dataFim"].ToString());

                    listaClienteRoteador.Add(clienteRoteador);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao Listar ClienteRoteador...");
            }
            finally
            {
                conexao.Close();
            }
            return listaClienteRoteador;
        }

        public void Insert(MODEL.ClienteRoteador clienteRoteador)
        {
            SqlConnection conexao = new SqlConnection(stringConexao);

            string sql = "INSERT INTO Emprestimo VALUES (@clienteID, @roteadorID, @dataInicio, @dataFim);";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@clienteID", clienteRoteador.clienteID);
            cmd.Parameters.AddWithValue("@roteadorID", clienteRoteador.roteadorID);
            cmd.Parameters.AddWithValue("@dataInicio", clienteRoteador.dataInicio);
            cmd.Parameters.AddWithValue("@dataFim", clienteRoteador.dataFim);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro SQL ao Inserir ClienteRoteador...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.ClienteRoteador clienteRoteador)
        {
            SqlConnection conexao = new SqlConnection(stringConexao);

            string sql = "UPDATE ClienteRoteador SET clienteID=@clienteID, roteadorID=@roteadorID, dataInicio=@dataInicio, dataFim=@dataFim ";
            sql += " WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@id", clienteRoteador.id);
            cmd.Parameters.AddWithValue("@clienteID", clienteRoteador.clienteID);
            cmd.Parameters.AddWithValue("@roteadorID", clienteRoteador.roteadorID);
            cmd.Parameters.AddWithValue("@dataInicio", clienteRoteador.dataInicio);
            cmd.Parameters.AddWithValue("@dataFim", clienteRoteador.dataFim);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro SQL ao Atualizar ClienteRoteador...");
            }
            finally
            {
                conexao.Close();
            }

        }

        public void Delete(int idClienteRoteador)
        {
            SqlConnection conexao = new SqlConnection(stringConexao);

            string sql = "DELETE FROM Emprestimo WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@id", idClienteRoteador);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro SQL ao Remover ClienteRoteador...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
