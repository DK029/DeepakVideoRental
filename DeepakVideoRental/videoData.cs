using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DeepakVideoRental
{
    public class videoData
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
        public int addData(String title,String Ratting,int year,int copies,int cost, String plot,String genre) {

            if (title.Equals("") && Ratting.Equals("") && year == 0 && copies == 0 && cost == 0 && plot.Equals("") && genre.Equals(""))
            {
                return 0;
            }
            else
            {
                String qry = "insert into Video(Title,Ratting,Year,Copies,Cost,Plot,Genre)values(@Title,@Ratting,@Year,@Copies,@Cost,@Plot,@Genre)";
                sqlConn = new SqlConnection(connection_String);
                sqlConn.Open();
                sqlCmd = new SqlCommand(qry, sqlConn);

                sqlCmd.Parameters.Add("@Title", System.Data.SqlDbType.VarChar);
                sqlCmd.Parameters.Add("@Ratting", System.Data.SqlDbType.VarChar);
                sqlCmd.Parameters.Add("@Year", System.Data.SqlDbType.Int);
                sqlCmd.Parameters.Add("@Copies", System.Data.SqlDbType.Int);
                sqlCmd.Parameters.Add("@Cost", System.Data.SqlDbType.Int);
                sqlCmd.Parameters.Add("@Plot", System.Data.SqlDbType.VarChar);
                sqlCmd.Parameters.Add("@Genre", System.Data.SqlDbType.VarChar);

                sqlCmd.Parameters["@Title"].Value = title;
                sqlCmd.Parameters["@Ratting"].Value = Ratting;
                sqlCmd.Parameters["@Year"].Value = Convert.ToInt32(year);
                sqlCmd.Parameters["@Copies"].Value = Convert.ToInt32(copies);
                sqlCmd.Parameters["@Cost"].Value = Convert.ToInt32(cost);
                sqlCmd.Parameters["@Plot"].Value = plot;
                sqlCmd.Parameters["@Genre"].Value = genre;

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
        public int updateData(int UniqId,String title, String Ratting, int year, int copies, int cost, String plot, String genre)
        {

            if (title.Equals("") && Ratting.Equals("") && year == 0 && copies == 0 && cost == 0 && plot.Equals("") && genre.Equals(""))
            {
                return 0;
            }
            else
            {
                


                String qry = "update Video set Title=@Title,Ratting=@Ratting,Year=@Year,Copies=@Copies,Cost=@Cost,Plot=@Plot,Genre=@Genre where VideoUniqID=@Id";
                sqlConn = new SqlConnection(connection_String);
                sqlConn.Open();
                sqlCmd = new SqlCommand(qry, sqlConn);

                sqlCmd.Parameters.Add("@Id", System.Data.SqlDbType.Int);
                sqlCmd.Parameters.Add("@Title", System.Data.SqlDbType.VarChar);
                sqlCmd.Parameters.Add("@Ratting", System.Data.SqlDbType.VarChar);
                sqlCmd.Parameters.Add("@Year", System.Data.SqlDbType.Int);
                sqlCmd.Parameters.Add("@Copies", System.Data.SqlDbType.Int);
                sqlCmd.Parameters.Add("@Cost", System.Data.SqlDbType.Int);
                sqlCmd.Parameters.Add("@Plot", System.Data.SqlDbType.VarChar);
                sqlCmd.Parameters.Add("@Genre", System.Data.SqlDbType.VarChar);

                sqlCmd.Parameters["@Id"].Value = UniqId;
                sqlCmd.Parameters["@Title"].Value = title;
                sqlCmd.Parameters["@Ratting"].Value = Ratting;
                sqlCmd.Parameters["@Year"].Value = Convert.ToInt32(year);
                sqlCmd.Parameters["@Copies"].Value = Convert.ToInt32(copies);
                sqlCmd.Parameters["@Cost"].Value = Convert.ToInt32(cost);
                sqlCmd.Parameters["@Plot"].Value = plot;
                sqlCmd.Parameters["@Genre"].Value = genre;

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

        public int delData(int UniqId) {

            if (UniqId == 0)
            {
                return 0;
            }
            else {

                String query = "select * from BookingRecord where VideoId="+Convert.ToInt32(UniqId)+" && VideoReturnDate='0'";
                DataTable tbl = new DataTable();
                tbl = getRecord(query);

                if (tbl.Rows.Count > 0)
                {
                    return 1;
                }
                else { 

                    String qry = "delete from Video  where VideoUniqID=@Id";
                    sqlConn = new SqlConnection(connection_String);
                    sqlConn.Open();
                    sqlCmd = new SqlCommand(qry, sqlConn);

                    sqlCmd.Parameters.Add("@Id", System.Data.SqlDbType.Int);

                    sqlCmd.Parameters["@Id"].Value = UniqId;

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
