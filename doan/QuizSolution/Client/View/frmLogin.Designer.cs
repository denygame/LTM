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
            this.panelInfo = new System.Windows.Forms.Panel();
            this.btnConnect = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuMaterialTextbox5 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMaterialTextbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelProcess = new System.Windows.Forms.Panel();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.panelProcess.SuspendLayout();
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
            this.panelHeader.TabIndex = 0;
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
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.panelInfo.Controls.Add(this.btnConnect);
            this.panelInfo.Controls.Add(this.bunifuMaterialTextbox5);
            this.panelInfo.Controls.Add(this.bunifuCustomLabel5);
            this.panelInfo.Controls.Add(this.bunifuMaterialTextbox4);
            this.panelInfo.Controls.Add(this.bunifuCustomLabel4);
            this.panelInfo.Controls.Add(this.bunifuMaterialTextbox3);
            this.panelInfo.Controls.Add(this.bunifuCustomLabel3);
            this.panelInfo.Controls.Add(this.bunifuMaterialTextbox2);
            this.panelInfo.Controls.Add(this.bunifuCustomLabel2);
            this.panelInfo.Controls.Add(this.bunifuMaterialTextbox1);
            this.panelInfo.Controls.Add(this.bunifuCustomLabel1);
            this.PanelTransition.SetDecoration(this.panelInfo, BunifuAnimatorNS.DecorationType.None);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInfo.Location = new System.Drawing.Point(0, 49);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(310, 479);
            this.panelInfo.TabIndex = 1;
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
            // bunifuMaterialTextbox5
            // 
            this.bunifuMaterialTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PanelTransition.SetDecoration(this.bunifuMaterialTextbox5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox5.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuMaterialTextbox5.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox5.HintText = "";
            this.bunifuMaterialTextbox5.isPassword = false;
            this.bunifuMaterialTextbox5.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox5.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox5.LineMouseHoverColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox5.LineThickness = 3;
            this.bunifuMaterialTextbox5.Location = new System.Drawing.Point(29, 344);
            this.bunifuMaterialTextbox5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox5.Name = "bunifuMaterialTextbox5";
            this.bunifuMaterialTextbox5.Size = new System.Drawing.Size(256, 37);
            this.bunifuMaterialTextbox5.TabIndex = 21;
            this.bunifuMaterialTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // bunifuMaterialTextbox4
            // 
            this.bunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PanelTransition.SetDecoration(this.bunifuMaterialTextbox4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox4.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox4.HintText = "";
            this.bunifuMaterialTextbox4.isPassword = false;
            this.bunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox4.LineThickness = 3;
            this.bunifuMaterialTextbox4.Location = new System.Drawing.Point(29, 271);
            this.bunifuMaterialTextbox4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
            this.bunifuMaterialTextbox4.Size = new System.Drawing.Size(256, 37);
            this.bunifuMaterialTextbox4.TabIndex = 19;
            this.bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PanelTransition.SetDecoration(this.bunifuMaterialTextbox3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox3.HintText = "";
            this.bunifuMaterialTextbox3.isPassword = false;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox3.LineThickness = 3;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(29, 200);
            this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(256, 37);
            this.bunifuMaterialTextbox3.TabIndex = 17;
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PanelTransition.SetDecoration(this.bunifuMaterialTextbox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(29, 131);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(256, 37);
            this.bunifuMaterialTextbox2.TabIndex = 15;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PanelTransition.SetDecoration(this.bunifuMaterialTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(29, 61);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(256, 37);
            this.bunifuMaterialTextbox1.TabIndex = 13;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // panelProcess
            // 
            this.panelProcess.BackColor = System.Drawing.Color.Black;
            this.panelProcess.Controls.Add(this.bunifuThinButton22);
            this.panelProcess.Controls.Add(this.bunifuCircleProgressbar1);
            this.PanelTransition.SetDecoration(this.panelProcess, BunifuAnimatorNS.DecorationType.None);
            this.panelProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProcess.Location = new System.Drawing.Point(310, 49);
            this.panelProcess.Name = "panelProcess";
            this.panelProcess.Size = new System.Drawing.Size(310, 479);
            this.panelProcess.TabIndex = 2;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.bunifuThinButton22.BackColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Bắt Đầu Làm Bài";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.bunifuThinButton22, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.bunifuThinButton22.Location = new System.Drawing.Point(27, 399);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(256, 41);
            this.bunifuThinButton22.TabIndex = 14;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.PanelTransition.SetDecoration(this.bunifuCircleProgressbar1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 8;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(55, 103);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(201, 201);
            this.bunifuCircleProgressbar1.TabIndex = 13;
            this.bunifuCircleProgressbar1.Value = 35;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelHeader;
            this.bunifuDragControl1.Vertical = true;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelProcess.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelProcess;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConnect;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private BunifuAnimatorNS.BunifuTransition PanelTransition;
    }
}