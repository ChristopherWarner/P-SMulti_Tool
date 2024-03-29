﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Rosebery_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new PagesXAML.RoseberyCollections();
        }

        private void Residential_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new PagesXAML.ResidentialCollections();
        }

        private void Auction_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new PagesXAML.AuctionCollections();
        }

        private void Overview_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new PagesXAML.Overview();
        }
        private void ShowPreviousRoseberyLists()
        {
            Main.Content = new PagesXAML.Overview();
        }
    }
}
