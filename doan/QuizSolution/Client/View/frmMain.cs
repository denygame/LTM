using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        List<Panel> list = new List<Panel>();

        private void btnImgClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnImgMax_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Maximized;
                this.MaximumSize = this.Size;
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string ques = "dasklfdjbgajdsf gdsfhgifdsk fsadkdskjadfk sa dsauif hds fhdsa hfjkds hfjkds hafdsahfk ds;hli fhdsui hfuda hfuksd fkjsda ghfkj dsaghfjk dhsagk fjhdsajk fhdsj kafhds jkahfk jdsahfdjska hfkjdsa hfkjdsa hfjkdsa hfkjads hfkjasd hfdsjkfdsf  dfhdskf dsjkf dskjf kdjsh fkjds hfkjdsh fkjd hkjf hsf hsa fhdsugh dsif ghids hgiodsh flksajhf ksahg fksja fkusaj hfs hfsa f;isahf ;iosahfio;sah fisahfisa;f lsahfkjsagfjk saf usa fhsakjfh saklh fklsa hfklsa hfisah fskalh flksah klf end.";

            Graphics g = this.CreateGraphics();
            Font f = lblQues.Font;
            SizeF sz = g.MeasureString(ques, f);
            string strDetail = "height: " + sz.Height.ToString() + ", width: " + sz.Width.ToString();

            //MessageBox.Show(strDetail);


            var row = sz.Width / lblQues.Width;


            var a = sz.Height;
            var b = row + 1;
            var c = (a * b);

            //MessageBox.Show(a.ToString() + "," + b.ToString() + "," + c.ToString() /*row.ToString()*/);

            lblQues.Height = (int)c;
            lblQues.Text = ques;

            //MessageBox.Show(lblQues.Height.ToString());
            lblQues.BackColor = Color.Blue;


            int width = this.panelQuiz.Width - 35;
            int height = (int)c + 1;

            for (int i = 0; i < 4; i++)
            {
                Panel pn = new Panel();
                pn.Location = new Point(10, height);
                pn.Text = i.ToString();
                pn.Size = new Size(width, 100);

                height += pn.Height + 10;

                pn.BackColor = Color.Black;

                panelQuiz.Controls.Add(pn);

                this.list.Add(pn);
            }
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            string ques = "dasklfdjbgajdsf gdsfhgifdsk fsadkdskjadfk sa dsauif hds fhdsa hfjkds hfjkds hafdsahfk ds;hli fhdsui hfuda hfuksd fkjsda ghfkj dsaghfjk dhsagk fjhdsajk fhdsj kafhds jkahfk jdsahfdjska hfkjdsa hfkjdsa hfjkdsa hfkjads hfkjasd hfdsjkfdsf  dfhdskf dsjkf dskjf kdjsh fkjds hfkjdsh fkjd hkjf hsf hsa fhdsugh dsif ghids hgiodsh flksajhf ksahg fksja fkusaj hfs hfsa f;isahf ;iosahfio;sah fisahfisa;f lsahfkjsagfjk saf usa fhsakjfh saklh fklsa hfklsa hfisah fskalh flksah klf end.";




            Graphics g = this.CreateGraphics();
            Font f = lblQues.Font;
            SizeF sz = g.MeasureString(ques, f);
            string strDetail = "height: " + sz.Height.ToString() + ", width: " + sz.Width.ToString();

            //MessageBox.Show(strDetail);


            var row = sz.Width / lblQues.Width;


            var a = sz.Height;
            var b = row + 1;
            var c = (a * b);

            //MessageBox.Show(a.ToString() + "," + b.ToString() + "," + c.ToString() /*row.ToString()*/);

            lblQues.Height = (int)c;
            lblQues.Text = ques;

            //MessageBox.Show(lblQues.Height.ToString());
            lblQues.BackColor = Color.Blue;

            int width, height = (int)c + 1;
            if (this.WindowState == FormWindowState.Maximized)
            {
                width = this.panelQuiz.Width - 35;
            }
            else
            {
                width = this.panelQuiz.Width - 35;
            }


            foreach(var item in list)
            {
                item.Size = new Size(width, 100);
            }

            //for (int i = 0; i < 4; i++)
            //{
            //    Panel pn = new Panel();
            //    pn.Location = new Point(10, height);
            //    pn.Text = i.ToString();
            //    pn.Size = new Size(width, 100);

            //    height += pn.Height + 10;

            //    pn.BackColor = Color.Black;

            //    panelQuiz.Controls.Add(pn);
            //}
        }
    }
}
