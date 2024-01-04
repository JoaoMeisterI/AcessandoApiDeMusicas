using ScrrenSound4.Modelos;
using System.Linq;


namespace ScrrenSound4.Filtros;

internal class LinqOrder
{
    //Vamos criar mais um método estático 
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        //O orderBy ele vai ordenar a lista que está vindo de forma crescente
        //Já o Select ele vai selecionar somente o campo que você precisa, seleciona só uma parte da lista
        var artistasOrdenados = musicas.OrderBy(x =>
        x.Artista).Select(x => x.Artista).Distinct().ToList();

        Console.WriteLine("Lista de artistas ordenados");
        foreach (var artista in artistasOrdenados) 
        {
            Console.WriteLine($" - {artista}");
        
        }

    }
}
