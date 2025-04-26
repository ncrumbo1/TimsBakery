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


namespace TimsBakery.forms
{
   public partial class RegisterForm : Form
   {

      private StringBuilder orderLog = new StringBuilder();

      private string selectedProduct = "";
      private int enteredQuantity = 0;
      private RegisterCalculations calc;

      public RegisterForm()
      {
         InitializeComponent();
         calc = new RegisterCalculations();

         WireProductButtons();
         WireNumpadButtons();

         btnAddItem.Click += btnAddItem_Click;
         btnSubtotal.Click += btnSubtotal_Click;
         btnReset.Click += btnReset_Click;
         btnCheckout.Click += btnCheckout_Click;
      }

      private void WireProductButtons()
      {
         btnDonut.Click += Product_Click;
         btnCoffee.Click += Product_Click;
         btnBagel.Click += Product_Click;
         btnMuffin.Click += Product_Click;
         btnLatte.Click += Product_Click;
         btnIcedCoffee.Click += Product_Click;
         btnCroissant.Click += Product_Click;
         btnCookie.Click += Product_Click;
      }

      private void WireNumpadButtons()
      {
         for (int i = 0; i <= 9; i++)
         {
            numpadButtons[i].Click += Numpad_Click;
         }
      }

      private void Product_Click(object sender, EventArgs e)
      {
         Button btn = sender as Button;
         selectedProduct = btn.Text;
         enteredQuantity = 0;

         // Update receipt preview
         rtbReceipt.Clear();
         rtbReceipt.AppendText(orderLog.ToString()); // show all past items
         rtbReceipt.AppendText($"Product: {selectedProduct}\n");
         rtbReceipt.AppendText("Quantity: \n");

         // Update prompt
         lblPrompt.Text = "Enter the quantity:";
      }


      private void Numpad_Click(object sender, EventArgs e)
      {
         if (string.IsNullOrEmpty(selectedProduct))
         {
            MessageBox.Show("Select a product first.");
            return;
         }

         Button btn = sender as Button;
         int value = int.Parse(btn.Text);
         enteredQuantity = (enteredQuantity * 10) + value;

         // Update preview
         rtbReceipt.Clear();
         rtbReceipt.AppendText(orderLog.ToString()); // show all past items
         rtbReceipt.AppendText($"Product: {selectedProduct}\n");
         rtbReceipt.AppendText($"Quantity: {enteredQuantity}\n");

         // You can optionally update the prompt again here (if needed)
         lblPrompt.Text = "Press + to add item";
      }



      private void btnAddItem_Click(object sender, EventArgs e)
      {
         if (string.IsNullOrEmpty(selectedProduct) || enteredQuantity == 0)
         {
            MessageBox.Show("Select a product and enter quantity first.");
            return;
         }

         string line = calc.AddItem(selectedProduct, enteredQuantity);
         if (line != null)
         {
            orderLog.AppendLine(line);       // Save it to the permanent order
            rtbReceipt.Clear();              // Start fresh for next product
            rtbReceipt.AppendText(orderLog.ToString()); // Re-display everything
         }

         // Reset
         selectedProduct = "";
         enteredQuantity = 0;

         // Reset the prompt
         lblPrompt.Text = "Enter a product:";
      }


      private void btnSubtotal_Click(object sender, EventArgs e)
      {
         decimal tax = calc.GetTax();
         decimal total = calc.GetTotal();

         rtbReceipt.AppendText("-----------------------\n");
         rtbReceipt.AppendText($"Subtotal:       ${calc.Subtotal:F2}\n");
         rtbReceipt.AppendText($"Tax:            ${tax:F2}\n");
         rtbReceipt.AppendText($"Total:          ${total:F2}\n");
      }

      private void btnReset_Click(object sender, EventArgs e)
      {
         calc.Reset();
         rtbReceipt.Clear();
         orderLog.Clear(); 
         selectedProduct = "";
         enteredQuantity = 0;
         lblPrompt.Text = "Enter a product:";

         txtAmountPaid.Text = "";          
         lblChange.Text = "Change: $0.00"; 
         lblPreview.Text = "";
      }

      private void btnCheckout_Click(object sender, EventArgs e)
      {
         if (decimal.TryParse(txtAmountPaid.Text, out decimal amountPaid))
         {
            decimal total = calc.GetTotal();
            decimal change = amountPaid - total;

            if (change < 0)
            {
               lblChange.Text = $"Amount Due: ${Math.Abs(change):F2}";
            }
            else
            {
               lblChange.Text = $"Change: ${change:F2}";
            }
         }
         else
         {
            MessageBox.Show("Please enter a valid payment amount.");
            txtAmountPaid.Focus();
         }
      }



   }
}
