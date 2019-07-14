using System;
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
using System.Windows.Shapes;

namespace StoreWPF1.PL
{
    /// <summary>
    /// Interaction logic for items.xaml
    /// </summary>
    public partial class items : Window
    {
        BL.clsproduct prd = new BL.clsproduct();
        public items()
        {
            InitializeComponent();
            this.DataGrid1.AutoGenerateColumns = false;
            this.DataGrid1.DataContext= prd.Get_All_Product();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
