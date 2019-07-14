using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StoreWPF1.PL
{
    class clssetting
    {
        public DataTable Name_Category(string ID)
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            Dt = DAL.SelectData("Name_Category", param);
            DAL.Close();
            return Dt;
        }

        public void AddPosition(int ID, string Position, double Salary)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@Position", SqlDbType.NVarChar, 20);
            param[1].Value = Position;

            param[2] = new SqlParameter("@salary", SqlDbType.Money);
            param[2].Value = Salary;
            DAL.ExecuteCommand("AddPosition", param);
            DAL.Close();
        }
        public void AddCategory(int ID, string Category, int Company)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@Category", SqlDbType.NVarChar, 50);
            param[1].Value = Category;

            param[2] = new SqlParameter("@Company", SqlDbType.Int);
            param[2].Value = Company;
            DAL.ExecuteCommand("AddCategory", param);
            DAL.Close();
        }

        public void AddType(int ID, string Type)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@Type", SqlDbType.NVarChar, 30);
            param[1].Value = Type;




            DAL.ExecuteCommand("AddType", param);
            DAL.Close();
        }

        public void UpdatePosition(int ID, string Position, double Salary)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@Position", SqlDbType.NVarChar, 20);
            param[1].Value = Position;

            param[2] = new SqlParameter("@salary", SqlDbType.Money);
            param[2].Value = Salary;
            DAL.ExecuteCommand("UpdatePosition", param);
            DAL.Close();
        }
        public void UpdateCategory(int ID, string Category, int Company)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@Category", SqlDbType.NVarChar, 50);
            param[1].Value = Category;

            param[2] = new SqlParameter("@Company", SqlDbType.Int);
            param[2].Value = Company;
            DAL.ExecuteCommand("UpdateCategory", param);
            DAL.Close();
        }
        public void UpdateType(int ID, string Type)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@Type", SqlDbType.NVarChar, 30);
            param[1].Value = Type;




            DAL.ExecuteCommand("UpdateType", param);
            DAL.Close();
        }



        public DataTable maxitemtype()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("maxitemtype", null);
            DAL.Close();
            return Dt;


        }
        public void DeleteItemType(int ID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("DeleteItemType", param);
            DAL.Close();

        }
        public void DeletePosition(int ID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("DeletePosition", param);
            DAL.Close();

        }
        public void DeleteCategory(int ID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("DeleteCategory", param);
            DAL.Close();

        }

        public DataTable maxposition()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("maxposition", null);
            DAL.Close();
            return Dt;


        }

        public DataTable maxcat()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("maxcat", null);
            DAL.Close();
            return Dt;


        }
        public DataTable Get_All_Position()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_Position", null);
            DAL.Close();
            return Dt;
        }

        public DataTable Get_All_Type()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_Type", null);
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

        public DataTable Get_All_Category()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_Categorys", null);
            DAL.Close();
            return Dt;
        }

    }
}
