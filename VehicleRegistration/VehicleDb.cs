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
        public static List<string> GetAllModels()
        {     //Connection string for LocalDb       
            //string connection = "Data Source = (localdb)\\ProjectsV13;Initial Catalog = VehicleRegistrationDb; Integrated Security = True";
            string connection = ConfigurationManager.ConnectionStrings["VehicleRegistrationDb"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
            }
            throw new NotImplementedException();
        }

        //deleting an instance in the database
        //public static void DeleteVehicle(Vehicle v)
        //{
        //    Vehicle car = new Vehicle();

        //    context.Entry(car).State = EntityState.Deleted;

        //    context.SaveChanges();
        //}

        //public static Vehicle AddVehicle(Vehicle v)
        //{
        //    VechicleRegContext context = new VehicleRegContext();
        //    context.Vehicle.Add(v);
        //    context.SaveChanges();
        //    return v;
        //}

    }
}

