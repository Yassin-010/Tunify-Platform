﻿namespace TunifyPlatform.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
        public TimeSpan Duration { get; set; }
        public ICollection<PlaylistSongs> PlaylistSongs { get; set; }
        public ICollection<ArtistSongs> ArtistSongs { get; set; }
    }
}