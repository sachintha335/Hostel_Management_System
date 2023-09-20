using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hostel_Management_System
{
    class DBConnection
    {
        private static DBConnection connection = null;
        public  SqlConnection con;
        private DBConnection() 
        {
            con = new SqlConnection("Data Source=LAPTOP-EN1HC111;Initial Catalog=Hostel_Management_Database;Integrated Security=True");
        }

        public static DBConnection getConnection()
        {
            if (connection == null)
                connection = new DBConnection();
            return connection;

        }
    }
}
