﻿using System.Drawing;
using System.Windows.Forms;

namespace TimsBakery.forms
{
   partial class RegisterForm
   {
      private System.ComponentModel.IContainer components = null;

      //private System.Windows.Forms.Label lblPreview;
      //private System.Windows.Forms.Label lblPrompt;

      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      private void InitializeComponent()
      {
         this.lblTitle = new Label();
         this.panelReceipt = new Panel();
         this.rtbReceipt = new RichTextBox();
         this.panelProducts = new Panel();
         this.panelNumpad = new Panel();
         this.panelCalc = new Panel();
         this.panelBottom = new Panel();

         this.txtAmountPaid = new TextBox();
         this.lblSubtotal = new Label();
         this.lblTax = new Label();
         this.lblLoyalty = new Label();
         this.lblTotal = new Label();
         this.lblChange = new Label();

         this.btnSubtotal = new Button();
         this.btnCheckout = new Button();
         this.btnReset = new Button();

         this.btnClear = new Button();
         this.btnBackspace = new Button();
         this.btnAddItem = new Button();

         // Add product buttons
         this.btnCoffee = CreateProductButton("Coffee", 0);
         this.btnDonut = CreateProductButton("Latte", 1);
         this.btnCookie = CreateProductButton("Iced Coffee", 2);
         this.btnMuffin = CreateProductButton("Muffin", 0, 1);
         this.btnBagel = CreateProductButton("Bagel", 1, 1);
         this.btnLatte = CreateProductButton("Croissant", 2, 1);
         this.btnCroissant = CreateProductButton("Donut", 0, 2);
         this.btnIcedCoffee = CreateProductButton("Cookie", 1, 2);

         // lblPrompt - shows the current instruction

         this.SuspendLayout();

         // Title
         this.lblTitle.Text = "Register";
         this.lblTitle.Font = new Font("Segoe UI", 24, FontStyle.Bold);
         this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
         this.lblTitle.Dock = DockStyle.Top;
         this.lblTitle.Height = 60;



         // Add this label to panelReceipt
         this.lblPrompt = new System.Windows.Forms.Label();
         this.lblPrompt.Text = "Enter a Product:";
         this.lblPrompt.Font = new System.Drawing.Font("Segoe UI", 11F);
         this.lblPrompt.ForeColor = System.Drawing.Color.MidnightBlue;
         this.lblPrompt.Location = new System.Drawing.Point(5, 5);  // inside panelProducts
         this.lblPrompt.Size = new System.Drawing.Size(200, 25);
         //this.lblPrompt.BackColor = System.Drawing.Color.White;
         this.panelReceipt.Controls.Add(this.lblPrompt);

         // Preview label (shows selected product, quantity, etc.)
         this.lblPreview = new System.Windows.Forms.Label();
         this.lblPreview.Text = "";
         this.lblPreview.Font = new System.Drawing.Font("Segoe UI", 10F);
         this.lblPreview.ForeColor = System.Drawing.Color.DarkSlateGray;
         //this.lblPreview.BackColor = System.Drawing.Color.White;
         this.lblPreview.Location = new System.Drawing.Point(5, 30); // directly below lblPrompt
         this.lblPreview.Size = new System.Drawing.Size(250, 20);
         this.panelReceipt.Controls.Add(this.lblPreview); // same panel as lblPrompt

         // Receipt Panel
         this.panelReceipt.Location = new Point(20, 80);
         this.panelReceipt.Size = new Size(350, 300);
         this.panelReceipt.BorderStyle = BorderStyle.FixedSingle;
         //this.rtbReceipt.Dock = DockStyle.Fill;

         this.rtbReceipt.Location = new Point(5, 55);
         this.rtbReceipt.Size = new Size(340, 240);  // Adjust if needed

         this.rtbReceipt.Font = new Font("Consolas", 10);
         this.panelReceipt.Controls.Add(this.rtbReceipt);

         // Product Button Panel
         this.panelProducts.Location = new Point(400, 82);
         this.panelProducts.Size = new Size(350, 120);
         this.panelProducts.BorderStyle = BorderStyle.FixedSingle;

         this.panelProducts.Controls.AddRange(new Control[] {
         btnCoffee, btnDonut, btnCookie, btnMuffin,
         btnBagel, btnLatte, btnCroissant, btnIcedCoffee
   });

         // Numpad Panel
         this.panelNumpad.Location = new Point(400, 218);
         this.panelNumpad.Size = new Size(350, 162);
         this.panelNumpad.BorderStyle = BorderStyle.FixedSingle;

         numpadButtons = new Button[10];
         int btnSize = 40;
         int btnSpacing = 0;

         for (int i = 1; i <= 9; i++)
         {
            numpadButtons[i] = new Button();
            numpadButtons[i].Text = i.ToString();
            numpadButtons[i].Size = new Size(btnSize, btnSize);
            numpadButtons[i].Font = new Font("Segoe UI", 12);
            numpadButtons[i].Location = new Point(((i - 1) % 3) * (btnSize + btnSpacing), ((i - 1) / 3) * (btnSize + btnSpacing));
            this.panelNumpad.Controls.Add(numpadButtons[i]);
         }

         numpadButtons[0] = new Button();
         numpadButtons[0].Text = "0";
         numpadButtons[0].Size = new Size(btnSize, btnSize);
         numpadButtons[0].Font = new Font("Segoe UI", 12);
         numpadButtons[0].Location = new Point(0, 3 * (btnSize + btnSpacing));
         this.panelNumpad.Controls.Add(numpadButtons[0]);

         this.btnClear.Text = "C";
         this.btnBackspace.Text = "←";
         this.btnAddItem.Text = "+";

         Button[] extraBtns = { btnClear, btnBackspace, btnAddItem };
         for (int i = 0; i < 3; i++)
         {
            extraBtns[i].Size = new Size(btnSize, btnSize);
            extraBtns[i].Font = new Font("Segoe UI", 12);
            extraBtns[i].Location = new Point((i + 1) * (btnSize + btnSpacing), 3 * (btnSize + btnSpacing));
            this.panelNumpad.Controls.Add(extraBtns[i]);
         }

         // Calculation Panel
         this.panelCalc.Location = new Point(20, 390);
         this.panelCalc.Size = new Size(750, 80);

         SetupCalcLabel(lblSubtotal, "Subtotal: $0.00", 10, 10);
         SetupCalcLabel(lblTax, "Tax: $0.00", 190, 10);
         SetupCalcLabel(lblLoyalty, "Loyalty: $0.00", 370, 10);
         SetupCalcLabel(lblTotal, "Total: $0.00", 550, 10);

         Label lblPaid = new Label();
         lblPaid.Text = "Paid:";
         lblPaid.Location = new Point(10, 45);
         lblPaid.Size = new Size(50, 23);
         this.txtAmountPaid.Location = new Point(60, 45);
         this.txtAmountPaid.Size = new Size(100, 23);

         this.lblChange.Text = "Change: $0.00";
         this.lblChange.Location = new Point(190, 45);
         this.lblChange.Size = new Size(150, 23);
         this.lblChange.Font = new Font("Segoe UI", 10, FontStyle.Bold);

         this.panelCalc.Controls.AddRange(new Control[] {
         lblSubtotal, lblTax, lblLoyalty, lblTotal,
         lblPaid, txtAmountPaid, lblChange
   });

         // Bottom Buttons
         this.panelBottom.Location = new Point(20, 480);
         this.panelBottom.Size = new Size(750, 40);

         this.btnSubtotal.Text = "Subtotal";
         this.btnCheckout.Text = "Checkout";
         this.btnReset.Text = "Clear";

         Button[] bottomButtons = { btnSubtotal, btnCheckout, btnReset };
         for (int i = 0; i < 3; i++)
         {
            bottomButtons[i].Size = new Size(100, 30);
            bottomButtons[i].Font = new Font("Segoe UI", 10);
            bottomButtons[i].Location = new Point(i * 120, 5);
            this.panelBottom.Controls.Add(bottomButtons[i]);
         }

         // Add to form
         this.Controls.Add(this.lblTitle);
         this.Controls.Add(this.panelReceipt);
         this.Controls.Add(this.panelProducts);
         this.Controls.Add(this.panelNumpad);
         this.Controls.Add(this.panelCalc);
         this.Controls.Add(this.panelBottom);

         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 530);
         this.BackColor = System.Drawing.Color.FromArgb(200, 230, 255);
         this.Name = "RegisterForm";
         this.Text = "RegisterForm";
         this.ResumeLayout(false);
      }


