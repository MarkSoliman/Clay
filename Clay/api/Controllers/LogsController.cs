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
    public class LogsController : ApiController
    {
        Simulation simulation = new Simulation();
        public List<Log> GetLogs(int building_id, int door_id)
        {
            foreach (IDoor item in simulation.GetBuilding(building_id).GetDoors())
            {
                if(item.GetId() == door_id)
                {
                    return item.GetLogs();    
                }
            }
            throw new Exception("Door Not Found");
        }
        public List<object> GetLogs(int building_id)
        {
            IList<IDoor> doors = simulation.GetBuilding(building_id).GetDoors();
            List<object> result = new List<object>();
            foreach (IDoor item in simulation.GetBuilding(building_id).GetDoors())
            {
                var json = new
                {
                    door_id = item.GetId(),
                    location = item.GetLocation(),
                    door_status = item.DoorStatus()
                };
                result.Add(json);
            }
            return result;
        }
    }
}
