namespace TrainingymTest.DTOs
{
    public class LastOrderByMemberDTO
    {
        public string MemberName { get; set; }
        public string ProductName { get; set; }
        public OrdenDataDto OrdenData { get; set; }
    }
    public class OrdenDataDto
    {
        public long Id { get; set; }
        public DateTime DateOrder { get; set; }
    }
}
