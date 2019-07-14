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
    /// Interaction logic for Category.xaml
    /// </summary>
    public partial class Category : Window
    {
        clssetting s = new clssetting();
      

        public Category()
        {
            InitializeComponent();
            date.Text = Convert.ToString(DateTime.Now);

            textBox1.Text = s.maxcat().Rows[0][0].ToString();
           
           
        }
        
        private void loaded(object sender,RoutedEventArgs e)
        {
         
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void catbtn_Click(object sender, RoutedEventArgs e)
        {
            if (catbtn.Content=="Add")
                  {

                      if (textBox1.Text == "" || textBox2.Text == "")
                      {
                          MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButton.OK, MessageBoxImage.Warning);

                      }
                      else
                      {
                          s.AddCategory(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(cmbcomp.SelectedValue));
                          MessageBox.Show("Add Seccess", "Add Product ", MessageBoxButton.OK, MessageBoxImage.Information);

                          textBox2.Clear();
                          textBox1.Text = s.maxcat().Rows[0][0].ToString();

                      }
                  }
                  if (catbtn.Content=="Delete")
                  {
                      if (MessageBox.Show("Do you realy want to delete this Product ?", "Delete Product", MessageBoxButton.YesNo, MessageBoxImage.Exclamation)==MessageBoxResult.Yes)
                      {
                          s.DeleteCategory(Convert.ToInt32(textBox1.Text));
                          MessageBox.Show("Delete successful", "Delete Product", MessageBoxButton.OK, MessageBoxImage.Information);
                


                      }
                      else
                      {
                          MessageBox.Show("Delete Cancled", "Delete Product", MessageBoxButton.OK, MessageBoxImage.Exclamation);

                      }
                  }
                  if(catbtn.Content=="Update")
                  {
                      if (textBox1.Text == "" || textBox2.Text == "")
                      {
                          MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButton.OK, MessageBoxImage.Warning);

                      }
                      else
                      {
                          s.UpdateCategory(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(cmbcomp.SelectedValue));
                          MessageBox.Show("Update Seccess", "Update Product ", MessageBoxButton.OK, MessageBoxImage.Information);

                   
                          textBox2.Clear();
                          textBox1.Text = s.maxcat().Rows[0][0].ToString();
                      }
                  }
              }

        private void textBox1_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtname.Text != "")
            {


                DataTable Dt = new DataTable();
                Dt = s.Name_Category(txtname.Text);
              
            }
        }

    
    }
    }

