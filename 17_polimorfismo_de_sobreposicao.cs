using System;
// O polimorfismo de sobreposição em C# refere-se à capacidade de uma classe derivada de substituir (ou sobrescrever) o comportamento de um método definido em sua classe base.
// Isso permite que você forneça uma implementação específica do método na classe derivada, que substitui a implementação herdada da classe base.
// Um exemplo simples de polimorfismo de sobreposição em C# pode ser demonstrado com classes e métodos que representam diferentes formas geométricas. Considere as seguintes classes:

class Program
{
    class Forma             // Classe base para formas geométricas
    {
        public virtual void Desenhar()
        {
            Console.WriteLine("Desenhando uma forma genérica.");
        }
    }

    // Classe derivada que representa um círculo
    class Circulo : Forma
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um círculo.");
        }
    }

    // Classe derivada que representa um quadrado
    class Quadrado : Forma
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um quadrado.");
        }
    }

    // Neste exemplo, a classe base Forma define um método virtual Desenhar().
    // As classes Circulo e Quadrado herdam da classe Forma e sobrescrevem o método Desenhar()
    // para fornecer implementações específicas para desenhar um círculo e um quadrado, respectivamente.
    // Agora, ao criar instâncias dessas classes e chamar o método Desenhar(), o método apropriado será chamado dependendo do tipo de objeto:
    class Program
    {
        static void Main(string[] args)
        {
            Forma forma = new Forma();
            Circulo circulo = new Circulo();
            Quadrado quadrado = new Quadrado();

            forma.Desenhar();   // Saída: Desenhando uma forma genérica.
            circulo.Desenhar(); // Saída: Desenhando um círculo.
            quadrado.Desenhar();// Saída: Desenhando um quadrado.
        }
    }
    // Neste exemplo, quando chamamos o método Desenhar() em cada instância, o método específico da classe derivada é chamado,
    // graças à capacidade de sobrescrever o comportamento do método na classe base. Isso é um exemplo de polimorfismo de sobreposição em C#.
}
