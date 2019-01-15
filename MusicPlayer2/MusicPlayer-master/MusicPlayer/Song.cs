using System;

namespace MusicPlayer
{
    public class Song :IComparable
    {
        public int Duration;
        public string Title;
        public string Name;
        public Artist Artist;
        public Album Album;

        public int CompareTo(object obj)
        {
            if (this.Name == null)
                return 0;
            var songToCompare = (obj as Song);
            return this.Name.CompareTo(songToCompare);

          // return this.Name?.CompareTo((obj as Song)?.Name) ?? 0;
            
        }
        public void SortByTitle()
        {

            Song.Sort();
            var LocalList = new List<string>();

            foreach (var item in Song)
            {
                LocalList.Add(item.Title);
            }

            LocalList.Sort();

            var NewSongs = new List<Song>();

            foreach (var item in LocalList)
            {
                foreach (var item2 in Songs)
                {
                    if (item == item2.Title)
                        NewSongs.Add(item2);
                }
            }
            Songs = NewSongs;
        }
    }
}