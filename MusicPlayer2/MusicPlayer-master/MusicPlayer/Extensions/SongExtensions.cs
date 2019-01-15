using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Extensions
{
    static class SongExtensions
    {
        static public List<Song> Shuffle(this List<Song> songs)
        {
            Random random = new Random();
            for (int i = 0; i < songs.Count - 1; i++)
            {
                var song = songs[random.Next(songs.Count - 1)];
                songs.Remove(song);
                songs.Add(song);
                //Song temp = Songs[0];
                //Songs.RemoveAt(0);
                //Songs.Insert(random.Next(Songs.Count + 1), temp);
            }
            return songs;
        }

    }
}

