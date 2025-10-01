using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ProjetoAppEscola
{
    internal class ConexaoCliente
    {
        MySqlConnection conn;

        public void ConectarBD()
        {
            try
            {
                conn = new MySqlConnection("Persist Security info= false; server = localhost;database=dbloja;user=root;pwd=;");
                conn.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int ExecutarComandos(string sql)
        {
            int resultado;
            try
            {
                ConectarBD();
                //Criado o objeto com as informações para executar o comando
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Método para executar o comando no banco
                cmd.ExecuteNonQuery();
                resultado = 1;
                
            }
            catch (Exception) { 
                resultado = 0;
                throw;

            }
            finally
            {
                conn.Close();
            }

            return resultado;
        }
        public DataTable ExecutarConsulta(string sql)
        {
            try
            {
                ConectarBD();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                    throw;
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
