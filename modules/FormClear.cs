using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimsBakery.modules
{
    public static class FormClear
    {

      public static void ResetFields(Control container)
      {
         foreach (Control control in container.Controls)
         {
            if (control is TextBox txt)
            {
               txt.Clear();
            }
            else if (control is ComboBox cmb)
            {
               cmb.SelectedIndex = -1;
            }
            else if (control.HasChildren)
            {
               // Recursively clear nested containers (like panels inside panels)
               ResetFields(control);
            }
         }
      }


    }
}
