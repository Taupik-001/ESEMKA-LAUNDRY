using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test
{
    [Table("Unit")]
    public class Unit
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}