using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test
{
    [Table("DetailDeposit")]
    public class DetailDeposit
    {
        [Key]
        public int Id { get; set; }
        public int IdDeposit { get; set; }
        public int IdService { get; set; }
        public int IdPrepaidPackage { get; set; }
        public int PriceUnit { get; set; }
        public decimal TotalUnit { get; set; }
        public DateTime CompletedDatetime { get; set; }
        [ForeignKey("IdDeposit")]
        public virtual HeaderDeposit? HeaderDeposit { get; set; }
        [ForeignKey("IdService")]
        public virtual Service? Service { get; set; }
        [ForeignKey("IdPrepaidPackage")]
        public virtual PrepaidPackage? PrepaidPackage { get; set; }
    }
}