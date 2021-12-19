using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Models.Dtos;

namespace Task2.Services.Interfaces
{
   public interface IPhoneService
   {
       (SearchResponseDto respone, MsgDto Msg) GetPhoneInfo(string number);
   }
}
