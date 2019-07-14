using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace StoreWPF1.BL
{
    class clsInvoice
    {

        public DataTable Get_All_PurchaseDetails(int ID)
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            Dt = DAL.SelectData("GetAllpurchaseDetails", param);
            DAL.Close();
            return Dt;
        }
        public void Delete_Purchase(int ID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("Delete_Purchase", param);
            DAL.Close();

        }
        public DataTable Get_All_PurchaseDetail()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GetAllpurchaseDetails", null);
            DAL.Close();
            return Dt;


        }
        public DataTable Get_All_Purchase()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GetAllPurchase", null);
            DAL.Close();
            return Dt;


        }
        public DataTable Get_All_Company()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_Company", null);
            DAL.Close();
            return Dt;


        }

        public DataTable Get_All_Customer()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_Customer", null);
            DAL.Close();
            return Dt;


        }
        public DataTable invoicedetailsmax()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("invoicedetaismax", null);
            DAL.Close();
            return Dt;


        }

        public DataTable maxsale()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("maxsale", null);
            DAL.Close();
            return Dt;


        }
        public DataTable maxpurchase()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("maxpurchase", null);
            DAL.Close();
            return Dt;


        }
        public DataTable dgv()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("dgv", null);
            DAL.Close();
            return Dt;


        }
        public void AddInvoice(int ID, DateTime date,
                        int type, int empno, int cocuno, string Total)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[1].Value = date;

            param[2] = new SqlParameter("@Typeno", SqlDbType.Int);
            param[2].Value = type;

            param[3] = new SqlParameter("@empno", SqlDbType.Int);
            param[3].Value = empno;

            param[4] = new SqlParameter("@cocuno", SqlDbType.Int);
            param[4].Value = cocuno;


            param[5] = new SqlParameter("@Total", SqlDbType.NVarChar, 50);
            param[5].Value = Total;



            DAL.ExecuteCommand("AddInvoice", param);
            DAL.Close();





        }

        public void AddInvoiceDetails(int item,
                       int Qty, string Cost, string Expdate, string Price, string Percentage, string total, int invoiceID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[8];


            param[0] = new SqlParameter("@item", SqlDbType.Int);
            param[0].Value = item;

            param[1] = new SqlParameter("@Qty", SqlDbType.Int);
            param[1].Value = Qty;

            param[2] = new SqlParameter("@Cost", SqlDbType.NVarChar, 50);
            param[2].Value = Cost;

            param[3] = new SqlParameter("@Expdate", SqlDbType.NVarChar, 50);
            param[3].Value = Expdate;

            param[4] = new SqlParameter("@Price", SqlDbType.NVarChar, 50);
            param[4].Value = Price;

            param[5] = new SqlParameter("@Percentage", SqlDbType.NVarChar, 50);
            param[5].Value = Percentage;

            param[6] = new SqlParameter("@total", SqlDbType.NVarChar, 50);
            param[6].Value = total;

            param[7] = new SqlParameter("@invoiceID", SqlDbType.Int);
            param[7].Value = invoiceID;


            DAL.ExecuteCommand("AddInvoiceDetails", param);
            DAL.Close();





        }

        public void UpdateInvoice(int ID, DateTime date,
                int type, int empno, int cocuno, string Total)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[1].Value = date;

            param[2] = new SqlParameter("@Typeno", SqlDbType.Int);
            param[2].Value = type;

            param[3] = new SqlParameter("@empno", SqlDbType.Int);
            param[3].Value = empno;

            param[4] = new SqlParameter("@cocuno", SqlDbType.Int);
            param[4].Value = cocuno;


            param[5] = new SqlParameter("@Total", SqlDbType.NVarChar, 50);
            param[5].Value = Total;



            DAL.ExecuteCommand("UpdateInvoice", param);
            DAL.Close();





        }
        public void UpdateInvoiceDetails(int ID, int item,
                    int Qty, string Cost, string Expdate, string Price, string Percentage, string total, int invoiceID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@item", SqlDbType.Int);
            param[1].Value = item;

            param[2] = new SqlParameter("@Qty", SqlDbType.Int);
            param[2].Value = Qty;

            param[3] = new SqlParameter("@Cost", SqlDbType.NVarChar, 50);
            param[3].Value = Cost;

            param[4] = new SqlParameter("@Expdate", SqlDbType.NVarChar, 50);
            param[4].Value = Expdate;

            param[5] = new SqlParameter("@Price", SqlDbType.NVarChar, 50);
            param[5].Value = Price;

            param[6] = new SqlParameter("@Percentage", SqlDbType.NVarChar, 50);
            param[6].Value = Percentage;

            param[7] = new SqlParameter("@total", SqlDbType.NVarChar, 50);
            param[7].Value = total;

            param[8] = new SqlParameter("@invoiceID", SqlDbType.Int);
            param[8].Value = invoiceID;


            DAL.ExecuteCommand("UpdateInvoiceDetails", param);
            DAL.Close();





        }

    }
}
