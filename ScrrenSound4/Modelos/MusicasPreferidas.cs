

using System.Text.Json;

namespace ScrrenSound4.Modelos;

internal class MusicasPreferidas
{
    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public string Nome { get; set; }

    public List<Musica> ListaDeMusicasFavoritas { get;}

    //Adicionando uma musica a lista

    public void AdicionaMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);

    }

    //Exibindo 

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            //Esse que é o bom de lista de objetos
            //Você consegue usar todas as propriedades do objeto
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine();
    }

    //Criando arquivo Json

    public void GerarArquivoJson()
    {
        //Serializando a lista de músicas para Json
        string json = JsonSerializer.Serialize(new
        //ISSO É UM OBJETO ANONIMO OU SEJA NÃO TEM TIPO DEFINIDO
        //Por aqui tu define a estrutura do Json
        {
            
            nome = Nome,
            musicas = ListaDeMusicasFavoritas

        });

        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

        //Criando o arquivo
        File.WriteAllText(nomeDoArquivo, json);

        Console.WriteLine($"O arquivo Json foi criado com sucesso! E está no seguinte caminho\n" +
            $"{Path.GetFullPath(nomeDoArquivo)}");
        

    }





}   
