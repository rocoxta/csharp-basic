using System;
// Em C#, um construtor é um método especial de uma classe que é executado automaticamente quando um objeto dessa classe é criado.
// Ele é usado para inicializar os campos da classe ou realizar outras operações necessárias para preparar o objeto para uso. Aqui está um exemplo simples de uma classe em C# com um construtor:
// Neste exemplo, a classe Carro possui um construtor que aceita três parâmetros: marca, modelo e ano.
// Quando um objeto Carro é criado usando este construtor, os valores passados são utilizados para inicializar os campos correspondentes da classe.
// Em seguida, o método ExibirInformacoes() é chamado para exibir as informações do carro.
class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }

    // Construtor da classe Carro
    public Carro(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }

    // Método para exibir informações do carro
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto Carro usando o construtor
        Carro meuCarro = new Carro("Toyota", "Corolla", 2022);

        // Chamando o método para exibir informações do carro
        meuCarro.ExibirInformacoes();
    }
}
