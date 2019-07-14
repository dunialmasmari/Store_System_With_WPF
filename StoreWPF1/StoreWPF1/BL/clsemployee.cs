using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StoreWPF1.BL
{
    class clsemployee
    {
        public DataTable Get_All_Employee()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_Employee", null);
            DAL.Close();
            return Dt;


        }
        public DataTable maxemp()
        {

            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("maxemp", null);
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
        public DataTable Get_All_Store()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_Store", null);
            DAL.Close();
            return Dt;
        }
        public void AddEmployee(int ID, string Name,
                 string Phone, string Address, int PositionID, int StoreID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@EmpID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@EmpName", SqlDbType.NVarChar, 50);
            param[1].Value = Name;

            param[2] = new SqlParameter("@EmpPhone", SqlDbType.NVarChar, 50);
            param[2].Value = Phone;

            param[3] = new SqlParameter("@EmpAddress", SqlDbType.NVarChar, 50);
            param[3].Value = Address;

            param[4] = new SqlParameter("@EmppositionID", SqlDbType.Int);
            param[4].Value = PositionID;
            param[5] = new SqlParameter("@EmpStoreID", SqlDbType.Int);
            param[5].Value = StoreID;


            DAL.ExecuteCommand("Add_Employee", param);
            DAL.Close();





        }
        public void DeleteEmployee(int ID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("Delete_Employee", param);
            DAL.Close();

        }

        public void UpdateEmployee(int ID, string Name,
                    string Phone, string Address, int PositionID, int StoreID)
        {

            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@EmpID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@EmpName", SqlDbType.NVarChar, 50);
            param[1].Value = Name;

            param[2] = new SqlParameter("@EmpPhone", SqlDbType.NVarChar, 50);
            param[2].Value = Phone;

            param[3] = new SqlParameter("@EmpAddress", SqlDbType.NVarChar, 50);
            param[3].Value = Address;

            param[4] = new SqlParameter("@EmppositionID", SqlDbType.Int);
            param[4].Value = PositionID;

            param[5] = new SqlParameter("@EmpStoreID", SqlDbType.Int);
            param[5].Value = StoreID;



            DAL.ExecuteCommand("Update_Employee", param);
            DAL.Close();

        }
    }
}
