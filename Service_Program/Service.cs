using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test
{
    [Table("Service")]
    public class Service
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int IdCategory { get; set; }
        public int IdUnit { get; set; }
        public int PriceUnit { get; set; }
        public int EstimationDuration { get; set; }
        [ForeignKey("IdCategory")]
        public virtual Category? Category { get; set; }
        [ForeignKey("IdUnit")]
        public virtual Unit? Unit { get; set; }
    }
}