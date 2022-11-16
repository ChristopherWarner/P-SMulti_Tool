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
        public EditRoseberyCollection(AuctionCollectionModel toEdit)
        {
            InitializeComponent();

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
    }
}
