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

            PopulateDataGrid();

        }

        private void PopulateDataGrid()
        {
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
           
            foreach (AuctionCollectionModel toDelete in RoseList.SelectedItems)
            {
                SQLiteDataAccess.RemoveAuctionCollection(toDelete);
            }
            
            
            RoseList.ItemsSource = null;
            PopulateDataGrid();
          
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            //export to Excel document
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Window roseberyCollectionEdit = new Windows.EditRoseberyCollection();
            roseberyCollectionEdit.Show();
        }

        private void PreviousLists_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
