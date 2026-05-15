using System;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    class BLL_Tecnico
    {
        Conexao bd = new Conexao();
        public void InserirTecnico(DTO_Tecnico Tecnico)
        {
            try
            {
                string comando = "INSERT INTO tbl_Tecnico VALUES (DEFAULT, '" + Tecnico.Nome + "','" 
                                                                           + Tecnico.Espec_id + "');";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;   
            }
        }

        public void AlterarTecnico(DTO_Tecnico Tecnico)
        {
            try
            {
                string comando = "UPDATE tbl_Tecnico SET nome_Tecnico = '" + Tecnico.Nome +
                                                    "', tbl_especialidade_id_espec = '" + Tecnico.Espec_id +
                                                    "' WHERE id_Tecnico = " + Tecnico.Id + ";";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)  
            {  
                throw ex;
            }
        }

        public void ExcluirTecnico(int id)
        {
            try
            {
                string comando = "DELETE FROM tbl_Tecnico WHERE id_Tecnico = " + id + ";";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarTecnicos()
        {
            try
            {
                string comando = "SELECT * FROM tbl_Tecnico;";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