      private void SetupCalcLabel(Label label, string text, int x, int y)
      {
         label.Text = text;
         label.Location = new Point(x, y);
         label.Size = new Size(130, 23);
         label.Font = new Font("Segoe UI", 10);
      }

      private Button CreateProductButton(string text, int col, int row = 0)
      {
         int buttonWidth = 85;
         int buttonHeight = 30;
         int spacing = 5;
         int totalRows = 2;

         int baseY = panelProducts.Height - (totalRows * (buttonHeight + spacing));

         return new Button()
         {
            Text = text,
            Size = new Size(buttonWidth, buttonHeight),
            Font = new Font("Segoe UI", 9),
            Location = new Point(5 + col * 90, 5 + row * 35)
         };
      }

      private Label lblTitle;
      private Panel panelReceipt, panelProducts, panelNumpad, panelCalc, panelBottom;
      private RichTextBox rtbReceipt;
      private Button[] numpadButtons;
      private Button btnClear, btnBackspace, btnAddItem;
      private Label lblSubtotal, lblTax, lblLoyalty, lblTotal, lblChange;
      private TextBox txtAmountPaid;
      private Button btnSubtotal, btnCheckout, btnReset;
      private Button btnCoffee, btnDonut, btnCookie;
      private Button btnMuffin, btnBagel, btnLatte;
      private Button btnCroissant, btnIcedCoffee;

      private System.Windows.Forms.Label lblPrompt;
      private System.Windows.Forms.Label lblPreview;
   }
}