using System.ComponentModel.DataAnnotations;


namespace MovieInfo.Models

{
    public class FilmActor
    {
        [Key]
        public int FilmId { get; set; }
        public int ActorId { get; set; }
    }
}
