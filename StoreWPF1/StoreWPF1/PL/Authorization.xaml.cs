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
    /// Interaction logic for Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
            date.Text = DateTime.Now.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void authbtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
