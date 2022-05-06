using System.ComponentModel.DataAnnotations;

namespace MovieInfo.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int  DateRelease { get; set; }
        public double Rating { get; set; }
        public string? About { get; set; }

    }
}
