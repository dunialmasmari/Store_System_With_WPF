using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace StoreWPF1.PL
{
    public partial class reports : Form
    {
        SqlConnection con = new SqlConnection();
        int x;
        public reports(String x)
        {
            InitializeComponent();
            this.x = int.Parse(x);
         
        }

        private void reports_Load(object sender, EventArgs e)
        {
            Reportform f = new Reportform();
            if (f.b1.Content == "pp")
            {
                con.ConnectionString = " server=THENME-PC;integrated security=true;dataBase=store_system";
                string sql = "SELECT  Storeinvoice.Storeinvoice_no as PurchaseId, Storeinvoice.Storeinvoice_date as PurchaseDate,customercompany.cocuname as CompanyName,employee.empname as EmployeeName, item.item_name as ProductName,invoice_details.invoice_detailsExpirydate as ExpiryDate, invoice_details.invoice_detailsCost UnitCost, invoice_details.invoice_detailsqty Quantity, invoice_details.invoice_detailsqty * CONVERT(int, invoice_details.invoice_detailsCost)  AS Total FROM item INNER JOIN invoice_details ON item.item_no = invoice_details.item_no INNER JOIN customercompany ON item.cucono = customercompany.cocuno INNER JOIN  Storeinvoice ON invoice_details.Storeinvoice_no = Storeinvoice.Storeinvoice_no AND customercompany.cocuno = Storeinvoice.cocuno INNER JOIN employee ON Storeinvoice.empno = employee.empno where  Storeinvoice.Storeinvoice_no= " + x;

                PL.DataSet1 ds = new PL.DataSet1();
                SqlDataAdapter dad = new SqlDataAdapter(sql, con);
                dad.Fill(ds.Tables["DataTable1"]);
                Report.CrystalReport1 cr = new Report.CrystalReport1();
                cr.SetDataSource(ds.Tables["DataTable1"]);
                crystalReportViewer1.ReportSource = cr;
                crystalReportViewer1.Refresh();
            }
          
        }
    }
}
