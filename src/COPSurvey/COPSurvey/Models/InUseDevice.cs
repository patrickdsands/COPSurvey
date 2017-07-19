using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COPSurvey.Models
{
    public class InUseDevice
    {
        public string SerialNumber { get; set; }
        public string PCName { get; set; }
        public string DeviceType { get; set; }
        public string SupportGroup { get; set; }
        public string Building { get; set; }
        public string Floor { get; set; }
        public string Room { get; set; }
        public bool MonitorNeedsReplaced { get; set; }

        public InUseDevice()
        {
            SerialNumber = "";
            PCName = "";
            DeviceType = "";
            SupportGroup = "";
            Building = "";
            Floor = "";
            Room = "";
            MonitorNeedsReplaced = true;
        }

        public InUseDevice(string SerialNumber)
        {
            this.SerialNumber = SerialNumber;
        }

        public InUseDevice(string SerialNumber, string PCName)
        {
            this.SerialNumber = SerialNumber;
            this.PCName = PCName;
        }

        public InUseDevice(string SerialNumber, string PCName, string DeviceType, string SupportGroup, string Building, string Floor, 
            string Room)
        {
            this.SerialNumber = SerialNumber;
            this.PCName = PCName;
            this.DeviceType = DeviceType;
            this.SupportGroup = SupportGroup;
            this.Building = Building;
            this.Floor= Floor;
            this.Room = Room;
        }

        public InUseDevice GetInUseDevice()
        {
            return this;
        }

        //Takes a MonitorNeedsReplaced bool and returns the ID code used for monitor sizes in the database.
        public int GetMonitorIDForDatabase(bool NeedsReplaced)
        {
            int MonitorID = 5;

            if(NeedsReplaced == false)
            {
                return MonitorID = 8;
            }

            return MonitorID;
        }

    }
}