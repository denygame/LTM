namespace Server.View
{
    partial class frmCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCourse));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnImgClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCreateOrOK = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtNameCourse = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNumCourse = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.panelHeader.Controls.Add(this.lblName);
            this.panelHeader.Controls.Add(this.btnImgClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(332, 48);
            this.panelHeader.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(35, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Khóa Học !";
            // 
            // btnImgClose
            // 
            this.btnImgClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImgClose.BackColor = System.Drawing.Color.Transparent;
            this.btnImgClose.Image = ((System.Drawing.Image)(resources.GetObject("btnImgClose.Image")));
            this.btnImgClose.ImageActive = null;
            this.btnImgClose.Location = new System.Drawing.Point(295, 12);
            this.btnImgClose.Name = "btnImgClose";
            this.btnImgClose.Size = new System.Drawing.Size(25, 25);
            this.btnImgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnImgClose.TabIndex = 1;
            this.btnImgClose.TabStop = false;
            this.btnImgClose.Zoom = 20;
            this.btnImgClose.Click += new System.EventHandler(this.btnImgClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.lblName;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panelHeader;
            this.bunifuDragControl2.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCreateOrOK);
            this.panel1.Controls.Add(this.txtNameCourse);
            this.panel1.Controls.Add(this.txtNumCourse);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 163);
            this.panel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveBorderThickness = 1;
            this.btnDelete.ActiveCornerRadius = 20;
            this.btnDelete.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnDelete.ActiveForecolor = System.Drawing.Color.White;
            this.btnDelete.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.ButtonText = "Xóa";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleCornerRadius = 20;
            this.btnDelete.IdleFillColor = System.Drawing.Color.White;
            this.btnDelete.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnDelete.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnDelete.Location = new System.Drawing.Point(14, 111);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 41);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateOrOK
            // 
            this.btnCreateOrOK.ActiveBorderThickness = 1;
            this.btnCreateOrOK.ActiveCornerRadius = 20;
            this.btnCreateOrOK.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnCreateOrOK.ActiveForecolor = System.Drawing.Color.White;
            this.btnCreateOrOK.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateOrOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateOrOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.btnCreateOrOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateOrOK.BackgroundImage")));
            this.btnCreateOrOK.ButtonText = "Tạo";
            this.btnCreateOrOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateOrOK.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnCreateOrOK.IdleBorderThickness = 1;
            this.btnCreateOrOK.IdleCornerRadius = 20;
            this.btnCreateOrOK.IdleFillColor = System.Drawing.Color.White;
            this.btnCreateOrOK.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnCreateOrOK.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateOrOK.Location = new System.Drawing.Point(200, 111);
            this.btnCreateOrOK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCreateOrOK.Name = "btnCreateOrOK";
            this.btnCreateOrOK.Size = new System.Drawing.Size(118, 41);
            this.btnCreateOrOK.TabIndex = 3;
            this.btnCreateOrOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNameCourse
            // 
            this.txtNameCourse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameCourse.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNameCourse.HintForeColor = System.Drawing.Color.Empty;
            this.txtNameCourse.HintText = "";
            this.txtNameCourse.isPassword = false;
            this.txtNameCourse.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.txtNameCourse.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNameCourse.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.txtNameCourse.LineThickness = 3;
            this.txtNameCourse.Location = new System.Drawing.Point(118, 68);
            this.txtNameCourse.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameCourse.Name = "txtNameCourse";
            this.txtNameCourse.Size = new System.Drawing.Size(201, 33);
            this.txtNameCourse.TabIndex = 1;
            this.txtNameCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumCourse
            // 
            this.txtNumCourse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumCourse.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumCourse.HintForeColor = System.Drawing.Color.Empty;
            this.txtNumCourse.HintText = "";
            this.txtNumCourse.isPassword = false;
            this.txtNumCourse.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.txtNumCourse.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNumCourse.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.txtNumCourse.LineThickness = 3;
            this.txtNumCourse.Location = new System.Drawing.Point(118, 17);
            this.txtNumCourse.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumCourse.Name = "txtNumCourse";
            this.txtNumCourse.Size = new System.Drawing.Size(201, 33);
            this.txtNumCourse.TabIndex = 0;
            this.txtNumCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(82)))), ((int)(((byte)(105)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(2, 81);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(109, 20);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Tên Khóa Học:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(82)))), ((int)(((byte)(105)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(7, 30);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(104, 20);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Mã Khóa Học:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 211);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCourse";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuImageButton btnImgClose;
        private Bunifu.Framework.UI.BunifuCustomLabel lblName;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNumCourse;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNameCourse;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCreateOrOK;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
    }
}