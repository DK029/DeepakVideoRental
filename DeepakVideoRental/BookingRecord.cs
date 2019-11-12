using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepakVideoRental
{
    class BookingRecord
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






        public int addData(int CustomerId, int VideoId, String VideoIssue, String VideoReturn)
        {

            if (CustomerId==0 && VideoId==0 && VideoIssue.Equals("") && VideoReturn.Equals(""))
            {
                return 0;
            }
            else
            {
                String query = "select * from BookRecord where VideoId="+Convert.ToInt32(VideoId)+" and VideoReturnDate='0'";
                DataTable tbl = new DataTable();
                tbl = getRecord(query);

                String query1 = "select * from Video where VideoUniqID=" + Convert.ToInt32(VideoId) + "";
                DataTable tbl1 = new DataTable();
                tbl1 = getRecord(query1);

                String query2 = "select * from BookRecord where CustomerID=" + Convert.ToInt32(CustomerId) + "";
                DataTable tbl2 = new DataTable();
                tbl2 = getRecord(query2);

                if (tbl.Rows.Count == Convert.ToInt32(tbl1.Rows[0]["Copies"].ToString())) {
                    return 1;
                } else if (tbl2.Rows.Count==2) {

                    return 1;
                }
                else { 
                    String qry = "insert into BookRecord(CustomerId,VideoId,VideoIssueDate,VideoReturnDate)values(@CustomerId,@VideoId,@VideoIssue,@VideoReturn)";
                    sqlConn = new SqlConnection(connection_String);
                    sqlConn.Open();
                    sqlCmd = new SqlCommand(qry, sqlConn);

                    sqlCmd.Parameters.Add("@CustomerId", System.Data.SqlDbType.Int);
                    sqlCmd.Parameters.Add("@VideoId", System.Data.SqlDbType.Int);
                    sqlCmd.Parameters.Add("@VideoIssue", System.Data.SqlDbType.VarChar);
                    sqlCmd.Parameters.Add("@VideoReturn", System.Data.SqlDbType.VarChar);

                    sqlCmd.Parameters["@CustomerId"].Value = CustomerId;
                    sqlCmd.Parameters["@VideoId"].Value = VideoId;
                    sqlCmd.Parameters["@VideoIssue"].Value = VideoIssue;
                    sqlCmd.Parameters["@VideoReturn"].Value = "0";

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

        public int updateData(int rentUniqId,int CustomerId, int VideoId, String VideoIssue, String VideoReturn)
        {

            if (rentUniqId==0 && CustomerId == 0 && VideoId == 0 && VideoIssue.Equals("") && VideoReturn.Equals(""))
            {
                return 0;
            }
            else
            {

                String qry = "";
                qry = "update BookRecord set CustomerId=@CustomerId,VideoId=@VideoId,VideoIssueDate=@VideoIssue,VideoReturnDate=@VideoReturn where RentUniqID=@rentUniqId";
                sqlConn = new SqlConnection(connection_String);
                sqlConn.Open();
                sqlCmd = new SqlCommand(qry, sqlConn);

                sqlCmd.Parameters.Add("@rentUniqId", System.Data.SqlDbType.Int);
                sqlCmd.Parameters.Add("@CustomerId", System.Data.SqlDbType.Int);
                sqlCmd.Parameters.Add("@VideoId", System.Data.SqlDbType.Int);
                sqlCmd.Parameters.Add("@VideoIssue", System.Data.SqlDbType.VarChar);
                sqlCmd.Parameters.Add("@VideoReturn", System.Data.SqlDbType.VarChar);

                sqlCmd.Parameters["@rentUniqId"].Value = rentUniqId;
                sqlCmd.Parameters["@CustomerId"].Value = CustomerId;

                sqlCmd.Parameters["@VideoId"].Value = VideoId;
                sqlCmd.Parameters["@VideoIssue"].Value = VideoIssue;
                sqlCmd.Parameters["@VideoReturn"].Value =VideoReturn;

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

        public int deleteData(int rentUniqId)
        {

            if (rentUniqId == 0)
            {
                return 0;
            }
            else
            {
                String qry = "delete from BookRecord  where RentUniqID=@rentUniqId";
                sqlConn = new SqlConnection(connection_String);
                sqlConn.Open();
                sqlCmd = new SqlCommand(qry, sqlConn);

                sqlCmd.Parameters.Add("@rentUniqId", System.Data.SqlDbType.Int);

                sqlCmd.Parameters["@rentUniqId"].Value = rentUniqId;

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
