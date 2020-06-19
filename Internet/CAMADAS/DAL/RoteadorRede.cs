using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.CAMADAS.DAL
{
    public class RoteadorRede
    {
        private string stringConexao = Conexao.getConexao();

        public List<MODEL.RoteadorRede> Select()
        {
            List<MODEL.RoteadorRede> listaRoteadorRede = new List<MODEL.RoteadorRede>();
            SqlConnection conexao = new SqlConnection(stringConexao);
            string sql = "SELECT * FROM RoteadorRede";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.RoteadorRede roteadorRede = new MODEL.RoteadorRede();
                    roteadorRede.id = Convert.ToInt32(dados["id"].ToString());
                    roteadorRede.roteadorID = Convert.ToInt32(dados["roteadorID"].ToString());
                    roteadorRede.redeID = Convert.ToInt32(dados["redeID"].ToString());
                    roteadorRede.dataInicio = Convert.ToDateTime(dados["dataInicio"].ToString());
                    roteadorRede.dataFim = Convert.ToDateTime(dados["dataFim"].ToString());

                    listaRoteadorRede.Add(roteadorRede);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao Listar RoteadorRede...");
            }
            finally
            {
                conexao.Close();
            }
            return listaRoteadorRede;
        }

        public void Insert(MODEL.RoteadorRede roteadorRede)
        {
            SqlConnection conexao = new SqlConnection(stringConexao);

            string sql = "INSERT INTO RoteadorRede VALUES (@roteadorID, @redeID, @dataInicio, @dataFim);";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@roteadorID", roteadorRede.roteadorID);
            cmd.Parameters.AddWithValue("@redeID", roteadorRede.redeID);
            cmd.Parameters.AddWithValue("@dataInicio", roteadorRede.dataInicio);
            cmd.Parameters.AddWithValue("@dataFim", roteadorRede.dataFim);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro SQL ao Inserir RoteadorRede...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.RoteadorRede roteadorRede)
        {
            SqlConnection conexao = new SqlConnection(stringConexao);

            string sql = "UPDATE RoteadorRede SET roteadorID=@roteadorID, redeID=@redeID, dataInicio=@dataInicio, dataFim=@dataFim ";
            sql += " WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@id", roteadorRede.id);
            cmd.Parameters.AddWithValue("@roteadorID", roteadorRede.roteadorID);
            cmd.Parameters.AddWithValue("@redeID", roteadorRede.redeID);
            cmd.Parameters.AddWithValue("@dataInicio", roteadorRede.dataInicio);
            cmd.Parameters.AddWithValue("@dataFim", roteadorRede.dataFim);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro SQL ao Atualizar RoteadorRede...");
            }
            finally
            {
                conexao.Close();
            }

        }

        public void Delete(int idRoteadorRede)
        {
            SqlConnection conexao = new SqlConnection(stringConexao);

            string sql = "DELETE FROM RoteadorRede WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@id", idRoteadorRede);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro SQL ao Remover RoteadorRede...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
