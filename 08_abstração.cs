using System;
// Em C#, abstração refere-se ao conceito de representar apenas os aspectos relevantes de um objeto e ocultar os detalhes de implementação desnecessários para os usuários.
// Exemplo de abstração com classes e métodos
public abstract class Veiculo
{
    public abstract void Mover(); // Método abstrato
}

// Um exemplo comum de abstração em C# é o uso de classes e métodos. Por exemplo, considere uma classe Veículo:
// Aqui, Veiculo é uma classe abstrata que define um método abstrato Mover().
// Esta classe abstrata pode ser estendida por outras classes concretas, como Carro e Aviao, que devem implementar o método Mover() de acordo com o comportamento específico de cada veículo.
// Neste exemplo, Veiculo fornece uma abstração para todos os tipos de veículos, enquanto Carro e Aviao implementam o comportamento específico de mover-se de acordo com seu tipo.
public class Carro : Veiculo
{
    public override void Mover()
    {
        Console.WriteLine("O carro está se movendo na estrada.");
    }
}

public class Aviao : Veiculo
{
    public override void Mover()
    {
        Console.WriteLine("O avião está voando no céu.");
    }
}

// Exemplo de abstração com interfaces
public interface IAnimal
{
    void EmitirSom();
}

public class Cachorro : IAnimal
{
    public void EmitirSom()
    {
        Console.WriteLine("O cachorro está latindo.");
    }
}

public class Gato : IAnimal
{
    public void EmitirSom()
    {
        Console.WriteLine("O gato está miando.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Exemplo de uso de abstração com classes e métodos
        Veiculo carro = new Carro();
        Veiculo aviao = new Aviao();

        carro.Mover();
        aviao.Mover();

        // Exemplo de uso de abstração com interfaces
        IAnimal cachorro = new Cachorro();
        IAnimal gato = new Gato();

        cachorro.EmitirSom();
        gato.EmitirSom();
    }
}
