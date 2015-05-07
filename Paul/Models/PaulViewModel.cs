using System;
using System.Data;

namespace Paul.Models
{
    public class PaulViewModel
    {
        public int Id { get; set; }
        public string FilmName { get; set; }
        public int ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Synopsis { get; set; }
        public decimal ImdbRating { get; set; }
        public decimal? MyRating { get; set; }
        public bool Watched { get; set; }
    }
}
