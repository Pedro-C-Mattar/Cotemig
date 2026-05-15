using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    class BLL_Especialidade
    {
        Conexao bd = new Conexao();
        public DataTable ListarEspecialidades()
        {
            try     
            {
                string comando = "SELECT * FROM tbl_especialidade;";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
