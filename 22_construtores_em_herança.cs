using System;
// Em C#, os construtores em herança são construtores que são invocados quando uma classe derivada é instanciada.
// Eles são utilizados para inicializar os membros da classe base e da classe derivada durante a criação de um objeto.
// Quando uma classe derivada é instanciada, o construtor da classe base é chamado automaticamente antes do construtor da classe derivada.
// Isso garante que os membros herdados da classe base sejam inicializados corretamente antes que a inicialização específica da classe derivada ocorra.
class Program
{
    // Classe base
    class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        // Construtor da classe base
        public Veiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
            Console.WriteLine("Construtor da classe base (Veiculo) chamado.");
        }
    }

    // Classe derivada
    class Carro : Veiculo
    {
        public int Ano { get; set; }

        // Construtor da classe derivada
        public Carro(string marca, string modelo, int ano) : base(marca, modelo)
        {
            Ano = ano;
            Console.WriteLine("Construtor da classe derivada (Carro) chamado.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando um objeto da classe derivada
            Carro meuCarro = new Carro("Toyota", "Corolla", 2020);

            // Exibindo os detalhes do carro
            Console.WriteLine($"Marca: {meuCarro.Marca}, Modelo: {meuCarro.Modelo}, Ano: {meuCarro.Ano}");
        }
    }
}

// Neste exemplo, a classe Veiculo é a classe base e a classe Carro é uma classe derivada.
// O construtor da classe Veiculo é chamado automaticamente quando um objeto da classe Carro é instanciado, devido à chamada : base(marca, modelo) no construtor da classe Carro.
// Isso garante que os membros herdados da classe base (Marca e Modelo) sejam inicializados antes que a inicialização específica da classe derivada (Ano) ocorra.