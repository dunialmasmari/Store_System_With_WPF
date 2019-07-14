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
using System.Data.SqlClient;

namespace StoreWPF1.PL
{
    /// <summary>
    /// Interaction logic for Reportform.xaml
    /// </summary>
    public partial class Reportform : Window
    {
       
        SqlConnection con = new SqlConnection();
       
        public Reportform()
        {
         
            InitializeComponent();
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (purchase1.IsChecked==true)
                {
                    
                    if (txt1.Text == "")
                    {

                        MessageBox.Show("لايمكن ان تكون احد الحقول فارغة");

                    }
                    else
                    {
                        reports f = new reports(txt1.Text);
                        b1.Content = "pp";
                        f.Show();

                    }

                
                
            }
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            reports f = new reports(txt1.Text);
            b2.Content = "pp";
            f.Show();
        }
    }
}
