using ScreenSound_V4.Modelos;


namespace ScreenSound_V4.Filtros
{
    internal class LinqOrder
    {
        public static void ordernarArtistas(List<Musica> musicas)
        {
            var artistasOrdenados =  musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
            foreach (var artista in artistasOrdenados)
            {
                Console.WriteLine($"- {artista}");
            }
        }
    }
}
