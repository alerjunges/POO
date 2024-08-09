namespace E2.Classes
{
    //Classe abstrata
    public abstract class Pessoa
    {
        protected int _id;
        protected string _nome;
        protected string _endereco;
        protected string _telefone;

        //Construtor para inicializar os campos
        public Pessoa(int id, string nome, string endereco, string telefone)
        {
            _id = id;
            _nome = nome;
            _endereco = endereco;
            _telefone = telefone;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        //Métodos abstratos
        public abstract string IdUnico();
        public abstract void Andar();
        public abstract void Falar();
    }
}

