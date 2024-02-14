using System;
// Polimorfismo de sobrecarga em C# refere-se à capacidade de ter métodos com o mesmo nome em uma classe, mas com diferentes listas de parâmetros.
// Isso permite que você defina várias versões de um método com o mesmo nome, mas com assinaturas diferentes (ou seja, tipos diferentes ou números diferentes de parâmetros).
// O método a ser chamado é determinado em tempo de compilação com base na lista de argumentos passados.

class Program
{
    public class Calculadora
    {
        // Método de soma com dois inteiros como parâmetros
        public int Soma(int a, int b)
        {
            return a + b;
        }

        // Método de soma com três inteiros como parâmetros
        public int Soma(int a, int b, int c)
        {
            return a + b + c;
        }

        // Método de soma com dois doubles como parâmetros
        public double Soma(double a, double b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            // Chama o método de soma com dois inteiros
            Console.WriteLine(calc.Soma(2, 3));

            // Chama o método de soma com três inteiros
            Console.WriteLine(calc.Soma(2, 3, 4));

            // Chama o método de soma com dois doubles
            Console.WriteLine(calc.Soma(2.5, 3.7));

            Console.ReadLine();
        }
    }
}
// Neste exemplo, a classe Calculadora possui três métodos chamados Soma, cada um com uma assinatura diferente (quantidade e tipos de parâmetros).
// Quando você chama o método Soma com diferentes argumentos, o compilador C# determina qual versão do método deve ser chamada com base nos tipos e
// na quantidade de argumentos passados. Isso demonstra o conceito de polimorfismo de sobrecarga.