using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StoreWPF1.BL
{
    class clscustomercompany
    {

        public DataTable Get_All_Customer()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_Customer", null);
            DAL.Close();
            return Dt;


        }
        public DataTable GetMax()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("maxCustomer", null);
            DAL.Close();
            return Dt;


        }
        public DataTable Name_Customer(string ID)
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            Dt = DAL.SelectData("Name_Customer", param);
            DAL.Close();
            return Dt;
        }
        public DataTable Name_Company(string ID)
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            Dt = DAL.SelectData("Name_Company", param);
            DAL.Close();
            return Dt;
        }
        public DataTable Get_All_Company()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GetAllCompany", null);
            DAL.Close();
            return Dt;


        }
        public void AddCustomer(int ID, string Name,
                         string Phone, string Address, int TypeID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@CustomerID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@CustomerName", SqlDbType.NVarChar, 50);
            param[1].Value = Name;

            param[2] = new SqlParameter("@CustomerPhone", SqlDbType.NVarChar, 50);
            param[2].Value = Phone;

            param[3] = new SqlParameter("@CustomerAddress", SqlDbType.NVarChar, 50);
            param[3].Value = Address;

            param[4] = new SqlParameter("@CocuTypeID", SqlDbType.Int);
            param[4].Value = TypeID;



            DAL.ExecuteCommand("AddCustomer", param);
            DAL.Close();





        }
        public void Delete_Customer(int ID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("DeleteCocu", param);
            DAL.Close();

        }


        public void UpdateCustomer(int ID, string Name,
                    string Phone, string Address, int TypeID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@CustomerID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@CustomerName", SqlDbType.NVarChar, 50);
            param[1].Value = Name;

            param[2] = new SqlParameter("@CustomerPhone", SqlDbType.NVarChar, 50);
            param[2].Value = Phone;

            param[3] = new SqlParameter("@CustomerAddress", SqlDbType.NVarChar, 50);
            param[3].Value = Address;

            param[4] = new SqlParameter("@CocuTypeID", SqlDbType.Int);
            param[4].Value = TypeID;



            DAL.ExecuteCommand("Update_Customer", param);
            DAL.Close();

        }
        public DataTable maxcomp()
        {

            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("maxCompany", null);
            DAL.Close();
            return Dt;

        }
    }
}
