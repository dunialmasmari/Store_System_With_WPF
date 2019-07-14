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
using System.Data;

namespace StoreWPF1.PL
{
    /// <summary>
    /// Interaction logic for Employee.xaml
    /// </summary>
    public partial class Employee : Window
    {
        BL.clsemployee Emp = new BL.clsemployee();
        public Employee()
        {
            InitializeComponent();
            date.Text = Convert.ToString(DateTime.Now);
            txtid.Text = Emp.maxemp().Rows[0][0].ToString();

        }

        private void empbtn_Click(object sender, RoutedEventArgs e)
        {

            if (empbtn.Content == "Add")
            {

               
                  

                if (txtid.Text == "" || txtname.Text == "" || txtphone.Text == "" || txtaddress.Text == "")
                {
                    MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButton.OK, MessageBoxImage.Warning);

                }
                else
                {
                    Emp.AddEmployee(Convert.ToInt32(txtid.Text), txtname.Text, txtphone.Text, txtaddress.Text, Convert.ToInt32(cmb1.SelectedValue), Convert.ToInt32(cmb2.SelectedValue));
            
                   
                    MessageBox.Show("Add Seccess", "Add Product ", MessageBoxButton.OK, MessageBoxImage.Information);

                    txtid.Text = Emp.maxemp().Rows[0][0].ToString();
                    lbl1.Content = "";
                    txtname.Clear();
                    txtphone.Clear();
                    txtaddress.Clear();
                }
            }
            if (empbtn.Content == "Delete")
            {
                if (txtid.Text == "" || txtname.Text == "" || txtphone.Text == "" || txtaddress.Text == "")
                {
                    MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButton.OK, MessageBoxImage.Warning);

                }
                else
                {
                    if (MessageBox.Show("Do you realy want to delete this Product ?", "Delete Product", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
                    {
                        Emp.DeleteEmployee(Convert.ToInt32(txtid.Text));
                        MessageBox.Show("Delete successful", "Delete Product", MessageBoxButton.OK, MessageBoxImage.Information);
                    }


                    else
                    {
                        MessageBox.Show("Delete Cancled", "Delete Product", MessageBoxButton.OK, MessageBoxImage.Exclamation);

                    }
                }
            }
            if (empbtn.Content == "Update")
            {
                if (txtid.Text == "" || txtname.Text == "" || txtphone.Text == "" || txtaddress.Text == "")
                {
                    MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButton.OK, MessageBoxImage.Warning);

                }
                else
                {
                    Emp.AddEmployee(Convert.ToInt32(txtid.Text), txtname.Text, txtphone.Text, txtaddress.Text, Convert.ToInt32(cmb1.SelectedValue), Convert.ToInt32(cmb2.SelectedValue));
                    MessageBox.Show("Update Seccess", "Update Product ", MessageBoxButton.OK, MessageBoxImage.Information);

                    txtid.Text = Emp.maxemp().Rows[0][0].ToString();

                    txtname.Clear();
                    txtphone.Clear();
                    txtaddress.Clear();
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void cmb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SqlConnection con = new SqlConnection(" server=THENME-PC;integrated security=true;dataBase=store_system");

            DataTable dt = new DataTable();

            string s = "select empposition_salary from empposition where empposition_name='" + cmb1.Text + "'";

            SqlDataAdapter da = new SqlDataAdapter(s, con);
            da.Fill(dt);
            string d = dt.Rows[0][0].ToString();
            lbl1.Content = d;
        }
    }
}
