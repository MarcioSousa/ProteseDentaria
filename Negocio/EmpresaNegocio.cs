using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
using Control;

namespace Negocio
{
    public class EmpresaNegocio
    {
        readonly Acessomdf acessomdf = new Acessomdf();

        public string Inserir(Empresa empresa)
        {
            try
            {
                acessomdf.LimparParametros();
                return acessomdf.ExecutarManipulacao(CommandType.Text, "INSERT INTO Empresa(codigo, empresanome, dentistadono, rua, numero, bairro, cidade, uf, cep, contatou, contatod) VALUES (" + empresa.Codigo + ", '" + empresa.Empresanome.Trim() + "', '" + empresa.Dentistadono.Trim() + "', '" + empresa.Rua + "', '" + empresa.Numero + "', '" + empresa.Bairro + "', '" + empresa.Cidade + "', '" + empresa.Uf + "' ,'" + empresa.Cep + "' ,'" + empresa.ContatoU + "', '" + empresa.ContatoD + "')").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(Empresa empresa, int codigoempresaantigo)
        {
            try
            {
                acessomdf.LimparParametros();

                if (empresa.Codigo == codigoempresaantigo)
                {
                    return acessomdf.ExecutarManipulacao(CommandType.Text, "UPDATE Empresa set empresanome = '" + empresa.Empresanome.Trim() + "', dentistadono = '" + empresa.Dentistadono + "', rua = '" + empresa.Rua + "', numero = '" + empresa.Numero + "', bairro = '" + empresa.Bairro + "', cidade = '" + empresa.Cidade + "', uf = '" + empresa.Uf + "', cep = '" + empresa.Cep + "',contatou = '" + empresa.ContatoU + "', contatod = '" + empresa.ContatoD + "' WHERE codigo = " + empresa.Codigo).ToString();
                }
                else
                {
                    return acessomdf.ExecutarManipulacao(CommandType.Text, "UPDATE Empresa set codigo = " + empresa.Codigo + ", empresanome = '" + empresa.Empresanome.Trim() + "', dentistadono = '" + empresa.Dentistadono + "', rua = '" + empresa.Rua + "', numero = '" + empresa.Numero + "', bairro = '" + empresa.Bairro + "', cidade = '" + empresa.Cidade + "', uf = '" + empresa.Uf + "', cep = '" + empresa.Cep + "',contatou = '" + empresa.ContatoU + "', contatod = '" + empresa.ContatoD + "' WHERE codigo = " + codigoempresaantigo).ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Excluir(int codigoempresa)
        {
            try
            {
                acessomdf.LimparParametros();
                return acessomdf.ExecutarManipulacao(CommandType.Text, "DELETE FROM Empresa WHERE codigo = " + codigoempresa).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Empresa> CarregaListaEmpresas()
        {
            try
            {
                List<Empresa> empresas = new List<Empresa>();

                acessomdf.LimparParametros();

                DataTable dataTableEmpresas = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT codigo, empresanome, dentistadono, rua, numero, bairro, cidade, uf, cep, contatou, contatod FROM Empresa ORDER BY codigo");

                foreach (DataRow linha in dataTableEmpresas.Rows) 
                {
                    Empresa empresa = new Empresa(Convert.ToInt32(linha["codigo"]), linha["empresanome"].ToString(), linha["dentistadono"].ToString(), linha["rua"].ToString(), linha["numero"].ToString(), linha["bairro"].ToString(), linha["cidade"].ToString(), linha["uf"].ToString(), linha["cep"].ToString(), linha["contatoU"].ToString(), linha["contatoD"].ToString());
                    empresas.Add(empresa);
                }

                return empresas;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Empresa> ProcurarPorCodigoOuNome(int codigo, string nome)
        {
            try
            {
                List<Empresa> empresas = new List<Empresa>();
                DataTable dataTableEmpresas = new DataTable();

                acessomdf.LimparParametros();

                if(codigo != 0)
                {
                    dataTableEmpresas = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT codigo, dentistadono, empresanome FROM Empresa WHERE codigo = " + codigo);
                }
                else
                {
                    dataTableEmpresas = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT codigo, dentistadono, empresanome FROM Empresa WHERE dentistadono like '%" + nome + "%' OR empresanome like '%" + nome + "%' ORDER BY codigo");
                }

                foreach (DataRow linha in dataTableEmpresas.Rows) 
                {
                    Empresa empresa = new Empresa(Convert.ToInt32(linha["codigo"]), linha["empresanome"].ToString(), linha["dentistadono"].ToString());
                    empresas.Add(empresa);
                }

                return empresas;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
