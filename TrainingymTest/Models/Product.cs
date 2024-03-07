using System.ComponentModel.DataAnnotations;

namespace TrainingymTest.Models
{
    public class Product
    {
        public long Id { get; set; }

        [StringLength(500)]
        public string Name { get; set; }
    }
}
