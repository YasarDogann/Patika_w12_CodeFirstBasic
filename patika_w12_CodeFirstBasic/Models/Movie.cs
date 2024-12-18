using System.ComponentModel.DataAnnotations.Schema;

namespace patika_w12_CodeFirstBasic.Models
{
    [Table("Movies")]
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
    }
}
