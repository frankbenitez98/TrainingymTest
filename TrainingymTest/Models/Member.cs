using System.ComponentModel.DataAnnotations;

namespace TrainingymTest.Models
{
    public class Member
    {
        public long Id { get; set; }

        [StringLength(500)]
        public string Name { get; set; }
    }
}
