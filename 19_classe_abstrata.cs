using System;
// Em C#, uma classe abstrata é uma classe que não pode ser instanciada diretamente.
// Ela é projetada para ser uma classe base para outras classes derivadas, e frequentemente contém métodos abstratos,
// ou seja, métodos que não têm uma implementação definida na classe abstrata e devem ser implementados pelas classes derivadas.
// Uma classe abstrata pode também conter implementações de métodos regulares (não abstratos), propriedades, campos e outros membros.
class condicionais
{
    public abstract class Animal
    {
        public string Nome { get; set; }

        // Método abstrato que deve ser implementado por classes derivadas
        public abstract void EmitirSom();
    }

    // Classe derivada de Animal
    public class Cachorro : Animal
    {
        // Implementação do método abstrato EmitirSom
        public override void EmitirSom()
        {
            Console.WriteLine("O cachorro late.");
        }
    }

    // Classe derivada de Animal
    public class Gato : Animal
    {
        // Implementação do método abstrato EmitirSom
        public override void EmitirSom()
        {
            Console.WriteLine("O gato mia.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal cachorro = new Cachorro();
            cachorro.Nome = "Rex";
            cachorro.EmitirSom(); // Saída: O cachorro late.

            Animal gato = new Gato();
            gato.Nome = "Garfield";
            gato.EmitirSom(); // Saída: O gato mia.
        }
    }
    // Neste exemplo, Animal é uma classe abstrata que define um membro Nome e um método abstrato EmitirSom().
    // As classes Cachorro e Gato são derivadas da classe Animal e implementam o método abstrato EmitirSom() de acordo com o som que cada animal faz.
}