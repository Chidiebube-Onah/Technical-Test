using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task2.Models.Dtos;
using Task2.Models.Enums;
using Task2.Services.Interfaces;

namespace Task2.Api.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("[controller]")]
    public class PhoneInfoController : ControllerBase
    {
        private readonly IPhoneService _phoneService;


        public PhoneInfoController(IPhoneService phoneService)
        {
            _phoneService = phoneService;
        }

        [ProducesResponseType(typeof(SearchResponseDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [HttpGet("{number}")]
        public IActionResult Get(string number)
        {
            var (response, errMsg) = _phoneService.GetPhoneInfo(number);

            if (response != null)
                return Ok(response);

            return errMsg switch
            {
                { MsgType: MsgType.BadRequest } => BadRequest(errMsg.Message),
                { MsgType: MsgType.NotFound } => NotFound(errMsg.Message),
                _ => BadRequest()
            };
        }

    }
}
