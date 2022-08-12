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

namespace P_SMulti_Tool.UserControls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public List<string> ReturnDetails(UserControl1 Passed)
        {
            List<string> Details = new List<string>();

            string convertedLotNum = Convert.ToString(Passed.LotNumInput);
            string convertedDescription = Convert.ToString(Passed.Description);
            string convertedDateOfSale = Convert.ToString(Passed.DateOfSaleInput);

            Details.Add(convertedLotNum);
            Details.Add(convertedDescription);
            Details.Add(convertedDateOfSale);

            return Details;
        }
    }
}
