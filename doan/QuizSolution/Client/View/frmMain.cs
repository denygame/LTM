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

            var setupQues = setQues(ques);

            int width = setupQues.Item1;
            int height = setupQues.Item2;

            for (int i = 0; i < 2; i++)
            {
                Panel pn = new Panel();
                pn.Location = new Point(20, height);
                pn.Text = i.ToString();
                pn.Size = new Size(width, 100);

                height += pn.Height + 10;

                pn.BackColor = Color.Black;

                panelQuiz.Controls.Add(pn);

                this.list.Add(pn);
            }

            Panel pn1 = new Panel();
            pn1.Location = new Point(20, height);
            pn1.Size = new Size(width, 10);
            pn1.BackColor = Color.Red;
            panelQuiz.Controls.Add(pn1);
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {

        }


        // item1: width, item2:height
        private Tuple<int, int> setQues(string ques)
        {
            Graphics g = this.CreateGraphics();
            Font f = lblQues.Font;
            SizeF sz = g.MeasureString(ques, f);
            //string strDetail = "height: " + sz.Height.ToString() + ", width: " + sz.Width.ToString();
            //MessageBox.Show(strDetail);
            var row = sz.Width / lblQues.Width;
            var a = sz.Height;
            var rowofQues = row + 1;
            var heightQues = (a * rowofQues);

            this.lblQues.Height = (int)heightQues;
            this.lblQues.Text = ques;
            //MessageBox.Show(lblQues.Height.ToString());
            this.lblQues.BackColor = Color.Blue;

            // width height return for answers
            int width = this.panelQuiz.Width - 40;
            int height = (int)heightQues + 1;

            return new Tuple<int, int>(width, height);
        }

    }
}
