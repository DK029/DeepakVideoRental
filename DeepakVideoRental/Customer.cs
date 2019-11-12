using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepakVideoRental
{
  public   class Customer
    {
        SqlConnection sqlConn;
        String connection_String = "Data Source=DESKTOP-P3L0OHD\\SQLEXPRESS;Initial Catalog=VideoRentalDatabase;Integrated Security=True";
        SqlCommand sqlCmd;
        SqlDataReader sqlDatareader;


        public DataTable getRecord(String qry)
        {
            DataTable tbl = new DataTable();


            sqlConn = new SqlConnection(connection_String);

            sqlConn.Open();
            sqlCmd = new SqlCommand(qry, sqlConn);

            sqlDatareader = sqlCmd.ExecuteReader();

            tbl.Load(sqlDatareader);

            sqlConn.Close();

            return tbl;
        }
        //this method is used to 
        public int addData(String frstName,String lstName,String PhoneNo,String Address)
        {

            if (frstName.Equals("") && lstName.Equals("") && PhoneNo.Equals("") && Address.Equals(""))
            {
                return 0;
            }
            else
            {
                String qry = "insert into Customer(FrstName,LstName,PhoneNo,Address)values(@frstName,@lstName,@PhoneNo,@Address)";
                sqlConn = new SqlConnection(connection_String);
                sqlConn.Open();
                sqlCmd = new SqlCommand(qry, sqlConn);

                sqlCmd.Parameters.Add("@frstName", System.Data.SqlDbType.VarChar);
                sqlCmd.Parameters.Add("@lstName", System.Data.SqlDbType.VarChar);
                 sqlCmd.Parameters.Add("@PhoneNo", System.Data.SqlDbType.VarChar);
                sqlCmd.Parameters.Add("@Address", System.Data.SqlDbType.VarChar);

                sqlCmd.Parameters["@frstName"].Value = frstName;
                sqlCmd.Parameters["@lstName"].Value = lstName;
                sqlCmd.Parameters["@PhoneNo"].Value = PhoneNo;
                sqlCmd.Parameters["@Address"].Value = Address;

                int rowsAffected = sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
                sqlConn.Close();
                if (rowsAffected == 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }

            }

        }
        //this method is used to 
        public int updateData(int uniqID,String frstName, String lstName, String PhoneNo, String Address)
        {

            if (uniqID==0 && frstName.Equals("") && lstName.Equals("") && PhoneNo.Equals("") && Address.Equals(""))
            {
                return 0;
            }
            else
            {
                String qry = "update Customer set FrstName=@frstName,LstName=@lstName,PhoneNo=@PhoneNo,Address=@Address where CustomerUniqId=@Id";
                sqlConn = new SqlConnection(connection_String);
                sqlConn.Open();
                sqlCmd = new SqlCommand(qry, sqlConn);

                sqlCmd.Parameters.Add("@Id", System.Data.SqlDbType.Int);

                sqlCmd.Parameters.Add("@frstName", System.Data.SqlDbType.VarChar);
                sqlCmd.Parameters.Add("@lstName", System.Data.SqlDbType.VarChar);
                sqlCmd.Parameters.Add("@PhoneNo", System.Data.SqlDbType.VarChar);
                sqlCmd.Parameters.Add("@Address", System.Data.SqlDbType.VarChar);

                sqlCmd.Parameters["@Id"].Value =uniqID;
                sqlCmd.Parameters["@frstName"].Value = frstName;
                sqlCmd.Parameters["@lstName"].Value = lstName;
                sqlCmd.Parameters["@PhoneNo"].Value = PhoneNo;
                sqlCmd.Parameters["@Address"].Value = Address;

                int rowsAffected = sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
                sqlConn.Close();
                if (rowsAffected == 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }

            }

        }

        public int delData(int uniqID) {

            if (uniqID == 0)
            {
                return 0;
            }
            else
            {
                String query = "select * from BookingRecord where CustomerId=" + Convert.ToInt32(uniqID) + " && VideoReturnDate='0'";
                DataTable tbl = new DataTable();
                tbl = getRecord(query);

                if (tbl.Rows.Count > 0)
                {
                    return 1;
                }
                else
                {
                    String qry = "delete from Customer where CustomerUniqId=@Id";
                    sqlConn = new SqlConnection(connection_String);
                    sqlConn.Open();
                    sqlCmd = new SqlCommand(qry, sqlConn);

                    sqlCmd.Parameters.Add("@Id", System.Data.SqlDbType.Int);



                    sqlCmd.Parameters["@Id"].Value = uniqID;


                    int rowsAffected = sqlCmd.ExecuteNonQuery();
                    sqlCmd.Dispose();
                    sqlConn.Close();
                    if (rowsAffected == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }



    }
}
