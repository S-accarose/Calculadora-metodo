using Biblio;
class Program 
{
  public static void Main (string[] args) 
  {
    Console.Write("Digite o primeiro número: ");
    int a = int.Parse(Console.ReadLine() ?? "0");
    Thread.Sleep(1000);
    Console.Clear();
    Console.Write("Digite o segundo número: ");
    int b = int.Parse(Console.ReadLine() ?? "0");
    Thread.Sleep(1000);
    Console.Clear();
    Console.Write("Aqui estão os resultados:\n");
    Console.WriteLine($"Soma: {Calculadora.Somar(a, b)}");
    Console.WriteLine($"Subtração: {Calculadora.Subtrair(a, b)}");
    Console.WriteLine($"Multiplicação: {Calculadora.Multiplicar(a, b):F2}");
    Console.WriteLine($"Divisão: {Calculadora.Dividir(a, b):F2}");
    Console.WriteLine($"Potência: {Calculadora.Potencia(a, b):F2}");
  }
}