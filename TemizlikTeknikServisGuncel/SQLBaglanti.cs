using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace TemizlikTeknikServisGuncel
{
    public class SQLBaglanti
    {
        public static string BaglantiCumlesiGonder()
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
           return sqlConnectionStringBuilder.ConnectionString = "Server=localhost;Database=TemizlikTeknikServis;Integrated Security = True;TrustServerCertificate=True;";

        }
    }
}
