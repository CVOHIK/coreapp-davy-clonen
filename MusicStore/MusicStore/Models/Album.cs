using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        [Display(Name ="Genre")]
        public int GenreID { get; set; }
        [Display(Name = "Artist")]
        public int ArtistID { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        [Display(Name = "Album Art")]
        public string AlbumArtUrl { get; set; }

        public Genre Genre { get; set; }
        public Artist Artist { get; set; }
    }
}
