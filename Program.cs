
using E1;

// cria um objeto Estudante 
Estudante estudante = new Estudante("Ana", 20, "Rua das Acácias, 123", "99999-9999", "Engenharia");

// cria um objeto Professor 
Professor professor = new Professor("Carlos", 45, "Avenida Central, 456", "98888-8888", "Matemática");

// exibe as informaçoes do Estudante e executa seus métodos
Console.WriteLine("Informações do Estudante:");
Console.WriteLine(estudante.ColetarInformacoes());
estudante.Estudar();

//exibe as informaçoes do Professor e executa seus métodos
Console.WriteLine("\nInformações do Professor:");
Console.WriteLine(professor.ColetarInformacoes());
professor.Ensinar();
