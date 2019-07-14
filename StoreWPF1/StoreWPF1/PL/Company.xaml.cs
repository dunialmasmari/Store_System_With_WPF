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
    /// Interaction logic for Company.xaml
    /// </summary>
    public partial class Company : Window
    {
        BL.clscustomercompany c = new BL.clscustomercompany();
        public Company()
        {
            InitializeComponent();
            date.Text = Convert.ToString(DateTime.Now);
            txtid.Text = c.maxcomp().Rows[0][0].ToString();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (compbtn.Content == "Add")
            {

                if (txtid.Text == "" || txtname.Text == "" || txtphone.Text == "" || txtaddress.Text == "")
                {
                    MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButton.OK, MessageBoxImage.Warning);

                }
                else
                {

                    c.AddCustomer(Convert.ToInt32(txtid.Text), txtname.Text, txtphone.Text, txtaddress.Text, Convert.ToInt32("1"));
                    MessageBox.Show("Add Seccess", "Add Product ", MessageBoxButton.OK, MessageBoxImage.Information);

                    txtid.Text = c.maxcomp().Rows[0][0].ToString();

                    txtname.Clear();
                    txtphone.Clear();
                    txtaddress.Clear();
                }
            }
            if (compbtn.Content == "Delete")
            {
                if (txtid.Text == "" || txtname.Text == "" || txtphone.Text == "" || txtaddress.Text == "")
                {
                    MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButton.OK, MessageBoxImage.Warning);

                }
                else
                {
                    if (MessageBox.Show("Do you realy want to delete this Product ?", "Delete Product", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
                    {
                        c.Delete_Customer(Convert.ToInt32(txtid.Text));
                        MessageBox.Show("Delete successful", "Delete Product", MessageBoxButton.OK, MessageBoxImage.Information);
                    }


                    else
                    {
                        MessageBox.Show("Delete Cancled", "Delete Product", MessageBoxButton.OK, MessageBoxImage.Exclamation);

                    }
                }
            }
            if (compbtn.Content == "Update")
            {
                if (txtid.Text == "" || txtname.Text == "" || txtphone.Text == "" || txtaddress.Text == "")
                {
                    MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButton.OK, MessageBoxImage.Warning);

                }
                else
                {
                    c.UpdateCustomer(Convert.ToInt32(txtid.Text), txtname.Text, txtphone.Text, txtaddress.Text, Convert.ToInt32("1"));
                    MessageBox.Show("Update Seccess", "Update Product ", MessageBoxButton.OK, MessageBoxImage.Information);


                    txtid.Text = c.maxcomp().Rows[0][0].ToString();

                    txtname.Clear();
                    txtphone.Clear();
                    txtaddress.Clear();
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                txtname.Focus();
            }
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                txtphone.Focus();
            }
        }

        private void txtphone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtaddress.Focus();
            }
        }

        private void txtaddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                compbtn.Focus();
            }
        }
    }
}
