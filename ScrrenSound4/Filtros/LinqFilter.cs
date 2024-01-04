//Vamos usar esse system
using ScrrenSound4.Modelos;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ScrrenSound4.Filtros;

internal class LinqFilter
{

    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos =>
        generos.Genero).Distinct().ToList();


        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }
    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero) 
    {
        //Puxa as músicas que a string gênero for igual a propriedade Genero da lista
        //E seleciona os artistas que passarem nessa condição 
        //pega a lista música aonde o genero é igual ao genero solicitado
        // E seleciona os artistas desse gênero 
        var artistarPorGeneroMusical = musicas.Where(x => x.Genero.Contains(genero)).Select(x => x.Artista).Distinct().ToList();

        Console.WriteLine($"Segue os artistas filtrados por gênero musical ({genero})");
        foreach (var artista in artistarPorGeneroMusical)
        {
            Console.WriteLine($"{artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string artista)
    {
        //Não é nulo e é igual ao parametro colocado 
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).Select(musica => musica.Nome).ToList();

        Console.WriteLine($"Músicas do artista {artista}");
        foreach(var musica in  musicasDoArtista)
        {
            Console.WriteLine($"- {musica}");
        }

    }
    public static void FiltrarMusicasPorAno(List<Musica> musicas, string ano)
    {
        //Não é nulo e é igual ao parametro colocado 
        var musicasDoArtista = musicas.Where(musica => musica.Ano!.Equals(ano)).Select(musica => musica.Nome).ToList();

        Console.WriteLine($"Músicas do ano de {ano}");
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica}");
        }

    }

    public static void FiltrarMusicasC(List<Musica> musicas)
    {
        //Não é nulo e é igual ao parametro colocado 
        var musicasDoArtista = musicas.Where(musica => musica.Tonalidade.Equals("C#")).Select(musica => musica.Nome).ToList();

        Console.WriteLine("Segue as musicas que tem tonalidade C#");
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica}");
        }

    }



}
