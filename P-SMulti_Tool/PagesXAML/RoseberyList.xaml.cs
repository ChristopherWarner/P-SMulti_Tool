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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace P_SMulti_Tool.PagesXAML
{
    /// <summary>
    /// Interaction logic for RoseberyList.xaml
    /// </summary>
    public partial class RoseberyList : Page
    {
        public RoseberyList()
        {
            InitializeComponent();

            List<AuctionCollectionModel> roseberyCollections = SQLiteDataAccess.LoadAuctionCollections();

            //RoseGrid.ItemsSource = roseberyCollections;

        }

        private void RoseGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddToList_Click(object sender, RoutedEventArgs e)
        {
            Window addToList = new Windows.AddToRosebery();
            addToList.Show();
        }
    }
}
