namespace DeepakVideoRental
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nm_VideoCopies = new System.Windows.Forms.NumericUpDown();
            this.nm_VideoCost = new System.Windows.Forms.NumericUpDown();
            this.nm_VideoYear = new System.Windows.Forms.NumericUpDown();
            this.nm_CustomerMobile = new System.Windows.Forms.NumericUpDown();
            this.txt_VideoGenre = new System.Windows.Forms.TextBox();
            this.txt_VideoPlot = new System.Windows.Forms.TextBox();
            this.txt_VideoRatting = new System.Windows.Forms.TextBox();
            this.txt_VideoTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_MovieID = new System.Windows.Forms.TextBox();
            this.txt_CustomerID = new System.Windows.Forms.TextBox();
            this.btn_DeleteVideo = new System.Windows.Forms.Button();
            this.btn_ReturnVideo = new System.Windows.Forms.Button();
            this.btn_BookVideo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_Customer_Delete = new System.Windows.Forms.Button();
            this.btn_CustomerUpdate = new System.Windows.Forms.Button();
            this.btn_CustomerAdd = new System.Windows.Forms.Button();
            this.txt_CustomerAddress = new System.Windows.Forms.TextBox();
            this.txt_CustomerLName = new System.Windows.Forms.TextBox();
            this.txt_CustomerFName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_VideoDelete = new System.Windows.Forms.Button();
            this.btn_VideoUpdate = new System.Windows.Forms.Button();
            this.btn_VideoAdd = new System.Windows.Forms.Button();
            this.dtp_IssueDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nm_VideoCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_VideoCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_VideoYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_CustomerMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Silver;
            this.label18.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1500, 346);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(220, 36);
            this.label18.TabIndex = 187;
            this.label18.Text = "Rental System";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(461, 309);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(153, 36);
            this.label17.TabIndex = 186;
            this.label17.Text = "Customer";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 36);
            this.label1.TabIndex = 185;
            this.label1.Text = "Video Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nm_VideoCopies
            // 
            this.nm_VideoCopies.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_VideoCopies.Location = new System.Drawing.Point(176, 196);
            this.nm_VideoCopies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nm_VideoCopies.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nm_VideoCopies.Name = "nm_VideoCopies";
            this.nm_VideoCopies.Size = new System.Drawing.Size(231, 40);
            this.nm_VideoCopies.TabIndex = 184;
            this.nm_VideoCopies.ValueChanged += new System.EventHandler(this.nm_VideoCopies_ValueChanged);
            // 
            // nm_VideoCost
            // 
            this.nm_VideoCost.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_VideoCost.Location = new System.Drawing.Point(176, 252);
            this.nm_VideoCost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nm_VideoCost.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nm_VideoCost.Name = "nm_VideoCost";
            this.nm_VideoCost.Size = new System.Drawing.Size(231, 40);
            this.nm_VideoCost.TabIndex = 183;
            // 
            // nm_VideoYear
            // 
            this.nm_VideoYear.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_VideoYear.Location = new System.Drawing.Point(176, 142);
            this.nm_VideoYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nm_VideoYear.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nm_VideoYear.Name = "nm_VideoYear";
            this.nm_VideoYear.Size = new System.Drawing.Size(231, 40);
            this.nm_VideoYear.TabIndex = 182;
            // 
            // nm_CustomerMobile
            // 
            this.nm_CustomerMobile.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_CustomerMobile.Location = new System.Drawing.Point(181, 147);
            this.nm_CustomerMobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nm_CustomerMobile.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nm_CustomerMobile.Name = "nm_CustomerMobile";
            this.nm_CustomerMobile.Size = new System.Drawing.Size(231, 40);
            this.nm_CustomerMobile.TabIndex = 181;
            // 
            // txt_VideoGenre
            // 
            this.txt_VideoGenre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_VideoGenre.Location = new System.Drawing.Point(176, 364);
            this.txt_VideoGenre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_VideoGenre.Name = "txt_VideoGenre";
            this.txt_VideoGenre.Size = new System.Drawing.Size(229, 44);
            this.txt_VideoGenre.TabIndex = 180;
            // 
            // txt_VideoPlot
            // 
            this.txt_VideoPlot.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_VideoPlot.Location = new System.Drawing.Point(176, 305);
            this.txt_VideoPlot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_VideoPlot.Name = "txt_VideoPlot";
            this.txt_VideoPlot.Size = new System.Drawing.Size(229, 44);
            this.txt_VideoPlot.TabIndex = 179;
            // 
            // txt_VideoRatting
            // 
            this.txt_VideoRatting.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_VideoRatting.Location = new System.Drawing.Point(176, 89);
            this.txt_VideoRatting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_VideoRatting.Name = "txt_VideoRatting";
            this.txt_VideoRatting.Size = new System.Drawing.Size(229, 44);
            this.txt_VideoRatting.TabIndex = 178;
            // 
            // txt_VideoTitle
            // 
            this.txt_VideoTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_VideoTitle.Location = new System.Drawing.Point(176, 19);
            this.txt_VideoTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_VideoTitle.Name = "txt_VideoTitle";
            this.txt_VideoTitle.Size = new System.Drawing.Size(229, 44);
            this.txt_VideoTitle.TabIndex = 177;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 378);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 36);
            this.label7.TabIndex = 176;
            this.label7.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 318);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 36);
            this.label6.TabIndex = 175;
            this.label6.Text = "Plot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 36);
            this.label5.TabIndex = 174;
            this.label5.Text = "Copies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 36);
            this.label4.TabIndex = 173;
            this.label4.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 36);
            this.label3.TabIndex = 172;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 36);
            this.label2.TabIndex = 171;
            this.label2.Text = "Points";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Yellow;
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(25, 19);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 36);
            this.label16.TabIndex = 170;
            this.label16.Text = "Title";
            // 
            // txt_MovieID
            // 
            this.txt_MovieID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MovieID.Location = new System.Drawing.Point(296, 70);
            this.txt_MovieID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MovieID.Name = "txt_MovieID";
            this.txt_MovieID.Size = new System.Drawing.Size(229, 44);
            this.txt_MovieID.TabIndex = 169;
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustomerID.Location = new System.Drawing.Point(296, 16);
            this.txt_CustomerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.Size = new System.Drawing.Size(229, 44);
            this.txt_CustomerID.TabIndex = 168;
            // 
            // btn_DeleteVideo
            // 
            this.btn_DeleteVideo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_DeleteVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteVideo.Location = new System.Drawing.Point(87, 288);
            this.btn_DeleteVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_DeleteVideo.Name = "btn_DeleteVideo";
            this.btn_DeleteVideo.Size = new System.Drawing.Size(411, 57);
            this.btn_DeleteVideo.TabIndex = 167;
            this.btn_DeleteVideo.Text = "Delete";
            this.btn_DeleteVideo.UseVisualStyleBackColor = false;
            this.btn_DeleteVideo.Click += new System.EventHandler(this.btn_DeleteVideo_Click);
            // 
            // btn_ReturnVideo
            // 
            this.btn_ReturnVideo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_ReturnVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReturnVideo.Location = new System.Drawing.Point(267, 230);
            this.btn_ReturnVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ReturnVideo.Name = "btn_ReturnVideo";
            this.btn_ReturnVideo.Size = new System.Drawing.Size(231, 49);
            this.btn_ReturnVideo.TabIndex = 166;
            this.btn_ReturnVideo.Text = "Return";
            this.btn_ReturnVideo.UseVisualStyleBackColor = false;
            this.btn_ReturnVideo.Click += new System.EventHandler(this.btn_ReturnVideo_Click);
            // 
            // btn_BookVideo
            // 
            this.btn_BookVideo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_BookVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BookVideo.Location = new System.Drawing.Point(84, 230);
            this.btn_BookVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_BookVideo.Name = "btn_BookVideo";
            this.btn_BookVideo.Size = new System.Drawing.Size(152, 49);
            this.btn_BookVideo.TabIndex = 165;
            this.btn_BookVideo.Text = "Issue";
            this.btn_BookVideo.UseVisualStyleBackColor = false;
            this.btn_BookVideo.Click += new System.EventHandler(this.btn_BookVideo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Silver;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(54, 168);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(231, 36);
            this.label12.TabIndex = 164;
            this.label12.Text = "Date of Return ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(53, 125);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(202, 36);
            this.label13.TabIndex = 163;
            this.label13.Text = "Date of Issue";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Silver;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(53, 75);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 36);
            this.label14.TabIndex = 162;
            this.label14.Text = "Movie ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Silver;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(53, 20);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(194, 36);
            this.label15.TabIndex = 161;
            this.label15.Text = "Customer ID";
            // 
            // btn_Customer_Delete
            // 
            this.btn_Customer_Delete.BackColor = System.Drawing.Color.DimGray;
            this.btn_Customer_Delete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer_Delete.Location = new System.Drawing.Point(1, 314);
            this.btn_Customer_Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Customer_Delete.Name = "btn_Customer_Delete";
            this.btn_Customer_Delete.Size = new System.Drawing.Size(411, 57);
            this.btn_Customer_Delete.TabIndex = 160;
            this.btn_Customer_Delete.Text = "Delete";
            this.btn_Customer_Delete.UseVisualStyleBackColor = false;
            this.btn_Customer_Delete.Click += new System.EventHandler(this.btn_Customer_Delete_Click);
            // 
            // btn_CustomerUpdate
            // 
            this.btn_CustomerUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btn_CustomerUpdate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomerUpdate.Location = new System.Drawing.Point(181, 263);
            this.btn_CustomerUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_CustomerUpdate.Name = "btn_CustomerUpdate";
            this.btn_CustomerUpdate.Size = new System.Drawing.Size(231, 49);
            this.btn_CustomerUpdate.TabIndex = 159;
            this.btn_CustomerUpdate.Text = "Update";
            this.btn_CustomerUpdate.UseVisualStyleBackColor = false;
            this.btn_CustomerUpdate.Click += new System.EventHandler(this.btn_CustomerUpdate_Click);
            // 
            // btn_CustomerAdd
            // 
            this.btn_CustomerAdd.BackColor = System.Drawing.Color.DimGray;
            this.btn_CustomerAdd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomerAdd.Location = new System.Drawing.Point(-3, 262);
            this.btn_CustomerAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_CustomerAdd.Name = "btn_CustomerAdd";
            this.btn_CustomerAdd.Size = new System.Drawing.Size(152, 49);
            this.btn_CustomerAdd.TabIndex = 157;
            this.btn_CustomerAdd.Text = "Add";
            this.btn_CustomerAdd.UseVisualStyleBackColor = false;
            this.btn_CustomerAdd.Click += new System.EventHandler(this.btn_CustomerAdd_Click);
            // 
            // txt_CustomerAddress
            // 
            this.txt_CustomerAddress.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustomerAddress.Location = new System.Drawing.Point(181, 202);
            this.txt_CustomerAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_CustomerAddress.Name = "txt_CustomerAddress";
            this.txt_CustomerAddress.Size = new System.Drawing.Size(229, 44);
            this.txt_CustomerAddress.TabIndex = 158;
            // 
            // txt_CustomerLName
            // 
            this.txt_CustomerLName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustomerLName.Location = new System.Drawing.Point(181, 85);
            this.txt_CustomerLName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_CustomerLName.Name = "txt_CustomerLName";
            this.txt_CustomerLName.Size = new System.Drawing.Size(229, 44);
            this.txt_CustomerLName.TabIndex = 156;
            // 
            // txt_CustomerFName
            // 
            this.txt_CustomerFName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustomerFName.Location = new System.Drawing.Point(181, 27);
            this.txt_CustomerFName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_CustomerFName.Name = "txt_CustomerFName";
            this.txt_CustomerFName.Size = new System.Drawing.Size(229, 44);
            this.txt_CustomerFName.TabIndex = 155;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-9, 205);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 36);
            this.label8.TabIndex = 154;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-9, 148);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 36);
            this.label9.TabIndex = 153;
            this.label9.Text = "Mobile No.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-4, 92);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 36);
            this.label10.TabIndex = 152;
            this.label10.Text = "Last Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-8, 33);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 36);
            this.label11.TabIndex = 151;
            this.label11.Text = "First Name";
            // 
            // btn_VideoDelete
            // 
            this.btn_VideoDelete.BackColor = System.Drawing.Color.Gray;
            this.btn_VideoDelete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VideoDelete.Location = new System.Drawing.Point(280, 445);
            this.btn_VideoDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_VideoDelete.Name = "btn_VideoDelete";
            this.btn_VideoDelete.Size = new System.Drawing.Size(128, 49);
            this.btn_VideoDelete.TabIndex = 192;
            this.btn_VideoDelete.Text = "Delete";
            this.btn_VideoDelete.UseVisualStyleBackColor = false;
            this.btn_VideoDelete.Click += new System.EventHandler(this.btn_VideoDelete_Click);
            // 
            // btn_VideoUpdate
            // 
            this.btn_VideoUpdate.BackColor = System.Drawing.Color.Gray;
            this.btn_VideoUpdate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VideoUpdate.Location = new System.Drawing.Point(144, 445);
            this.btn_VideoUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_VideoUpdate.Name = "btn_VideoUpdate";
            this.btn_VideoUpdate.Size = new System.Drawing.Size(128, 49);
            this.btn_VideoUpdate.TabIndex = 191;
            this.btn_VideoUpdate.Text = "Update";
            this.btn_VideoUpdate.UseVisualStyleBackColor = false;
            this.btn_VideoUpdate.Click += new System.EventHandler(this.btn_VideoUpdate_Click);
            // 
            // btn_VideoAdd
            // 
            this.btn_VideoAdd.BackColor = System.Drawing.Color.Gray;
            this.btn_VideoAdd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VideoAdd.Location = new System.Drawing.Point(7, 445);
            this.btn_VideoAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_VideoAdd.Name = "btn_VideoAdd";
            this.btn_VideoAdd.Size = new System.Drawing.Size(128, 49);
            this.btn_VideoAdd.TabIndex = 190;
            this.btn_VideoAdd.Text = "Add";
            this.btn_VideoAdd.UseVisualStyleBackColor = false;
            this.btn_VideoAdd.Click += new System.EventHandler(this.btn_VideoAdd_Click);
            // 
            // dtp_IssueDate
            // 
            this.dtp_IssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_IssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_IssueDate.Location = new System.Drawing.Point(295, 125);
            this.dtp_IssueDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_IssueDate.Name = "dtp_IssueDate";
            this.dtp_IssueDate.Size = new System.Drawing.Size(229, 43);
            this.dtp_IssueDate.TabIndex = 193;
            // 
            // dtp_ReturnDate
            // 
            this.dtp_ReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ReturnDate.Location = new System.Drawing.Point(296, 171);
            this.dtp_ReturnDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_ReturnDate.Name = "dtp_ReturnDate";
            this.dtp_ReturnDate.Size = new System.Drawing.Size(229, 43);
            this.dtp_ReturnDate.TabIndex = 194;
            // 
            // dgvRecord
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecord.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecord.Location = new System.Drawing.Point(672, 4);
            this.dgvRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRecord.Name = "dgvRecord";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecord.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecord.RowHeadersWidth = 62;
            this.dgvRecord.Size = new System.Drawing.Size(1026, 337);
            this.dgvRecord.TabIndex = 195;
            this.dgvRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecord_CellContentClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(455, 38);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 41);
            this.checkBox1.TabIndex = 196;
            this.checkBox1.Text = "Video";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(449, 144);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(182, 41);
            this.checkBox2.TabIndex = 197;
            this.checkBox2.Text = "Customer";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(455, 89);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(159, 41);
            this.checkBox3.TabIndex = 198;
            this.checkBox3.Text = "Booking";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 672);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(404, 49);
            this.button1.TabIndex = 199;
            this.button1.Text = " Popular Customer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(18, 596);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(406, 49);
            this.button2.TabIndex = 200;
            this.button2.Text = "Most Rented Movie";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_VideoTitle);
            this.groupBox1.Controls.Add(this.txt_VideoRatting);
            this.groupBox1.Controls.Add(this.btn_VideoDelete);
            this.groupBox1.Controls.Add(this.txt_VideoPlot);
            this.groupBox1.Controls.Add(this.btn_VideoUpdate);
            this.groupBox1.Controls.Add(this.txt_VideoGenre);
            this.groupBox1.Controls.Add(this.btn_VideoAdd);
            this.groupBox1.Controls.Add(this.nm_VideoYear);
            this.groupBox1.Controls.Add(this.nm_VideoCost);
            this.groupBox1.Controls.Add(this.nm_VideoCopies);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 497);
            this.groupBox1.TabIndex = 201;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txt_CustomerFName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_CustomerLName);
            this.groupBox2.Controls.Add(this.txt_CustomerAddress);
            this.groupBox2.Controls.Add(this.btn_CustomerAdd);
            this.groupBox2.Controls.Add(this.btn_CustomerUpdate);
            this.groupBox2.Controls.Add(this.btn_Customer_Delete);
            this.groupBox2.Controls.Add(this.nm_CustomerMobile);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(438, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 365);
            this.groupBox2.TabIndex = 202;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fill All";
            this.groupBox2.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txt_CustomerID);
            this.groupBox3.Controls.Add(this.txt_MovieID);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.dtp_IssueDate);
            this.groupBox3.Controls.Add(this.dtp_ReturnDate);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btn_ReturnVideo);
            this.groupBox3.Controls.Add(this.btn_BookVideo);
            this.groupBox3.Controls.Add(this.btn_DeleteVideo);
            this.groupBox3.Location = new System.Drawing.Point(911, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(567, 362);
            this.groupBox3.TabIndex = 203;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fill All";
            this.groupBox3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1764, 802);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dgvRecord);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.nm_VideoCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_VideoCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_VideoYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_CustomerMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nm_VideoCopies;
        private System.Windows.Forms.NumericUpDown nm_VideoCost;
        private System.Windows.Forms.NumericUpDown nm_VideoYear;
        private System.Windows.Forms.NumericUpDown nm_CustomerMobile;
        private System.Windows.Forms.TextBox txt_VideoGenre;
        private System.Windows.Forms.TextBox txt_VideoPlot;
        private System.Windows.Forms.TextBox txt_VideoRatting;
        private System.Windows.Forms.TextBox txt_VideoTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_MovieID;
        private System.Windows.Forms.TextBox txt_CustomerID;
        private System.Windows.Forms.Button btn_DeleteVideo;
        private System.Windows.Forms.Button btn_ReturnVideo;
        private System.Windows.Forms.Button btn_BookVideo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_Customer_Delete;
        private System.Windows.Forms.Button btn_CustomerUpdate;
        private System.Windows.Forms.Button btn_CustomerAdd;
        private System.Windows.Forms.TextBox txt_CustomerAddress;
        private System.Windows.Forms.TextBox txt_CustomerLName;
        private System.Windows.Forms.TextBox txt_CustomerFName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_VideoDelete;
        private System.Windows.Forms.Button btn_VideoUpdate;
        private System.Windows.Forms.Button btn_VideoAdd;
        private System.Windows.Forms.DateTimePicker dtp_IssueDate;
        private System.Windows.Forms.DateTimePicker dtp_ReturnDate;
        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

