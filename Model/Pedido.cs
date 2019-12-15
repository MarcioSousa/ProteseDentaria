using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pedido
    {
        private int codigo;
        private int codigoempresa;
        private string dentista;
        private DateTime? datafechamento;

        public int Codigo { get => codigo; set => codigo = value; }
        public int Codigoempresa { get => codigoempresa; set => codigoempresa = value; }
        public string Dentista { get => dentista; set => dentista = value; }
        public DateTime? Datafechamento { get => datafechamento; set => datafechamento = value; }

        public Pedido(int codigo, int codigoempresa, string dentista, DateTime? datafechamento)
        {
            this.codigo = codigo;
            this.codigoempresa = codigoempresa;
            this.dentista = dentista;
            this.datafechamento = datafechamento;
        }

        public Pedido(int codigo)
        {
            this.codigo = codigo;
        }

        public Pedido()
        {

        }
    }
}
