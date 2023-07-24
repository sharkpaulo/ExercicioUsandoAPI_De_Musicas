using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScreenSound_V4.Modelos
{
    internal class Musica
    {
        private string[] Tonalidades = {"C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
        [JsonPropertyName("song")]
        public string Nome { get; set; }
        [JsonPropertyName("artist")]
        public string Artista { get; set; }
        [JsonPropertyName("duracion_ms")]
        public int Duracao { get; set; }
        [JsonPropertyName("genre")]
        public string? Genero { get; set; }
        [JsonPropertyName("key")]
        public int Key { get; set; }

        public string Tonalidade { get
            {
                return Tonalidades[Key];
            } 
        }


        public void ExibirDetalhesDaMusica()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Música: {Nome}");
            Console.WriteLine($"Duração em segundos: {Duracao/1000}");
            Console.WriteLine($"Genero Musical: {Genero}");
            Console.WriteLine($"Tonalidade: {Tonalidade}");
        }
    }
}
