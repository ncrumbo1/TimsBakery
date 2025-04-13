using System.Drawing;
using System.Windows.Forms;

namespace TimsBakery.forms
{
   partial class ReportsForm
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
         this.label1 = new System.Windows.Forms.Label();
         this.panelMain = new System.Windows.Forms.Panel();
         this.panelList = new System.Windows.Forms.Panel();

         this.lblOrdersReport = new System.Windows.Forms.Label();
         this.lblTransactionsReport = new System.Windows.Forms.Label();
         this.lblCustomersReport = new System.Windows.Forms.Label();
         this.lblProductsReport = new System.Windows.Forms.Label();
         this.lblInventoryReport = new System.Windows.Forms.Label();
         this.lblEmployeesReport = new System.Windows.Forms.Label();

         this.SuspendLayout();

         // Title Label
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
         this.label1.Location = new System.Drawing.Point(250, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(270, 39);
         this.label1.TabIndex = 0;
         this.label1.Text = "Reports Dashboard";

         // Main Panel
         this.panelMain.Location = new System.Drawing.Point(12, 60);
         this.panelMain.Name = "panelMain";
         this.panelMain.Size = new System.Drawing.Size(776, 360);
         this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
         this.panelMain.TabIndex = 1;

         // List Panel for clickable links
         this.panelList.Location = new System.Drawing.Point(20, 10);
         this.panelList.Name = "panelList";
         this.panelList.Size = new System.Drawing.Size(300, 300);
         this.panelList.TabIndex = 2;

         // Add clickable labels (link-style)
         SetupClickableLabel(lblOrdersReport, "Daily Orders Report", new Point(10, 10));
         SetupClickableLabel(lblTransactionsReport, "Transactions Report", new Point(10, 50));
         SetupClickableLabel(lblCustomersReport, "Customer Directory", new Point(10, 90));
         SetupClickableLabel(lblProductsReport, "Product List", new Point(10, 130));
         SetupClickableLabel(lblInventoryReport, "Inventory Stock Report", new Point(10, 170));
         SetupClickableLabel(lblEmployeesReport, "Employee Roster", new Point(10, 210));

         // Add all to list panel
         this.panelList.Controls.Add(lblOrdersReport);
         this.panelList.Controls.Add(lblTransactionsReport);
         this.panelList.Controls.Add(lblCustomersReport);
         this.panelList.Controls.Add(lblProductsReport);
         this.panelList.Controls.Add(lblInventoryReport);
         this.panelList.Controls.Add(lblEmployeesReport);

         // Add to main report panel
         this.panelMain.Controls.Add(this.panelList);

         // Add all to form
         this.Controls.Add(this.label1);
         this.Controls.Add(this.panelMain);

         // ReportsForm
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Name = "ReportsForm";
         this.Text = "ReportsForm";
         this.ResumeLayout(false);
         this.PerformLayout();
      }

      // Link setup utility
      private void SetupClickableLabel(Label label, string text, Point location)
      {
         label.Text = text;
         label.ForeColor = Color.Blue;
         label.Font = new Font("Segoe UI", 10, FontStyle.Underline);
         label.Cursor = Cursors.Hand;
         label.AutoSize = true;
         label.Location = location;
         // Placeholder for click event:
         label.Click += (s, e) => MessageBox.Show($"'{text}' clicked.");
      }



      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button3;

      private System.Windows.Forms.Panel panelMain;
      private System.Windows.Forms.Panel panelList;
      private System.Windows.Forms.Label lblOrdersReport;
      private System.Windows.Forms.Label lblTransactionsReport;
      private System.Windows.Forms.Label lblCustomersReport;
      private System.Windows.Forms.Label lblProductsReport;
      private System.Windows.Forms.Label lblInventoryReport;
      private System.Windows.Forms.Label lblEmployeesReport;


   }

}