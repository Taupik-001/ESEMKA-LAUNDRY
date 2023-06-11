using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test
{
    [Table("Job")]
    public class Job
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
