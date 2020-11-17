using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uts
{
    public class Connection
    {

        private string _connString = "";

        public Connection()
        {
            SqlConnectionStringBuilder connStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = @".\sql2019express",
                InitialCatalog = @"DB_DATA",
                IntegratedSecurity = true
            };
            _connString = connStringBuilder.ToString();
        }

        public SqlConnection CreateAndOpenConnection()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(_connString);
                conn.Open();
            }
            catch (Exception)
            {
                throw;
            }
            return conn;
        }


    }
}
