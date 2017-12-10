using System;
namespace Clay.Models
{
    public class LockException:Exception
    {
        public LockException()
        {
        }
        public LockException(string message) : base(message)
        {
        }
    }
}
