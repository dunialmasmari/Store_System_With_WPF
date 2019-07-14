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
using System.Data;

namespace StoreWPF1.PL
{
    /// <summary>
    /// Interaction logic for Stockitem.xaml
    /// </summary>
    public partial class Stockitem : Window
    {
        public DataTable Get_All_stockitem()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_stockitem", null);
            DAL.Close();
            return Dt;


        }
        public Stockitem()
        {
            InitializeComponent();
            Datagrid1.AutoGenerateColumns = false;

            Datagrid1.DataContext= Get_All_stockitem();
        }
    }
}
