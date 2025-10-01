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
    internal class DAODisciplinas
    {
        Conexao bd = new Conexao();
        public void InserirDisciplina(DTODisciplinas Disciplina)
        {
            try
            {
                string comando = "INSERT INTO Disciplina (idDisciplina, nome, diaSemana, turno, cargaHoraria, horario) " +
                                                                            "VALUES (DEFAULT, '" + Disciplina.Nome + "','"
                                                                                          + Disciplina.DiaDaSemana + "','"
                                                                                                + Disciplina.Turno + "','"
                                                                                         + Disciplina.CargaHoraria + "','"
                                                                                              + Disciplina.Horario + "');";

                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarDisciplina(DTODisciplinas Disciplina)
        {
            try
            {
                string comando = "UPDATE Disciplina SET nome = '" + Disciplina.Nome +
                                        "', diaSemana = '" + Disciplina.DiaDaSemana +
                                                  "', turno = '" + Disciplina.Turno +
                                    "', cargaHoraria = '" + Disciplina.CargaHoraria +
                                              "', horario = '" + Disciplina.Horario +
                            "' WHERE idDisciplina = " + Disciplina.IdDisciplina + ";";

                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirDisciplina(int id)
        {
            try
            {
                string comando = "DELETE FROM Disciplina WHERE idDisciplina = " + id + ";";

                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarDisciplina()
        {
            try
            {
                string comando = "SELECT * FROM Disciplina;";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
