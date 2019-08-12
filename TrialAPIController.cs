using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TrialAPI.Models;

namespace TrialAPI.Controllers
{
    public class TrialAPIController : ApiController
    {
        // GET api/<controller>
        public GoatData Get()
        {
            var result = new GoatData();
            try
            {
                result.status = true;
                result.message = "The Sensor is active. The data collected is:";
                Random r = new Random();
                int day = 24 * 4;
                for (int i = 0; i<day; i++)
                {
                    TrialAPIclass1 mySensor = new TrialAPIclass1();
                    mySensor.PrimaryId = i + 1;
                    mySensor.SensorId = r.Next()%1000;
                    mySensor.latitiude = (r.Next() % 100 * (1+(r.Next() % 100) / 100));
                    mySensor.longitude = (r.Next() % 100 * (1+(r.Next() % 100) / 100));
                    mySensor.zone = 'a';
                    mySensor.ritcherscale = r.Next() % 10;
                    mySensor.sealevelpressure = r.Next() % 10;
                    mySensor.waterlevel = r.Next() % 100;
                    mySensor.wind_direction = r.Next()%100;
                    mySensor.wind_speed = r.Next() % 10;
                    mySensor.dt = DateTime.Now;
                    result.goats.Add(mySensor);
                }
                
            }
            catch(Exception ex)
            {
                result.message = ex.Message;
                result.status = false;
            }
            return result;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}