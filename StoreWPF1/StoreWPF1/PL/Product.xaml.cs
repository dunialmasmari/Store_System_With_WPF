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
    /// Interaction logic for Product.xaml
    /// </summary>
    public partial class Product : Window
    {
         BL.clsproduct prd = new BL.clsproduct();
      
        public Product()
        {
            InitializeComponent();

            date.Text = Convert.ToString(DateTime.Now);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

  /*      private void itembutton_Click(object sender, RoutedEventArgs e)
        {
            if(itembutton.Content=="Add")
            {

                if (txtid.Text == "" || txtname.Text == "" || txtmin.Text == "" || txtmax.Text == "")
                {
                    MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButton.OK, MessageBoxImage.Warning);

                }
                else
                {

                    prd.Add_Product(Convert.ToInt32(txtid.Text), txtname.Text, Convert.ToInt32(txtmin.Text), Convert.ToInt32(txtmax.Text), Convert.ToInt32(cmbtype.SelectedValue), Convert.ToInt32(cmbCategory.SelectedValue), Convert.ToInt32(cmbcomp.SelectedValue));
                    MessageBox.Show("Add Seccess", "Add Product ", MessageBoxButton.OK, MessageBoxImage.Information);
                   
                    txtid.Text = prd.Max_Productno().Rows[0][0].ToString();

                    txtname.Clear();
                    txtmin.Clear();
                    txtmax.Clear();
                }
            }
        }*/
    }
}
