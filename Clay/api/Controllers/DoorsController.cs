using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Clay.Controllers;
using Clay.Models;

namespace Clay.api.Controllers
{
    public class DoorsController : ApiController
    {
        Simulation simulation = new Simulation();
        IAuthenticate authentication;
        void SetSimulation()
        {
            if (HttpContext.Current.Session["Simulation"] != null)
            {
                simulation = HttpContext.Current.Session["Simulation"] as Simulation;
            }
            else
            {
                simulation = new Simulation();
            }
        }
        [System.Web.Http.HttpGet]
        public bool OpenDoor(int user_id, int door_id)
        {
            authentication = new Authenticate();
            if(authentication.IsAuthenticated(user_id, door_id))
            {
                return simulation.GetBuilding(0).OpenDoor(user_id, door_id);
            }
            return false;
        }
        public bool CloseDoor(int user_id, int door_id)
        {
            authentication = new Authenticate();
            if (authentication.IsAuthenticated(user_id, door_id))
            {
                return simulation.GetBuilding(0).CloseDoor(user_id, door_id);
            }
            return false;
        }
        public List<IDoor>GetDoors(int building_id)
        {
            return simulation.GetBuilding(0).GetDoors().ToList();
        }
    }
}
