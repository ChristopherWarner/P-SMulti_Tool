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

            List<AuctionCollectionModel> toDisplay = SQLiteDataAccess.ReturnRoseberyList();

            for (int i = 0; i < toDisplay.Count; i++)
            {
                RoseberyGrid.Items.Add(toDisplay[i]);
            }

        }
    }
}
