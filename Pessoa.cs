using System;

namespace E1
{
    // classe Pessoa
    public class Pessoa
    {
        // atributos
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }

        // construtor
        public Pessoa(string nome, int idade, string endereco, string telefone)
        {
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
            Telefone = telefone;
        }

        // coleta informações da Pessoa

        public virtual string ColetarInformacoes()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Endereço: {Endereco}, Telefone: {Telefone}";
        }
    }

    // subclasse Estudante 
    public class Estudante : Pessoa
    {
        // atributo específico
        public string Curso { get; private set; }

        // construtor
        public Estudante(string nome, int idade, string endereco, string telefone, string curso)
            : base(nome, idade, endereco, telefone)
        {
            Curso = curso;
        }

        // coleta as informações do Estudante
        public override string ColetarInformacoes()
        {
            return base.ColetarInformacoes() + $", Curso: {Curso}";
        }

        // vai por o nome e curso do Estudante
        public void Estudar()
        {
            Console.WriteLine($"{Nome} está estudando para o curso de {Curso}.");
        }
    }

    // subclasse Professor
    public class Professor : Pessoa
    {
        // atributo específico
        public string Disciplina { get; private set; }

        // construtor
        public Professor(string nome, int idade, string endereco, string telefone, string disciplina)
            : base(nome, idade, endereco, telefone)
        {
            Disciplina = disciplina;
        }

        // coleta as informações do Professor
        public override string ColetarInformacoes()
        {
            return base.ColetarInformacoes() + $", Disciplina: {Disciplina}";
        }

        // vai por o nome e a disciplina do Professor
        public void Ensinar()
        {
            Console.WriteLine($"Professor {Nome} está ensinando a disciplina de {Disciplina}.");
        }
    }
}

