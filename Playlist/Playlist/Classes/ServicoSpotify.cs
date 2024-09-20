using SpotifyAPI.Web;
using System;
using System.Threading.Tasks;

public class ServicoSpotify : IBaixador
{
    private readonly SpotifyClient _spotifyClient;

    public ServicoSpotify()
    {
        var config = SpotifyClientConfig.CreateDefault();
        var request = new ClientCredentialsRequest("22762b7640344d698204df95608333bd", "98cd189d47c84ce089527369310f345d");
        var response = new OAuthClient(config).RequestToken(request).Result;
        _spotifyClient = new SpotifyClient(config.WithToken(response.AccessToken));
    }

    public async Task BaixarConteudo(string url, ServicoYoutube servicoYoutube)
    {
        if (url.Contains("playlist"))
        {
            await BaixarPlaylist(url, servicoYoutube);
        }
        else
        {
            await BaixarMusica(url, servicoYoutube);
        }
    }

    private async Task BaixarPlaylist(string url, ServicoYoutube servicoYoutube)
    {
        var playlistId = ExtrairSpotifyId(url);
        var playlist = await _spotifyClient.Playlists.Get(playlistId);

        Console.WriteLine($"Baixando playlist: {playlist.Name}");

        foreach (var item in playlist.Tracks.Items)
        {
            if (item.Track is FullTrack track)
            {
                string query = $"{track.Name} {track.Artists[0].Name}";
                double duracao = track.DurationMs / 1000.0;
                await servicoYoutube.BaixarDoYoutube(query, duracao);
            }
        }
    }

    private async Task BaixarMusica(string url, ServicoYoutube servicoYoutube)
    {
        var trackId = ExtrairSpotifyId(url);
        var track = await _spotifyClient.Tracks.Get(trackId);

        string query = $"{track.Name} {track.Artists[0].Name}";
        double duracao = track.DurationMs / 1000.0;
        await servicoYoutube.BaixarDoYoutube(query, duracao);
    }

    private string ExtrairSpotifyId(string url)
    {
        var uri = new Uri(url);
        var segments = uri.AbsolutePath.Split('/');
        return segments.Last().Split('?')[0];
    }
}
