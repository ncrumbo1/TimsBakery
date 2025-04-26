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
   public static class EmployeeQueries
   {
      public static void InsertEmployee(string fname, string lname, string role, string address, string city, string state, string zip, string phone, string email)
      {
         try
         {
            using (MySqlConnection conn = Database.GetConnection())
            {
               conn.Open();
               string query = @"INSERT INTO employee (
                                        EMPLOYEE_FNAME, EMPLOYEE_LNAME, ROLE,
                                        EMPLOYEE_ADDRESS, EMPLOYEE_CITY, EMPLOYEE_STATE,
                                        EMPLOYEE_ZIPCODE, EMPLOYEE_PHONE, EMPLOYEE_EMAIL
                                     ) VALUES (
                                        @FirstName, @LastName, @Role,
                                        @Address, @City, @State,
                                        @Zip, @Phone, @Email
                                     )";

               using (MySqlCommand cmd = new MySqlCommand(query, conn))
               {
                  cmd.Parameters.AddWithValue("@FirstName", fname);
                  cmd.Parameters.AddWithValue("@LastName", lname);
                  cmd.Parameters.AddWithValue("@Role", role);
                  cmd.Parameters.AddWithValue("@Address", address);
                  cmd.Parameters.AddWithValue("@City", city);
                  cmd.Parameters.AddWithValue("@State", state);
                  cmd.Parameters.AddWithValue("@Zip", zip);
                  cmd.Parameters.AddWithValue("@Phone", phone);
                  cmd.Parameters.AddWithValue("@Email", email);

                  cmd.ExecuteNonQuery();
                  MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error inserting employee:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
   }
}