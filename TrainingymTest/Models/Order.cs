using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingymTest.Models
{
    public class Order
    {
            public long Id { get; set; }
            public long MemberId { get; set; }
            public long ProductId { get; set; }
            [Column(TypeName = "datetime2(0)")]
            public DateTime DateOrder { get; set; }
            public Product Product { get; set; }
            public Member Member { get; set; }
        
    }
}
