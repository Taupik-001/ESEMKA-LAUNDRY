using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test
{
    [Table("Package")]
    public class Package
    {
        [Key]
        public int Id { get; set; }
        public int IdService { get; set; }
        public int TotalUnit { get; set; }
        public int Price { get; set; }
        [ForeignKey("IdService")]
        public virtual Service? Service { get; set; }
    }
}