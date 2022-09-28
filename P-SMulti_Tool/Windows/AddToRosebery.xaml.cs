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
        public static List<UserControls.UserControl1> Items = new List<UserControls.UserControl1>();
        
        public AddToRosebery()
        {
            InitializeComponent();
            AddToList(StaticControl);
        }

        private static void AddToList(UserControls.UserControl1 Passed)
        {
            Items.Add(Passed);
        }

        private void Add_Item_Click(object sender, RoutedEventArgs e)
        {
            UserControls.UserControl1 toAdd = new UserControls.UserControl1();
            ItemsStackPanel.Children.Add(toAdd);
            AddToList(toAdd);
        }

        private void Add_Items_To_List(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < Items.Count; i++)
            {
                AuctionCollectionModel.CreateAuctionCollection(JobNumberInput.Text, ClientNameInput.Text, Items[i].DescriptionInput.Text, false, DateTime.Now, DateTime.MinValue, Items[i].LotNumInput.Text, Items[i].DateOfSaleInput.Text, "Rosebery", 0);
            }
            Items.Clear();
            Close();
        }
    }
}
