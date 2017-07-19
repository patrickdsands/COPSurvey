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

        public InUseDevice()
        {
            SerialNumber = "";
            PCName = "";
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

        public InUseDevice GetInUseDevice()
        {
            return this;
        }
    }
}