﻿using System;
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

        private void AlreadyCollected_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click Registered0");
        }

        private void UpcomingCollections_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click Registered1");
        }

        private void NotArranged_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click Registered2");
        }

        private void AuctionCollections_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click Registered3");
        }
    }
}
