using System;
using System.Data;

namespace DAL.Models.Dto
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

        public PaulViewModel()
        {
            
        }

        public PaulViewModel(IDataRecord record)
        {
            Id = (int)record["Id"];
            FilmName = (string)record["FilmName"];
            ReleaseDate = (int)record["ReleaseDate"];
            Genre = (string)record["Genre"];
            Synopsis = (string)record["Synopsis"];
            ImdbRating = (decimal)record["ImdbRating"];
            MyRating = (decimal?)record["MyRating"];
            Watched = (bool)record["Watched"];
        }

        public PaulViewModel(IDataRecord record, string filmName)
        {
            Id = (int)record["Id"];
            FilmName = (string)record["FilmName"];
            ReleaseDate = (int) record["ReleaseDate"];
            Genre = (string) record["Genre"];
            Synopsis = (string) record["Synopsis"];
            ImdbRating = (decimal) record["ImdbRating"];
            MyRating = (decimal?) record["MyRating"];
            Watched = (bool) record["Watched"];
        }
    }
}
