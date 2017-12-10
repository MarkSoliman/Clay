using System;
namespace Clay.Models
{
    public interface IAuthenticate
    {
        bool IsAuthenticated(int userID, int doorID);
    }
}
