using ScrrenSound4.Filtros;
using ScrrenSound4.Modelos;
using System.Text.Json;


using (HttpClient client = new HttpClient())
{
     
    
    //USANDO LINQ

    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        //Console.WriteLine(resposta);

        
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarMusicasC(musicas);
       
        //Criando a instancia da classe de música favorita

        //var minhaPlaylist = new MusicasPreferidas("João - Playlist");

        //minhaPlaylist.AdicionaMusicasFavoritas(musicas[781]);
        //minhaPlaylist.AdicionaMusicasFavoritas(musicas[199]);
        //minhaPlaylist.AdicionaMusicasFavoritas(musicas[123]);
        //minhaPlaylist.AdicionaMusicasFavoritas(musicas[1129]);
        //minhaPlaylist.AdicionaMusicasFavoritas(musicas[1276]);
       
        //minhaPlaylist.ExibirMusicasFavoritas();


         //var minhaPlaylist2 = new MusicasPreferidas("João - Playlist - boladona");

         // minhaPlaylist2.AdicionaMusicasFavoritas(musicas[11]);
         // minhaPlaylist2.AdicionaMusicasFavoritas(musicas[99]);
         // minhaPlaylist2.AdicionaMusicasFavoritas(musicas[23]);
         // minhaPlaylist2.AdicionaMusicasFavoritas(musicas[129]);
         // minhaPlaylist2.AdicionaMusicasFavoritas(musicas[216]);

         // minhaPlaylist2.ExibirMusicasFavoritas();


         // minhaPlaylist2.GerarArquivoJson();




    }
    catch (Exception e)
    {
        Console.WriteLine($"Temos um problema: {e.Message} ");
    }

   


}