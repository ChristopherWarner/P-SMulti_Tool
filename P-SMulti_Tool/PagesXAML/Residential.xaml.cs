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
            ResidentialCollectionModel.CreateResidentialCollection(JobNumberTB.Text, NameTB.Text, DescriptionTB.Text, false, DateTime.Now, DateTime.MinValue, Address1TB.Text, Address2TB.Text, PostCodeTB.Text, ContactNumberTB.Text);

            PagesXAML.XAMLhelper.ClearTextBoxes(ResidentialGrid);

            
        }

    }
}
