using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using System;
using System.IO;
using System.Threading.Tasks;

public class ServicoYoutube
{
    private readonly YoutubeClient _youtubeClient;

    public ServicoYoutube()
    {
        _youtubeClient = new YoutubeClient();
    }

    // Lista 10 primeiros resultados para busca por nome da música no YouTube
    public async Task ListarMusicas(string query)
    {
        var videos = _youtubeClient.Search.GetVideosAsync(query);
        int count = 0;

        Console.WriteLine("Resultados da busca:");
        await foreach (var video in videos)
        {
            count++;
            Console.WriteLine($"{count}. {video.Title} - {video.Author} ({video.Duration})");
            if (count == 10) break;
        }

        if (count == 0)
        {
            Console.WriteLine("Nenhum vídeo correspondente encontrado no YouTube.");
        }
    }

    // Método para baixar diretamente do YouTube pelo nome ou URL
    public async Task BaixarDoYoutube(string query, double duracao = 0)
    {
        var videos = _youtubeClient.Search.GetVideosAsync(query);

        await foreach (var video in videos)
        {
            if (duracao == 0 || Math.Abs(video.Duration.Value.TotalSeconds - duracao) <= 5)
            {
                var streamManifest = await _youtubeClient.Videos.Streams.GetManifestAsync(video.Id);
                var audioStream = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                var titulo = LimparTitulo(video.Title);

                var caminho = Path.Combine(@"C:\Downloads", $"{titulo}.mp3");
                Directory.CreateDirectory(Path.GetDirectoryName(caminho));

                await _youtubeClient.Videos.Streams.DownloadAsync(audioStream, caminho);
                Console.WriteLine($"Música {video.Title} baixada com sucesso!");
                return;
            }
        }

        Console.WriteLine("Nenhum vídeo correspondente encontrado no YouTube.");
    }

    private string LimparTitulo(string titulo)
    {
        var invalidos = Path.GetInvalidFileNameChars();
        return string.Join("_", titulo.Split(invalidos, StringSplitOptions.RemoveEmptyEntries)).TrimEnd('.');
    }
}
