﻿namespace MovieApp.DTOs.Commons
{
    public class InvalidRequestDTO
    {
        public InvalidRequestDTO(string code, string message)
        {
            Code = code;
            Message = message;
        }

        public string Code { get; set; }
        public string Message { get; set; }
    }
}
