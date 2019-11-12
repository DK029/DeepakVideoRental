using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepakVideoRental
{
    public partial class Form1 : Form
    {
        videoData videoObject = new videoData();
        Customer customerObject = new Customer();
        BookingRecord bookingObject = new BookingRecord();
        int BookUniqId = 0;
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("CLick on Video data , Customer Data and Rent to view the details ");
        }

        public void reset() {

            txt_VideoGenre.Text = "";
            txt_VideoPlot.Text = "";
            txt_VideoRatting.Text = "";
            txt_VideoTitle.Text = "";
            nm_VideoYear.Value = 0;
            nm_VideoCost.Value = 0;
            nm_VideoCopies.Value = 0;

            txt_CustomerAddress.Text = "";
            txt_CustomerFName.Text = "";
            txt_CustomerID.Text = "";
            txt_CustomerLName.Text = "";

            txt_CustomerID.Text = "";
            txt_MovieID.Text = "";

            BookUniqId = 0;


        }
        private void btn_VideoAdd_Click(object sender, EventArgs e)
        {
            //pass the value to the video class and invoke the method of the addData
            int data=videoObject.addData(txt_VideoTitle.Text.ToString(),txt_VideoRatting.Text.ToString(),Convert.ToInt32(nm_VideoYear.Value), Convert.ToInt32(nm_VideoCopies.Value), Convert.ToInt32(nm_VideoCost.Value),txt_VideoPlot.Text.ToString(),txt_VideoGenre.Text.ToString());
            if (data == 0)
            {
                MessageBox.Show("Record is not saved in the table check it properly");
            }
            else {
                MessageBox.Show("Record is saved in the table ");
            }
            reset();
        }

        private void btn_VideoUpdate_Click(object sender, EventArgs e)
        {
            //pass the value to the video class and invoke the method of the UpdateData
            int data = videoObject.updateData(Convert.ToInt32(txt_MovieID.Text.ToString()),txt_VideoTitle.Text.ToString(), txt_VideoRatting.Text.ToString(), Convert.ToInt32(nm_VideoYear.Value), Convert.ToInt32(nm_VideoCopies.Value), Convert.ToInt32(nm_VideoCost.Value), txt_VideoPlot.Text.ToString(), txt_VideoGenre.Text.ToString());
            if (data == 0)
            {
                MessageBox.Show("Record is not update in the table check it properly");
            }
            else
            {
                MessageBox.Show("Record is update in the table of the video ");
            }
            reset();

        }

        private void btn_VideoDelete_Click(object sender, EventArgs e)
        {
            //pass the value to the video class and invoke the method of the delData
            int data = videoObject.delData(Convert.ToInt32(txt_MovieID.Text.ToString()));
            if (data == 0)
            {
                MessageBox.Show("Record is not update in the table check it properly");
            }
            else
            {
                MessageBox.Show("Record is update in the table of the video ");
            }

            reset();
        }

        private void btn_CustomerAdd_Click(object sender, EventArgs e)
        {

            //add the data of the customer
            int data = customerObject.addData(txt_CustomerFName.Text.ToString(), txt_CustomerLName.Text.ToString(), nm_CustomerMobile.Value.ToString(), txt_CustomerAddress.Text.ToString());
            if (data == 0)
            {
                MessageBox.Show("Customer is not Registered ");
            }
            else {
                MessageBox.Show("Customer in registered and data is saved in the table");
            }

            reset();
        }

        private void btn_Customer_Delete_Click(object sender, EventArgs e)
        {
            //delete the data of the customer
            int data = customerObject.delData(Convert.ToInt32(txt_CustomerID.Text.ToString()));
            if (data == 0)
            {
                MessageBox.Show("Customer is not deleted ");
            }
            else
            {
                MessageBox.Show("Customer in deleted and data is removed from the table");
            }
            reset();

        }

        private void btn_CustomerUpdate_Click(object sender, EventArgs e)
        {
            //update the data of the customer

            int data = customerObject.updateData(Convert.ToInt32(txt_CustomerID.Text.ToString()),txt_CustomerFName.Text.ToString(), txt_CustomerLName.Text.ToString(), nm_CustomerMobile.Value.ToString(), txt_CustomerAddress.Text.ToString());
            if (data == 0)
            {
                MessageBox.Show("Customer record is not Updated ");
            }
            else
            {
                MessageBox.Show("Customer record in updated and data is also update in the table");
            }
            reset();
        }

        private void btn_BookVideo_Click(object sender, EventArgs e)
        {
            //book a video on rent
            int data = bookingObject.addData(Convert.ToInt32(txt_CustomerID.Text.ToString()), Convert.ToInt32(txt_MovieID.Text.ToString()), dtp_IssueDate.Text.ToString(), dtp_ReturnDate.Text.ToString());
            if (data == 0)
            {
                MessageBox.Show("check your record to get a video on rent ");
            }
            else {
                MessageBox.Show("video is given on rent ");
            }
            reset();
        }

        private void btn_DeleteVideo_Click(object sender, EventArgs e)
        {
            //delete the data of the video
            int data = bookingObject.deleteData(Convert.ToInt32(BookUniqId));
            if (data == 0)
            {
                MessageBox.Show("check your record to delete a video from rent ");
            }
            else
            {
                MessageBox.Show("video is delete the record ");
            }
            reset();

        }

        private void btn_ReturnVideo_Click(object sender, EventArgs e)
        {
            int data = bookingObject.updateData(Convert.ToInt32(BookUniqId),Convert.ToInt32(txt_CustomerID.Text.ToString()), Convert.ToInt32(txt_MovieID.Text.ToString()), dtp_IssueDate.Text.ToString(), dtp_ReturnDate.Text.ToString());
            if (data == 0)
            {
                MessageBox.Show("check your record to get a video on rent ");
            }
            else
            {

                //getting the differnece between  the days of the old and current date to generate the bill 
                String qry = "select * from Video where VideoUniqID=" + Convert.ToInt32(txt_MovieID.Text.ToString()) + "";
                DataTable tbl = new DataTable();
                tbl = videoObject.getRecord(qry);
                int Videocost = Convert.ToInt32(tbl.Rows[0]["Cost"].ToString());

                DateTime start = Convert.ToDateTime(dtp_IssueDate.Text.ToString());
                DateTime end = DateTime.Now;



                TimeSpan difference = end - start; //create TimeSpan object
                int days = difference.Days;
                if (difference.Days == 0)
                {
                    days = 1;
                }



                MessageBox.Show("video is return and your total charges are =$"+Videocost*days);
                reset();
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //display the whole video record
            if (checkBox1.Checked==true) {
                checkBox2.Checked = false;
                checkBox3.Checked = false;

                String query = "select * from Video";
                DataTable tbl = new DataTable();
                tbl = videoObject.getRecord(query);
                dgvRecord.DataSource = tbl;


            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //display the registered customer record
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;

                String query = "select * from Customer";
                DataTable tbl = new DataTable();
                tbl =customerObject.getRecord(query);
                dgvRecord.DataSource = tbl;


            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //display the booking video record
            if (checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;

                String query = "select * from BookRecord";
                DataTable tbl = new DataTable();
                tbl =bookingObject.getRecord(query);
                dgvRecord.DataSource = tbl;


            }
        }

        private void nm_VideoCopies_ValueChanged(object sender, EventArgs e)
        {


            // when we add  the year of the video then the cost of the video will be display automatically
            try
            {
                DateTime date = DateTime.Now;

                int year = date.Year;

                int yr = year - Convert.ToInt32(nm_VideoYear.Value);
                //if the  difference is more then the 5 year then the charges will be 2 dollar other wise 5 dollar per day
                if (yr >= 5)
                {
                    nm_VideoCost.Value = 2;
                }
                else if (yr >= 0 && yr < 5)
                {
                    nm_VideoCost.Value = 5;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //means video data will be fetched 
            if (checkBox1.Checked==true) {
                txt_MovieID.Text = dgvRecord.CurrentRow.Cells[0].Value.ToString();
                txt_VideoTitle.Text= dgvRecord.CurrentRow.Cells[1].Value.ToString();
                txt_VideoRatting.Text= dgvRecord.CurrentRow.Cells[2].Value.ToString();
                nm_VideoYear.Value = Convert.ToInt32(dgvRecord.CurrentRow.Cells[3].Value.ToString());
                nm_VideoCopies.Value= Convert.ToInt32(dgvRecord.CurrentRow.Cells[4].Value.ToString());
                nm_VideoCost.Value= Convert.ToInt32(dgvRecord.CurrentRow.Cells[5].Value.ToString());
                txt_VideoPlot.Text=dgvRecord.CurrentRow.Cells[6].Value.ToString();
                txt_VideoGenre.Text= dgvRecord.CurrentRow.Cells[7].Value.ToString();

            }
            // checkbox 2 is checked then it means customer record willbe display
            if (checkBox2.Checked==true){
                txt_CustomerID.Text= dgvRecord.CurrentRow.Cells[0].Value.ToString();
                txt_CustomerFName.Text= dgvRecord.CurrentRow.Cells[1].Value.ToString();
                txt_CustomerLName.Text= dgvRecord.CurrentRow.Cells[2].Value.ToString();
                nm_CustomerMobile.Value = Convert.ToInt32(dgvRecord.CurrentRow.Cells[3].Value.ToString());
                txt_CustomerAddress.Text= dgvRecord.CurrentRow.Cells[4].Value.ToString();


            }
            //if the 3rd checkbox is checked then it means rental record will display
            if (checkBox3.Checked==true) {
                BookUniqId=Convert.ToInt32(dgvRecord.CurrentRow.Cells[0].Value.ToString());
                txt_CustomerID.Text= dgvRecord.CurrentRow.Cells[1].Value.ToString();
                txt_MovieID.Text= dgvRecord.CurrentRow.Cells[2].Value.ToString();
                dtp_IssueDate.Text= dgvRecord.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable tblData = new DataTable();
            videoData instance_Rcrd = new videoData();
            tblData = instance_Rcrd.getRecord("select * from Video");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = instance_Rcrd.getRecord("select * from BookRecord where VideoId=" + Convert.ToInt32(tblData.Rows[x]["VideoUniqID"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Title"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }
            MessageBox.Show("Top Ratting Video Movie Title is ==" + Title);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tblData = new DataTable();
            Customer instance_Rcrd = new Customer();
            tblData = instance_Rcrd.getRecord("select * from Customer");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = instance_Rcrd.getRecord("select * from BookRecord where CustomerId=" + Convert.ToInt32(tblData.Rows[x]["CustomerUniqId"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["FrstName"].ToString()+" "+ tblData.Rows[x]["LstName"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }
            MessageBox.Show("Top Ratting Customer is ==" + Title);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
        }
    }
}
