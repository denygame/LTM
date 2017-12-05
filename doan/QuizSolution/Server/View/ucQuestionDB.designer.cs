namespace Server.View
{
    partial class ucQuestionDB
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucQuestionDB));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contentCourse = new System.Windows.Forms.Panel();
            this.btnCreateCourse = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnPrevPageCourse = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNextPageCourse = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPageCourse = new System.Windows.Forms.Label();
            this.dGv_Course = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearchCourse = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.headerCourse = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse_Header = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.contentQues = new System.Windows.Forms.Panel();
            this.btnAddQues = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnReadFile = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPageQues = new System.Windows.Forms.Label();
            this.btnPrevPageQues = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNextPageQues = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dGv_Ques = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSearchQues = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.headerQues = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.contentCourse.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGv_Course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.headerCourse.SuspendLayout();
            this.contentQues.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGv_Ques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.headerQues.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentCourse
            // 
            this.contentCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.contentCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.contentCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contentCourse.Controls.Add(this.btnCreateCourse);
            this.contentCourse.Controls.Add(this.btnPrevPageCourse);
            this.contentCourse.Controls.Add(this.btnNextPageCourse);
            this.contentCourse.Controls.Add(this.panel1);
            this.contentCourse.Controls.Add(this.dGv_Course);
            this.contentCourse.Controls.Add(this.pictureBox1);
            this.contentCourse.Controls.Add(this.txtSearchCourse);
            this.contentCourse.Location = new System.Drawing.Point(11, 36);
            this.contentCourse.Name = "contentCourse";
            this.contentCourse.Size = new System.Drawing.Size(294, 382);
            this.contentCourse.TabIndex = 0;
            // 
            // btnCreateCourse
            // 
            this.btnCreateCourse.ActiveBorderThickness = 1;
            this.btnCreateCourse.ActiveCornerRadius = 20;
            this.btnCreateCourse.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnCreateCourse.ActiveForecolor = System.Drawing.Color.White;
            this.btnCreateCourse.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.btnCreateCourse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateCourse.BackgroundImage")));
            this.btnCreateCourse.ButtonText = "Tạo Khóa Học Mới";
            this.btnCreateCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateCourse.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnCreateCourse.IdleBorderThickness = 1;
            this.btnCreateCourse.IdleCornerRadius = 20;
            this.btnCreateCourse.IdleFillColor = System.Drawing.Color.White;
            this.btnCreateCourse.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnCreateCourse.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateCourse.Location = new System.Drawing.Point(14, 72);
            this.btnCreateCourse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCreateCourse.Name = "btnCreateCourse";
            this.btnCreateCourse.Size = new System.Drawing.Size(264, 41);
            this.btnCreateCourse.TabIndex = 4;
            this.btnCreateCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreateCourse.Click += new System.EventHandler(this.btnCreateCourse_Click);
            // 
            // btnPrevPageCourse
            // 
            this.btnPrevPageCourse.ActiveBorderThickness = 1;
            this.btnPrevPageCourse.ActiveCornerRadius = 20;
            this.btnPrevPageCourse.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnPrevPageCourse.ActiveForecolor = System.Drawing.Color.White;
            this.btnPrevPageCourse.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrevPageCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevPageCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.btnPrevPageCourse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrevPageCourse.BackgroundImage")));
            this.btnPrevPageCourse.ButtonText = "Trước";
            this.btnPrevPageCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevPageCourse.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevPageCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnPrevPageCourse.IdleBorderThickness = 1;
            this.btnPrevPageCourse.IdleCornerRadius = 20;
            this.btnPrevPageCourse.IdleFillColor = System.Drawing.Color.White;
            this.btnPrevPageCourse.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnPrevPageCourse.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrevPageCourse.Location = new System.Drawing.Point(14, 330);
            this.btnPrevPageCourse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPrevPageCourse.Name = "btnPrevPageCourse";
            this.btnPrevPageCourse.Size = new System.Drawing.Size(84, 41);
            this.btnPrevPageCourse.TabIndex = 4;
            this.btnPrevPageCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNextPageCourse
            // 
            this.btnNextPageCourse.ActiveBorderThickness = 1;
            this.btnNextPageCourse.ActiveCornerRadius = 20;
            this.btnNextPageCourse.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnNextPageCourse.ActiveForecolor = System.Drawing.Color.White;
            this.btnNextPageCourse.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNextPageCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNextPageCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.btnNextPageCourse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNextPageCourse.BackgroundImage")));
            this.btnNextPageCourse.ButtonText = "Sau";
            this.btnNextPageCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPageCourse.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPageCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnNextPageCourse.IdleBorderThickness = 1;
            this.btnNextPageCourse.IdleCornerRadius = 20;
            this.btnNextPageCourse.IdleFillColor = System.Drawing.Color.White;
            this.btnNextPageCourse.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnNextPageCourse.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNextPageCourse.Location = new System.Drawing.Point(194, 330);
            this.btnNextPageCourse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNextPageCourse.Name = "btnNextPageCourse";
            this.btnNextPageCourse.Size = new System.Drawing.Size(84, 41);
            this.btnNextPageCourse.TabIndex = 4;
            this.btnNextPageCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.lblPageCourse);
            this.panel1.Location = new System.Drawing.Point(98, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 36);
            this.panel1.TabIndex = 3;
            // 
            // lblPageCourse
            // 
            this.lblPageCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPageCourse.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblPageCourse.Location = new System.Drawing.Point(0, 0);
            this.lblPageCourse.Name = "lblPageCourse";
            this.lblPageCourse.Size = new System.Drawing.Size(96, 36);
            this.lblPageCourse.TabIndex = 0;
            this.lblPageCourse.Text = "10000/10000";
            this.lblPageCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dGv_Course
            // 
            this.dGv_Course.AllowUserToAddRows = false;
            this.dGv_Course.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dGv_Course.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGv_Course.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dGv_Course.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGv_Course.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dGv_Course.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGv_Course.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dGv_Course.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGv_Course.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGv_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGv_Course.DoubleBuffered = true;
            this.dGv_Course.EnableHeadersVisualStyles = false;
            this.dGv_Course.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.dGv_Course.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.dGv_Course.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dGv_Course.Location = new System.Drawing.Point(14, 115);
            this.dGv_Course.Name = "dGv_Course";
            this.dGv_Course.ReadOnly = true;
            this.dGv_Course.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGv_Course.Size = new System.Drawing.Size(264, 208);
            this.dGv_Course.TabIndex = 2;
            this.dGv_Course.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGv_Course_CellDoubleClick);
            this.dGv_Course.SelectionChanged += new System.EventHandler(this.dGv_Course_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearchCourse
            // 
            this.txtSearchCourse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchCourse.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchCourse.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearchCourse.HintText = "Tìm khóa học";
            this.txtSearchCourse.isPassword = false;
            this.txtSearchCourse.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.txtSearchCourse.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearchCourse.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.txtSearchCourse.LineThickness = 3;
            this.txtSearchCourse.Location = new System.Drawing.Point(53, 35);
            this.txtSearchCourse.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchCourse.Name = "txtSearchCourse";
            this.txtSearchCourse.Size = new System.Drawing.Size(225, 33);
            this.txtSearchCourse.TabIndex = 0;
            this.txtSearchCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // headerCourse
            // 
            this.headerCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.headerCourse.Controls.Add(this.bunifuCustomLabel1);
            this.headerCourse.Location = new System.Drawing.Point(26, 9);
            this.headerCourse.Name = "headerCourse";
            this.headerCourse.Size = new System.Drawing.Size(264, 56);
            this.headerCourse.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(264, 56);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "KHÓA HỌC !";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse_Header
            // 
            this.bunifuElipse_Header.ElipseRadius = 5;
            this.bunifuElipse_Header.TargetControl = this.headerCourse;
            // 
            // contentQues
            // 
            this.contentQues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentQues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.contentQues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contentQues.Controls.Add(this.btnAddQues);
            this.contentQues.Controls.Add(this.btnReadFile);
            this.contentQues.Controls.Add(this.panel2);
            this.contentQues.Controls.Add(this.btnPrevPageQues);
            this.contentQues.Controls.Add(this.btnNextPageQues);
            this.contentQues.Controls.Add(this.dGv_Ques);
            this.contentQues.Controls.Add(this.pictureBox2);
            this.contentQues.Controls.Add(this.txtSearchQues);
            this.contentQues.Location = new System.Drawing.Point(311, 36);
            this.contentQues.Name = "contentQues";
            this.contentQues.Size = new System.Drawing.Size(385, 382);
            this.contentQues.TabIndex = 2;
            // 
            // btnAddQues
            // 
            this.btnAddQues.ActiveBorderThickness = 1;
            this.btnAddQues.ActiveCornerRadius = 20;
            this.btnAddQues.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(62)))));
            this.btnAddQues.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddQues.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddQues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.btnAddQues.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddQues.BackgroundImage")));
            this.btnAddQues.ButtonText = "Thêm";
            this.btnAddQues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQues.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(62)))));
            this.btnAddQues.IdleBorderThickness = 1;
            this.btnAddQues.IdleCornerRadius = 20;
            this.btnAddQues.IdleFillColor = System.Drawing.Color.White;
            this.btnAddQues.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(62)))));
            this.btnAddQues.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddQues.Location = new System.Drawing.Point(14, 72);
            this.btnAddQues.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddQues.Name = "btnAddQues";
            this.btnAddQues.Size = new System.Drawing.Size(101, 41);
            this.btnAddQues.TabIndex = 9;
            this.btnAddQues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddQues.Click += new System.EventHandler(this.btnAddQues_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.ActiveBorderThickness = 1;
            this.btnReadFile.ActiveCornerRadius = 20;
            this.btnReadFile.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(62)))));
            this.btnReadFile.ActiveForecolor = System.Drawing.Color.White;
            this.btnReadFile.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReadFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.btnReadFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReadFile.BackgroundImage")));
            this.btnReadFile.ButtonText = "Đọc File TXT";
            this.btnReadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReadFile.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(62)))));
            this.btnReadFile.IdleBorderThickness = 1;
            this.btnReadFile.IdleCornerRadius = 20;
            this.btnReadFile.IdleFillColor = System.Drawing.Color.White;
            this.btnReadFile.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(62)))));
            this.btnReadFile.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReadFile.Location = new System.Drawing.Point(231, 72);
            this.btnReadFile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(138, 41);
            this.btnReadFile.TabIndex = 8;
            this.btnReadFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblPageQues);
            this.panel2.Location = new System.Drawing.Point(148, 335);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 36);
            this.panel2.TabIndex = 7;
            // 
            // lblPageQues
            // 
            this.lblPageQues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPageQues.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageQues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblPageQues.Location = new System.Drawing.Point(0, 0);
            this.lblPageQues.Name = "lblPageQues";
            this.lblPageQues.Size = new System.Drawing.Size(96, 36);
            this.lblPageQues.TabIndex = 0;
            this.lblPageQues.Text = "10000/10000";
            this.lblPageQues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrevPageQues
            // 
            this.btnPrevPageQues.ActiveBorderThickness = 1;
            this.btnPrevPageQues.ActiveCornerRadius = 20;
            this.btnPrevPageQues.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(62)))));
            this.btnPrevPageQues.ActiveForecolor = System.Drawing.Color.White;
            this.btnPrevPageQues.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrevPageQues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevPageQues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.btnPrevPageQues.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrevPageQues.BackgroundImage")));
            this.btnPrevPageQues.ButtonText = "Trước";
            this.btnPrevPageQues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevPageQues.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevPageQues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(62)))));
            this.btnPrevPageQues.IdleBorderThickness = 1;
            this.btnPrevPageQues.IdleCornerRadius = 20;
            this.btnPrevPageQues.IdleFillColor = System.Drawing.Color.White;
            this.btnPrevPageQues.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(62)))));
            this.btnPrevPageQues.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrevPageQues.Location = new System.Drawing.Point(14, 330);
            this.btnPrevPageQues.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPrevPageQues.Name = "btnPrevPageQues";
            this.btnPrevPageQues.Size = new System.Drawing.Size(101, 41);
            this.btnPrevPageQues.TabIndex = 5;
            this.btnPrevPageQues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNextPageQues
            // 
            this.btnNextPageQues.ActiveBorderThickness = 1;
            this.btnNextPageQues.ActiveCornerRadius = 20;
            this.btnNextPageQues.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(62)))));
            this.btnNextPageQues.ActiveForecolor = System.Drawing.Color.White;
            this.btnNextPageQues.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNextPageQues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPageQues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.btnNextPageQues.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNextPageQues.BackgroundImage")));
            this.btnNextPageQues.ButtonText = "Sau";
            this.btnNextPageQues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPageQues.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPageQues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(62)))));
            this.btnNextPageQues.IdleBorderThickness = 1;
            this.btnNextPageQues.IdleCornerRadius = 20;
            this.btnNextPageQues.IdleFillColor = System.Drawing.Color.White;
            this.btnNextPageQues.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(62)))));
            this.btnNextPageQues.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNextPageQues.Location = new System.Drawing.Point(268, 330);
            this.btnNextPageQues.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNextPageQues.Name = "btnNextPageQues";
            this.btnNextPageQues.Size = new System.Drawing.Size(101, 41);
            this.btnNextPageQues.TabIndex = 6;
            this.btnNextPageQues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dGv_Ques
            // 
            this.dGv_Ques.AllowUserToAddRows = false;
            this.dGv_Ques.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dGv_Ques.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dGv_Ques.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGv_Ques.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dGv_Ques.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGv_Ques.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dGv_Ques.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGv_Ques.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dGv_Ques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGv_Ques.DoubleBuffered = true;
            this.dGv_Ques.EnableHeadersVisualStyles = false;
            this.dGv_Ques.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(62)))));
            this.dGv_Ques.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dGv_Ques.Location = new System.Drawing.Point(14, 115);
            this.dGv_Ques.Name = "dGv_Ques";
            this.dGv_Ques.ReadOnly = true;
            this.dGv_Ques.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGv_Ques.Size = new System.Drawing.Size(355, 208);
            this.dGv_Ques.TabIndex = 2;
            this.dGv_Ques.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGv_Ques_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // txtSearchQues
            // 
            this.txtSearchQues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchQues.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchQues.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchQues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchQues.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearchQues.HintText = "Tìm câu hỏi";
            this.txtSearchQues.isPassword = false;
            this.txtSearchQues.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(62)))));
            this.txtSearchQues.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearchQues.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(62)))));
            this.txtSearchQues.LineThickness = 3;
            this.txtSearchQues.Location = new System.Drawing.Point(53, 35);
            this.txtSearchQues.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchQues.Name = "txtSearchQues";
            this.txtSearchQues.Size = new System.Drawing.Size(316, 33);
            this.txtSearchQues.TabIndex = 1;
            this.txtSearchQues.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // headerQues
            // 
            this.headerQues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerQues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(62)))));
            this.headerQues.Controls.Add(this.bunifuCustomLabel2);
            this.headerQues.Location = new System.Drawing.Point(326, 9);
            this.headerQues.Name = "headerQues";
            this.headerQues.Size = new System.Drawing.Size(355, 56);
            this.headerQues.TabIndex = 1;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(355, 56);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "CÂU HỎI ?";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.headerQues;
            // 
            // ucQuestionDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.Controls.Add(this.headerQues);
            this.Controls.Add(this.contentQues);
            this.Controls.Add(this.headerCourse);
            this.Controls.Add(this.contentCourse);
            this.Name = "ucQuestionDB";
            this.Size = new System.Drawing.Size(707, 428);
            this.Load += new System.EventHandler(this.ucQuestionDB_Load);
            this.contentCourse.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGv_Course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.headerCourse.ResumeLayout(false);
            this.contentQues.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGv_Ques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.headerQues.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentCourse;
        private System.Windows.Forms.Panel headerCourse;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_Header;
        private System.Windows.Forms.Panel contentQues;
        private System.Windows.Forms.Panel headerQues;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchCourse;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchQues;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dGv_Course;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dGv_Ques;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPrevPageCourse;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNextPageCourse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPageCourse;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPrevPageQues;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNextPageQues;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPageQues;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReadFile;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddQues;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCreateCourse;
    }
}
