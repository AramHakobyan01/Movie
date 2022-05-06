using System.ComponentModel.DataAnnotations;

namespace MovieInfo.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Rating { get; set; }
        public string? About { get; set; }
    }
}
