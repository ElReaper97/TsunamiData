using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrialAPI.Models
{
    public class TrialAPIclass1
    {
        public int PrimaryId;
        public int SensorId;
        public DateTime dt= DateTime.Now;
        public double latitiude;
        public double longitude;
        public char zone;
        public float ritcherscale;
        public float sealevelpressure;
        public float waterlevel;
        public int wind_direction;
        public float wind_speed;
    }
    public class GoatData
    {
        public bool status;
        public string message;
        public string values_displayed;
        public List<TrialAPIclass1> goats;
        public GoatData()
        {
            goats = new List<TrialAPIclass1>();
        }
    }
}