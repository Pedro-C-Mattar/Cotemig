using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    class BLL_Usuario
    {
        Conexao bd = new Conexao();
        public void InserirUsuario(DTO_Usuario usuario)
        {
            try   
            {    
                string comando = "INSERT INTO tbl_usuario(id_usuario,tbl_setores_id_setor,nome_usuario,email_usuario,tel_usuario)" +
                                                         "VALUES (DEFAULT, '" + usuario.Setor_id + "','" 
                                                                              + usuario.Nome + "','" 
                                                                              + usuario.Email + "','" 
                                                                              + usuario.Tel + "');";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarUsuario(DTO_Usuario usuario)
        {  
            try
            {
                string comando = "UPDATE tbl_usuario SET tbl_setores_id_setor = '" + usuario.Setor_id + 
                                                    "', nome_usuario = '" + usuario.Nome +
                                                    "', email_usuario = '" + usuario.Email +
                                                    "', tel_usuario = '" + usuario.Tel +
                                                    "' WHERE id_usuario = " + usuario.Id + ";";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirUsuario(int id)
        {
            try
            {
                string comando = "DELETE FROM tbl_usuario WHERE id_usuario = " + id + ";";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarUsuarios()
        {
            try
            {
                string comando = "SELECT * FROM tbl_usuario;";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
