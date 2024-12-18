using System.ComponentModel.DataAnnotations.Schema;

namespace patika_w12_CodeFirstBasic.Models
{
    [Table("Games")]
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Platform { get; set; }
        public decimal Rating { get; set; }
    }
}
