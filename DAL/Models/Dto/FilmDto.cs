using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Dto
{
    public class FilmDto
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
