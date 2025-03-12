using System;

public class Exercicio1
{
    public static void Main()
    {
        // Solicita que insira dois números inteiros
        Console.Write("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        int soma = num1 + num2;
        int subtracao = num1 - num2;
        int multiplicacao = num1 * num2;
        int divisao = num1 / num2;
        int resto = num1 % num2;

        Console.WriteLine("\nResultados:");
        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Subtração: {subtracao}");
        Console.WriteLine($"Multiplicação: {multiplicacao}");
        Console.WriteLine($"Divisão: {divisao}");
        Console.WriteLine($"Resto da divisão: {resto}");
    }
}
