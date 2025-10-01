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
    internal class DAOEnderecos
    {
        Conexao bd = new Conexao();
        public void InserirEndereco(DTOEnderecos Endereco)
        {
            try
            {
                string comando = "INSERT INTO Endereco (idEndereco, logradouro, numero, complemento, bairro, CEP, cidade, estado) " +
                                                                                   "VALUES (DEFAULT, '" + Endereco.Logradouro + "','"
                                                                                                            + Endereco.Numero + "','"
                                                                                                       + Endereco.Complemento + "','"
                                                                                                            + Endereco.Bairro + "','"
                                                                                                               + Endereco.Cep + "','"
                                                                                                            + Endereco.Cidade + "','"
                                                                                                            + Endereco.Estado + "');";

                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarEndereco(DTOEnderecos Endereco)
        {
            try
            {
                string comando = "UPDATE Endereco SET logradouro = '" + Endereco.Logradouro +
                                                          "', numero = '" + Endereco.Numero +
                                                "', complemento = '" + Endereco.Complemento +
                                                          "', bairro = '" + Endereco.Bairro +
                                                                "', CEP = '" + Endereco.Cep +
                                                          "', cidade = '" + Endereco.Cidade +
                                                          "', estado = '" + Endereco.Estado +
                                          "' WHERE idEndereco = " + Endereco.IdEndereco + ";";

                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirEndereco(int id)
        {
            try
            {
                string comando = "DELETE FROM Endereco WHERE idEndereco = " + id + ";";

                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarEndereco()
        {
            try
            {
                string comando = "SELECT * FROM Endereco;";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
