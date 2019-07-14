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
using System.Data.SqlClient;

namespace StoreWPF1.PL
{
    /// <summary>
    /// Interaction logic for crviewer.xaml
    /// </summary>
    public partial class crviewer : Window
    {
        SqlConnection con = new SqlConnection();
       
        public crviewer()
        {
            InitializeComponent();
       
        }

        private void CrystalReportsViewer_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        { 
            Report.salereport cr = new Report.salereport();
            cr.Load(@"salereport.rep");
            crviewr.ViewerCore.ReportSource = cr;
            
                 }
    }
}
