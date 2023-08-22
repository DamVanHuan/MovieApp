namespace MovieApp.DTOs.Commons
{
    public class ResponseBase
    {
        public string Code { get; set; }
        public string Message { get; set; }

        public ResponseBase(string code, string message)
        {
            Code = code;
            Message = message;
        }
    }
}
