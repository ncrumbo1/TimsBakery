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
   public static class InventoryQueries
   {
      public static void InsertInventory(int productId, int storeId, int quantity)
      {
         try
         {
            using (MySqlConnection conn = Database.GetConnection())
            {
               conn.Open();
               string query = @"INSERT INTO inventory (
                                        PRODUCT_ID,
                                        STORE_ID,
                                        QUANTITY,
                                        INVENTORY_UPDATE
                                     ) VALUES (
                                        @ProductId,
                                        @StoreId,
                                        @Quantity,
                                        NOW()
                                     )";

               using (MySqlCommand cmd = new MySqlCommand(query, conn))
               {
                  cmd.Parameters.AddWithValue("@ProductId", productId);
                  cmd.Parameters.AddWithValue("@StoreId", storeId);
                  cmd.Parameters.AddWithValue("@Quantity", quantity);

                  cmd.ExecuteNonQuery();
                  MessageBox.Show("Inventory added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error inserting inventory:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
   }
}
