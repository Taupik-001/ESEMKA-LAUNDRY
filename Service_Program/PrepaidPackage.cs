using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test
{
    [Table("PrepaidPackage")]
    public class PrepaidPackage
    {
        [Key]
        public int Id { get; set; }
        // public string Name { get; set; }
        public int IdCustomer { get; set; }
        public int IdPackage { get; set; }
        public int Price { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime CompletedDateTime { get; set; }
        [ForeignKey("IdCustomer")]
        public virtual Customer? Customer { get; set; }
        [ForeignKey("IdPackage")]
        public virtual Package? Package { get; set; }
    }
}