namespace Client.View
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelProcess = new System.Windows.Forms.Panel();
            this.btnStartQuiz = new Bunifu.Framework.UI.BunifuThinButton2();
            this.processBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.btnConnect = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtPort = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtIpServer = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtClass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PanelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panelProcess.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panelHeader.Controls.Add(this.btnClose);
            this.PanelTransition.SetDecoration(this.panelHeader, BunifuAnimatorNS.DecorationType.None);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(620, 49);
            this.panelHeader.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.PanelTransition.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(290, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 13;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 20;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelProcess
            // 
            this.panelProcess.BackColor = System.Drawing.Color.Black;
            this.panelProcess.Controls.Add(this.btnStartQuiz);
            this.panelProcess.Controls.Add(this.processBar);
            this.PanelTransition.SetDecoration(this.panelProcess, BunifuAnimatorNS.DecorationType.None);
            this.panelProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProcess.Location = new System.Drawing.Point(310, 49);
            this.panelProcess.Name = "panelProcess";
            this.panelProcess.Size = new System.Drawing.Size(310, 479);
            this.panelProcess.TabIndex = 4;
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.ActiveBorderThickness = 1;
            this.btnStartQuiz.ActiveCornerRadius = 20;
            this.btnStartQuiz.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.btnStartQuiz.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnStartQuiz.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnStartQuiz.BackColor = System.Drawing.Color.Black;
            this.btnStartQuiz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStartQuiz.BackgroundImage")));
            this.btnStartQuiz.ButtonText = "Bắt Đầu Làm Bài";
            this.btnStartQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnStartQuiz, BunifuAnimatorNS.DecorationType.None);
            this.btnStartQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartQuiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnStartQuiz.IdleBorderThickness = 1;
            this.btnStartQuiz.IdleCornerRadius = 20;
            this.btnStartQuiz.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnStartQuiz.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.btnStartQuiz.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnStartQuiz.Location = new System.Drawing.Point(27, 399);
            this.btnStartQuiz.Margin = new System.Windows.Forms.Padding(5);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(256, 41);
            this.btnStartQuiz.TabIndex = 14;
            this.btnStartQuiz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStartQuiz.Visible = false;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            // 
            // processBar
            // 
            this.processBar.animated = true;
            this.processBar.animationIterval = 30;
            this.processBar.animationSpeed = 100;
            this.processBar.BackColor = System.Drawing.Color.Black;
            this.processBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("processBar.BackgroundImage")));
            this.PanelTransition.SetDecoration(this.processBar, BunifuAnimatorNS.DecorationType.None);
            this.processBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.processBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.processBar.LabelVisible = true;
            this.processBar.LineProgressThickness = 8;
            this.processBar.LineThickness = 5;
            this.processBar.Location = new System.Drawing.Point(55, 103);
            this.processBar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.processBar.MaxValue = 100;
            this.processBar.Name = "processBar";
            this.processBar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.processBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.processBar.Size = new System.Drawing.Size(201, 201);
            this.processBar.TabIndex = 13;
            this.processBar.Value = 0;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.panelInfo.Controls.Add(this.btnConnect);
            this.panelInfo.Controls.Add(this.txtPort);
            this.panelInfo.Controls.Add(this.bunifuCustomLabel5);
            this.panelInfo.Controls.Add(this.txtIpServer);
            this.panelInfo.Controls.Add(this.bunifuCustomLabel4);
            this.panelInfo.Controls.Add(this.txtClass);
            this.panelInfo.Controls.Add(this.bunifuCustomLabel3);
            this.panelInfo.Controls.Add(this.txtName);
            this.panelInfo.Controls.Add(this.bunifuCustomLabel2);
            this.panelInfo.Controls.Add(this.txtCode);
            this.panelInfo.Controls.Add(this.bunifuCustomLabel1);
            this.PanelTransition.SetDecoration(this.panelInfo, BunifuAnimatorNS.DecorationType.None);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInfo.Location = new System.Drawing.Point(0, 49);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(310, 479);
            this.panelInfo.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.ActiveBorderThickness = 1;
            this.btnConnect.ActiveCornerRadius = 20;
            this.btnConnect.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.btnConnect.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnConnect.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btnConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnect.BackgroundImage")));
            this.btnConnect.ButtonText = "Kết Nối Với Server";
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnConnect, BunifuAnimatorNS.DecorationType.None);
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnConnect.IdleBorderThickness = 1;
            this.btnConnect.IdleCornerRadius = 20;
            this.btnConnect.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnConnect.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.btnConnect.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnConnect.Location = new System.Drawing.Point(29, 399);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(256, 41);
            this.btnConnect.TabIndex = 22;
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPort
            // 
            this.txtPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PanelTransition.SetDecoration(this.txtPort, BunifuAnimatorNS.DecorationType.None);
            this.txtPort.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtPort.HintForeColor = System.Drawing.Color.Empty;
            this.txtPort.HintText = "";
            this.txtPort.isPassword = false;
            this.txtPort.LineFocusedColor = System.Drawing.Color.White;
            this.txtPort.LineIdleColor = System.Drawing.Color.White;
            this.txtPort.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtPort.LineThickness = 3;
            this.txtPort.Location = new System.Drawing.Point(29, 344);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(256, 37);
            this.txtPort.TabIndex = 21;
            this.txtPort.Text = "12345";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.PanelTransition.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(26, 322);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(54, 18);
            this.bunifuCustomLabel5.TabIndex = 20;
            this.bunifuCustomLabel5.Text = "PORT";
            // 
            // txtIpServer
            // 
            this.txtIpServer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PanelTransition.SetDecoration(this.txtIpServer, BunifuAnimatorNS.DecorationType.None);
            this.txtIpServer.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIpServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtIpServer.HintForeColor = System.Drawing.Color.Empty;
            this.txtIpServer.HintText = "";
            this.txtIpServer.isPassword = false;
            this.txtIpServer.LineFocusedColor = System.Drawing.Color.White;
            this.txtIpServer.LineIdleColor = System.Drawing.Color.White;
            this.txtIpServer.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtIpServer.LineThickness = 3;
            this.txtIpServer.Location = new System.Drawing.Point(29, 271);
            this.txtIpServer.Margin = new System.Windows.Forms.Padding(4);
            this.txtIpServer.Name = "txtIpServer";
            this.txtIpServer.Size = new System.Drawing.Size(256, 37);
            this.txtIpServer.TabIndex = 19;
            this.txtIpServer.Text = "127.0.0.1";
            this.txtIpServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.PanelTransition.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(26, 249);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(98, 18);
            this.bunifuCustomLabel4.TabIndex = 18;
            this.bunifuCustomLabel4.Text = "IP SERVER";
            // 
            // txtClass
            // 
            this.txtClass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PanelTransition.SetDecoration(this.txtClass, BunifuAnimatorNS.DecorationType.None);
            this.txtClass.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtClass.HintForeColor = System.Drawing.Color.Empty;
            this.txtClass.HintText = "";
            this.txtClass.isPassword = false;
            this.txtClass.LineFocusedColor = System.Drawing.Color.White;
            this.txtClass.LineIdleColor = System.Drawing.Color.White;
            this.txtClass.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtClass.LineThickness = 3;
            this.txtClass.Location = new System.Drawing.Point(29, 200);
            this.txtClass.Margin = new System.Windows.Forms.Padding(4);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(256, 37);
            this.txtClass.TabIndex = 17;
            this.txtClass.Text = "CN14A";
            this.txtClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.PanelTransition.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(26, 178);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(43, 18);
            this.bunifuCustomLabel3.TabIndex = 16;
            this.bunifuCustomLabel3.Text = "LỚP";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PanelTransition.SetDecoration(this.txtName, BunifuAnimatorNS.DecorationType.None);
            this.txtName.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.White;
            this.txtName.LineIdleColor = System.Drawing.Color.White;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(29, 131);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(256, 37);
            this.txtName.TabIndex = 15;
            this.txtName.Text = "Nguyễn Thanh Huy";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.PanelTransition.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(26, 109);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(70, 18);
            this.bunifuCustomLabel2.TabIndex = 14;
            this.bunifuCustomLabel2.Text = "HỌ TÊN";
            // 
            // txtCode
            // 
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PanelTransition.SetDecoration(this.txtCode, BunifuAnimatorNS.DecorationType.None);
            this.txtCode.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtCode.HintForeColor = System.Drawing.Color.Empty;
            this.txtCode.HintText = "";
            this.txtCode.isPassword = false;
            this.txtCode.LineFocusedColor = System.Drawing.Color.White;
            this.txtCode.LineIdleColor = System.Drawing.Color.White;
            this.txtCode.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtCode.LineThickness = 3;
            this.txtCode.Location = new System.Drawing.Point(29, 61);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(256, 37);
            this.txtCode.TabIndex = 13;
            this.txtCode.Text = "1451120025";
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.PanelTransition.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(26, 39);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(55, 18);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "MSSV";
            // 
            // PanelTransition
            // 
            this.PanelTransition.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.PanelTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.PanelTransition.DefaultAnimation = animation1;
            this.PanelTransition.MaxAnimationTime = 500;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 528);
            this.Controls.Add(this.panelProcess);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelHeader);
            this.PanelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "Kết Nối";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin2_Load);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panelProcess.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panelProcess;
        private Bunifu.Framework.UI.BunifuThinButton2 btnStartQuiz;
        private Bunifu.Framework.UI.BunifuCircleProgressbar processBar;
        private System.Windows.Forms.Panel panelInfo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConnect;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPort;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIpServer;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtClass;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCode;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private BunifuAnimatorNS.BunifuTransition PanelTransition;
    }
}