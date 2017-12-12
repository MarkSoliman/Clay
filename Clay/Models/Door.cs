using System;
using System.Collections.Generic;
namespace Clay.Models
{
    public class Door:IDoor
    {
        int id;

        string location;
        public string GetLocation()
        {
            return this.location;
        }
        public string Location
        {
            get
            {
                return this.location;
            }
        }
        public int Id
        {
            get
            {
                return this.id;
            }
        }
        public string Status{
            get
            {
                return this.DoorStatus();
            }
        }
        ILock doorLock;
        List<Log> logs;
        protected IList<User> users;
        public void AddUser(User user)
        {
            this.users.Add(user);
        }
        public User GetUser(int userId)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].GetId() == userId)
                {
                    return users[i];
                }
            }
            return null;
        }
        public List<Log> GetLogs()
        {
            return logs;
        }
        public int GetId()
        {
            return this.id;
        }
        public bool OpenDoor(int userId)
        {
            User user = GetUser(userId);
            if (user != null)
            {
                if (doorLock.Open())
                {
                    logs.Add(new Log(DateTime.Now, user, this.DoorStatus()));
                    return true;
                }
                return false;
            }
            else
            {
                throw new UnAuthorizeUserException("This user is not authorized to control this door");
            }
        }
        public bool CloseDoor(int userId)
        {
            User user = GetUser(userId);
            if (user != null)
            {
                if (doorLock.Close())
                {
                    logs.Add(new Log(DateTime.Now, user, this.DoorStatus()));
                    return true;
                }
            }
            else
            {
                throw new UnAuthorizeUserException("This user is not authorized to control this door");
            }
            return true;
        }
        public Door(int id,string location,ILock doorLock)
        {
            this.id = id;
            this.location = location;
            this.doorLock = doorLock;
            logs = new List<Log>();
            users = new List<User>();
        }
        public string DoorStatus()
        {
            if(doorLock.GetLockStatus() == LockStatus.Opened)
            {
                return "Opened";
            }
            else
            {
                return "Closed";
            }
        }
    }
}
