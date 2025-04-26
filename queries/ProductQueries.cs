using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using TimsBakery.database;

namespace TimsBakery.queries
{
   public static class ProductQueries
   {
      public static void InsertProduct(string name, string category, decimal price, string description)
      {
         try
         {
            using (MySqlConnection conn = Database.GetConnection())
            {
               conn.Open();
               string query = @"INSERT INTO products (
                                        PRODUCT_NAME, PRODUCT_CATEGORY,
                                        PRODUCT_PRICE, PRODUCT_DESCRIPTION
                                     ) VALUES (
                                        @Name, @Category, @Price, @Description
                                     )";

               using (MySqlCommand cmd = new MySqlCommand(query, conn))
               {
                  cmd.Parameters.AddWithValue("@Name", name);
                  cmd.Parameters.AddWithValue("@Category", category);
                  cmd.Parameters.AddWithValue("@Price", price);
                  cmd.Parameters.AddWithValue("@Description", description);

                  cmd.ExecuteNonQuery();
                  MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error inserting products:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
   }
}

