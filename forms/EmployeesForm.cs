using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimsBakery.modules;
using TimsBakery.queries;
using TimsBakery.database;

namespace TimsBakery.forms

{
   public partial class EmployeesForm : Form
   {
      public EmployeesForm()
      {
         InitializeComponent();

      }

      private void btnSubmit_Click(object sender, EventArgs e)
      {
         if (!FormValidator.ValidateRequiredFields(panel1)) return;

         EmployeeQueries.InsertEmployee(
             txtFirstName.Text,
             txtLastName.Text,
             txtRole.Text,
             txtAddress.Text,
             txtCity.Text,
             txtState.Text,
             txtZip.Text,
             txtPhone.Text,
             txtEmail.Text
         );
      }
   }
}
