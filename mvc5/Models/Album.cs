using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace muscshop.Models
{
    public class Album
    {
        [Required(ErrorMessage = "enter the title")]
        public string Title { get; set; }
        [Range(1, 300, ErrorMessage = "enter price: 1 to 300")]
        public double Price { get; set; }
        public string AlbumUrl { get; set; }
        [Required(ErrorMessage = "ReleaseYear is required")]
        public int ReleaseYear { get; set; }
        public Artist Artist { get; set; }
        public Genre Genre { get; set; }
        public int AlbumId { get; set; }
        public string Description { get; set; } = "albumDescription";
        public int ArtistId { get; set; }
        public int GenreId { get; set; }
        public void UpdateAlb(Album newalbum)
        {
            Price = newalbum.Price;
            Title = newalbum.Title;
            GenreId = newalbum.GenreId;
            ArtistId = newalbum.ArtistId;
            ReleaseYear = newalbum.ReleaseYear;
            Description = newalbum.Description;
            AlbumUrl = newalbum.AlbumUrl;
        }
    }
}