using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.CAMADAS.DAL
{
    public class Roteador
    {
        private string stringConexao = Conexao.getConexao();

        public List<MODEL.Roteador> Select()
        {
            List<MODEL.Roteador> listaRoteador = new List<MODEL.Roteador>();
            SqlConnection conexao = new SqlConnection(stringConexao);
            string sql = "SELECT * FROM Roteador;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Roteador roteador = new MODEL.Roteador();
                    roteador.id = Convert.ToInt32(dados["id"].ToString());
                    roteador.nome = dados["nome"].ToString();
                    roteador.marca = dados["marca"].ToString();
                    roteador.usuario = dados["usuario"].ToString();
                    roteador.senha = dados["senha"].ToString();
                    roteador.mac = dados["mac"].ToString();
                    roteador.situacao = Convert.ToInt32(dados["situacao"].ToString());

                    listaRoteador.Add(roteador);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao Listar Roteador...");
            }
            finally
            {
                conexao.Close();
            }
            return listaRoteador;
        }

        public void Insert(MODEL.Roteador roteador)
        {
            SqlConnection conexao = new SqlConnection(stringConexao);
            string sql = "INSERT INTO Roteador VALUES (@nome, @marca, @usuario, @senha, @mac, @situacao);";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            roteador.situacao = 1;
            cmd.Parameters.AddWithValue("@nome", roteador.nome);
            cmd.Parameters.AddWithValue("@marca", roteador.marca);
            cmd.Parameters.AddWithValue("@usuario", roteador.usuario);
            cmd.Parameters.AddWithValue("@senha", roteador.senha);
            cmd.Parameters.AddWithValue("@mac", roteador.mac);
            cmd.Parameters.AddWithValue("@situacao", roteador.situacao);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro SQL ao Inserir Roteador...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update (MODEL.Roteador roteador)
        {
            SqlConnection conexao = new SqlConnection(stringConexao);
            string sql = "UPDATE Roteador SET nome=@nome, marca=@marca, usuario=@usuario, senha=@senha, mac=@mac, situacao=@situacao ";
            sql += " WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            roteador.situacao = 1;
            cmd.Parameters.AddWithValue("@id", roteador.id);
            cmd.Parameters.AddWithValue("@nome", roteador.nome);
            cmd.Parameters.AddWithValue("@marca", roteador.marca);
            cmd.Parameters.AddWithValue("@usuario", roteador.usuario);
            cmd.Parameters.AddWithValue("@senha", roteador.senha);
            cmd.Parameters.AddWithValue("@mac", roteador.mac);
            cmd.Parameters.AddWithValue("@situacao", roteador.situacao);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao Atualizar Roteador...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete (int idRoteador)
        {
            SqlConnection conexao = new SqlConnection(stringConexao);
            string sql = "DELETE FROM Roteador WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idRoteador);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao Remover Roteador...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
