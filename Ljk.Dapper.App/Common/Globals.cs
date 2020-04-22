using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD.Web.API
{
    public class Globals
    {
        public static string SecretKey = "5C9476A3-D13F-40A5-BDE9-CC104BF7CCA3";


        public static string ValidAudience = "ljk";
        public static string ValidIssuer = "ljk";

        public static IDbConnection SqlConnection { get; internal set; }
        public static string SqlConnectionString = "Server=192.168.3.31;Database=PACKPRESSDB;User Id=sa;Password=cssd20151231@;";
    }
}
