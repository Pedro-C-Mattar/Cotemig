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
    internal class DAOAlunos
    {
        Conexao bd = new Conexao();
        public void InserirAluno(DTOAlunos Aluno)
        {
            try
            {
                string comando = "INSERT INTO Aluno (idAluno, nome, CPF, telefone, email, endereco, dataNascimento) " +
                                                                               "VALUES (DEFAULT, '" + Aluno.Nome + "','" 
                                                                                                     + Aluno.Cpf + "','" 
                                                                                                + Aluno.Telefone + "','" 
                                                                                                   + Aluno.Email + "','" 
                                                                                                + Aluno.Endereco + "','" 
                                                                                          + Aluno.DataNascimento + "');";

                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarAluno(DTOAlunos Aluno)
        {
            try
            {
                string comando = "UPDATE Aluno SET nome = '" + Aluno.Nome +
                                                 "', CPF = '" + Aluno.Cpf +
                                       "', telefone = '" + Aluno.Telefone +
                                             "', email = '" + Aluno.Email +
                                       "', endereco = '" + Aluno.Endereco +
                           "', dataNascimento = '" + Aluno.DataNascimento +
                                "' WHERE idAluno = " + Aluno.IdAluno + ";";

                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirAluno(int id)
        {
            try
            {
                string comando = "DELETE FROM Aluno WHERE idAluno = " + id + ";";

                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarAluno()
        {
            try
            {
                string comando = "SELECT * FROM Aluno;";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
