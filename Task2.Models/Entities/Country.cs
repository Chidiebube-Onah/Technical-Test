using System.Collections.Generic;

namespace Task2.Models.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }
        public ICollection<CountryDetail> CountryDetails { get; set; }
    }
}
