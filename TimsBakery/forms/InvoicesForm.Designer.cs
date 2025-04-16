using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using TimsBakery.modules;

namespace TimsBakery.forms
{
   partial class InvoicesForm
   {

      private System.ComponentModel.IContainer components = null;

      
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      private void InitializeComponent()
      {

         //place this at beginning of initialized component
         this.rtbPreview = new RichTextBox();
         this.rtbPreview.Location = new Point(380, 65);
         this.rtbPreview.Size = new Size(350, 300);
         this.rtbPreview.ReadOnly = true;
         this.Controls.Add(this.rtbPreview);
         this.rtbPreview.BackColor = Color.White; // ← Add this line


         this.label1 = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.panel2 = new System.Windows.Forms.Panel();
         this.button1 = new System.Windows.Forms.Button();
         //this.button2 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();

         this.txtOrderID = new System.Windows.Forms.TextBox();
         this.txtProductID = new System.Windows.Forms.TextBox();
         this.txtQuantity = new System.Windows.Forms.TextBox();
         this.txtUnitPrice = new System.Windows.Forms.TextBox();

         this.panel2.SuspendLayout();
         this.SuspendLayout();

         // label1
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
         this.label1.Location = new System.Drawing.Point(250, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(242, 39);
         this.label1.TabIndex = 0;
         this.label1.Text = "Invoice Manager";

         // panel1
         this.panel1.Location = new System.Drawing.Point(12, 52);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(776, 351);
         this.panel1.TabIndex = 2;

         // Add fields to panel
         int y = 10;
         int spacing = 35;

         AddLabeledControl(panel1, "Order ID:", txtOrderID, 10, ref y, spacing);
         AddLabeledControl(panel1, "Product ID:", txtProductID, 10, ref y, spacing);
         AddLabeledControl(panel1, "Quantity:", txtQuantity, 10, ref y, spacing);
         AddLabeledControl(panel1, "Unit Price:", txtUnitPrice, 10, ref y, spacing);

         // panel2 (Buttons)
         this.panel2.Controls.Add(this.button3);
         this.panel2.Controls.Add(this.button1);
         //this.panel2.Controls.Add(this.button2);
         this.panel2.Location = new System.Drawing.Point(12, 409);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(776, 29);
         this.panel2.TabIndex = 3;

         // button1
         this.button1.Location = new System.Drawing.Point(184, 3);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 1;
         this.button1.Text = "SUBMIT";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new EventHandler(this.btnSubmit_Click);

         //// button2
         //this.button2.Location = new System.Drawing.Point(350, 3);
         //this.button2.Name = "button2";
         //this.button2.Size = new System.Drawing.Size(75, 23);
         //this.button2.TabIndex = 4;
         //this.button2.Text = "CANCEL";
         //this.button2.UseVisualStyleBackColor = true;

         // button3
         this.button3.Location = new System.Drawing.Point(320, 3);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(75, 23);
         this.button3.TabIndex = 5;
         this.button3.Text = "CLEAR";
         this.button3.UseVisualStyleBackColor = true;
         this.button3.Click += new EventHandler(this.btnClear_Click);

         // InvoicesForm
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.label1);
         this.BackColor = System.Drawing.Color.FromArgb(200, 230, 255);
         this.Name = "InvoicesForm";
         this.Text = "InvoicesForm";
         this.panel2.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

         // place this after form configs
         this.txtOrderID.TextChanged += (s, e) => UpdatePreview();
         this.txtProductID.TextChanged += (s, e) => UpdatePreview();
         this.txtQuantity.TextChanged += (s, e) => UpdatePreview();
         this.txtUnitPrice.TextChanged += (s, e) => UpdatePreview();

      }

      private void btnSubmit_Click(object sender, EventArgs e)
      {
         if (!FormValidator.ValidateRequiredFields(panel1))
            return;

      }

      private void btnClear_Click(object sender, EventArgs e)
      {
         FormClear.ResetFields(panel1);  // or 'this' to clear the whole form
         MessageBox.Show("Form cleared!", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }


      private void UpdatePreview()
      {
         rtbPreview.Text =
            $"Order ID: {txtOrderID.Text}\n" +
            $"Product ID: {txtProductID.Text}\n" +
            $"Quantity: {txtQuantity.Text}\n" +
            $"Unit Price: {txtUnitPrice.Text}";
      }

      // Shared alignment method
      private void AddLabeledControl(Panel panel, string labelText, Control control, int x, ref int y, int spacing)
      {
         Label label = new Label();
         label.Text = labelText;
         label.Location = new Point(x, y);
         label.Width = 120;

         control.Location = new Point(x + 130, y);
         control.Width = 200;

         panel.Controls.Add(label);
         panel.Controls.Add(control);

         y += spacing;
      }


      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel panel2;
      //private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button3;

      private System.Windows.Forms.TextBox txtOrderID;
      private System.Windows.Forms.TextBox txtProductID;
      private System.Windows.Forms.TextBox txtQuantity;
      private System.Windows.Forms.TextBox txtUnitPrice;
      private System.Windows.Forms.RichTextBox rtbPreview;
   }

}