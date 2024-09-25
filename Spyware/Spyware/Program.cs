using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

public class Program
{
    // Importando função da API do Windows para obter o título da janela ativa 
    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern int GetForegroundWindow();

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern int GetWindowText(int hWnd, System.Text.StringBuilder text, int count);

    public static void Main()
    {
        string logFilePath = "window_log.txt";
        string lastWindowTitle = string.Empty;

        Console.WriteLine("Monitoramento de janelas ativas iniciado. Pressione Ctrl+C para encerrar.");

        while (true)
        {
            // Obtém o título da janela ativa
            string currentWindowTitle = GetActiveWindowTitle();

            // Verifica se o título da janela mudou
            if (currentWindowTitle != lastWindowTitle)
            {
                lastWindowTitle = currentWindowTitle;
                string logEntry = $"Janela ativa: {currentWindowTitle} em {DateTime.Now}\n";

                // Grava o título da nova janela ativa no log
                File.AppendAllText(logFilePath, logEntry);
                Console.WriteLine(logEntry);
            }

            // Espera 1 segundo antes de verificar novamente
            Thread.Sleep(1000);
        }
    }

    // Função para obter o título da janela ativa
    private static string GetActiveWindowTitle()
    {
        const int nChars = 256;
        //Cria um buffer que vai armazenar o título da janela.
        System.Text.StringBuilder Buff = new System.Text.StringBuilder(nChars);
        int handle = GetForegroundWindow();

        if (GetWindowText(handle, Buff, nChars) > 0)
        {
            return Buff.ToString();
        }

        return null;
    }
}
