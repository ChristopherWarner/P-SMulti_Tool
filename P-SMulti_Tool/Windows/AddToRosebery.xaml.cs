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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBlock Added = new TextBlock();
            TextBox toAdd = new TextBox();
            toAdd.Text = "Item";
            Items.Children.Add(toAdd);

        }
    }
   
}
