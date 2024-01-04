

using System.Text.Json.Serialization;

namespace ScrrenSound4.Modelos;

//Quando a gente recebe a API a gente usa tudo mesmo
//Seleciona só o que for usar

//Vamos usar artista duração e gênero
internal class Musica
{

        private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
        [JsonPropertyName("song")]
        public string? Nome { get; set; }
        [JsonPropertyName("artist")]
        public string? Artista { get; set; }
        [JsonPropertyName("duration_ms")]
        public int? Duracao { get; set; }
        [JsonPropertyName("genre")]
        public string? Genero { get; set; }
        [JsonPropertyName("year")]
        public string? Ano { get; set; }
        [JsonPropertyName("key")]
        public int Chave { get; set; }
           
        //Vai buscar na lista tonalidades com base na chave
        public string Tonalidade
        {
            get
            {
                return tonalidades[Chave];
            }

        }





    public void ExibirDetalheDaMusica()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Música: {Nome}");
            Console.WriteLine($"Gênero musical: {Genero}");
            Console.WriteLine($"Duração: {Duracao / 1000}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Ano: {Tonalidade}");

    }



        

        
}
