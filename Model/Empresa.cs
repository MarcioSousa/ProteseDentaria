namespace Model
{
    public class Empresa
    {
        private int codigo;
        private string empresanome;
        private string dentistadono;
        private string rua;
        private string numero;
        private string bairro;
        private string cidade;
        private string uf;
        private string cep;
        private string contatoU;
        private string contatoD;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Empresanome { get => empresanome; set => empresanome = value; }
        public string Dentistadono { get => dentistadono; set => dentistadono = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Cep { get => cep; set => cep = value; }
        public string ContatoU { get => contatoU; set => contatoU = value; }
        public string ContatoD { get => contatoD; set => contatoD = value; }

        public Empresa(int codigo, string empresanome, string dentistadono, string rua, string numero, string bairro, string cidade, string uf, string cep, string contatoU, string contatoD)
        {
            this.codigo = codigo;
            this.empresanome = empresanome;
            this.dentistadono = dentistadono;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.uf = uf;
            this.cep = cep;
            this.contatoU = contatoU;
            this.contatoD = contatoD;
        }

        public Empresa(int codigo, string empresanome, string dentistadono)
        {
            this.codigo = codigo;
            this.empresanome = empresanome;
            this.dentistadono = dentistadono;
        }

        public Empresa(int codigo)
        {
            Codigo = codigo;
        }

        public Empresa()
        {

        }


    }
}