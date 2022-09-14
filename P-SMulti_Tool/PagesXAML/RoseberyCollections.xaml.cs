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
    public partial class RoseberyCollections : Page
    {
        public RoseberyCollections()
        {
            InitializeComponent();

            List<AuctionCollectionModel> roseberyCollections = SQLiteDataAccess.LoadAuctionCollections();

            RoseList.ItemsSource = roseberyCollections;

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Window addToList = new Windows.AddToRosebery();
            addToList.Show();
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            
            List<AuctionCollectionModel> toRemove = new List<AuctionCollectionModel>();


            //Get collections and send to SQLite data access class
          
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            //export to word document
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            //bring up window to edit collection
        }

        private void PreviousLists_Click(object sender, RoutedEventArgs e)
        {
            //Bring up previous list window
        }
    }
}
