using System;


namespace SalesWebMvc.Services.Exceptions
{
    public class NotFoudException : ApplicationException
    {
        public NotFoudException(string message) : base(message)
        {

        }
    }
}
