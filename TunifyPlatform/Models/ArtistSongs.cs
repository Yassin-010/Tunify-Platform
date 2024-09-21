namespace TunifyPlatform.Models
{
    public class ArtistSongs
    {
        public int SongId { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

        
        public Song Song { get; set; }

    }
}