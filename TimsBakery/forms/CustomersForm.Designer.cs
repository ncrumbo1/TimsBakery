﻿using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace TimsBakery.forms
{
   partial class CustomersForm
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

         // Customer fields
         this.txtFirstName = new System.Windows.Forms.TextBox();
         this.txtLastName = new System.Windows.Forms.TextBox();
         this.txtAddress = new System.Windows.Forms.TextBox();
         this.txtCity = new System.Windows.Forms.TextBox();
         this.cmbState = new System.Windows.Forms.ComboBox();
         this.txtZip = new System.Windows.Forms.TextBox();
         this.txtPhone = new System.Windows.Forms.TextBox();
         this.txtEmail = new System.Windows.Forms.TextBox();
         this.cmbLoyalty = new System.Windows.Forms.ComboBox();

         this.panel2.SuspendLayout();
         this.SuspendLayout();

         // label1
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
         this.label1.Location = new System.Drawing.Point(250, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(295, 39);
         this.label1.TabIndex = 0;
         this.label1.Text = "Customer Manager";

         // panel1 (Main content area)
         this.panel1.Location = new System.Drawing.Point(12, 52);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(776, 351);
         this.panel1.TabIndex = 2;

         // Labels & Controls added manually
         int y = 10;
         int spacing = 35;

         AddLabeledControl(panel1, "First Name:", txtFirstName, 10, ref y, spacing);
         AddLabeledControl(panel1, "Last Name:", txtLastName, 10, ref y, spacing);
         AddLabeledControl(panel1, "Address:", txtAddress, 10, ref y, spacing);
         AddLabeledControl(panel1, "City:", txtCity, 10, ref y, spacing);
         AddLabeledControl(panel1, "State:", cmbState, 10, ref y, spacing);
         AddLabeledControl(panel1, "ZIP Code:", txtZip, 10, ref y, spacing);
         AddLabeledControl(panel1, "Phone:", txtPhone, 10, ref y, spacing);
         AddLabeledControl(panel1, "Email:", txtEmail, 10, ref y, spacing);
         AddLabeledControl(panel1, "Loyalty Level:", cmbLoyalty, 10, ref y, spacing);

         // panel2 (Button panel)
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

         // CustomerForm (Form config)
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.label1);
         this.Name = "CustomerForm";
         this.Text = "CustomerForm";
         this.panel2.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

         this.txtFirstName.TextChanged += (s, e) => UpdatePreview();
         this.txtLastName.TextChanged += (s, e) => UpdatePreview();
         this.txtEmail.TextChanged += (s, e) => UpdatePreview();
         // etc...


      }

      // Utility method to add a label + control pair
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

      private void UpdatePreview()
      {
         rtbPreview.Text =
            $"Name: {txtFirstName.Text} {txtLastName.Text}\n" +
            $"Email: {txtEmail.Text}\n" +
         $"Phone: {txtPhone.Text}\n" +
            $"Address: {txtAddress.Text}, {txtCity.Text}, {cmbState.Text} {txtZip.Text}";
      }


      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button3;

      // Customer form controls
      private System.Windows.Forms.TextBox txtFirstName;
      private System.Windows.Forms.TextBox txtLastName;
      private System.Windows.Forms.TextBox txtAddress;
      private System.Windows.Forms.TextBox txtCity;
      private System.Windows.Forms.ComboBox cmbState;
      private System.Windows.Forms.TextBox txtZip;
      private System.Windows.Forms.TextBox txtPhone;
      private System.Windows.Forms.TextBox txtEmail;
      private System.Windows.Forms.ComboBox cmbLoyalty;
      private System.Windows.Forms.RichTextBox rtbPreview;

   }

}