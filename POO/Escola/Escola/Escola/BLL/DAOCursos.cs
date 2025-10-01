using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.DTO;
using Escola.DAL;
using System.Data;

namespace Escola.BLL
{
    internal class DAOCursos
    {
        Conexao bd = new Conexao();
        public void InserirCurso(DTOCursos Curso)
        {
            try
            {
                string comando = "INSERT INTO Curso (idCurso, nome, turno, periodo, cargaHoraria) " +
                                                            "VALUES (DEFAULT, '" + Curso.Nome + "','"
                                                                                + Curso.Turno + "','"
                                                                              + Curso.Periodo + "','"
                                                                         + Curso.CargaHoraria + "');";

                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarCurso(DTOCursos Curso)
        {
            try
            {
                string comando = "UPDATE Curso SET nome = '" + Curso.Nome +
                                             "', turno = '" + Curso.Turno +
                                         "', periodo = '" + Curso.Periodo +
                               "', cargaHoraria = '" + Curso.CargaHoraria +
                                "' WHERE idCurso = " + Curso.IdCurso + ";";

                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirCurso(int id)
        {
            try
            {
                string comando = "DELETE FROM Curso WHERE idCurso = " + id + ";";

                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarCurso()
        {
            try
            {
                string comando = "SELECT * FROM Curso;";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
