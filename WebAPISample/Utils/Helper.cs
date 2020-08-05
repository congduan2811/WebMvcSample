using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace WebAPISample.Utils
{
    public class Helper
    {
        public SqlConnection connect { get; set; }
        public SqlCommand cmd { get; set; }
        public SqlCommand cmdCount { get; set; }
        public bool OpenConnect()
        {
            try
            {
                connect = new SqlConnection(ConfigurationManager.ConnectionStrings["DataSample"].ToString());
                connect.Open();
                return connect.State == ConnectionState.Open;
            }
            catch
            {
                return false;
            }
        }


    }
}