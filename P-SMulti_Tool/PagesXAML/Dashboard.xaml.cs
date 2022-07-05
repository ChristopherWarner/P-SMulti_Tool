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

namespace P_SMulti_Tool
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        public Dashboard()
        {
            InitializeComponent();
            
        }

        private void RoseberyList_Click(object sender, RoutedEventArgs e)
        {
            DashboardFrame.Content = new PagesXAML.DashboardPages.RoseberyList();
        }

        private void OtherAuctionList_Click(object sender, RoutedEventArgs e)
        {
            DashboardFrame.Content = new PagesXAML.DashboardPages.OtherAuctionCollections();
        }

        private void ArangingRequired_Click(object sender, RoutedEventArgs e)
        {
            DashboardFrame.Content = new PagesXAML.DashboardPages.Unarranged();
        }

        private void PastCollections_Click(object sender, RoutedEventArgs e)
        {
            DashboardFrame.Content = new PagesXAML.DashboardPages.PreviousCollections();
        }
    }
}
