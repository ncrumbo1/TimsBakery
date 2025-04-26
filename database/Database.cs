using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TimsBakery.database
{
   public static class Database
   {
      // Replace these values with your actual DB credentials
      private static string connectionString = "server=localhost;user=root;password=Password01;database=timsbakery;";

      public static MySqlConnection GetConnection()
      {
         return new MySqlConnection(connectionString);
      }
   }
}

