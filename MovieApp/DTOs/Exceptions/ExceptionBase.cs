using Newtonsoft.Json;
using System.Net;

namespace MovieApp.DTOs.Exceptions
{
    public class ExceptionBase : Exception
    {
        public string Code { get; set; }
        public override string Message { get; }
        public int StatusCode { get; set; }

        public ExceptionBase(string code, string message, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
            : base(message)
        {
            Code = code;
            Message = message;
            StatusCode = (int)statusCode;
        }

        public virtual object GetMessage() => new { Code, Message };

        public override string ToString()
        {
            return JsonConvert.SerializeObject(GetMessage());
        }
    }
}
