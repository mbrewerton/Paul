using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Models.Dto;
using DAL.Models;
using AutoMapper;

namespace DAL.Services
{
    public class FilmService
    {
        /// <summary>
        /// Gets all films from the database.
        /// </summary>
        /// <returns></returns>
        public List<FilmDto> GetFilms()
        {
            List<FilmDto> filmsList = new List<FilmDto>();
            using (var db = new PaulContext())
            {
                var films = db.Film.ToList();
                filmsList = Mapper.Map<List<Film>, List<FilmDto>>(films);
            }

            return filmsList;
        }

        /// <summary>
        /// Gets a list of films that relate to the given search term.
        /// </summary>
        /// <param name="searchTerm">The title/description to search the database for.</param>
        /// <returns></returns>
        public List<FilmDto> Search(string searchTerm)
        {
            List<FilmDto> filmsList = new List<FilmDto>();
            using (var db = new PaulContext())
            {
                var films = db.Film
                    .Where(x => x.FilmName.ToLower().Contains(searchTerm))
                    .ToList();

                filmsList = Mapper.Map<List<Film>, List<FilmDto>>(films);
            }

            return filmsList;
        }

        public void SaveFilm(FilmDto film)
        {
            var id = film.Id;
            var newFilm = Mapper.Map<FilmDto, Film>(film);
            Film oldFilm;
            if (id == 0)
            {
                using (var db = new PaulContext())
                {
                    db.Film.Add(Mapper.Map<FilmDto, Film>(film));
                    db.SaveChanges();
                }
            }
            else
            {
                using (var db = new PaulContext())
                {
                    oldFilm = db.Film
                        .Where(x => x.Id == id).FirstOrDefault();
                }

                if (oldFilm != null)
                    oldFilm = newFilm;
                else
                    throw new NullReferenceException("Could not find the film to modify.");

                using (var db = new PaulContext())
                {
                    db.Entry(newFilm).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
    }
}
