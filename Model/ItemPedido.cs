using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ItemPedido
    {
        private int? codigo;
        private int codigoproduto;
        private int codigopedido;
        private double valorUnid;
        private int qtde;
        private string paciente;
        private DateTime? dataentrega;
        private double total;
        private string nomeProduto;

        public int? Codigo { get => codigo; set => codigo = value; }
        public int Codigoproduto { get => codigoproduto; set => codigoproduto = value; }
        public int Codigopedido { get => codigopedido; set => codigopedido = value; }
        public double ValorUnid { get => valorUnid; set => valorUnid = value; }
        public int Qtde { get => qtde; set => qtde = value; }
        public string Paciente { get => paciente; set => paciente = value; }
        public DateTime? Dataentrega { get => dataentrega; set => dataentrega = value; }
        public double Total { get => total; set => total = value; }
        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }

        public ItemPedido(int? codigo, int codigoproduto, int codigopedido, double valorUnid, int qtde, string paciente)
        {
            this.codigo = codigo;
            this.codigoproduto = codigoproduto;
            this.codigopedido = codigopedido;
            this.valorUnid = valorUnid;
            this.qtde = qtde;
            this.paciente = paciente;
        }

        public ItemPedido(int? codigo, int codigoproduto, int codigopedido, double valorUnid, int qtde, string paciente, DateTime? dataentrega)
        {
            this.codigo = codigo;
            this.codigoproduto = codigoproduto;
            this.codigopedido = codigopedido;
            this.valorUnid = valorUnid;
            this.qtde = qtde;
            this.paciente = paciente;
            this.dataentrega = dataentrega;
        }

        public ItemPedido(int? codigo, int codigoproduto, int codigopedido, double valorUnid, int qtde, string paciente, DateTime? dataentrega, double total, string nomeProduto)
        {
            this.codigo = codigo;
            this.codigoproduto = codigoproduto;
            this.codigopedido = codigopedido;
            this.valorUnid = valorUnid;
            this.qtde = qtde;
            this.paciente = paciente;
            this.dataentrega = dataentrega;
            this.total = total;
            this.nomeProduto = nomeProduto;
        }

    }
}
