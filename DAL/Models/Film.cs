using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Film
    {
        public int Id { get; set; }
        [Required]
        public string FilmName { get; set; }
        [Required]
        public int ReleaseDate { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Synopsis { get; set; }
        [Required]
        public decimal ImdbRating { get; set; }
        public decimal? MyRating { get; set; }
        public bool Watched { get; set; }
    }
}
