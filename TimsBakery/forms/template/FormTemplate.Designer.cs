﻿namespace TimsBakery.forms.template
{
   partial class FormTemplate
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
      private void InitializeComponent()
      {
         this.label1 = new System.Windows.Forms.Label();
         this.button1 = new System.Windows.Forms.Button();
         this.panel1 = new System.Windows.Forms.Panel();
         this.panel2 = new System.Windows.Forms.Panel();
         this.button2 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.panel2.SuspendLayout();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(276, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(212, 39);
         this.label1.TabIndex = 0;
         this.label1.Text = "Tim\'s Bakery";
         //this.label1.Click += new System.EventHandler(this.label1_Click);
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(184, 3);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 1;
         this.button1.Text = "SAVE";
         this.button1.UseVisualStyleBackColor = true;
         // 
         // panel1
         // 
         this.panel1.Location = new System.Drawing.Point(12, 52);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(776, 351);
         this.panel1.TabIndex = 2;
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.button3);
         this.panel2.Controls.Add(this.button1);
         this.panel2.Controls.Add(this.button2);
         this.panel2.Location = new System.Drawing.Point(12, 409);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(776, 29);
         this.panel2.TabIndex = 3;
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(350, 3);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(75, 23);
         this.button2.TabIndex = 4;
         this.button2.Text = "CANCEL";
         this.button2.UseVisualStyleBackColor = true;
         // 
         // button3
         // 
         this.button3.Location = new System.Drawing.Point(497, 3);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(75, 23);
         this.button3.TabIndex = 5;
         this.button3.Text = "DELETE";
         this.button3.UseVisualStyleBackColor = true;
         // 
         // FormTemplate
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.label1);
         this.Name = "FormTemplate";
         this.Text = "FormTemplate";
         this.panel2.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button3;
   }
}