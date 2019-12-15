using Control;
using Model;
using System;
using System.Collections.Generic;
using System.Data;


namespace Negocio
{
    public class TipoNegocio
    {
        readonly Acessomdf acessomdf = new Acessomdf();

        public string Inserir(Tipo tipo)
        {
            try
            {
                acessomdf.LimparParametros();
                return acessomdf.ExecutarManipulacao(CommandType.Text, "INSERT INTO Tipo(nome) VALUES('" + tipo.Nome + "')").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(Tipo tipo)
        {
            try
            {
                acessomdf.LimparParametros();
                return acessomdf.ExecutarManipulacao(CommandType.Text, "UPDATE Tipo SET nome = '" + tipo.Nome + "' WHERE codigo = " + tipo.Codigo).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Excluir(int codigotipo)
        {
            try
            {
                acessomdf.LimparParametros();
                return acessomdf.ExecutarManipulacao(CommandType.Text, "DELETE FROM Tipo WHERE codigo = " + codigotipo).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Tipo> CarregaListaTipo()
        {
            try
            {
                List<Tipo> tipos = new List<Tipo>();

                acessomdf.LimparParametros();

                DataTable dataTableTipos = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT codigo, nome FROM Tipo ORDER BY codigo");

                foreach (DataRow linha in dataTableTipos.Rows)
                {
                    Tipo tipo = new Tipo(Convert.ToInt32(linha["codigo"]), linha["nome"].ToString());
                    tipos.Add(tipo);
                }

                return tipos;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
