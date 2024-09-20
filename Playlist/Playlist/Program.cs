using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var servicoYoutube = new ServicoYoutube();
        var servicoSpotify = new ServicoSpotify();

        while (true)
        {
            Console.WriteLine("Digite o nome de uma música, a URL (Spotify/YouTube), ou 'sair' para fechar:");
            string entrada = Console.ReadLine();

            if (entrada.Equals("sair", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            if (entrada.Contains("spotify.com"))
            {
                await servicoSpotify.BaixarConteudo(entrada, servicoYoutube);
            }
            else if (entrada.Contains("youtube.com") || entrada.Contains("youtu.be"))
            {
                await servicoYoutube.BaixarDoYoutube(entrada);
            }
            else
            {
                await servicoYoutube.ListarMusicas(entrada);

                Console.Write("Digite o número da música que deseja baixar: ");
                if (int.TryParse(Console.ReadLine(), out int escolha) && escolha >= 1 && escolha <= 10)
                {
                    await servicoYoutube.BaixarDoYoutube(entrada);
                }
                else
                {
                    Console.WriteLine("Escolha inválida.");
                }
            }
        }
    }
}
