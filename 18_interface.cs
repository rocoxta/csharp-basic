using System;
// Em C#, uma interface é um tipo de contrato que define um conjunto de membros (métodos, propriedades, eventos ou indexadores) que uma classe ou estrutura deve implementar.
// Uma interface define o que uma classe pode fazer, mas não fornece a implementação desses membros. Em vez disso, a implementação é deixada para as classes que implementam a interface.
// As interfaces são muito úteis para alcançar a abstração e o polimorfismo em C#.
class Program
{
    interface IAnimal
    {
        void EmitSound();
    }

    // Classe que implementa a interface
    class Dog : IAnimal
    {
        public void EmitSound()
        {
            Console.WriteLine("Woof!");
        }
    }

    // Outra classe que implementa a interface
    class Cat : IAnimal
    {
        public void EmitSound()
        {
            Console.WriteLine("Meow!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IAnimal dog = new Dog();
            IAnimal cat = new Cat();

            dog.EmitSound(); // Saída: Woof!
            cat.EmitSound(); // Saída: Meow!
        }
    }

    // Neste exemplo, a interface IAnimal define um método EmitSound(). As classes Dog e Cat implementam essa interface, fornecendo sua própria implementação do método EmitSound().
    // Quando você chama o método EmitSound() em uma instância de Dog ou Cat, a implementação correspondente é executada.
    // Isso demonstra como as interfaces em C# permitem a abstração e o polimorfismo, pois você pode usar objetos de diferentes classes que implementam a mesma interface de forma intercambiável.

}