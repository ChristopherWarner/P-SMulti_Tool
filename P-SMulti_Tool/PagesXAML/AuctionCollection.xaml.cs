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
    /// Interaction logic for AuctionCollection.xaml
    /// </summary>
    public partial class AuctionCollection : Page
    {
        

        public AuctionCollection()
        {
            InitializeComponent();

            List<ObjectModels.AuctioneerModel> ToDisplay = SQLiteDataAccess.LoadAuctioneers();
            AuctionHouseCB.ItemsSource = ToDisplay;
            


        }


        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            
            ObjectModels.AuctioneerModel selected = (ObjectModels.AuctioneerModel)AuctionHouseCB.SelectedItem;


            AuctionCollectionModel.CreateAuctionCollection(JobNumberTB.Text, ClientNameTB.Text, DescriptionTB.Text, false, DateTime.Now, DateTime.MinValue, LotNumber.Text, DateOfSaleTB.Text, selected);

            PagesXAML.XAMLhelper.ClearTextBoxes(AuctionCollectionGrid);
       
        }
    }
}
