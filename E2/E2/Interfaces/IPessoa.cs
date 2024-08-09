using System;

namespace E2.Interfaces
{
    // Interface IPessoa que define um contrato para classes que representam pessoas
    public interface IPessoa
    {
        int Id { get; set; }
        string Nome { get; set; }
        string Endereco { get; set; }
        string Telefone { get; set; }

        string IdUnico();
        void Andar();
        void Falar();
        void ExibirInformacoes();
    }
}
