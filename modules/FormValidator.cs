using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimsBakery.modules
{
   public static class FormValidator
   {
      public static bool ValidateRequiredFields(Control container)
      {
         foreach (Control control in container.Controls)
         {
            if (control is TextBox textBox)
            {
               if (string.IsNullOrWhiteSpace(textBox.Text))
               {
                  MessageBox.Show($"The field \"{GetName(textBox)}\" is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  textBox.Focus();
                  return false;
               }
            }

            if (control is ComboBox comboBox)
            {
               if (string.IsNullOrWhiteSpace(comboBox.Text) || comboBox.SelectedIndex == -1)
               {
                  MessageBox.Show($"Please select a value for \"{GetName(comboBox)}\".", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  comboBox.Focus();
                  return false;
               }
            }
         }
         return true;
      }

      private static string GetName(Control control)
      {
         string name = control.Name;
         name = name.Replace("txt", "").Replace("cmb", "").Replace("ddl", "");
         return System.Text.RegularExpressions.Regex.Replace(name, "(\\B[A-Z])", " $1").Trim();
      }

   }
}
