using System;
namespace CustomsExceptions.CustomExceptions
{
    public class MyCustomException : Exception
    {
        public MyCustomException()
        {
        }

        public MyCustomException(string? message) : base(message)
        {
        }

        public override string Message => "Custom error";
    }
}

