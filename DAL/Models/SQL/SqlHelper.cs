using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.SQL
{
    public class SqlHelper
    {
        public string DeleteFromDatabase()
        {
            const string sql = "";
            return sql;
        }

        public void DropTable(string table)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Context"].ConnectionString);

            using (conn)
            {
                SqlCommand cmd = new SqlCommand(string.Format("DROP TABLE {0}", table));
            }
        }
    }
}
