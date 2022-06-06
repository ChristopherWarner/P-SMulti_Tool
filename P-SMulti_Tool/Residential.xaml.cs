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
    /// Interaction logic for Residential.xaml
    /// </summary>
    public partial class Residential : Page
    {
        public Residential()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            //Type type = typeof(ResidentialCollectionModel);
            //int fieldCount = type.GetProperties().Length;

            //string[] details = new string[fieldCount];

            // deatils block to be passed to Res collection constructor

            string jobnumber;
            string name;
            string description;
            bool collected = false;
            DateTime createdate = DateTime.Now;
            DateTime? collectedon = null;
            string address1;
            string address2;
            string postcode;
            string contactnumber;
        }
    }
}
