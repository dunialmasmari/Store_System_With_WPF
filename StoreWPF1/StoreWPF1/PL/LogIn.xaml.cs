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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace StoreWPF1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtid.Focus();
        }
        BL.clslogin log = new BL.clslogin();

            

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtpwd.Focus();
            }
        }

        private void txtpwd_KeyDown(object sender, KeyEventArgs e)
        {
            
            }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (txtid.Text == "" || txtpwd.Password == "")
            {
                MessageBox.Show("Please fill the boxes..");
            }
            else
            {

                DataTable Dt = log.LOGIN(txtid.Text, txtpwd.Password);
                if (Dt.Rows.Count > 0)
                {





                    StoreWPF1.Properties.Settings.empname = Dt.Rows[0]["empname"].ToString();
                    StoreWPF1.Properties.Settings.empno = Convert.ToInt32(Dt.Rows[0]["empno"]);
                    PL.Main f = new PL.Main(StoreWPF1.Properties.Settings.empname.ToString());
                    f.Show();
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Login Faild !");
                }

            }

        }   

      
    }
}
