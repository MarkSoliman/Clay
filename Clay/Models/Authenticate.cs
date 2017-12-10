using System;
namespace Clay.Models
{
    public class Authenticate:IAuthenticate
    {
        public bool IsAuthenticated(int userID, int doorID)
        {
            return true;
        }
        public Authenticate()
        {
        }
    }
}
