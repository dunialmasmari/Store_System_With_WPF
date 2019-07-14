using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StoreWPF1.BL
{
    class clslogin
    {
       

            public DataTable LOGIN(string ID, string PWD)
            {
                DAL.DAL DAL = new DAL.DAL();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
                param[0].Value = ID;
                param[1] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
                param[1].Value = PWD;
                DataTable Dt = new DataTable();
                Dt = DAL.SelectData("SP_LOGIN", param);
                DAL.Close();
                return Dt;


            }

            public void AddStore(int ID, string Name,
                  string Phone, string Fax, string Address)
            {
                DAL.DAL DAL = new DAL.DAL();
                DAL.Open();
                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                param[1] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
                param[1].Value = Name;

                param[2] = new SqlParameter("@Phone", SqlDbType.NVarChar, 50);
                param[2].Value = Phone;

                param[3] = new SqlParameter("@Fax", SqlDbType.NVarChar, 50);
                param[3].Value = Fax;

                param[4] = new SqlParameter("@Address", SqlDbType.NVarChar, 50);
                param[4].Value = Address;


                DAL.ExecuteCommand("AddStore", param);
                DAL.Close();





            }
            public void UpdateStore(int ID, string Name,
                 string Phone, string Fax, string Address)
            {
                DAL.DAL DAL = new DAL.DAL();
                DAL.Open();
                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                param[1] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
                param[1].Value = Name;

                param[2] = new SqlParameter("@Phone", SqlDbType.NVarChar, 50);
                param[2].Value = Phone;

                param[3] = new SqlParameter("@Fax", SqlDbType.NVarChar, 50);
                param[3].Value = Fax;

                param[4] = new SqlParameter("@Address", SqlDbType.NVarChar, 50);
                param[4].Value = Address;


                DAL.ExecuteCommand("UpdateStore", param);
                DAL.Close();





            }
            public void DeleteStore(int ID)
            {
                DAL.DAL DAL = new DAL.DAL();
                DAL.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                DAL.ExecuteCommand("DeleteStore", param);
                DAL.Close();

            }
            public DataTable GetAllStore()
            {
                DAL.DAL DAL = new DAL.DAL();

                DataTable Dt = new DataTable();
                Dt = DAL.SelectData("GetAllStore", null);
                DAL.Close();
                return Dt;


            }

            public DataTable maxstore()
            {

                DAL.DAL DAL = new DAL.DAL();

                DataTable Dt = new DataTable();
                Dt = DAL.SelectData("maxstore", null);
                DAL.Close();
                return Dt;

            }
        }
    }

