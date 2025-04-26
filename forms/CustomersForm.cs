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
   public partial class CustomersForm : Form
   {
      public CustomersForm()
      {
         InitializeComponent();

      }

      private void btnSubmit_Click(object sender, EventArgs e)
      {
         if (!FormValidator.ValidateRequiredFields(panel1))
            return;

         int loyaltyId = 0;
         int.TryParse(txtLoyalty.Text, out loyaltyId); // fallback to 0 if invalid

         CustomerQueries.InsertCustomer(
             txtFirstName.Text,
             txtLastName.Text,
             txtAddress.Text,
             txtCity.Text,
             txtState.Text,
             txtZip.Text,
             txtPhone.Text,
             txtEmail.Text,
             loyaltyId
         );
      }

   }
}


