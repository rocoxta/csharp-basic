using System;
// Em C#, encapsulamento refere-se à prática de ocultar os detalhes internos de uma classe e fornecer uma interface pública para interagir com essa classe.
// Isso é alcançado usando modificadores de acesso, como public, private, protected, internal, entre outros.

class Program
{
    // Método Público (public): Este método pode ser acessado de fora da classe.
    public class Calculadora
    {
        public int Somar(int num1, int num2)        // Método público para somar dois números
        {
            return num1 + num2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            int resultado = calc.Somar(5, 3);
            Console.WriteLine("Resultado da soma: " + resultado);
        }
    }

    // Método Privado (private): Este método só pode ser acessado dentro da própria classe "ContaBancaria".
    public class ContaBancaria
    {
        private void RegistrarTransacao(decimal valor)
        {
        }

        public void Depositar(decimal valor)
        {
            RegistrarTransacao(valor);    // Realiza o depósito
        }
    }

    // Método Protegido (protected): Este método pode ser acessado dentro da própria classe ou em classes derivadas (subclasses).
    public class Animal
    {
        protected void Respirar()
        {
            Console.WriteLine("Respirando...");
        }
    }

    public class Cachorro : Animal
    {
        public void Latir()
        {
            Console.WriteLine("Au au!");
            Respirar(); // Método protegido acessível dentro de uma classe derivada
        }
    }

    // Método Interno (internal): Este método só pode ser acessado dentro do mesmo assembly.

    // Assembly A
    internal class ClasseInterna
    {
        internal void MetodoInterno()
        {
            Console.WriteLine("Método interno chamado.");
        }
    }

    // Assembly B (outro arquivo ou projeto)
    class Program
    {
        static void Main(string[] args)
        {
            // Erro! Método interno não é acessível em outro assembly
            ClasseInterna instancia = new ClasseInterna();
            instancia.MetodoInterno();
        }
    }

    // Método Estático(static): Este método pertence à classe em vez de uma instância específica e pode ser acessado diretamente pela classe.
    public class Utilidades
    {
        public static double ConverterParaCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double tempFahrenheit = 80;
            double tempCelsius = Utilidades.ConverterParaCelsius(tempFahrenheit);
            Console.WriteLine("Temperatura em Celsius: " + tempCelsius);
        }
    }
}