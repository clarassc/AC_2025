using System;

public class Exercicio3
{
    public static void Main()
    {
        // Solicita a idade
        Console.Write("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        // Solicita se é estudante
        Console.Write("És estudante? (sim/não): ");
        string resposta = Console.ReadLine();

        // Converte a resposta para booleano
        bool isEstudante = (resposta == "sim");

        // Verifica se é estudante adulto
        if (idade >= 18 && isEstudante)
        {
            Console.WriteLine("É um estudante adulto.");
        }
        else
        {
            Console.WriteLine("Não é um estudante adulto.");
        }
    }
}
