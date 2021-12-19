using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text.RegularExpressions;
using Task2.Models.Dtos;
using Task2.Models.Entities;
using Task2.Models.Enums;
using Task2.Services.Interfaces;

namespace Task2.Services.Implementations
{
    public class PhoneService : IPhoneService
    {
        private readonly Task2Context _dbContext;
        private readonly IMapper _mapper;

        public PhoneService(Task2Context dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public (SearchResponseDto respone, MsgDto Msg) GetPhoneInfo(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
                return (null, new MsgDto{Message = "Blank values not allowed!", MsgType = MsgType.BadRequest});

            var phonePattern = new Regex(@"^[0-9]{13}$");

            var validNumber = phonePattern.IsMatch(number);

            if (!validNumber)
                return (null, new MsgDto { Message = "Invalid Number!", MsgType = MsgType.BadRequest });

            var searchKey = number[..3];

            var query = _dbContext.Countries.Include(x => x.CountryDetails).SingleOrDefault(c => c.CountryCode == searchKey);

            if (query == null)
                return (null, new MsgDto {Message = "Phone Info not found!", MsgType = MsgType.NotFound});
            

            var response = _mapper.Map<Country, SearchResponseDto>(query, opt => opt.AfterMap((src, dest) =>
            {
                dest.Number = number;
            }));

            return (response, null);
        }
    }
}
