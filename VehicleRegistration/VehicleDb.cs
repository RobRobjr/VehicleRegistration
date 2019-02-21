using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRegistration
{
    static class VehicleDb
    {
        public static List<string> GetAllVehicles()
        {     //Connection string for LocalDb       
            //string connection = "Data Source = (localdb)\\ProjectsV13;Initial Catalog = VehicleRegistrationDb; Integrated Security = True";
            //Put the above string into App.config folder .............. then use the below connection.
            string connection = ConfigurationManager.ConnectionStrings["VehicleRegistrationDb"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {   //Finish Database code...

                con.Open();

                
            }
            throw new NotImplementedException();
        } 
        


    }
}
