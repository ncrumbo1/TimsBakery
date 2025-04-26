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
   public static class InvoiceQueries
   {
      public static void InsertInvoice(int orderId, int productId, int quantity, decimal unitPrice)
      {
         try
         {
            using (MySqlConnection conn = Database.GetConnection())
            {
               conn.Open();

               string query = @"INSERT INTO invoices (
                                        ORDER_ID, PRODUCT_ID, QUANTITY, UNIT_PRICE
                                     ) VALUES (
                                        @OrderId, @ProductId, @Quantity, @UnitPrice
                                     )";

               using (MySqlCommand cmd = new MySqlCommand(query, conn))
               {
                  cmd.Parameters.AddWithValue("@OrderId", orderId);
                  cmd.Parameters.AddWithValue("@ProductId", productId);
                  cmd.Parameters.AddWithValue("@Quantity", quantity);
                  cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);

                  cmd.ExecuteNonQuery();
                  MessageBox.Show("Invoice added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error inserting invoices:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
   }
}
