using System;
using System.Collections.Generic;
namespace Clay.Models
{
    public interface IDoor
    {
        bool OpenDoor(int userID);
        bool CloseDoor(int userID);
        string DoorStatus();
        int GetId();
        List<Log> GetLogs();
        User GetUser(int id);
        void AddUser(User user);
    }
}
