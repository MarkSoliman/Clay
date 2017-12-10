using System;
using System.Collections.Generic;
namespace Clay.Models
{
    public class Office:Building
    {
        string name; // not all bulidings has name but all has address
        public Office(string name, string address)
        {
            this.name = name;
            this.address = address;
            doors = new List<IDoor>();

        }
        public void AddDoor(IDoor door)
        {
            doors.Add(door);
        }
       
    }
}
