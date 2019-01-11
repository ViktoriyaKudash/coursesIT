using System;
using System.Collections.Generic;

namespace MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();

            int totalDuration = 0;

            player.Add(GetSongsData(ref totalDuration, out int minDuration, out int maxDuration));

            //Console.WriteLine($"Total: {totalDuration}, min: {minDuration}, max: {maxDuration}");

            player.Play();
          
    
            player.Shuffle();
            player.Play();
            player.SortByTitle1();

            Console.ReadLine();
        }

        public static Song CreateSong()
        {
            Random random = new Random();
            var song = new Song()
            {
                Duration = random.Next(0, 300),
                Title = "Unknown",
                Album = AddAlbum(),
                Artist = AddArtist()
            };
            return song;
        }

        public static Song CreateSong(string Name)
        {
            var song = CreateSong();
            song.Title = Name;
            return song;
        }

        public static Song CreateSong(int duration, string name, Artist artist, Album album)
        {
            var song = new Song()
            {
                
                Title = name,
                Artist = artist,
                Album = album
            };
            return song;
        }

        public static Artist AddArtist(string name = "Unknown Artist")
        {
            var Artist = new Artist(name);
            return new Artist(name);
        }

        public static Album AddAlbum(string name = "Unknown Album", string year = "-")
        {
            var Album = new Album()
            {
                Name = name,
                Year = year
            };
            return Album;
        }

        public static List<Song> GetSongsData(ref int totalDuration, out int minDuration, out int maxDuration)
        {
            minDuration = 1000;
            maxDuration = 0;

            List<Artist> artist = new List<Artist>
            {
                AddArtist("Noname")
            };

            List<Album> album = new List<Album>
            {
                AddAlbum(year: "2016", name: "Sky Of full stars")
            };

            List<Song> songs = new List<Song>
            {
                CreateSong(100, "The Ladder", artist[0], album[0]),
                CreateSong(100, "Closure ", artist[0], album[0]),
                CreateSong( 100,"Never Give Up ", artist[0], album[0]),
                CreateSong(100, "Nobody", artist[0], album[0]),
               
            };

            for (int i = 0; i < songs.Count; i++)
            {
                totalDuration += songs[i].Duration;

                if (songs[i].Duration < minDuration) minDuration = songs[i].Duration;

                maxDuration = Math.Max(maxDuration, songs[i].Duration);
            }
            return songs;
        }
    }
}
