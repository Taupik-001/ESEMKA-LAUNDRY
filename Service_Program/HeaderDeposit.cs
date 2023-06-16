using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Test
{
    [Table("HeaderDeposit")]
    public class HeaderDeposit
    {
        [Key]
        public int Id { get; set; }
        public int IdCustomer { get; set; }
        public int IdEmployee { get; set; }
        public DateTime TransactionDatetime { get; set; }
        public DateTime CompleteEstimationDatetime { get; set; }
        [ForeignKey("IdCustomer")]
        public virtual Customer? Customer { get; set; }
        [ForeignKey("IdEmployee")]
        public virtual Employee? Employee { get; set; }
    }
}