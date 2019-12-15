using Control;
using Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace Negocio
{
    public class PedidoNegocio
    {
        readonly Acessomdf acessomdf = new Acessomdf();

        public string Inserir(Pedido pedido)
        {
            try
            {
                acessomdf.LimparParametros();
                return acessomdf.ExecutarManipulacao(CommandType.Text, "INSERT INTO Pedido(codigo, codigoempresa, dentista) VALUES (" + pedido.Codigo + "," + pedido.Codigoempresa + ", '" + pedido.Dentista + "')").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(Pedido pedido, int codigopedidoantigo)
        {
            try
            {
                acessomdf.LimparParametros();

                if (pedido.Codigo == codigopedidoantigo)
                {
                    return acessomdf.ExecutarManipulacao(CommandType.Text, "UPDATE Pedido SET codigoempresa = " + pedido.Codigoempresa + ", dentista = '" + pedido.Dentista + "', datafechamento = " + pedido.Datafechamento + " WHERE codigo = " + pedido.Codigo).ToString();
                }
                else
                {
                    return acessomdf.ExecutarManipulacao(CommandType.Text, "UPDATE Pedido SET codigo = " + pedido.Codigo + ", codigoempresa = " + pedido.Codigoempresa + ", dentista = '" + pedido.Dentista + "', datafechamento = " + pedido.Datafechamento + " WHERE codigo = " + codigopedidoantigo).ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AlterarCodigo(Pedido pedido, int codigopedidonovo)
        {
            try
            {
                acessomdf.LimparParametros();
                return acessomdf.ExecutarManipulacao(CommandType.Text, "UPDATE Pedido SET codigo = " + codigopedidonovo + " WHERE codigo = " + pedido.Codigo).ToString();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Excluir(int codigopedido)
        {
            try
            {
                acessomdf.LimparParametros();
                return acessomdf.ExecutarManipulacao(CommandType.Text, "DELETE FROM Pedido WHERE codigo = " + codigopedido).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string CancelarSaida(int codigopedido)
        {
            try
            {
                acessomdf.LimparParametros();
                acessomdf.ExecutarManipulacao(CommandType.Text, "UPDATE Pedido SET datasaida = null WHERE codigo = " + codigopedido);
                return "Data Saída cancelado com Sucesso!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string RegistrarFechamento(int codigopedido, DateTime datafechamento)
        {
            try
            {
                acessomdf.LimparParametros();
                acessomdf.ExecutarManipulacao(CommandType.Text, "UPDATE Pedido SET datafechamento = '" + datafechamento.ToString("yyyy-MM-dd") + "' WHERE codigo = " + codigopedido);
                return "Data de Fechamento registrado com Sucesso!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ApagarDataFechamento(int codigopedido)
        {
            try
            {
                acessomdf.LimparParametros();
                acessomdf.ExecutarManipulacao(CommandType.Text, "UPDATE Pedido SET datafechamento = NULL WHERE codigo = " + codigopedido);
                return "Data de Fechamento apagado com Sucesso!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool VerificarCodigo(int codigo)
        {
            try
            {
                DataTable datatablePedidos = new DataTable();

                acessomdf.LimparParametros();

                datatablePedidos = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT COUNT(codigo) AS qtde FROM Pedido WHERE codigo = " + codigo);

                if (Convert.ToInt32(datatablePedidos.Rows[0]["qtde"].ToString()) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pedido> Pedidos(int mes, int ano, bool entrega)
        {
            try
            {
                List<Pedido> pedidos = new List<Pedido>();
                DataTable dataTablePedidos = new DataTable();

                acessomdf.LimparParametros();
                if (mes != 0 && ano != 0)
                {
                    dataTablePedidos = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT P.codigo, P.dataentrada, P.datasaida, P.paciente, P.dentista FROM Pedido P WHERE MONTH(dataentrada) = " + mes + " AND YEAR(dataentrada) = " + ano + " ORDER BY dataentrada ASC");
                }
                else if (mes == 0 && ano == 0)
                {
                    dataTablePedidos = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT P.codigo, P.dataentrada, P.datasaida, P.paciente, P.dentista FROM Pedido P ORDER BY dataentrada DESC");
                }
                else if (mes != 0 && ano == 0)
                {
                    dataTablePedidos = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT P.codigo, P.dataentrada, P.datasaida, P.paciente, P.dentista FROM Pedido P WHERE MONTH(dataentrada) = " + mes + " ORDER BY dataentrada DESC");
                }
                else
                {
                    dataTablePedidos = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT P.codigo, P.dataentrada, P.datasaida, P.paciente, P.dentista, P.datasaida FROM Pedido P WHERE YEAR(dataentrada) = " + ano + " ORDER BY dataentrada DESC");
                }

                foreach (DataRow linha in dataTablePedidos.Rows)
                {
                    if (linha["datasaida"].ToString() == "")
                    {
                        //Pedido pedido = new Pedido(Convert.ToInt32(linha["codigo"]), 0, linha["dentista"].ToString(), linha["paciente"].ToString(), Convert.ToDateTime(linha["dataentrada"]), null, "");
                        //pedidos.Add(pedido);
                    }
                    else
                    {
                        //Pedido pedido = new Pedido(Convert.ToInt32(linha["codigo"]), 0, linha["dentista"].ToString(), linha["paciente"].ToString(), Convert.ToDateTime(linha["dataentrada"]), Convert.ToDateTime(linha?["datasaida"]), "");
                        //pedidos.Add(pedido);
                    }

                }

                return pedidos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pedido> Pedidos(int mes, int ano)
        {
            try
            {
                List<Pedido> pedidos = new List<Pedido>();
                DataTable dataTablePedidos = new DataTable();

                acessomdf.LimparParametros();
                if (mes != 0 && ano != 0)
                {
                    dataTablePedidos = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT P.codigo, P.dataentrada, P.paciente, P.dentista FROM Pedido P WHERE MONTH(dataentrada) = " + mes + " AND YEAR(dataentrada) = " + ano + " ORDER BY dataentrada ASC");
                }
                else if (mes == 0 && ano == 0)
                {
                    dataTablePedidos = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT P.codigo, P.dataentrada, P.paciente, P.dentista FROM Pedido P ORDER BY dataentrada DESC");
                }
                else if (mes != 0 && ano == 0)
                {
                    dataTablePedidos = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT P.codigo, P.dataentrada, P.paciente, P.dentista FROM Pedido P WHERE MONTH(dataentrada) = " + mes + " ORDER BY dataentrada DESC");
                }
                else
                {
                    dataTablePedidos = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT P.codigo, P.dataentrada, P.paciente, P.dentista, P.datasaida FROM Pedido P WHERE YEAR(dataentrada) = " + ano + " ORDER BY dataentrada DESC");
                }

                foreach (DataRow linha in dataTablePedidos.Rows)
                {

                    //Pedido pedido = new Pedido(Convert.ToInt32(linha["codigo"]), linha["dentista"].ToString(), linha["paciente"].ToString(), Convert.ToDateTime(linha["dataentrada"]), "");
                    //pedidos.Add(pedido);
                }

                return pedidos;
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
                double somaPedido = 0;

                DataTable soma = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT SUM(qtde* valorunid) As Total FROM ItemPedido WHERE codigopedido = " + codigopedido);

                if(soma.Rows[0]["Total"].ToString() != "")
                {
                    somaPedido = Convert.ToDouble(soma.Rows[0]["Total"]);
                }
               

                return somaPedido;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pedido> AnosRegistrados()
        {
            List<Pedido> datasAnos = new List<Pedido>();

            acessomdf.LimparParametros();

            DataTable dataTablePedidos = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT distinct(datepart(year, dataentrada)) AS anos FROM Pedido");


            foreach (DataRow linha in dataTablePedidos.Rows)
            {
                Pedido pedido = new Pedido(Convert.ToInt32(linha["anos"]));
                datasAnos.Add(pedido);
            }

            return datasAnos;
        }

        public List<Pedido> PedidosDeterminadaEmpresa(int codigoempresa)
        {
            List<Pedido> pedidos = new List<Pedido>();

            acessomdf.LimparParametros();

            pedidos = CarregaValoresNulos(codigoempresa);

            DataTable dataTablePedidosEmpresa= acessomdf.ExecutarConsulta(CommandType.Text, "SELECT codigo, codigoempresa, dentista, datafechamento FROM Pedido WHERE datafechamento IS NOT NULL AND codigoempresa = " + codigoempresa + " ORDER BY datafechamento DESC");

            foreach (DataRow linha in dataTablePedidosEmpresa.Rows)
            {
                Pedido pedido = new Pedido(Convert.ToInt32(linha["codigo"]), Convert.ToInt32(linha["codigoempresa"]), linha["dentista"].ToString(), Convert.ToDateTime(linha["datafechamento"]));
                pedidos.Add(pedido);
            }

            return pedidos;
        }

        private List<Pedido> CarregaValoresNulos(int codigoempresa)
        {
            List<Pedido> pedidos = new List<Pedido>();

            acessomdf.LimparParametros();

            DataTable dataTablePedidosEmpresa = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT codigo, codigoempresa, dentista, datafechamento FROM Pedido WHERE datafechamento IS NULL AND codigoempresa = " + codigoempresa);

            foreach (DataRow linha in dataTablePedidosEmpresa.Rows)
            {
                Pedido pedido = new Pedido(Convert.ToInt32(linha["codigo"]), Convert.ToInt32(linha["codigoempresa"]), linha["dentista"].ToString(), null);
                pedidos.Add(pedido);
            }

            return pedidos;
        }

        public Pedido PesquisaPedido(int codigopedido)
        {
            Pedido pedido = new Pedido();

            acessomdf.LimparParametros();

            DataTable dataTablePedidos = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT codigo, dentista, datafechamento FROM Pedido WHERE codigo =  " + codigopedido);

            if (dataTablePedidos.Rows.Count != 0)
            {
                pedido.Codigo = Convert.ToInt32(dataTablePedidos.Rows[0]["codigo"]);
                pedido.Dentista = dataTablePedidos.Rows[0]["dentista"].ToString();

                if (dataTablePedidos.Rows[0]["datafechamento"].ToString() != "")
                {
                    pedido.Datafechamento = Convert.ToDateTime(dataTablePedidos.Rows[0]["datafechamento"]);
                }
                
            }

            return pedido;
        }
    }
}

//public Pedido OrdemServicoPedido(int codigopedido)
//{
//    try
//    {
//        acessomdf.LimparParametros();

//        Pedido pedido = new Pedido();

//        DataTable dataTableEmpresa = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT P.dentista, P.paciente, P.dataentrada, E.nome FROM Pedido P INNER JOIN Empresa E ON P.codigoempresa = E.codigo WHERE P.codigo = " + codigopedido);

//        if (dataTableEmpresa.Rows.Count != 0)
//        {
//            pedido = new Pedido(dataTableEmpresa.Rows[0]["dentista"].ToString(), dataTableEmpresa.Rows[0]["paciente"].ToString(), Convert.ToDateTime(dataTableEmpresa.Rows[0]["dataentrada"].ToString()), dataTableEmpresa.Rows[0]["nome"].ToString());
//        }

//        return pedido;

//    }
//    catch (Exception ex)
//    {
//        throw new Exception(ex.Message);
//    }
//}