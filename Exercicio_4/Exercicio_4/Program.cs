using System;

public class Exercicio4
{
    public static void Main()
    {
        // Solicita a idade
        Console.Write("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        // Solicita o estado civil
        Console.Write("Digite seu estado civil (solteiro/casado): ");
        string estadoCivil = Console.ReadLine();

        // Classificação com base na idade e estado civil
        if (idade < 18)
        {
            Console.WriteLine("És menor de idade.");
        }
        else if (idade >= 18 && idade < 65)
        {
            if (estadoCivil == "solteiro")
            {
                Console.WriteLine("És adulto e solteiro.");
            }
            else if (estadoCivil == "casado")
            {
                Console.WriteLine("És adulto e casado.");
            }
            else
            {
                Console.WriteLine("Estado civil inválido.");
            }
        }
        else
        {
            Console.WriteLine("És sénior.");
        }
    }
}
