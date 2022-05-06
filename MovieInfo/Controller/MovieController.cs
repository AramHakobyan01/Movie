using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MovieInfo.Models; 
using static MovieInfo.Models.Movie;

namespace MovieInfo.Controller
{
    [Route("api/movie")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private const double unit = 0.1;

        [HttpGet("films-by-alphabet")]
        public  List<Film> GetFilmsByAlphabet()
        {
            List<Film> films;
            using (MovieContext db = new MovieContext())
            {
                films = db.Films.OrderBy(p => p.Name).ToList();
            }
            return films;
        }


        [HttpGet("films-by-release-date")]
        public List<Film> GetFilmsByDateRelease()
        {
            List<Film> films;
            using (MovieContext db = new MovieContext())
            {
                films = db.Films.OrderBy(p => p.DateRelease).ToList();
            }
            return films;
        }
        [HttpGet("films-by-rating")]
        public List<Film> GetFilmsByRating()
        {
            List<Film> films;
            using (MovieContext db = new MovieContext())
            {
                films = db.Films.OrderBy(p => p.Rating).ToList();
            }
            return films;
        }
        [HttpGet("actors-by-rating")]
        public List<Actor> GetActorsByRating()
        {
            List<Actor> actors;
            using (MovieContext db = new MovieContext())
            {
                actors = db.Actors.OrderBy(p => p.Rating).ToList();
            }
            return actors;
        }
        [HttpGet("film-by-actor")]
        public List<Film> GetFilmsByActor(int actorId)
        {
            List<Film> films;
            using (MovieContext db = new MovieContext())
            {
                films = (
                    from f in db.Films
                    join fa in db.FilmsActors on f.Id equals fa.FilmId
                    where fa.ActorId == actorId
                    select f
                    ).ToList();
            }
            return films;
        }

        [HttpGet("actor-by-films")]
        public List<Actor> GetActorsByFilm(int filmId)
        {
            List<Actor> actors;
            using (MovieContext db = new MovieContext())
            {
                actors = (
                     from a in db.Actors
                     join fa in db.FilmsActors on a.Id equals fa.ActorId
                     where fa.FilmId == filmId
                     select a).ToList();
            }
            return actors;
        }
        [HttpPost("plus-film-rating")]
        public Film PlusFilmRating(Film film)
        {

            using (MovieContext db = new MovieContext())
            {
                db.Database.ExecuteSqlRaw("update Films set Rating = Rating + {0}  where Id = {1}", unit, film.Id);
                film = db.Films.Single(x => x.Id == film.Id);
            }
            return film;
        }
        [HttpPost("minus-film-rating")]
        public Film MinusFilmRating(Film film)
        {

            using (MovieContext db = new MovieContext())
            {
                db.Database.ExecuteSqlRaw("update Films set Rating = Rating - {0}  where Id = {1}", unit, film.Id);
                film = db.Films.Single(x => x.Id == film.Id);
            }
            return film;
        }
        [HttpPost("plus-actor-rating")]
        public Actor PlusActorRating(Actor actor)
        {
            using (MovieContext db = new MovieContext())
            {
                db.Database.ExecuteSqlRaw("update Actors set Rating = Rating + {0}  where Id = {1}", unit, actor.Id);
                actor = db.Actors.Single(x => x.Id == actor.Id);
            }
            return actor;
        }
        [HttpPost("minus-actor-rating")]
        public Actor MinusActorRating(Actor actor)
        {
            using (MovieContext db = new MovieContext())
            {
                db.Database.ExecuteSqlRaw("update Actors set Rating = Rating - {0}  where Id = {1}", unit, actor.Id);
                actor = db.Actors.Single(x => x.Id == actor.Id);
            }
            return actor;
        }


    }
}
