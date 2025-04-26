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
    public partial class InventoryForm: Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }
      private void btnSubmit_Click(object sender, EventArgs e)
      {
         if (!FormValidator.ValidateRequiredFields(panel1)) return;

         int productId = int.Parse(txtProductID.Text);
         int storeId = int.Parse(txtStoreID.Text);
         int quantity = int.Parse(txtQuantity.Text);

         InventoryQueries.InsertInventory(productId, storeId, quantity);
      }
   }
}
