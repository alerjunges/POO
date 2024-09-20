using System.Threading.Tasks;

public interface IBaixador
{
    Task BaixarConteudo(string url, ServicoYoutube servicoYoutube);
}
