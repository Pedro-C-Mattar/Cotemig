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
    internal class DAOColaborador
    {
        Conexao bd = new Conexao();
        public void InserirColaborador(DTOColaborador Colaborador)
        {
            try
            {
                string comando = "INSERT INTO Colaborador (idColaborador, nome, CPF, telefone, salario, email, endereco, dataNascimento, cargo) " +
                                                                                        "VALUES (DEFAULT, '" + Colaborador.Nome + "','"
                                                                                                              + Colaborador.Cpf + "','"
                                                                                                         + Colaborador.Telefone + "','"
                                                                                                          + Colaborador.Salario + "','"
                                                                                                            + Colaborador.Email + "','"
                                                                                                         + Colaborador.Endereco + "','"
                                                                                                   + Colaborador.DataNascimento + "','"
                                                                                                            + Colaborador.Cargo + "');";

                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarColaborador(DTOColaborador Colaborador)
        {
            try
            {
                string comando = "UPDATE Colaborador SET nome = '" + Colaborador.Nome +
                                                       "', CPF = '" + Colaborador.Cpf +
                                             "', telefone = '" + Colaborador.Telefone +
                                               "', salario = '" + Colaborador.Salario +
                                                   "', email = '" + Colaborador.Email +
                                             "', endereco = '" + Colaborador.Endereco +
                                 "', dataNascimento = '" + Colaborador.DataNascimento +
                                                   "', cargo = '" + Colaborador.Cargo +
                           "' WHERE idColaborador = " + Colaborador.IdColaborador + ";";

                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirColaborador(int id)
        {
            try
            {
                string comando = "DELETE FROM Colaborador WHERE idColaborador = " + id + ";";

                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarColaborador()
        {
            try
            {
                string comando = "SELECT * FROM Colaborador;";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
