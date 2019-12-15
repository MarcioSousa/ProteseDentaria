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
    public class ItemPedidoNegocio
    {
        readonly Acessomdf acessomdf = new Acessomdf();

        public string Inserir(ItemPedido itemPedido)
        {
            try
            {
                acessomdf.LimparParametros();

                if (itemPedido.Dataentrega is null)
                {
                    return acessomdf.ExecutarManipulacao(CommandType.Text, "INSERT INTO ItemPedido(codigoproduto, codigopedido, valorunid, qtde, paciente) VALUES (" + itemPedido.Codigoproduto + ", " + itemPedido.Codigopedido + ", " + itemPedido.ValorUnid.ToString().Replace(",", ".") + "," + itemPedido.Qtde + ", '" + itemPedido.Paciente + "')").ToString();
                }
                else
                {
                    return acessomdf.ExecutarManipulacao(CommandType.Text, "INSERT INTO ItemPedido(codigoproduto, codigopedido, valorunid, qtde, paciente, dataentrega) VALUES (" + itemPedido.Codigoproduto + ", " + itemPedido.Codigopedido + ", " + itemPedido.ValorUnid.ToString().Replace(",", ".") + "," + itemPedido.Qtde + ", '" + itemPedido.Paciente + "', '" + (itemPedido.Dataentrega.Value).ToString("yyyy-MM-dd") + "')").ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(ItemPedido itemPedido)
        {
            try
            {
                acessomdf.LimparParametros();

                if (itemPedido.Dataentrega != null)
                {
                    return acessomdf.ExecutarManipulacao(CommandType.Text, "UPDATE ItemPedido SET codigoproduto = " + itemPedido.Codigoproduto + ", codigopedido = " + itemPedido.Codigopedido + ", valorunid = " + itemPedido.ValorUnid + ", qtde = " + itemPedido.Qtde + ", paciente = '" + itemPedido.Paciente + "', dataentrega = '" + (itemPedido.Dataentrega.Value).ToString("yyyy-MM-dd") + "' WHERE codigo = " + itemPedido.Codigo).ToString();
                }
                else
                {
                    return acessomdf.ExecutarManipulacao(CommandType.Text, "UPDATE ItemPedido SET codigoproduto = " + itemPedido.Codigoproduto + ", codigopedido = " + itemPedido.Codigopedido + ", valorunid = " + itemPedido.ValorUnid + ", qtde = " + itemPedido.Qtde + ", paciente = '" + itemPedido.Paciente + "', dataentrega = null WHERE codigo = " + itemPedido.Codigo).ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AlterarCodigoPedido(int codigopedidonovo, int codigopedidoantigo)
        {
            try
            {
                acessomdf.LimparParametros();
                return acessomdf.ExecutarManipulacao(CommandType.Text, "UPDATE ItemPedido SET codigopedido = " + codigopedidonovo + " WHERE codigo = " + codigopedidoantigo).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Excluir(int codigoitempedido)
        {
            try
            {
                acessomdf.LimparParametros();
                return acessomdf.ExecutarManipulacao(CommandType.Text, "DELETE FROM ItemPedido WHERE codigo = " + codigoitempedido).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ExcluirPedido(int codigopedido)
        {
            try
            {
                acessomdf.LimparParametros();
                return acessomdf.ExecutarManipulacao(CommandType.Text, "DELETE FROM ItemPedido WHERE codigopedido = " + codigopedido).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<ItemPedido> ItemPedidos(int codigopedido)
        {
            try
            {
                List<ItemPedido> itemPedidos = new List<ItemPedido>();

                acessomdf.LimparParametros();

                DataTable dataTableItemPedidos = new DataTable();

                dataTableItemPedidos = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT I.codigo, I.codigoproduto, P.nome, I.paciente, I.valorunid, I.qtde, (I.valorunid * I.qtde) AS total, I.dataentrega FROM ItemPedido I INNER JOIN Produto P ON P.codigo = I.codigoproduto WHERE codigopedido = " + codigopedido);

                foreach (DataRow linha in dataTableItemPedidos.Rows)
                {
                    if (linha["dataentrega"].ToString() == "")
                    {
                        ItemPedido itemPedido = new ItemPedido(Convert.ToInt32(linha["codigo"]), Convert.ToInt32(linha["codigoproduto"]), codigopedido, Convert.ToDouble(linha["valorunid"]), Convert.ToInt32(linha["qtde"]), linha["paciente"].ToString(), null, Convert.ToDouble(linha["total"]), linha["nome"].ToString());
                        itemPedidos.Add(itemPedido);
                    }
                    else
                    {
                        ItemPedido itemPedido = new ItemPedido(Convert.ToInt32(linha["codigo"]), Convert.ToInt32(linha["codigoproduto"]), codigopedido, Convert.ToDouble(linha["valorunid"]), Convert.ToInt32(linha["qtde"]), linha["paciente"].ToString(), Convert.ToDateTime(linha["dataentrega"]), Convert.ToDouble(linha["total"]), linha["nome"].ToString());
                        itemPedidos.Add(itemPedido);
                    }
                }

                return itemPedidos;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ItemPedido> CarregarGridImpressao(int codigopedido)
        {
            try
            {
                List<ItemPedido> itemPedidos = new List<ItemPedido>();

                acessomdf.LimparParametros();

                DataTable dataTableItemPedidos = new DataTable();

                dataTableItemPedidos = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT I.qtde, P.nome, I.paciente, I.dataentrega, I.valorunid, (I.qtde * I.valorunid) AS total  FROM ItemPedido I INNER JOIN Produto P ON I.codigoproduto = P.codigo INNER JOIN Pedido E ON I.codigopedido = E.codigo WHERE I.codigopedido = " + codigopedido);

                foreach (DataRow linha in dataTableItemPedidos.Rows)
                {
                    if (linha["dataentrega"].ToString() == "")
                    {
                        ItemPedido itemPedido = new ItemPedido(0, 0, 0, Convert.ToDouble(linha["valorunid"]), Convert.ToInt32(linha["qtde"]), linha["paciente"].ToString(), null, Convert.ToDouble(linha["total"]), linha["nome"].ToString());
                        itemPedidos.Add(itemPedido);
                    }
                    else
                    {
                        ItemPedido itemPedido = new ItemPedido(0, 0, 0, Convert.ToDouble(linha["valorunid"]), Convert.ToInt32(linha["qtde"]), linha["paciente"].ToString(), Convert.ToDateTime(linha["dataentrega"]), Convert.ToDouble(linha["total"]), linha["nome"].ToString());
                        itemPedidos.Add(itemPedido);
                    }
                }

                return itemPedidos;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public double SomaPedido(int codigopedido)
        {
            try
            {
                double valortotal = 0;

                DataTable dataTableItemPedidosSoma = new DataTable();

                acessomdf.LimparParametros();

                dataTableItemPedidosSoma = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT SUM(qtde * valorunid) AS total FROM ItemPedido WHERE codigopedido = " + codigopedido);

                if(dataTableItemPedidosSoma.Rows[0]["total"].ToString() != "")
                {
                    valortotal = Convert.ToDouble(dataTableItemPedidosSoma.Rows[0]["total"]);
                }
                return valortotal;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
