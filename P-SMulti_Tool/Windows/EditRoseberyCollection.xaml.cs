using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace P_SMulti_Tool.Windows
{
    /// <summary>
    /// Interaction logic for EditRoseberyCollection.xaml
    /// </summary>
    public partial class EditRoseberyCollection : Window
    {
        public AuctionCollectionModel toEdit;

        public EditRoseberyCollection(AuctionCollectionModel toEdit)
        {
            InitializeComponent();

            this.toEdit = toEdit;

            Set_Collection_Model_Data(toEdit);
        }

        private void Set_Collection_Model_Data(AuctionCollectionModel toEdit)
        {
            NameInput.Text = toEdit.Name;
            JobNumberInput.Text = toEdit.JobNumber;
            LotNumberInput.Text = toEdit.LotNumber;
            DateOfSaleInput.Text = toEdit.DateOfSale;
            DescriptionInput.Text = toEdit.Description;
            DateOfSaleInput.Text = toEdit.DateOfSale;
 
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            NameInput.Text = toEdit.Name;
            JobNumberInput.Text = toEdit.JobNumber;
            LotNumberInput.Text = toEdit.LotNumber;
            DateOfSaleInput.Text = toEdit.DateOfSale;
            DescriptionInput.Text = toEdit.Description;
            DateOfSaleInput.Text = toEdit.DateOfSale;

             string message = Convert.ToString(SQLiteDataAccess.ReturnCollectionKey(toEdit));

            MessageBox.Show(message);

            Close();
        }
    }
}
