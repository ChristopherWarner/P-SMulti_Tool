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
        public delegate void RefreshList();

        public event RefreshList RefreshListEvent;

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

        private void UpdateRoseberyGrid()
        {
            RoseList.ItemsSource = null;
            PopulateDataGrid();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Windows.AddToRosebery addToList = new Windows.AddToRosebery();
            RefreshListEvent += new RefreshList(UpdateRoseberyGrid);
            addToList.UpdateRoseberyGrid = RefreshListEvent;
            addToList.Show();
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
           
            foreach (AuctionCollectionModel toDelete in RoseList.SelectedItems)
            {
                SQLiteDataAccess.RemoveAuctionCollection(toDelete);
            }

            UpdateRoseberyGrid();
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            //export to Excel document
            // save list to record of lists
            //
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (RoseList.SelectedItems.Count == 1)
            { 
                foreach(AuctionCollectionModel toEdit in RoseList.SelectedItems)
                {
                    Window roseberyCollectionEdit = new Windows.EditRoseberyCollection(toEdit);
                    roseberyCollectionEdit.Show();
                }
            }
            else
            {
                MessageBox.Show("Only one record can be modified at a time");
            }
        }

        private void PreviousLists_Click(object sender, RoutedEventArgs e)
        {
            
        } 
    }
}
