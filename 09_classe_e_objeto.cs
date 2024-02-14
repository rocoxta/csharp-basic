using System;
// Uma classe é um modelo ou plano para criar objetos.
// Ela define as propriedades e comportamentos que os objetos criados a partir dela terão.
// Em C#, as classes são definidas usando a palavra-chave class.
public class Carro
{
    // Propriedades
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }

    // Método construtor
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
// Um objeto é uma instância de uma classe.
// Ou seja, é uma entidade real que pode ser criada com base no modelo definido pela classe.
// Você pode criar quantos objetos quiser a partir de uma única classe.
class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto Carro
        Carro meuCarro = new Carro("Toyota", "Corolla", 2022);

        // Chamando método para exibir informações do carro
        meuCarro.ExibirInformacoes();

        // Criando outro objeto Carro
        Carro outroCarro = new Carro("Ford", "Focus", 2020);

        // Chamando método para exibir informações do outro carro
        outroCarro.ExibirInformacoes();
    }
}
