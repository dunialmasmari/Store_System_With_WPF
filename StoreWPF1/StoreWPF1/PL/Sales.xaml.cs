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
    /// Interaction logic for Sales.xaml
    /// </summary>
    public partial class Sales : Window
    {
        BL.clsInvoice inv = new BL.clsInvoice();
        public Sales()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            items f = new items();
            f.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (txtid.Text == "" || empname.Text == "")
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            else
            {
                inv.AddInvoice(Convert.ToInt32(txtid.Text), Convert.ToDateTime(date1.Text), 1, StoreWPF1.Properties.Settings.empno, Convert.ToInt32(custname.SelectedValue), total.Text);


                /*  for (int i = 0; i < DataGrid1.RowValidationRules.Count- 1; i++)
                  {
                      string max = inv.invoicedetailsmax().Rows[0][0].ToString();


                      inv.AddInvoiceDetails(Convert.ToInt32(DataGrid1.[i].Cells[0].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value), Convert.ToString("Null"),
                        dataGridView1.Rows[i].Cells[4].Value.ToString(), Convert.ToString(DataGrid1.Rows[i].Cells[3].Value),
                         Convert.ToString("0.15"), dataGridView1.Rows[i].Cells[5].Value.ToString(), Convert.ToInt32(textBox1.Text));




                  }


                  MessageBox.Show("Add Seccess", "Add Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  textBox1.Clear();
                  dataGridView1.DataSource = dt;
                  txtqty.Clear();
                  lbltotal.Text = "";
                  textBox3.Clear();

              }*/
            }
        }
    }
}
