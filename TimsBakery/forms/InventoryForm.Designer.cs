using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace TimsBakery.forms
{
   partial class InventoryForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      /// 


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
         this.button2 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();

         this.cmbProductID = new System.Windows.Forms.ComboBox();
         this.cmbStoreID = new System.Windows.Forms.ComboBox();
         this.txtQuantity = new System.Windows.Forms.TextBox();
         this.txtInventoryUpdate = new System.Windows.Forms.TextBox();

         this.panel2.SuspendLayout();
         this.SuspendLayout();

         // label1
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
         this.label1.Location = new System.Drawing.Point(250, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(243, 39);
         this.label1.TabIndex = 0;
         this.label1.Text = "Inventory Panel";

         // panel1
         this.panel1.Location = new System.Drawing.Point(12, 52);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(776, 351);
         this.panel1.TabIndex = 2;

         // Add fields to panel1
         int y = 10;
         int spacing = 35;

         AddLabeledControl(panel1, "Product ID:", cmbProductID, 10, ref y, spacing);
         AddLabeledControl(panel1, "Store ID:", cmbStoreID, 10, ref y, spacing);
         AddLabeledControl(panel1, "Quantity:", txtQuantity, 10, ref y, spacing);
         AddLabeledControl(panel1, "Last Updated:", txtInventoryUpdate, 10, ref y, spacing);

         // panel2 (Buttons)
         this.panel2.Controls.Add(this.button3);
         this.panel2.Controls.Add(this.button1);
         this.panel2.Controls.Add(this.button2);
         this.panel2.Location = new System.Drawing.Point(12, 409);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(776, 29);
         this.panel2.TabIndex = 3;

         // button1 - SAVE
         this.button1.Location = new System.Drawing.Point(184, 3);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 1;
         this.button1.Text = "SAVE";
         this.button1.UseVisualStyleBackColor = true;

         // button2 - CANCEL
         this.button2.Location = new System.Drawing.Point(350, 3);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(75, 23);
         this.button2.TabIndex = 4;
         this.button2.Text = "CANCEL";
         this.button2.UseVisualStyleBackColor = true;

         // button3 - DELETE
         this.button3.Location = new System.Drawing.Point(497, 3);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(75, 23);
         this.button3.TabIndex = 5;
         this.button3.Text = "DELETE";
         this.button3.UseVisualStyleBackColor = true;

         // InventoryForm
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.label1);
         this.Name = "InventoryForm";
         this.Text = "InventoryForm";
         this.panel2.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

         // place this after form configs
         this.cmbProductID.TextChanged += (s, e) => UpdatePreview();
         this.cmbStoreID.TextChanged += (s, e) => UpdatePreview();
         this.txtQuantity.TextChanged += (s, e) => UpdatePreview();
         this.txtInventoryUpdate.TextChanged += (s, e) => UpdatePreview();

      }

      private void UpdatePreview()
      {
         rtbPreview.Text =
            $"Product ID: {cmbProductID.Text}\n" +
            $"Store ID: {cmbStoreID.Text}\n" +
            $"Quantity: {txtQuantity.Text}\n" +
            $"Last Updated: {txtInventoryUpdate.Text}";
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
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button3;

      private System.Windows.Forms.ComboBox cmbProductID;
      private System.Windows.Forms.ComboBox cmbStoreID;
      private System.Windows.Forms.TextBox txtQuantity;
      private System.Windows.Forms.TextBox txtInventoryUpdate;
      private System.Windows.Forms.RichTextBox rtbPreview;

   }

}