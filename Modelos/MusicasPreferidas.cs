using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScreenSound_V4.Modelos
{
    internal class MusicasPreferidas
    {
        public string Nome { get; set; }

        public List<Musica> ListaMusicasPreferidas {  get; }

        public MusicasPreferidas(string nome)
        {
            Nome = nome;
            ListaMusicasPreferidas = new List<Musica>();
        }

        public void AdicionarMusica(Musica musica)
        {
            ListaMusicasPreferidas.Add(musica);
        }

        public void ExibirMusicasPreferidas()
        {
            Console.WriteLine($"Essas são as Musicas preferidas -> {Nome}");
            foreach (var musica in ListaMusicasPreferidas)
            {
                Console.WriteLine($"{musica.Nome} de {musica.Artista}");
            }
            Console.WriteLine();
        }

        public void GerarArquivoJSON()
        {
            string json = JsonSerializer.Serialize(new 
            {
                nome = Nome,
                musicas = ListaMusicasPreferidas
            });
            string nomeArquivo = $"musicas-favoritas-{Nome}";
            File.WriteAllText(nomeArquivo, json);
            Console.WriteLine($"O arquivo Json foi criado com sucesso -> {Path.GetFullPath(nomeArquivo)}");
        }
    }
}
