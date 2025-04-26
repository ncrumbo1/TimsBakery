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
    public partial class InvoicesForm: Form
    {
        public InvoicesForm()
        {
            InitializeComponent();
        }
      private void btnSubmit_Click(object sender, EventArgs e)
      {
         if (!FormValidator.ValidateRequiredFields(panel1)) return;

         try
         {
            int orderId = int.Parse(txtOrderID.Text);
            int productId = int.Parse(txtProductID.Text);
            int quantity = int.Parse(txtQuantity.Text);
            decimal unitPrice = decimal.Parse(txtUnitPrice.Text);

            InvoiceQueries.InsertInvoice(orderId, productId, quantity, unitPrice);
         }
         catch (FormatException)
         {
            MessageBox.Show("Please enter valid numeric values for IDs, Quantity, and Unit Price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         }
      }
    }
}
