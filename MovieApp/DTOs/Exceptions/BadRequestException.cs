using System.Net;

namespace MovieApp.DTOs.Exceptions
{
    public class BadRequestException : ExceptionBase
    {
        public BadRequestException(string code = "InvalidRequest", string message = "Yêu cầu không hợp lệ")
            : base(code, message, HttpStatusCode.BadRequest)
        {
        }
    }
}
