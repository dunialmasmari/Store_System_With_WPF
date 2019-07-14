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
    /// Interaction logic for Purchase.xaml
    /// </summary>
    public partial class Purchase : Window
    {
        public Purchase()
        {
            InitializeComponent();
            date.Text = Convert.ToString(DateTime.Now);
        }
    }
}
