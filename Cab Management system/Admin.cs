using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB011943
{
    public class Admin 
    {
        SqlDataAdapter adpt;
 /*       private string name;
        private string contact;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }*/
        public Admin()
        {

        }

        public DataTable ViewOrders()
        {
            SqlConnection connection = new DbConnector().GetConnection();
            string query = "SELECT * FROM Orders";
            adpt = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }

    }
}
