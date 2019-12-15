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
    public class ProdutoNegocio
    {
        readonly Acessomdf acessomdf = new Acessomdf();

        public string Inserir(Produto produto)
        {
            try
            {
                acessomdf.LimparParametros();
                return acessomdf.ExecutarManipulacao(CommandType.Text, "INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES (" + produto.Codigo + ", '" + produto.Nome + "', " + produto.Valor.ToString().Replace(",",".") + ", " + produto.Codigotipo + ")").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(Produto produto, int? codigoprodutoantigo)
        {
            try
            {
                acessomdf.LimparParametros();

                if (produto.Codigo == codigoprodutoantigo)
                {
                   
                    return acessomdf.ExecutarManipulacao(CommandType.Text, "UPDATE Produto set nome = '" + produto.Nome + "', valor = " + produto.Valor.ToString().Replace(",",".") + ", codigotipo = " + produto.Codigotipo + " WHERE codigo = " + produto.Codigo).ToString();
                }
                else
                {
                    return acessomdf.ExecutarManipulacao(CommandType.Text, "UPDATE Produto set codigo = " + produto.Codigo + ", nome = '" + produto.Nome + "', valor = " + produto.Valor.ToString().Replace(",", ".") + ", codigotipo = " + produto.Codigotipo + " WHERE codigo = " + codigoprodutoantigo).ToString();
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Excluir(int codigoproduto)
        {
            try
            {
                acessomdf.LimparParametros();
                return acessomdf.ExecutarManipulacao(CommandType.Text, "DELETE FROM Produto WHERE codigo = " + codigoproduto).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Produto> ProdutosOrdenadoCodigo()
        {
            try
            {
                List<Produto> produtos = new List<Produto>();

                acessomdf.LimparParametros();

                DataTable dataTableProdutos = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT P.codigo, P.nome, P.valor, T.codigo AS codigotipo, T.nome AS nometipo FROM Produto P INNER JOIN Tipo T ON P.codigotipo = T.codigo ORDER BY P.codigo");

                foreach (DataRow linha in dataTableProdutos.Rows)
                {
                    Produto produto = new Produto(Convert.ToInt32(linha["codigo"]), linha["nome"].ToString(), Convert.ToDouble(linha["valor"]), Convert.ToInt32(linha["codigotipo"]), linha["nometipo"].ToString());
                    produtos.Add(produto);
                }

                return produtos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Produto> ProcurarPorCodigoOuNome(int codigo, string nome)
        {
            try
            {
                List<Produto> produtos = new List<Produto>();
                DataTable dataTableProdutos = new DataTable();

                acessomdf.LimparParametros();

                if (codigo != 0)
                {
                    dataTableProdutos = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT P.codigo, P.nome, P.valor, T.codigo AS codigotipo, T.nome AS nometipo FROM Produto P INNER JOIN Tipo T ON P.codigotipo = T.codigo WHERE P.codigo = " + codigo + " ORDER BY P.codigo");
                }
                else
                {
                    dataTableProdutos = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT P.codigo, P.nome, P.valor, T.codigo AS codigotipo, T.nome AS nometipo FROM Produto P INNER JOIN Tipo T ON P.codigotipo = T.codigo WHERE P.nome like '%" + nome + "%' ORDER BY P.codigo");
                }

                foreach (DataRow linha in dataTableProdutos.Rows)
                {
                    Produto produto = new Produto(Convert.ToInt32(linha["codigo"]), linha["nome"].ToString(), Convert.ToDouble(linha["valor"]), Convert.ToInt32(linha["codigotipo"]), linha["nometipo"].ToString());
                    produtos.Add(produto);
                }

                return produtos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public double ProcurarPorCodigo(int codigo)
        {
            try
            {
                double valor = 0;
                DataTable dataTableProdutos = new DataTable();

                acessomdf.LimparParametros();

                dataTableProdutos = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT valor FROM Produto WHERE codigo = " + codigo);

                foreach (DataRow linha in dataTableProdutos.Rows)
                {
                    valor = Convert.ToDouble(linha["valor"]);
                    break;
                }

                return valor;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int QtdeProdutos()
        {
            try
            {
                int qtdeProduto = 0;

                DataTable dataTableQtdeProduto = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT COUNT(codigo) AS qtde FROM Produto");

                foreach (DataRow linha in dataTableQtdeProduto.Rows)
                {
                    qtdeProduto = Convert.ToInt32(linha["qtde"]);
                }

                return qtdeProduto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}