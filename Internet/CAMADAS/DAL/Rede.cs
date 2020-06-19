using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.CAMADAS.DAL
{
    public class Rede
    {
        private string stringConexao = Conexao.getConexao();

        public List<MODEL.Rede> Select()
        {
            List<MODEL.Rede> listaRede = new List<MODEL.Rede>();

            SqlConnection conexao = new SqlConnection(stringConexao);
            string sql = "SELECT * FROM Rede;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Rede rede = new MODEL.Rede();
                    rede.id = Convert.ToInt32(dados["id"].ToString());
                    rede.ip = dados["ip"].ToString();
                    rede.gateway = dados["gateway"].ToString();
                    rede.mascara = dados["mascara"].ToString();
                    rede.valor = Convert.ToSingle(dados["valor"].ToString());
                    rede.situacao = Convert.ToInt32(dados["situacao"].ToString());
                    listaRede.Add(rede);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao Listar Rede...");
            }
            finally
            {
                conexao.Close();
            }
            return listaRede;
        }

        public List<MODEL.Rede> SelectByID(int id)
        {
            List<MODEL.Rede> listaRede = new List<MODEL.Rede>();
            SqlConnection conexao = new SqlConnection(stringConexao);
            string sql = "SELECT * FROM Rede WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Rede rede = new MODEL.Rede();
                    rede.id = Convert.ToInt32(dados["id"].ToString());
                    rede.ip = dados["ip"].ToString();
                    rede.gateway = dados["gateway"].ToString();
                    rede.mascara = dados["mascara"].ToString();
                    rede.valor = Convert.ToInt32(dados["valor"].ToString());
                    rede.situacao = Convert.ToInt32(dados["situacao"].ToString());

                    listaRede.Add(rede);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao Listar Rede por ID...");
            }
            finally
            {
                conexao.Close();
            }
            return listaRede;
        }

        public List<MODEL.Rede> SelectbyIP(string ip)
        {
            List<MODEL.Rede> listaRede = new List<MODEL.Rede>();
            SqlConnection conexao = new SqlConnection(stringConexao);
            string sql = "SELECT * FROM Rede WHERE (ip LIKE @ip);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ip", "%" + ip + "%");

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Rede rede = new MODEL.Rede();
                    rede.id = Convert.ToInt32(dados["id"].ToString());
                    rede.ip = dados["ip"].ToString();
                    rede.gateway = dados["gateway"].ToString();
                    rede.mascara = dados["mascara"].ToString();
                    rede.valor = Convert.ToInt32(dados["valor"].ToString());
                    rede.situacao = Convert.ToInt32(dados["situacao"].ToString());

                    listaRede.Add(rede);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao Listar Rede por IP...");
            }
            finally
            {
                conexao.Close();
            }
            return listaRede;
        }

        public void Insert(MODEL.Rede rede)
        {
            SqlConnection conexao = new SqlConnection(stringConexao);
            string sql = "INSERT INTO Rede VALUES (@ip, @gateway, @mascara, @valor, @situacao);";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            rede.situacao = 1;
            cmd.Parameters.AddWithValue("@ip", rede.ip);
            cmd.Parameters.AddWithValue("@gateway", rede.gateway);
            cmd.Parameters.AddWithValue("@mascara", rede.mascara);
            cmd.Parameters.AddWithValue("@valor", rede.valor);
            cmd.Parameters.AddWithValue("@situacao", rede.situacao);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro SQL ao Inserir Rede...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update (MODEL.Rede rede)
        {
            SqlConnection conexao = new SqlConnection(stringConexao);
            string sql = "UPDATE Rede SET ip=@ip, gateway=@gateway, mascara=@mascara, valor=@valor, situacao=@situacao ";
            sql += "WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", rede.id);
            cmd.Parameters.AddWithValue("@ip", rede.ip);
            cmd.Parameters.AddWithValue("@gateway", rede.gateway);
            cmd.Parameters.AddWithValue("@mascara", rede.mascara);
            cmd.Parameters.AddWithValue("@valor", rede.valor);
            cmd.Parameters.AddWithValue("@situacao", rede.situacao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro SQL ao Atualizar Rede...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int idRede)
        {
            SqlConnection conexao = new SqlConnection(stringConexao);
            string sql = "DELETE FROM Rede WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idRede);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro SQL ao Remover Rede...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
