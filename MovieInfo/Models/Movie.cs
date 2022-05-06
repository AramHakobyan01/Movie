using Microsoft.EntityFrameworkCore;

namespace MovieInfo.Models
{
    public class Movie
    {
        public partial class MovieContext : DbContext
        {
            public MovieContext()
            {
            }

            public MovieContext(DbContextOptions<MovieContext> options)
                : base(options)
            {
            }
            public DbSet<Film> Films { get; set; }
            public DbSet<Actor> Actors { get; set; }
            public DbSet<FilmActor> FilmsActors { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB; Database = Movie; Trusted_Connection = True;");
                }
            }

        }
    }
}
