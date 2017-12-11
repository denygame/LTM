namespace Server.View
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.panelSlideMenu = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnRunServer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSetting = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuestion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblInfo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNameProject = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnImgClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LogoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelContent = new System.Windows.Forms.Panel();
            this.SlideMenuTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelSlideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSlideMenu
            // 
            this.panelSlideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.panelSlideMenu.Controls.Add(this.logo);
            this.panelSlideMenu.Controls.Add(this.btnRunServer);
            this.panelSlideMenu.Controls.Add(this.btnSetting);
            this.panelSlideMenu.Controls.Add(this.btnQuestion);
            this.SlideMenuTransition.SetDecoration(this.panelSlideMenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.panelSlideMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelSlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlideMenu.Location = new System.Drawing.Point(0, 45);
            this.panelSlideMenu.Name = "panelSlideMenu";
            this.panelSlideMenu.Size = new System.Drawing.Size(206, 478);
            this.panelSlideMenu.TabIndex = 0;
            // 
            // logo
            // 
            this.LogoTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.SlideMenuTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(207, 57);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            // 
            // btnRunServer
            // 
            this.btnRunServer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(112)))), ((int)(((byte)(119)))));
            this.btnRunServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.btnRunServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRunServer.BorderRadius = 0;
            this.btnRunServer.ButtonText = "      Run Server";
            this.btnRunServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlideMenuTransition.SetDecoration(this.btnRunServer, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnRunServer, BunifuAnimatorNS.DecorationType.None);
            this.btnRunServer.DisabledColor = System.Drawing.Color.Gray;
            this.btnRunServer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunServer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRunServer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRunServer.Iconimage")));
            this.btnRunServer.Iconimage_right = null;
            this.btnRunServer.Iconimage_right_Selected = null;
            this.btnRunServer.Iconimage_Selected = null;
            this.btnRunServer.IconMarginLeft = 0;
            this.btnRunServer.IconMarginRight = 0;
            this.btnRunServer.IconRightVisible = true;
            this.btnRunServer.IconRightZoom = 0D;
            this.btnRunServer.IconVisible = true;
            this.btnRunServer.IconZoom = 70D;
            this.btnRunServer.IsTab = true;
            this.btnRunServer.Location = new System.Drawing.Point(0, 235);
            this.btnRunServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRunServer.Name = "btnRunServer";
            this.btnRunServer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.btnRunServer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(112)))), ((int)(((byte)(119)))));
            this.btnRunServer.OnHoverTextColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRunServer.selected = false;
            this.btnRunServer.Size = new System.Drawing.Size(207, 48);
            this.btnRunServer.TabIndex = 3;
            this.btnRunServer.Text = "      Run Server";
            this.btnRunServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunServer.Textcolor = System.Drawing.Color.White;
            this.btnRunServer.TextFont = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunServer.Click += new System.EventHandler(this.btnRunServer_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(112)))), ((int)(((byte)(119)))));
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.BorderRadius = 0;
            this.btnSetting.ButtonText = "      Cấu Hình";
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlideMenuTransition.SetDecoration(this.btnSetting, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnSetting, BunifuAnimatorNS.DecorationType.None);
            this.btnSetting.DisabledColor = System.Drawing.Color.Gray;
            this.btnSetting.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSetting.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSetting.Iconimage")));
            this.btnSetting.Iconimage_right = null;
            this.btnSetting.Iconimage_right_Selected = null;
            this.btnSetting.Iconimage_Selected = null;
            this.btnSetting.IconMarginLeft = 0;
            this.btnSetting.IconMarginRight = 0;
            this.btnSetting.IconRightVisible = true;
            this.btnSetting.IconRightZoom = 0D;
            this.btnSetting.IconVisible = true;
            this.btnSetting.IconZoom = 70D;
            this.btnSetting.IsTab = true;
            this.btnSetting.Location = new System.Drawing.Point(0, 179);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.btnSetting.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(112)))), ((int)(((byte)(119)))));
            this.btnSetting.OnHoverTextColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSetting.selected = false;
            this.btnSetting.Size = new System.Drawing.Size(207, 48);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Text = "      Cấu Hình";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Textcolor = System.Drawing.Color.White;
            this.btnSetting.TextFont = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnQuestion
            // 
            this.btnQuestion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(112)))), ((int)(((byte)(119)))));
            this.btnQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(112)))), ((int)(((byte)(119)))));
            this.btnQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuestion.BorderRadius = 0;
            this.btnQuestion.ButtonText = "      CSDL";
            this.btnQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlideMenuTransition.SetDecoration(this.btnQuestion, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnQuestion, BunifuAnimatorNS.DecorationType.None);
            this.btnQuestion.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuestion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuestion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuestion.Iconimage")));
            this.btnQuestion.Iconimage_right = null;
            this.btnQuestion.Iconimage_right_Selected = null;
            this.btnQuestion.Iconimage_Selected = null;
            this.btnQuestion.IconMarginLeft = 0;
            this.btnQuestion.IconMarginRight = 0;
            this.btnQuestion.IconRightVisible = true;
            this.btnQuestion.IconRightZoom = 0D;
            this.btnQuestion.IconVisible = true;
            this.btnQuestion.IconZoom = 70D;
            this.btnQuestion.IsTab = true;
            this.btnQuestion.Location = new System.Drawing.Point(0, 123);
            this.btnQuestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.btnQuestion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(112)))), ((int)(((byte)(119)))));
            this.btnQuestion.OnHoverTextColor = System.Drawing.Color.DarkGoldenrod;
            this.btnQuestion.selected = true;
            this.btnQuestion.Size = new System.Drawing.Size(207, 48);
            this.btnQuestion.TabIndex = 0;
            this.btnQuestion.Text = "      CSDL";
            this.btnQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuestion.Textcolor = System.Drawing.Color.White;
            this.btnQuestion.TextFont = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.SlideMenuTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(12, 9);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(25, 25);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 20;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.lblInfo);
            this.panelHeader.Controls.Add(this.lblNameProject);
            this.panelHeader.Controls.Add(this.btnMenu);
            this.panelHeader.Controls.Add(this.btnImgClose);
            this.SlideMenuTransition.SetDecoration(this.panelHeader, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.panelHeader, BunifuAnimatorNS.DecorationType.None);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(913, 45);
            this.panelHeader.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.SlideMenuTransition.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(845, 9);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 20;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.LogoTransition.SetDecoration(this.lblInfo, BunifuAnimatorNS.DecorationType.None);
            this.SlideMenuTransition.SetDecoration(this.lblInfo, BunifuAnimatorNS.DecorationType.None);
            this.lblInfo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(110, 11);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 23);
            this.lblInfo.TabIndex = 1;
            // 
            // lblNameProject
            // 
            this.lblNameProject.AutoSize = true;
            this.LogoTransition.SetDecoration(this.lblNameProject, BunifuAnimatorNS.DecorationType.None);
            this.SlideMenuTransition.SetDecoration(this.lblNameProject, BunifuAnimatorNS.DecorationType.None);
            this.lblNameProject.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProject.ForeColor = System.Drawing.Color.White;
            this.lblNameProject.Location = new System.Drawing.Point(43, 11);
            this.lblNameProject.Name = "lblNameProject";
            this.lblNameProject.Size = new System.Drawing.Size(61, 23);
            this.lblNameProject.TabIndex = 1;
            this.lblNameProject.Text = "Server";
            // 
            // btnImgClose
            // 
            this.btnImgClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImgClose.BackColor = System.Drawing.Color.Transparent;
            this.SlideMenuTransition.SetDecoration(this.btnImgClose, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnImgClose, BunifuAnimatorNS.DecorationType.None);
            this.btnImgClose.Image = ((System.Drawing.Image)(resources.GetObject("btnImgClose.Image")));
            this.btnImgClose.ImageActive = null;
            this.btnImgClose.Location = new System.Drawing.Point(876, 9);
            this.btnImgClose.Name = "btnImgClose";
            this.btnImgClose.Size = new System.Drawing.Size(25, 25);
            this.btnImgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnImgClose.TabIndex = 0;
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
            // LogoTransition
            // 
            this.LogoTransition.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.LogoTransition.Cursor = null;
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
            this.LogoTransition.DefaultAnimation = animation1;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.SlideMenuTransition.SetDecoration(this.panelContent, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.panelContent, BunifuAnimatorNS.DecorationType.None);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(206, 45);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(707, 478);
            this.panelContent.TabIndex = 2;
            // 
            // SlideMenuTransition
            // 
            this.SlideMenuTransition.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.SlideMenuTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 1F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.SlideMenuTransition.DefaultAnimation = animation2;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lblNameProject;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.lblInfo;
            this.bunifuDragControl3.Vertical = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 523);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSlideMenu);
            this.Controls.Add(this.panelHeader);
            this.LogoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.SlideMenuTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelSlideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSlideMenu;
        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuestion;
        private Bunifu.Framework.UI.BunifuImageButton btnImgClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnRunServer;
        private Bunifu.Framework.UI.BunifuFlatButton btnSetting;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNameProject;
        private BunifuAnimatorNS.BunifuTransition SlideMenuTransition;
        private BunifuAnimatorNS.BunifuTransition LogoTransition;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private System.Windows.Forms.Panel panelContent;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblInfo;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
    }
}

