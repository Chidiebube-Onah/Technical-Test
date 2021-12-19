using System.Collections.Generic;
using System.Threading.Tasks;
using Task2.Models.Entities;

namespace Task2.Services.Utilities
{
    public static class DataInitializer
    {
        public static async Task Seed(Task2Context dbContext)
        {
            var data = new List<Country>()
            {
                new Country
                {
                    CountryCode = "234",
                    Name = "Nigeria",
                    CountryIso = "NG",
                    CountryDetails = new List<CountryDetail>
                    {
                        new CountryDetail {Operator = "MTN Nigeria", OperatorCode = "MTN NG"},
                        new CountryDetail {Operator = "Airtel Nigeria", OperatorCode = "ANG"},
                        new CountryDetail {Operator = "9 Mobile Nigeria", OperatorCode = "ETN"},
                        new CountryDetail {Operator = "Globacom Nigeria", OperatorCode = "GLO NG"}
                    }
                },

                new Country
                {
                    CountryCode = "233",
                    Name = "Ghana",
                    CountryIso = "GH",
                    CountryDetails = new List<CountryDetail>
                    {
                        new CountryDetail {Operator = "Vodafone Ghana", OperatorCode = "Vodafone GH"},
                        new CountryDetail {Operator = "MTN Ghana", OperatorCode = "MTN Ghana"},
                        new CountryDetail {Operator = "Tigo Ghana", OperatorCode = "Tigo Ghana"}
                    }
                },

                new Country
                {
                    CountryCode = "229",
                    Name = "Benin Republic",
                    CountryIso = "BN",
                    CountryDetails = new List<CountryDetail>
                    {
                        new CountryDetail {Operator = "MTN Benin", OperatorCode = "MTN Benin"},
                        new CountryDetail {Operator = "Moov Benin", OperatorCode = "Moov Benin"}
                    }
                },

                new Country
                {
                    CountryCode = "225",
                    Name = "Côte d'Ivoire",
                    CountryIso = "CIV",
                    CountryDetails = new List<CountryDetail>
                    {
                        new CountryDetail {Operator = "MTN Côte d'Ivoire", OperatorCode = "MTN CIV"}
                    }
                }
            };

            await dbContext.Countries.AddRangeAsync(data);
            await dbContext.SaveChangesAsync();
        }
    }
}
