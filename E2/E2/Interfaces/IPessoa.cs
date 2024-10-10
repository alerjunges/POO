namespace E2.Interfaces
{
    public interface IPessoa
    {
        int Id { get; set; }
        string Nome { get; set; }
        string Endereco { get; set; }
        string Telefone { get; set; }

        string IdUnico();
        void ExibirInformacoes();
    }
}
