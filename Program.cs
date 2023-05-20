using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Complexidade O(N + M)
        SolucaoUtilizandoLINQ();

        // Complexidade O(N²)
        SolucaoUtilizandoIteracoesManuais();
    }

    private static void SolucaoUtilizandoLINQ()
    {
        // Lista de dados original
        List<int> listaDados = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Lista de filtro
        List<int> listaFiltro = new List<int> { 2, 4, 6, 8, 10 };

        // Filtrar a lista de dados com base na lista de filtro
        List<int> listaFiltrada = listaDados.Intersect(listaFiltro).ToList();

        // Exibir a lista filtrada
        foreach (int item in listaFiltrada)
        {
            Console.WriteLine(item);
        }
    }

    private static void SolucaoUtilizandoIteracoesManuais()
    {
        // Lista de dados original
        List<int> listaDados = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Lista de filtro
        List<int> listaFiltro = new List<int> { 2, 4, 6, 8, 10 };

        // Lista para armazenar os elementos filtrados
        List<int> listaFiltrada = new List<int>();

        // Filtrar a lista de dados com base na lista de filtro
        foreach (int item in listaDados)
        {
            if (listaFiltro.Contains(item))
            {
                listaFiltrada.Add(item);
            }
        }

        // Exibir a lista filtrada
        foreach (int item in listaFiltrada)
        {
            Console.WriteLine(item);
        }
    }
}
