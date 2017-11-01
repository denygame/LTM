namespace Server.View
{
    partial class frmQues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQues));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnImgClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelQues = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelAnswer = new System.Windows.Forms.Panel();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCreateOrOK = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgClose)).BeginInit();
            this.panelQues.SuspendLayout();
            this.panelAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(62)))));
            this.panelHeader.Controls.Add(this.lblName);
            this.panelHeader.Controls.Add(this.btnImgClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(487, 45);
            this.panelHeader.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(12, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Câu hỏi ?";
            // 
            // btnImgClose
            // 
            this.btnImgClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImgClose.BackColor = System.Drawing.Color.Transparent;
            this.btnImgClose.Image = ((System.Drawing.Image)(resources.GetObject("btnImgClose.Image")));
            this.btnImgClose.ImageActive = null;
            this.btnImgClose.Location = new System.Drawing.Point(450, 9);
            this.btnImgClose.Name = "btnImgClose";
            this.btnImgClose.Size = new System.Drawing.Size(25, 25);
            this.btnImgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnImgClose.TabIndex = 1;
            this.btnImgClose.TabStop = false;
            this.btnImgClose.Zoom = 20;
            this.btnImgClose.Click += new System.EventHandler(this.btnImgClose_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lblName;
            this.bunifuDragControl2.Vertical = true;
            // 
            // panelQues
            // 
            this.panelQues.AutoScroll = true;
            this.panelQues.AutoSize = true;
            this.panelQues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.panelQues.Controls.Add(this.richTextBox1);
            this.panelQues.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQues.Location = new System.Drawing.Point(0, 45);
            this.panelQues.Name = "panelQues";
            this.panelQues.Size = new System.Drawing.Size(487, 106);
            this.panelQues.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(16, 17);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(455, 74);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panelAnswer
            // 
            this.panelAnswer.Controls.Add(this.bunifuCustomDataGrid1);
            this.panelAnswer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAnswer.Location = new System.Drawing.Point(0, 151);
            this.panelAnswer.Name = "panelAnswer";
            this.panelAnswer.Size = new System.Drawing.Size(487, 160);
            this.panelAnswer.TabIndex = 2;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(487, 160);
            this.bunifuCustomDataGrid1.TabIndex = 0;
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
            this.btnDelete.Location = new System.Drawing.Point(16, 320);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(185, 41);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateOrOK
            // 
            this.btnCreateOrOK.ActiveBorderThickness = 1;
            this.btnCreateOrOK.ActiveCornerRadius = 20;
            this.btnCreateOrOK.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(62)))));
            this.btnCreateOrOK.ActiveForecolor = System.Drawing.Color.White;
            this.btnCreateOrOK.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateOrOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateOrOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.btnCreateOrOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateOrOK.BackgroundImage")));
            this.btnCreateOrOK.ButtonText = "Tạo";
            this.btnCreateOrOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateOrOK.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(62)))));
            this.btnCreateOrOK.IdleBorderThickness = 1;
            this.btnCreateOrOK.IdleCornerRadius = 20;
            this.btnCreateOrOK.IdleFillColor = System.Drawing.Color.White;
            this.btnCreateOrOK.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(62)))));
            this.btnCreateOrOK.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateOrOK.Location = new System.Drawing.Point(286, 320);
            this.btnCreateOrOK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCreateOrOK.Name = "btnCreateOrOK";
            this.btnCreateOrOK.Size = new System.Drawing.Size(185, 41);
            this.btnCreateOrOK.TabIndex = 5;
            this.btnCreateOrOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmQues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(487, 379);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreateOrOK);
            this.Controls.Add(this.panelAnswer);
            this.Controls.Add(this.panelQues);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQues";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmQues";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgClose)).EndInit();
            this.panelQues.ResumeLayout(false);
            this.panelAnswer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuImageButton btnImgClose;
        private Bunifu.Framework.UI.BunifuCustomLabel lblName;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Panel panelQues;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panelAnswer;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCreateOrOK;
    }
}