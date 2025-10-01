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
    internal class DAOProfessor
    {
        Conexao bd = new Conexao();
        public void InserirProfessor(DTOProfessor Professor)
        {
            try
            {
                string comando = "INSERT INTO Professor (idProfessor, nome, CPF, telefone, email, endereco, dataNascimento) " +
                                                                               "VALUES (DEFAULT, '" + Professor.Nome + "','"
                                                                                                     + Professor.Cpf + "','"
                                                                                                + Professor.Telefone + "','"
                                                                                                   + Professor.Email + "','"
                                                                                                + Professor.Endereco + "','"
                                                                                          + Professor.DataNascimento + "');";

                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarProfessor(DTOProfessor Professor)
        {
            try
            {
                string comando = "UPDATE Professor SET nome = '" + Professor.Nome +
                                                 "', CPF = '" + Professor.Cpf +
                                       "', telefone = '" + Professor.Telefone +
                                             "', email = '" + Professor.Email +
                                       "', endereco = '" + Professor.Endereco +
                           "', dataNascimento = '" + Professor.DataNascimento +
                         "' WHERE idProfessor = " + Professor.IdProfessor + ";";

                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirProfessor(int id)
        {
            try
            {
                string comando = "DELETE FROM Professor WHERE idProfessor = " + id + ";";

                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarProfessor()
        {
            try
            {
                string comando = "SELECT * FROM Professor;";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
