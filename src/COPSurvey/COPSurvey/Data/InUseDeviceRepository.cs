using COPSurvey.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace COPSurvey.Data
{
    public class InUseDeviceRepository
    {
        private static InUseDevice[] _inUseDevices = new InUseDevice[0];

        DataTable inUseDeviceTable = new AMCPMDBPRODDataSet.InUseDeviceDataTable();

        List<string> listOfSerialNumbers = new List<string>();

        public InUseDeviceRepository()
        {
            
        }

        public InUseDevice GetInUseDevice(string SerialNumber)
        {
            DataRow[] row = inUseDeviceTable.Select("SN = " + SerialNumber);
            return null;
        }

    }
}