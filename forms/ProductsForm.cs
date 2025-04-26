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

namespace TimsBakery.forms
{
    public partial class ProductsForm: Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }


      private void btnSubmit_Click(object sender, EventArgs e)
      {
         if (!FormValidator.ValidateRequiredFields(panel1)) return;

         try
         {
            decimal price = decimal.Parse(txtPrice.Text);

            ProductQueries.InsertProduct(
                txtProductName.Text,
                txtCategory.Text,
                price,
                txtDescription.Text
            );
         }
         catch (FormatException)
         {
            MessageBox.Show("Invalid price format. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         }
      }
    }
}
