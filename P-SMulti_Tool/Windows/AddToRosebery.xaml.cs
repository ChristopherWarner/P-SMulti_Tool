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
        public static List<UserControl> Items = new List<UserControl>();

        public AddToRosebery()
        {
            InitializeComponent();
            AddToList(StaticControl);
        }
        


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserControl toAdd = new UserControls.UserControl1();
            ItemsStackPanel.Children.Add(toAdd);
            AddToList(toAdd);
        }
        private static void AddToList(UserControl Passed)
        {
            Items.Add(Passed);
        }


    }

}
