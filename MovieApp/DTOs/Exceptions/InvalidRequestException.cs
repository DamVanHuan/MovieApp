namespace MovieApp.DTOs.Exceptions
{
    public class InvalidRequestException : Exception
    {
        public InvalidRequestException(string code, string message)
        {
            Code = code;
            Message = message;
        }

        public string Code { get; set; }
        public override string Message { get; }

        public virtual object GetMessage() => new { Code, Message };
    }
}
