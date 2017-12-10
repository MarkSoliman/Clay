using System;
using System.Collections.Generic;
using Clay.Models;
namespace Clay.api.Controllers
{
    public class Simulation
    {
        List<Building> building;
        public Building GetBuilding(int id)
        {
            return building[id];
        }
        public Simulation()
        {
            building = new List<Building>();
            Office clayOffice = new Office("Clay", "Amsterdam");

            User admin = new User(1, "admin", "admin");
            User engineer = new User(2, "eng", "eng");
            List<User> AllUser = new List<User>();
            AllUser.Add(admin);
            AllUser.Add(engineer);

            ILock tunnelLock = new Lock();
            IDoor tunnel = new Door(1, "Tunnel", tunnelLock);
            tunnel.AddUser(admin);

            ILock officeLock = new Lock();
            IDoor office = new Door(2, "Office", officeLock);
            office.AddUser(admin);
            office.AddUser(engineer);

            clayOffice.AddDoor(tunnel);
            clayOffice.AddDoor(office);

            building.Add(clayOffice);
        }
    }
}
