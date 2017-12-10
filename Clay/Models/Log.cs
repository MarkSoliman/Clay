using System;
namespace Clay.Models
{
    public class Log
    {
        DateTime timeStamp;
        string doorStatus;
        User user;
        public Log(DateTime timeStamp, User user, string doorStatus)
        {
            this.timeStamp = timeStamp;
            this.doorStatus = doorStatus;
            this.user = user;
        }
    }
}
