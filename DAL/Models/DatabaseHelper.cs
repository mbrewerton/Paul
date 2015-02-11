﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using DAL.Models.SQL;

namespace DAL.Models
{
    public class DatabaseHelper
    {
        public List<Film> GetAllFilms()
        {
            List<Film> films;
            using (var db = new PaulContext())
            {
                films = db.Film.ToList();
            }
            return films;
        }

        public void AddToDatabase(string filmName, string genre, decimal rating, int releaseDate, string synopsis)
        {
            using (var db = new PaulContext())
            {
                var film = new Film()
                {
                    FilmName = filmName,
                    Genre = genre,
                    MyRating = rating,
                    ReleaseDate = releaseDate,
                    Synopsis = synopsis
                };
                if (film.MyRating > 10 || film.MyRating < 0)
                {
                    throw new Exception("Rating must be between 0 and 10.");
                }
                db.Film.Add(film);
                db.SaveChanges();
                db.Dispose();
            }
        }

        public void AddImdbInfo(string filmName, string genre, decimal imdbRating, int releaseDate, string synopsis)
        {
            using (var db = new PaulContext())
            {
                var film = new Film()
                {
                    FilmName = filmName,
                    Genre = genre,
                    ImdbRating = imdbRating,
                    ReleaseDate = releaseDate,
                    Synopsis = synopsis
                };
                if (film.ImdbRating > 10 || film.ImdbRating < 0)
                {
                }
                db.Film.Add(film);
                db.SaveChanges();
                db.Dispose();
            }
        }

        public void AddToDatabase(string filmName, string genre, decimal rating, int releaseDate, string synopsis,
            bool isTesting)
        {
            if (isTesting)
            {
                SqlHelper sqlHelper = new SqlHelper();
                sqlHelper.DropTable("dbo.Films");
            }
            AddToDatabase(filmName, genre, rating, releaseDate, synopsis);
        }

        public void AddToDatabase(bool isTesting)
        {
            using (var db = new PaulContext())
            {
                var film = new Film
                {
                    FilmName = "TestName",
                    Genre = "TestGenre",
                    ImdbRating = 10,
                    ReleaseDate = 2014,
                    Synopsis = "Test Synopsis."
                };
                db.Film.Add(film);
                db.SaveChanges();
                db.Dispose();
            }
        }

        public void DeleteDatabase()
        {
            using (var db = new PaulContext())
            {
                db.Database.Connection.Close();
                db.Database.Delete();
            }
        }
    }
}