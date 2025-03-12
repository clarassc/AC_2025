using System;

public class Program
{
    public static void Main()
    {
        // Pede o raio
        Console.Write("Digite o raio da circunferência: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        // Calcula a área (π * raio²)
        double area = Math.PI * (raio * raio);

        // Resultado
        Console.WriteLine("O valor da área de raio " + raio + " é " + Math.Round(area, 0) + "m2");
    }
}
