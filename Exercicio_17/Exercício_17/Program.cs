using System;

public class Exercicio17
{
    public static void Main(String[] args)
    {
        // Criar um Array dos filmes
        String[] nomesFilmes = {"Harry Potter", "Zorro", "Simpsons"};
        
        // Criar um Array dos anos
        int[] anosFilmes = {1999, 2010, 2014};

        Console.WriteLine("Lista de Filmes:");

        // Percorrer os arrays e exibir os filmes antes dos anos
        for (int i = 0; i < anosFilmes.Length; i++)
        {
            Console.WriteLine(nomesFilmes[i] + " - " + anosFilmes[i]); // Filme primeiro, depois o ano
        }

    }

}