namespace _1451120025_ChatGUI
{
    partial class frmBegin
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
            this.butThoat = new System.Windows.Forms.Button();
            this.butOK = new System.Windows.Forms.Button();
            this.radServer = new System.Windows.Forms.RadioButton();
            this.radClient = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // butThoat
            // 
            this.butThoat.Location = new System.Drawing.Point(157, 120);
            this.butThoat.Margin = new System.Windows.Forms.Padding(2);
            this.butThoat.Name = "butThoat";
            this.butThoat.Size = new System.Drawing.Size(83, 37);
            this.butThoat.TabIndex = 7;
            this.butThoat.Text = "Exit";
            this.butThoat.UseVisualStyleBackColor = true;
            this.butThoat.Click += new System.EventHandler(this.butThoat_Click);
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(32, 121);
            this.butOK.Margin = new System.Windows.Forms.Padding(2);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(88, 35);
            this.butOK.TabIndex = 6;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // radServer
            // 
            this.radServer.AutoSize = true;
            this.radServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radServer.Location = new System.Drawing.Point(103, 56);
            this.radServer.Margin = new System.Windows.Forms.Padding(2);
            this.radServer.Name = "radServer";
            this.radServer.Size = new System.Drawing.Size(73, 24);
            this.radServer.TabIndex = 5;
            this.radServer.Text = "Server";
            this.radServer.UseVisualStyleBackColor = true;
            // 
            // radClient
            // 
            this.radClient.AutoSize = true;
            this.radClient.Checked = true;
            this.radClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radClient.Location = new System.Drawing.Point(103, 25);
            this.radClient.Margin = new System.Windows.Forms.Padding(2);
            this.radClient.Name = "radClient";
            this.radClient.Size = new System.Drawing.Size(67, 24);
            this.radClient.TabIndex = 4;
            this.radClient.TabStop = true;
            this.radClient.Text = "Client";
            this.radClient.UseVisualStyleBackColor = true;
            // 
            // frmBegin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 178);
            this.Controls.Add(this.butThoat);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.radServer);
            this.Controls.Add(this.radClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBegin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butThoat;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.RadioButton radServer;
        private System.Windows.Forms.RadioButton radClient;
    }
}

