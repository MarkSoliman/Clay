using System;
namespace Clay.Models
{
    public class UnAuthorizeUserException:Exception
    {
        public UnAuthorizeUserException()
        {
        }
        public UnAuthorizeUserException(string message) : base(message)
        {
        }
    }
}
