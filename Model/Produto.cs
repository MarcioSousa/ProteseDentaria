using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Produto
    {
        private int codigo;
        private string nome;
        private double valor;
        private int codigotipo;
        private string nometipo;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Valor { get => valor; set => valor = value; }
        public int Codigotipo { get => codigotipo; set => codigotipo = value; }
        public string Nometipo { get => nometipo; set => nometipo = value; }

        public Produto(int codigo, string nome, double valor, int codigotipo)
        {
            Codigo = codigo;
            Nome = nome;
            Valor = valor;
            Codigotipo = codigotipo;
        }

        public Produto(int codigo, string nome, double valor, int codigotipo, string nometipo)
        {
            Codigo = codigo;
            Nome = nome;
            Valor = valor;
            Codigotipo = codigotipo;
            Nometipo = nometipo;
        }

        public Produto(double valor)
        {
            Valor = valor;
        }
    }
}
