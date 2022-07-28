using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace P_SMulti_Tool.Windows
{
    /// <summary>
    /// Interaction logic for AddToRosebery.xaml
    /// </summary>
    public partial class AddToRosebery : Window
    {
        public AddToRosebery()
        {
            InitializeComponent();

            int[] comboBox = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            for (int i = 0; i < comboBox.Length; i++)
            {
                NumberOfLots.Items.Add(comboBox[i]);
            }


        }
     
    }
   
}
