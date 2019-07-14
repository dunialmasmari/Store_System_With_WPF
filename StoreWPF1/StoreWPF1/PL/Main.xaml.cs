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
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main(string x)
        {
            InitializeComponent();
          
            DT.Text = "TODAY IS: " + DateTime.Now; 
            MN.Text ="PC :" + Environment.MachineName;
            EN.Text = " Employee Name:" + x + "";
            
        
        }
      
      
        Authorization a = new Authorization();
    
    
       

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
            
          
        }
        private void AddCust(object sender, RoutedEventArgs e)
        {
            Customer c = new Customer();
            c.custbtn.Content = "Add";    
           
            c.Show();
        }
        private void AddComp(object sender, RoutedEventArgs e)
        {
            Company w = new Company();
            w.compbtn.Content = "Add"; 

            w.Show();
        }
        private void Additem(object sender, RoutedEventArgs e)
        {
            Product p = new Product();

            p.itemhead.Content = "Product Data Entry";
            p.itembutton.Content = "Add";
            p.Show();
        }
        private void AddEmp_clk(object sender, RoutedEventArgs e)
        {

            Employee f = new Employee();
            f.empbtn.Content = "Add"; 
            f.Show();
        }

        private void UdtEmp(object sender, RoutedEventArgs e)
        {
            Employee f = new Employee();
            f.empbtn.Content = "Update"; 
            f.Show();
        }
        private void UdtCust(object sender, RoutedEventArgs e)
        {
            Customer c = new Customer();
            c.custbtn.Content = "Update"; 
            c.Show();
        }
        private void UdtComp(object sender, RoutedEventArgs e)
        {
            Company w = new Company();
            w.compbtn.Content = "Update";
            w.Show();
        }
        private void Udtitem(object sender, RoutedEventArgs e)
        {
            Product p = new Product();
            p.itemhead.Content = "Product Data Management";
            p.itembutton.Content = "Update";
            p.Show();
        }

        private void delEmp(object sender, RoutedEventArgs e)
        {
            Employee f = new Employee();
            f.empbtn.Content = "Delete"; 
            f.Show();
        }
        private void delCust(object sender, RoutedEventArgs e)
        {
            Customer c = new Customer();
            c.custbtn.Content = "Delete"; 
            c.Show();
        }
        private void delitem(object sender, RoutedEventArgs e)
        {
            Product p = new Product();
            p.itemhead.Content = "Product Date Remover";
            p.itembutton.Content = "Delete";
            p.Show();
        }
        private void delComp(object sender, RoutedEventArgs e)
        {
            Company w = new Company();
            w.compbtn.Content = "Delete";
            w.Show();
        }

      

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Sales s = new Sales();
            s.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Purchase u = new Purchase();
            u.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Position f = new Position();
            f.itembutton.Content = "Add";
            f.Show();

        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Position f = new Position();
            f.itembutton.Content = "Update";
            f.Show();

        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            Position f = new Position();
            f.itembutton.Content = "Delete";
            f.Show();

        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            Type f = new Type();
            f.typbtn.Content = "Add";
            f.Show();

        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            Type f = new Type();
            f.typbtn.Content = "Update";
            f.Show();

        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            Type f = new Type();
            f.typbtn.Content = "Delete";
            f.Show();

        }

        private void MenuItem_Click_9(object sender, RoutedEventArgs e)
        {
            Category f = new Category();
            f.catbtn.Content = "Add";
            f.Show();

        }

        private void MenuItem_Click_10(object sender, RoutedEventArgs e)
        {
            Category f = new Category();
            f.catbtn.Content = "Update";
            f.Show();

        }

        private void MenuItem_Click_11(object sender, RoutedEventArgs e)
        {
            Category f = new Category();
            f.catbtn.Content = "Delete";
            f.Show();
        }

        private void MenuItem_Click_12(object sender, RoutedEventArgs e)
        {
            store f = new store();
            f.storebtn.Content = "Add";
            f.Show();
        }

        private void MenuItem_Click_13(object sender, RoutedEventArgs e)
        {
            store f = new store();
            f.storebtn.Content = "Update";
            f.Show();
        }

        private void MenuItem_Click_14(object sender, RoutedEventArgs e)
        {
            store f = new store();
            f.storebtn.Content = "Delete";
            f.Show();

        }

        private void MenuItem_Click_15(object sender, RoutedEventArgs e)
        {
            PL.Reportform f=new PL.Reportform();
            f.Show();

        }

        private void MenuItem_Click_16(object sender, RoutedEventArgs e)
        {
            PL.crviewer f = new PL.crviewer();
            f.Show();

        }

     

        

    }
}
