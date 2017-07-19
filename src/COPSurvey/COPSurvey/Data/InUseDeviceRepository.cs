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

        DataTable inUseDeviceTable = null;

        public InUseDeviceRepository()
        {
            inUseDeviceTable = new AMCPMDBPRODDataSet.InUseDeviceDataTable();
        }

        public InUseDevice GetInUseDevice(string SerialNumber)
        {
            InUseDevice device = null;

            string findSN = string.Format("@SerialNumber = SN", SerialNumber);
            DataRow[] row = inUseDeviceTable.Select(findSN);

            foreach (DataRow dataRow in row)
            {
                //snColumnIndex = dataRow.Table.Columns["SN"].Ordinal;

                if(dataRow != null)
                {
                    device = new InUseDevice(dataRow["SN"].ToString(), dataRow["Name"].ToString());

                    //device = new InUseDevice(dataRow.Field<string>("SerialNumber"), 
                    //    dataRow.Field<string>("Name"));
                    break;
                }
                else
                {
                    Console.WriteLine("The Data row is null!");
                }
            }
            //if (row != null)
            //{
            //    device = new InUseDevice(SerialNumber, row["Name"].Field<string>("Name"));
            //}
            return device;
                
        }

        public DataTable InitializeInUseDeviceTable()
        {
            return new AMCPMDBPRODDataSet.InUseDeviceDataTable();
        }

    }
}