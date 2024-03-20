
using ScreenSoud_04.Modelos;

namespace ScreenSoud_04.Filtros
{
    internal class LinqFilter
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica>musicas) 
        {
            var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
            foreach (var genero in todosOsGenerosMusicais)
            {
                Console.WriteLine($"-{genero}");
            }
        }

        public static void FiltrarArtistasPorGenerosMusical(List<Musica>musicas,string genero)
        {
            var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
            Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
            foreach (var artista in artistasPorGeneroMusical)
            {
                Console.WriteLine($"- {artista}");
            }
        }

        public static void FiltrarMusicasDeUmArtista(List<Musica>musicas, string nomeDoArtista)
        {
            var musicaDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
            Console.WriteLine(nomeDoArtista);
            foreach (var musica in musicaDoArtista) 
            {
                Console.WriteLine($"- {musica.Nome}");
            }

        }

        public static void FiltrarMusicasPeloAno(List<Musica>musicas, int ano) 
        {
            var musicasDoAno = musicas.Where(musica => musica.Ano == ano).OrderBy(musicas => musicas.Nome).Select(musicas => musicas.Nome).Distinct().ToList();
            Console.WriteLine($"Músicas de {ano}");
            foreach ( var musica in musicasDoAno)
            {
                Console.WriteLine($"- {musica}");
            }
        }

        internal static void FiltrarMusicasEmCSharp(List<Musica>musicas)
        {
            var musicasEmCSharp = musicas.Where(musicas => musicas.Tonalidade.Equals("C#")).Select(musica => musica.Nome).ToList();

            Console.WriteLine("Músicas em C#");
            foreach (var musica in musicasEmCSharp) 
            {
                Console.WriteLine($"- {musica}");
            }
        }
    }
}
