using System;
using System.Collections.Generic;
namespace Clay.Models
{
    public abstract class Building
    {
        protected string address;
        protected IList<IDoor> doors;

        public IList<IDoor>GetDoors()
        {
            return this.doors;
        }
       
        public bool OpenDoor(int userId,int doorId)
        {
            for (int i = 0; i < doors.Count;i++)
            {
                if(doors[i].GetId() == doorId)
                {
                    return doors[i].OpenDoor(userId);
                }
            }
            return false;
        }

        public bool CloseDoor(int userId, int doorId)
        {
            for (int i = 0; i < doors.Count; i++)
            {
                if (doors[i].GetId() == doorId)
                {
                    return doors[i].CloseDoor(userId);
                }
            }
            return false;
        }
    }
}
