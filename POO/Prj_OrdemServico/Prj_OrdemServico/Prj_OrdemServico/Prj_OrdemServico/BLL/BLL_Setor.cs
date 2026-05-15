using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    class BLL_Setor
    {
        Conexao bd = new Conexao();   
        public DataTable ListarSetores()
        {
            try
            {
                string comando = "SELECT * FROM tbl_setores;";    
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
