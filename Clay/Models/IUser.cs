using System;
namespace Clay.Models
{
    public interface IUser
    {
        bool LogIn(string username, string password);
        bool LogOut();

    }
}
