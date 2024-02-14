using System;
// Polimorfismo na herança em C# refere-se à capacidade de um objeto se comportar de maneira diferente com base no tipo de objeto que o está referenciando.
// Isso significa que, ao trabalhar com herança, é possível substituir o comportamento de um método em uma classe derivada, mantendo a mesma assinatura de método.
// Um exemplo simples de polimorfismo na herança em C# pode ser dado com uma hierarquia de classes envolvendo animais.
// Vamos criar uma classe base Animal e duas classes derivadas Cachorro e Gato. Cada uma dessas classes terá um método EmitirSom(), mas elas o implementarão de maneira diferente.
class Program
{
    class Animal
    {
        public virtual void EmitirSom()
        {
            Console.WriteLine("Animal fazendo algum som...");
        }
    }

    class Cachorro : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("O cachorro late: Au Au!");
        }
    }

    class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("O gato mia: Miau!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Cachorro();
            Animal animal2 = new Gato();

            animal1.EmitirSom(); // Saída: O cachorro late: Au Au!
            animal2.EmitirSom(); // Saída: O gato mia: Miau!
        }
    }
}
// Neste exemplo, a classe base Animal possui um método virtual EmitirSom(), que é substituído nas classes derivadas Cachorro e Gato.
// Quando você chama o método EmitirSom() em uma variável do tipo Animal, o comportamento específico da classe derivada é executado,
// dependendo do tipo real do objeto ao qual a variável se refere. Isso é polimorfismo na herança em ação.