using System;
namespace Clay.Models
{
    public class User
    {
        string userName;
        string password;
        int id;
        public int GetId()
        {
            return this.id;
        }
        public User(int id,string useName,string password)
        {
            this.id = id;
            this.userName = useName;
            this.password = password;
        }
    }
}
