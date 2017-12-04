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
            this.lblNameProject = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnImgMax = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnImgClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelStt = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.panelQuiz = new System.Windows.Forms.Panel();
            this.lblQues = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgClose)).BeginInit();
            this.panelContent.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.panelQuiz.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.panelHeader.Controls.Add(this.lblNameProject);
            this.panelHeader.Controls.Add(this.btnImgMax);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.btnImgClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(726, 51);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.DoubleClick += new System.EventHandler(this.btnImgMax_Click);
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
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.panelContent.Controls.Add(this.panelStt);
            this.panelContent.Controls.Add(this.panelButton);
            this.panelContent.Controls.Add(this.panelQuiz);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 51);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(726, 519);
            this.panelContent.TabIndex = 1;
            // 
            // panelStt
            // 
            this.panelStt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelStt.Location = new System.Drawing.Point(47, 7);
            this.panelStt.Name = "panelStt";
            this.panelStt.Size = new System.Drawing.Size(630, 31);
            this.panelStt.TabIndex = 2;
            // 
            // panelButton
            // 
            this.panelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelButton.BackColor = System.Drawing.Color.Transparent;
            this.panelButton.Controls.Add(this.bunifuThinButton23);
            this.panelButton.Controls.Add(this.bunifuThinButton22);
            this.panelButton.Controls.Add(this.bunifuThinButton21);
            this.panelButton.Location = new System.Drawing.Point(47, 456);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(630, 51);
            this.panelButton.TabIndex = 1;
            // 
            // panelQuiz
            // 
            this.panelQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelQuiz.AutoScroll = true;
            this.panelQuiz.BackColor = System.Drawing.Color.Red;
            this.panelQuiz.Controls.Add(this.lblQues);
            this.panelQuiz.Location = new System.Drawing.Point(47, 41);
            this.panelQuiz.Name = "panelQuiz";
            this.panelQuiz.Size = new System.Drawing.Size(630, 409);
            this.panelQuiz.TabIndex = 0;
            // 
            // lblQues
            // 
            this.lblQues.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQues.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQues.Location = new System.Drawing.Point(0, 0);
            this.lblQues.Name = "lblQues";
            this.lblQues.Size = new System.Drawing.Size(630, 13);
            this.lblQues.TabIndex = 0;
            this.lblQues.Text = "label";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Red;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Chọn";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(235, 3);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(163, 46);
            this.bunifuThinButton21.TabIndex = 0;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuThinButton22.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Tiếp theo";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.bunifuThinButton22.Location = new System.Drawing.Point(425, 10);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(116, 31);
            this.bunifuThinButton22.TabIndex = 0;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuThinButton23.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Quay lại";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(94)))));
            this.bunifuThinButton23.Location = new System.Drawing.Point(90, 10);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(116, 31);
            this.bunifuThinButton23.TabIndex = 0;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 570);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgClose)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.panelQuiz.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelContent;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton btnImgClose;
        private Bunifu.Framework.UI.BunifuImageButton btnImgMax;
        private System.Windows.Forms.Panel panelQuiz;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNameProject;
        private Bunifu.Framework.UI.BunifuCustomLabel lblQues;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelStt;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
    }
}