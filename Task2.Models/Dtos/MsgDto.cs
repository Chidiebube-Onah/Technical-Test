using Task2.Models.Enums;

namespace Task2.Models.Dtos
{
    public class MsgDto
    {
        public string Message { get; set; }
        public MsgType MsgType { get; set; }
    }
}