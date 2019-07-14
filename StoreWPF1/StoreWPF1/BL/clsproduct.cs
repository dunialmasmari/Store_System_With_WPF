using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StoreWPF1.BL
{
    class clsproduct
    {
           public DataTable Get_All_Categorys()
        {
            DAL.DAL DAL = new DAL.DAL();
          
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_Categorys", null);
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
        public DataTable Max_Productno()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Max_Productno", null);
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
        public void Add_Product(int ID_Product , string Name_Product,
                                int Min_Product, int Max_Product , int Type_Product ,int ID_Category , int ID_Company)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@ID_Product", SqlDbType.Int);
            param[0].Value = ID_Product;

            param[1] = new SqlParameter("@Name_Product", SqlDbType.NVarChar, 50);
            param[1].Value = Name_Product;

            param[2] = new SqlParameter("@Min_Product", SqlDbType.Int);
            param[2].Value = Min_Product;

            param[3] = new SqlParameter("@Max_Product", SqlDbType.Int);
            param[3].Value = Max_Product;

            param[4] = new SqlParameter("@Type_Product", SqlDbType.Int);
            param[4].Value = Type_Product;

            param[5] = new SqlParameter("@ID_Category", SqlDbType.Int);
            param[5].Value = ID_Category;

            param[6] = new SqlParameter("@ID_Company", SqlDbType.Int);
            param[6].Value = ID_Company;

            DAL.ExecuteCommand("ADDPRODUCT", param);
            DAL.Close();


            
               

        }
    
        public DataTable Get_All_Product()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_Product", null);
            DAL.Close();
            return Dt;


        }
        public DataTable Name_Product( string ID)
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,50);
            param[0].Value = ID;
            Dt = DAL.SelectData("Name_Product", param);
            DAL.Close();
            return Dt;
        }
        public DataTable ID_Product( int ID)
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            Dt = DAL.SelectData("ItemID", param);
            DAL.Close();
            return Dt;
        }

        public void Delete_Product(int ID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("Delete_Product", param);
            DAL.Close();

        }
        public void Update_Product(int ID_Product, string Name_Product,
                              int Min_Product, int Max_Product, int Type_Product, int ID_Category, int ID_Company)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@ID_Product", SqlDbType.Int);
            param[0].Value = ID_Product;

            param[1] = new SqlParameter("@Name_Product", SqlDbType.NVarChar, 50);
            param[1].Value = Name_Product;

            param[2] = new SqlParameter("@Min_Product", SqlDbType.Int);
            param[2].Value = Min_Product;

            param[3] = new SqlParameter("@Max_Product", SqlDbType.Int);
            param[3].Value = Max_Product;

            param[4] = new SqlParameter("@Type_Product", SqlDbType.Int);
            param[4].Value = Type_Product;

            param[5] = new SqlParameter("@ID_Category", SqlDbType.Int);
            param[5].Value = ID_Category;

            param[6] = new SqlParameter("@ID_Company", SqlDbType.Int);
            param[6].Value = ID_Company;

            DAL.ExecuteCommand("Update_Product", param);
            DAL.Close();





        }
    
    
    }
}
