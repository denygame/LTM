namespace Client.View
{
    partial class uc_answer
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
            this.pnRB = new System.Windows.Forms.Panel();
            this.lblContent = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnRB
            // 
            this.pnRB.BackColor = System.Drawing.Color.Transparent;
            this.pnRB.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnRB.Location = new System.Drawing.Point(10, 0);
            this.pnRB.Name = "pnRB";
            this.pnRB.Size = new System.Drawing.Size(15, 50);
            this.pnRB.TabIndex = 0;
            // 
            // lblContent
            // 
            this.lblContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContent.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(25, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(555, 50);
            this.lblContent.TabIndex = 1;
            this.lblContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblContent.Click += new System.EventHandler(this.lblContent_Click);
            this.lblContent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblContent_MouseDown);
            this.lblContent.MouseEnter += new System.EventHandler(this.lblContent_MouseEnter);
            this.lblContent.MouseLeave += new System.EventHandler(this.lblContent_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 50);
            this.panel1.TabIndex = 2;
            // 
            // uc_answer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.pnRB);
            this.Controls.Add(this.panel1);
            this.Name = "uc_answer";
            this.Size = new System.Drawing.Size(580, 50);
            this.Load += new System.EventHandler(this.test_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnRB;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Panel panel1;
    }
}
