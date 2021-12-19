using System.Collections.Generic;

namespace Task2.Models.Dtos
{
    public class CountryDto
    {
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }
        public IEnumerable<CountryDetailDto> CountryDetails { get; set; }
    }
}