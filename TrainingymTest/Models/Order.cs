using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingymTest.Models
{
    public class Order
    {
            public long Id { get; set; }
            public long MemberId { get; set; }
            public long ProductId { get; set; }
            [Column(TypeName = "datetime2(0)")]
            public DateTime dateOrder { get; set; }
            public Product product { get; set; }
            public Member member { get; set; }
        
    }
}
