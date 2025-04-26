using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimsBakery.database;
using TimsBakery.forms;

namespace TimsBakery
{
   public partial class MainForm : Form
   {
      Panel panelMainDisplay;
      Panel panelMenu;

      public MainForm()
      {
         InitializeComponent(); // Will now work correctly
         InitializeLayout();


         // Test Database Connection
         TestDatabaseConnection();

         // Load Register Form by default
         LoadForm(new RegisterForm());

      }
      private void LoadForm(Form form)
      {
         panelMainDisplay.Controls.Clear();
         form.TopLevel = false;
         form.FormBorderStyle = FormBorderStyle.None;
         form.Dock = DockStyle.Fill;
         panelMainDisplay.Controls.Add(form);
         form.Show();
      }

      private void InitializeLayout()
      {
         this.Text = "Tim’s Bakery Point of Sale - Main Menu";
         this.Size = new Size(1000, 600);
         this.StartPosition = FormStartPosition.CenterScreen;

         // MAIN DISPLAY PANEL (LEFT SIDE)
         panelMainDisplay = new Panel();
         panelMainDisplay.Dock = DockStyle.Left;
         panelMainDisplay.Width = 750;
         panelMainDisplay.BackColor = Color.FromArgb(200, 230, 255);
         this.Controls.Add(panelMainDisplay);

         // MENU PANEL (RIGHT SIDE)
         panelMenu = new Panel();
         panelMenu.Dock = DockStyle.Right;
         panelMenu.Width = 200;
         panelMenu.BackColor = Color.FromArgb(255, 223, 186);

         this.Controls.Add(panelMenu);

         // MENU BUTTONS
         CreateSidebarButton("Register", Register_Click);
         CreateSidebarButton("Employees", Employees_Click);
         CreateSidebarButton("Customers", Customers_Click);
         CreateSidebarButton("Products", Products_Click);
         CreateSidebarButton("Invoices", Invoices_Click);
         CreateSidebarButton("Inventory", Inventory_Click);
         CreateSidebarButton("Reports", Reports_Click);
         CreateSidebarButton("Exit", Exit_Click);
      }




      private void CreateSidebarButton(string text, EventHandler onClick)
      {
         Button btn = new Button();
         btn.Text = text;
         btn.Dock = DockStyle.Top;
         btn.Height = 50;
         btn.FlatStyle = FlatStyle.Flat;
         btn.ForeColor = Color.White;
         btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
         btn.FlatAppearance.BorderSize = 0;
         btn.Click += onClick;

         panelMenu.Controls.Add(btn);
         panelMenu.Controls.SetChildIndex(btn, 0);
      }

      // Embedded Form Loader
      private void LoadFormIntoPanel(Form form)
      {
         panelMainDisplay.Controls.Clear();
         form.TopLevel = false;
         form.FormBorderStyle = FormBorderStyle.None;
         form.Dock = DockStyle.Fill;
         panelMainDisplay.Controls.Add(form);
         form.Show();
      }

      // Updated Event Handlers
      private void Register_Click(object sender, EventArgs e) => LoadFormIntoPanel(new RegisterForm());
      private void Employees_Click(object sender, EventArgs e) => LoadFormIntoPanel(new EmployeesForm());
      private void Customers_Click(object sender, EventArgs e) => LoadFormIntoPanel(new CustomersForm());
      private void Products_Click(object sender, EventArgs e) => LoadFormIntoPanel(new ProductsForm());
      private void Invoices_Click(object sender, EventArgs e) => LoadFormIntoPanel(new InvoicesForm());
      private void Inventory_Click(object sender, EventArgs e) => LoadFormIntoPanel(new InventoryForm());
      private void Reports_Click(object sender, EventArgs e) => LoadFormIntoPanel(new ReportsForm());
      private void Exit_Click(object sender, EventArgs e) => Application.Exit();





      private void TestDatabaseConnection()
      {
         using (MySqlConnection conn = Database.GetConnection())
         {
            try
            {
               conn.Open();
               MessageBox.Show("Database connection successful.");
            }
            catch (Exception ex)
            {
               MessageBox.Show("Database connection failed:\n" + ex.Message);
            }
         }
      }










   }
}

