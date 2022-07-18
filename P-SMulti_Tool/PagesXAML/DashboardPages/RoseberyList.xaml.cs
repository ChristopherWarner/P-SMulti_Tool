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
using System.Collections.ObjectModel;



namespace P_SMulti_Tool.PagesXAML.DashboardPages
{
    /// <summary>
    /// Interaction logic for RoseberyList.xaml
    /// </summary>
    public partial class RoseberyList : Page
    {
        public RoseberyList()
        {
            InitializeComponent();

            List<AuctionCollectionModel> toConvert = SQLiteDataAccess.LoadAuctionCollections();
            ObservableCollection<AuctionCollectionModel> myCollection = new ObservableCollection<AuctionCollectionModel>(toConvert);
            
            string count = Convert.ToString(myCollection.Count);
            MessageBox.Show(count);

            for (int i = 0 ; i < toConvert.Count; i++)
            {
                RoseGrid.Items.Add(toConvert[i]);
            }
           
            
           

        }

    }
}
