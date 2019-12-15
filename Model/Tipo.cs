using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Tipo
    {
        private int codigo;
        private string nome;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }

        public Tipo(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
        }

    }
}
