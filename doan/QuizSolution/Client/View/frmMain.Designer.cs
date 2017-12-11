namespace Client.View
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblSecond = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblMinute = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNameProject = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnImgMax = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnImgClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelStt = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnPrev = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNext = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAccept = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelQuiz = new System.Windows.Forms.Panel();
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timerBlock = new System.Windows.Forms.Timer(this.components);
            this.lblInfo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgClose)).BeginInit();
            this.panelContent.SuspendLayout();
            this.panelStt.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.panelHeader.Controls.Add(this.lblSecond);
            this.panelHeader.Controls.Add(this.lblMinute);
            this.panelHeader.Controls.Add(this.lblNameProject);
            this.panelHeader.Controls.Add(this.btnImgMax);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.btnImgClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(726, 51);
            this.panelHeader.TabIndex = 3;
            this.panelHeader.DoubleClick += new System.EventHandler(this.btnImgMax_Click);
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.ForeColor = System.Drawing.Color.White;
            this.lblSecond.Location = new System.Drawing.Point(117, 19);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(30, 23);
            this.lblSecond.TabIndex = 3;
            this.lblSecond.Text = "00";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinute.ForeColor = System.Drawing.Color.White;
            this.lblMinute.Location = new System.Drawing.Point(81, 19);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(45, 23);
            this.lblMinute.TabIndex = 3;
            this.lblMinute.Text = "00 : ";
            // 
            // lblNameProject
            // 
            this.lblNameProject.AutoSize = true;
            this.lblNameProject.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProject.ForeColor = System.Drawing.Color.White;
            this.lblNameProject.Location = new System.Drawing.Point(12, 19);
            this.lblNameProject.Name = "lblNameProject";
            this.lblNameProject.Size = new System.Drawing.Size(53, 23);
            this.lblNameProject.TabIndex = 3;
            this.lblNameProject.Text = "Client";
            // 
            // btnImgMax
            // 
            this.btnImgMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImgMax.BackColor = System.Drawing.Color.Transparent;
            this.btnImgMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImgMax.Image = ((System.Drawing.Image)(resources.GetObject("btnImgMax.Image")));
            this.btnImgMax.ImageActive = null;
            this.btnImgMax.Location = new System.Drawing.Point(632, 12);
            this.btnImgMax.Name = "btnImgMax";
            this.btnImgMax.Size = new System.Drawing.Size(30, 30);
            this.btnImgMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnImgMax.TabIndex = 1;
            this.btnImgMax.TabStop = false;
            this.btnImgMax.Zoom = 20;
            this.btnImgMax.Click += new System.EventHandler(this.btnImgMax_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(596, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 20;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnImgClose
            // 
            this.btnImgClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImgClose.BackColor = System.Drawing.Color.Transparent;
            this.btnImgClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImgClose.Image = ((System.Drawing.Image)(resources.GetObject("btnImgClose.Image")));
            this.btnImgClose.ImageActive = null;
            this.btnImgClose.Location = new System.Drawing.Point(668, 12);
            this.btnImgClose.Name = "btnImgClose";
            this.btnImgClose.Size = new System.Drawing.Size(30, 30);
            this.btnImgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnImgClose.TabIndex = 2;
            this.btnImgClose.TabStop = false;
            this.btnImgClose.Zoom = 20;
            this.btnImgClose.Click += new System.EventHandler(this.btnImgClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.panelContent.Controls.Add(this.panelButton);
            this.panelContent.Controls.Add(this.panelQuiz);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 51);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(726, 519);
            this.panelContent.TabIndex = 4;
            // 
            // panelStt
            // 
            this.panelStt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.panelStt.Controls.Add(this.lblInfo);
            this.panelStt.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStt.Location = new System.Drawing.Point(0, 51);
            this.panelStt.Name = "panelStt";
            this.panelStt.Size = new System.Drawing.Size(726, 31);
            this.panelStt.TabIndex = 2;
            // 
            // panelButton
            // 
            this.panelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelButton.BackColor = System.Drawing.Color.Transparent;
            this.panelButton.Controls.Add(this.btnPrev);
            this.panelButton.Controls.Add(this.btnNext);
            this.panelButton.Controls.Add(this.btnAccept);
            this.panelButton.Location = new System.Drawing.Point(47, 456);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(630, 51);
            this.panelButton.TabIndex = 1;
            // 
            // btnPrev
            // 
            this.btnPrev.ActiveBorderThickness = 1;
            this.btnPrev.ActiveCornerRadius = 20;
            this.btnPrev.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.btnPrev.ActiveForecolor = System.Drawing.Color.White;
            this.btnPrev.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrev.BackgroundImage")));
            this.btnPrev.ButtonText = "Quay lại";
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.btnPrev.IdleBorderThickness = 1;
            this.btnPrev.IdleCornerRadius = 20;
            this.btnPrev.IdleFillColor = System.Drawing.Color.White;
            this.btnPrev.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.btnPrev.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.btnPrev.Location = new System.Drawing.Point(90, 10);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(116, 31);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.ActiveBorderThickness = 1;
            this.btnNext.ActiveCornerRadius = 20;
            this.btnNext.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.btnNext.ActiveForecolor = System.Drawing.Color.White;
            this.btnNext.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.ButtonText = "Tiếp theo";
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.btnNext.IdleBorderThickness = 1;
            this.btnNext.IdleCornerRadius = 20;
            this.btnNext.IdleFillColor = System.Drawing.Color.White;
            this.btnNext.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.btnNext.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.btnNext.Location = new System.Drawing.Point(425, 10);
            this.btnNext.Margin = new System.Windows.Forms.Padding(5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(116, 31);
            this.btnNext.TabIndex = 0;
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.ActiveBorderThickness = 1;
            this.btnAccept.ActiveCornerRadius = 20;
            this.btnAccept.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.btnAccept.ActiveForecolor = System.Drawing.Color.White;
            this.btnAccept.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAccept.BackColor = System.Drawing.Color.Transparent;
            this.btnAccept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccept.BackgroundImage")));
            this.btnAccept.ButtonText = "Chọn";
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.btnAccept.IdleBorderThickness = 1;
            this.btnAccept.IdleCornerRadius = 20;
            this.btnAccept.IdleFillColor = System.Drawing.Color.White;
            this.btnAccept.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.btnAccept.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.btnAccept.Location = new System.Drawing.Point(235, 2);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(5);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(163, 47);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // panelQuiz
            // 
            this.panelQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelQuiz.AutoScroll = true;
            this.panelQuiz.BackColor = System.Drawing.Color.Transparent;
            this.panelQuiz.Location = new System.Drawing.Point(47, 41);
            this.panelQuiz.Name = "panelQuiz";
            this.panelQuiz.Size = new System.Drawing.Size(630, 409);
            this.panelQuiz.TabIndex = 0;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.lblNameProject;
            this.bunifuDragControl3.Vertical = true;
            // 
            // timerBlock
            // 
            this.timerBlock.Interval = 1000;
            this.timerBlock.Tick += new System.EventHandler(this.timerBlock_Tick);
            // 
            // lblInfo
            // 
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo.Location = new System.Drawing.Point(0, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(726, 31);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 570);
            this.Controls.Add(this.panelStt);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "Trắc Nghiệm";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgClose)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelStt.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNameProject;
        private Bunifu.Framework.UI.BunifuImageButton btnImgMax;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton btnImgClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelStt;
        private System.Windows.Forms.Panel panelButton;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPrev;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNext;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAccept;
        private System.Windows.Forms.Panel panelQuiz;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSecond;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMinute;
        private System.Windows.Forms.Timer timerBlock;
        private Bunifu.Framework.UI.BunifuCustomLabel lblInfo;
    }
}