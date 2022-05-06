using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieInfo.Models
{
    public class FilmsActor
    {
        [Key]
        [Column(Order = 1)]
        public int FilmId { get; set; }

        public int ActorId { get; set; }
    }
}
