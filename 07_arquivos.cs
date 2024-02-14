using System;
using System.IO;

class Program
{
    static void Main()
    {
        // 1- Criar um arquivo: Para criar um arquivo em C#, você pode usar a classe FileStream, que representa um fluxo de arquivo.
        FileStream fs = File.Create("caminho/arquivo.txt");
        // 2- Ou usando métodos estáticos da classe File
        File.Create("caminho/arquivo.txt");

        // Escrever em um arquivo: Depois de criar um arquivo, você pode escrever dados nele usando classes como StreamWriter.
        using (StreamWriter sw = new StreamWriter("caminho/arquivo.txt"))
        {
            sw.WriteLine("Teste 123");
        }

        // Ler de um arquivo: Para ler dados de um arquivo, você pode usar a classe StreamReader.
        using (StreamReader sr = new StreamReader("caminho/arquivo.txt"))
        {
            string conteudo = sr.ReadToEnd();
            Console.WriteLine(conteudo);
        }

        // Modificar um arquivo: Para modificar um arquivo, você precisa primeiro lê-lo, fazer as modificações necessárias e depois escrever os dados de volta no arquivo.
        string caminhoMod = "caminho/arquivo.txt";
        // Ler:
        string conteudoMod;
        using (StreamReader sr = new StreamReader(caminhoMod))
        {
            conteudoMod = sr.ReadToEnd();
        }
        // Modificar:
        conteudoMod += "\nNova linha";
        // Escrevendo o conteúdo modificado de volta no arquivo:
        using (StreamWriter sw = new StreamWriter(caminhoMod))
        {
            sw.Write(conteudoMod);
        }

        // Excluindo o arquivo: Para excluir um arquivo, você pode usar o método File.Delete().
        string caminhoExcluir = "caminho/arquivo.txt";
        File.Delete(caminhoExcluir);
    }
}
