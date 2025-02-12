using System;

public class Exercicio18
{
    public static void Main(String[] args)
    {
        // Criar um Array dos nomes da Cidade
        String[] nomesCidades = { "Lisboa", "Porto", "Coimbra", "Faro", "Braga" };

        // Criar um Array dos habitantes da Cidade
        int[] habitantesCidades = { 545000, 237000, 143000, 118000, 193000 };

        Console.WriteLine("Cidades e as suas populações:");

        // Percorrer os arrays e exibir os nomes + número de habitantes + "habitantes"
        for (int i = 0; i < habitantesCidades.Length; i++)
        {
            Console.WriteLine(nomesCidades[i] + " - " + habitantesCidades[i] + " habitantes ");
        }

    }

}