namespace MusicPlayer
{
    public class Artist
    {
        public string Genre;
        public string Name;

        public Artist()
        {
            this.Name = "Unknown Artist";
            this.Genre = "Unknown Genre";
        }

        public Artist(string name)
        {
            this.Name = name;
            this.Genre = "Unknown Genre";
        }

        public Artist(string name, string genre)
        {
            this.Name = name;
            this.Genre = genre;
        }
    }
}