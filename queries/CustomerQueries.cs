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
   public static class CustomerQueries
   {
      public static void InsertCustomer(string fname, string lname, string address, string city, string state, string zip, string phone, string email, int loyaltyId)
      {
         try
         {
            using (MySqlConnection conn = Database.GetConnection())
            {
               conn.Open();
               string query = @"INSERT INTO customer (
                                        CUSTOMER_FNAME, CUSTOMER_LNAME, CUSTOMER_ADDRESS,
                                        CUSTOMER_CITY, CUSTOMER_STATE, CUSTOMER_ZIPCODE,
                                        CUSTOMER_PHONE, CUSTOMER_EMAIL, LOYALTY_ID
                                     ) VALUES (
                                        @FirstName, @LastName, @Address,
                                        @City, @State, @Zip,
                                        @Phone, @Email, @LoyaltyID
                                     )";

               using (MySqlCommand cmd = new MySqlCommand(query, conn))
               {
                  cmd.Parameters.AddWithValue("@FirstName", fname);
                  cmd.Parameters.AddWithValue("@LastName", lname);
                  cmd.Parameters.AddWithValue("@Address", address);
                  cmd.Parameters.AddWithValue("@City", city);
                  cmd.Parameters.AddWithValue("@State", state);
                  cmd.Parameters.AddWithValue("@Zip", zip);
                  cmd.Parameters.AddWithValue("@Phone", phone);
                  cmd.Parameters.AddWithValue("@Email", email);
                  cmd.Parameters.AddWithValue("@LoyaltyID", loyaltyId);

                  cmd.ExecuteNonQuery();
                  MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error inserting customer:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
   }
}






/*
namespace TimsBakery.queries
{
   public static class CustomerQueries
   {
      public static void InsertCustomer(string fname, string lname, string address, string city, string state, string zip, string phone, string email)
      {
         try
         {
            using (MySqlConnection conn = Database.GetConnection())
            {
               conn.Open();
               string query = @"INSERT INTO customer (
                                        CUSTOMER_FNAME, CUSTOMER_LNAME,
                                        CUSTOMER_ADDRESS, CUSTOMER_CITY, CUSTOMER_STATE,
                                        CUSTOMER_ZIPCODE, CUSTOMER_PHONE, CUSTOMER_EMAIL
                                     ) VALUES (
                                        @FirstName, @LastName,
                                        @Address, @City, @State,
                                        @Zip, @Phone, @Email
                                     )";

               using (MySqlCommand cmd = new MySqlCommand(query, conn))
               {
                  cmd.Parameters.AddWithValue("@FirstName", fname);
                  cmd.Parameters.AddWithValue("@LastName", lname);
                  cmd.Parameters.AddWithValue("@Address", address);
                  cmd.Parameters.AddWithValue("@City", city);
                  cmd.Parameters.AddWithValue("@State", state);
                  cmd.Parameters.AddWithValue("@Zip", zip);
                  cmd.Parameters.AddWithValue("@Phone", phone);
                  cmd.Parameters.AddWithValue("@Email", email);

                  cmd.ExecuteNonQuery();
                  MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error inserting customer:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
   }
}*/
