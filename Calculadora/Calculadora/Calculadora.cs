using System;

namespace Calculadora;

public class calcular
{
    public static double calculos (double numero1, double numero2, char operacao)
    {
        switch (operacao)
        {
            case '+':
                return Soma (numero1,numero2);
                
            case '-':
                return subtrair (numero1,numero2);
               
            case '*': 
                return multiplicar (numero1,numero2);
            case '/':
                return divisao (numero1,numero2);
               
            case '^':
                return potencias(numero1, numero2);
           
            case 'a':
                return raiz(numero1);
           
             default: throw new ArgumentException("Operação inválida! Use +, -, *, /,√ ou ^. ");
        }
    }

    public static double Soma (double numero1, double numero2)
    {
        double resultado = numero1 + numero2;
        return resultado;
        Console.WriteLine(resultado);
    }
    public static double subtrair(double numero1, double numero2)
    {
        double resultado = numero1 - numero2;
        return resultado;
    }
    public static double multiplicar(double numero1, double numero2)
    {
        double resultado = numero1 * numero2;
        return resultado;
    }
    public static double raiz(double numero1)
    {
        return Math.Sqrt(numero1);
        Console.WriteLine(numero1);
    }
    public static double potencias(double numero1, double numero2)
    {
        return Math.Pow(numero1, numero2);
    }
    public static double divisao(double numero1, double numero2) 
    {
        double resultado = numero2 / numero1;
        return resultado;
    }

}
