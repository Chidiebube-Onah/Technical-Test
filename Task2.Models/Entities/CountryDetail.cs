namespace Task2.Models.Entities
{
    public class CountryDetail
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Operator { get; set; }
        public string OperatorCode { get; set; }
        public virtual Country Country { get; set; }
    }
}