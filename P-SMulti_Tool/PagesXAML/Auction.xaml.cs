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
using System.Threading;

namespace P_SMulti_Tool
{
    /// <summary>
    /// Interaction logic for Auction.xaml
    /// </summary>
    public partial class Auction : Page
    {
        public Auction()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            ObjectModels.AuctioneerModel created = new ObjectModels.AuctioneerModel(NameTB.Text, RoadTB.Text, TownTB.Text, PostcodeTB.Text, ContactTB.Text, EmailTB.Text);
            SQLiteDataAccess.SaveAuctioneerModel(created);
            //implement an acutal save check inclusive of exception handling
            bool savecheck = true;

            if (savecheck == true)
            {
                Thread.Sleep(1000);
                MessageBox.Show("Save Sucessful");
            }

        }
    }
}
