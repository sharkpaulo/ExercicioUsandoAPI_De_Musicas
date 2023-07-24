using System.Text.Json.Serialization;
using System.Text.Json;
using ScreenSound_V4.Modelos;
using ScreenSound_V4.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        var response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(response);
        LinqFilter.FiltrarMusicasPorTonalidade(musicas, "C#");
        //LinqFilter.FiltrarTodosOsGeneros(musicas);
        //LinqOrder.ordernarArtistas(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        //var musicasFavoritasPaulo = new MusicasPreferidas("Paulo");
        //musicasFavoritasPaulo.AdicionarMusica(musicas[7]);
        //musicasFavoritasPaulo.AdicionarMusica(musicas[565]);
        //musicasFavoritasPaulo.AdicionarMusica(musicas[777]);
        //musicasFavoritasPaulo.AdicionarMusica(musicas[655]);
        //musicasFavoritasPaulo.AdicionarMusica(musicas[444]);
        //musicasFavoritasPaulo.ExibirMusicasPreferidas();
        //musicas[45].ExibirDetalhesDaMusica();
        //musicasFavoritasPaulo.GerarArquivoJSON();

        Console.ReadKey();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }

}