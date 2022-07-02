using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows;

namespace P_SMulti_Tool.PagesXAML
{
    public class XAMLhelper
    {
        public static void ClearTextBoxes(Grid gridname)
        {
            foreach (UIElement control in gridname.Children)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    TextBox txtBox = (TextBox)control;
                    txtBox.Text = null;
                }
            }
        }
    }
}
