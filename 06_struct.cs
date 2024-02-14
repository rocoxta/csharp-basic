using System;
// Em C#, uma struct (abreviação de "structure") é um tipo de dados que pode conter membros de dados e membros de função (métodos), como uma classe, mas é tipicamente usada para representar tipos de dados leves que não exigem herança. As structs são tipos de valor, o que significa que são armazenadas na pilha e copiadas por valor quando passadas para métodos ou atribuídas a outras variáveis. Aqui está um exemplo simples de declaração de struct em C#:
// Definindo uma struct para representar coordenadas 2D
// Neste exemplo, Coordenada2D é uma struct que contém dois membros de dados X e Y, representando as coordenadas em um plano 2D. Ele também possui um construtor personalizado para inicializar as coordenadas e um método ImprimirCoordenadas() para imprimir as coordenadas na saída.
public struct Coordenada2D
{
    public int X;
    public int Y;

    // Construtor para inicializar coordenadas
    public Coordenada2D(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Método para imprimir as coordenadas
    public void ImprimirCoordenadas()
    {
        Console.WriteLine($"Coordenadas: ({X}, {Y})");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando uma instância da struct Coordenada2D
        Coordenada2D ponto = new Coordenada2D(10, 20);

        // Acessando os membros da struct e chamando o método
        Console.WriteLine($"Coordenada X: {ponto.X}");
        Console.WriteLine($"Coordenada Y: {ponto.Y}");
        ponto.ImprimirCoordenadas();
    }
}
