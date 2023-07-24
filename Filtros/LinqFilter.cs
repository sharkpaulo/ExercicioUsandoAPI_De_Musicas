using ScreenSound_V4.Modelos;

namespace ScreenSound_V4.Filtros
{
    internal class LinqFilter
    {
        public static void FiltrarTodosOsGeneros(List<Musica> musicas)
        {
            var TodosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
            foreach (var genero in TodosOsGenerosMusicais)
            {
                Console.WriteLine($"- {genero}");
            }
        }

        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var artistasPorGenero = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
            foreach (var artista in artistasPorGenero)
            {
                Console.WriteLine($"- {artista}");
            }
        }

        public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string NomeDoArtista)
        {
            var musicasDoArtista = musicas.Where(musica => musica.Artista.Equals(NomeDoArtista)).ToList();
            foreach (var musica in musicasDoArtista)
            {
                Console.WriteLine($"- {musica.Nome}");
            }
        }

        internal static void FiltrarMusicasPorTonalidade(List<Musica> musicas, string tonalidade)
        {
            var musicasFiltradas = musicas.Where(musica => musica.Tonalidade.Equals(tonalidade)).Select(musica => musica.Nome).ToList();
            foreach (var musica in musicasFiltradas)
            {
                Console.WriteLine($"- {musica}");
            }            
        }
    }
}
