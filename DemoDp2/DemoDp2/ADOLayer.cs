using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace DemoDp2
{
    public class ADOLayer
    {
        string constr = "";
        public ADOLayer()
        {
            constr = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
        }
        public DataSet GetallRecords()
        {

        }
    }
}