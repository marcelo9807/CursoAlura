using Calculadora;
using System;

class Program
{
    static void Main()
    {
      

        Console.Write("Digite o primeiro número: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double numero2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a operação (+, -, *, /): ");
        char operacao = Console.ReadLine()[0];

        double resultado = calcular.calculos(numero1, numero2, operacao);

        Console.WriteLine($"Resultado: {numero1} {operacao} {numero2} = {resultado}");
    }
}
