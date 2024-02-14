using System;
// Em C#, a palavra-chave "static" é usada para declarar membros de uma classe que pertencem à própria classe,
// em vez de pertencerem a instâncias individuais dessa classe. Aqui estão alguns exemplos de como o "static" é utilizado em C#:


class Program { 
    public class Calculadora                             // Método Estático
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }
    }
    int resultado = Calculadora.Somar(5, 3);            // Uso do método estático
    //
    public class Contador                               // Campo Estático
    {
        public static int Quantidade { get; set; } = 0;
    }
    Contador.Quantidade++;                              // Uso do campo estático
    //
    public class Configuracoes                          // Propriedades Estáticas
    {
        public static string NomeDoAplicativo { get; set; } = "MeuApp";
    }
    Console.WriteLine(Configuracoes.NomeDoAplicativo);  // Uso da propriedade estática
    //
    public static class Utilitarios                     // Classe Estática
    {
        public static void Imprimir(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
    Utilitarios.Imprimir("Olá, Mundo!");                // Uso do método de uma classe estática
    //
    public static class ExtensaoString                  // Método de extensão estático
    {
        public static bool ÉNuloOuVazio(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
    }
    // Uso do método de extensão estático
    string texto = "Exemplo";
    bool resultado = texto.ÉNuloOuVazio();
}