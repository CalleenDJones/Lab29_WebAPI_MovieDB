using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lab29_WebAPI_MovieDB.Models;

namespace Lab29_WebAPI_MovieDB.Controllers
{
    public class ValuesController : ApiController
    {

        public List<Movy> GetMovie()
        {
            MoviesDBEntities db = new MoviesDBEntities();
            List<Movy> movies = db.Movies.ToList();

            return movies;
        }

        public List<Movy> GetMovieGenre(string gen)
        {
            MoviesDBEntities db = new MoviesDBEntities();
            List<Movy> MovGenre = (from m in db.Movies
                                   where m.Genre.Contains(gen)
                                   select m).ToList();
            return MovGenre;
        }

        public List<Movy> GetRandomPick()
        {
            Random r = new Random();

            MoviesDBEntities db = new MoviesDBEntities();
            List<Movy> randompick = db.Movies.ToList();
            int MoviesDB = randompick.Count() + 1;
            int ranpick = r.Next(0, MoviesDB);

            return randompick;
        }


        public List<Movy> GetRandomMovieGenre(string randomgen)
        {
            Random r = new Random();

            MoviesDBEntities db = new MoviesDBEntities();
            List<Movy> RanMovGenre = (from m in db.Movies
                                   where m.Genre.Contains(randomgen)
                                   select m).ToList();

            int MoviesDB = RanMovGenre.Count() + 1;
            int ranpick = r.Next(0, MoviesDB);

            return RanMovGenre;
        }



    }
}
