using COPSurvey.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace COPSurvey.Data
{
    public class InUseDeviceRepository
    {
        private static InUseDevice[] _inUseDevices = new InUseDevice[0];

        public InUseDeviceRepository() { }

        public InUseDevice GetInUseDevice(string SerialNumber)
        {
            InUseDevice device = null;

            SqlCommand command = null;
            SqlDataReader reader = null;
            string query = @"SELECT * FROM InUseDevice WHERE SN = @sn";

            using (SqlConnection connection = new SqlConnection(@"Data Source=WINETINSPRD01;Initial Catalog=AMCPMDBPROD;Integrated Security=SSPI;"))
            {
                try
                {
                    connection.Open();
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@sn", SerialNumber);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        device = new InUseDevice(SerialNumber, reader["Name"].ToString(), reader["DeviceType"].ToString(),
                            reader["BusinessUse"].ToString(), reader["SupportGroup"].ToString(), reader["Building"].ToString(),
                            reader["Floor"].ToString(), reader["Room"].ToString());
                    }

                }catch(Exception ex)
                {
                    Console.WriteLine("Error!" + ex.Message + "\n" + ex.StackTrace);
                }
            }

            return device;
                
        }

        


    }
}

