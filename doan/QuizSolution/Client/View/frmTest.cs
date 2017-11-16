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
    public partial class frmTest : Form
    {
        List<Panel> answer = new List<Panel>();

        public frmTest()
        {
            InitializeComponent();

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


            var a = sz.Height ;
            var b = row+1;
            var c = (a * b);

            //MessageBox.Show(a.ToString() + "," + b.ToString() + "," + c.ToString() /*row.ToString()*/);

            lblQues.Height = (int)c;
            lblQues.Text = ques;

            //MessageBox.Show(lblQues.Height.ToString());
            lblQues.BackColor = Color.Red;


            //// Instantiate two new panels
            //Panel blackPanel = new Panel();
            //Panel whitePanel = new Panel();
            //// Set color, location and size of the black panel
            //blackPanel.BackColor = Color.Black;
            //blackPanel.Location = new Point(10, (int)c+1);
            //blackPanel.Size = new Size(90, 90);
            //// Same here with the white one
            //whitePanel.BackColor = Color.White;
            //whitePanel.Location = new Point(110, (int)c+1);
            //whitePanel.Size = new Size(90, 90);
            //// That's the point, container controls exposes the Controls
            //// collection that you could use to add controls programatically
            //panelContent.Controls.Add(blackPanel);
            //panelContent.Controls.Add(whitePanel);

            //blackPanel.MouseHover += BlackPanel_MouseHover;
            //blackPanel.MouseLeave += BlackPanel_MouseLeave;

            //whitePanel.MouseHover += BlackPanel_MouseHover;
            //whitePanel.MouseLeave += BlackPanel_MouseLeave;

            //blackPanel.Controls.Add(new Button());
            //Label lbl = new Label();
            //lbl.Text = "hello";
            //whitePanel.Controls.Add(lbl);

            //this.answer.Add(blackPanel);
            //this.answer.Add(whitePanel);

            int width = this.panelContent.Width - 60;
            int height = (int)c + 1;
            for (int i = 0; i < 4; i++)
            {
                Panel pn = new Panel();
                pn.Location = new Point(10,height);
                pn.Text = i.ToString();
                pn.Size = new Size(width, 100);

                height += pn.Height + 10;

                pn.BackColor = Color.Black;

                panelContent.Controls.Add(pn);
            }

            //int width = this.panelContent.Width - 60;

            //Panel pn1 = new Panel();
            //pn1.Location = new Point(30, (int)c + 1);
            //pn1.Size = new Size(width, 100);

            //ComboBox cb = new ComboBox();
            //pn1.Controls.Add(cb);

            //pn1.BackColor = Color.Chartreuse;

            //pn1.Anchor = (AnchorStyles.Left | AnchorStyles.Right);

            //panelContent.Controls.Add(pn1);



            //Panel pn2 = new Panel();
            //int he = (int)c + pn1.Height + 10;
            //pn2.Location = new Point(30, he);

            //pn2.Size = new Size(width, 100);

            //pn2.BackColor = Color.Black;

            //pn2.Anchor = (AnchorStyles.Left | AnchorStyles.Right);

            //panelContent.Controls.Add(pn2);




            //Panel pn = new Panel();
            //int he1 = (int)c + pn1.Height + 20 + pn2.Height;
            //pn.Location = new Point(30, he1);

            //pn.Size = new Size(width, 100);

            //pn.BackColor = Color.DarkTurquoise;

            //Button btn = new Button();
            //pn.Controls.Add(btn);
            

            //pn.Anchor = (AnchorStyles.Left | AnchorStyles.Right);

            //panelContent.Controls.Add(pn);

            //this.answer.Add(pn);
            //this.answer.Add(pn2);
            //this.answer.Add(pn1);

            //DataGridView d = new DataGridView();
            //d.Size = new Size(200, 5000);
            //panelContent.Controls.Add(d);

        }

        private void BlackPanel_MouseLeave(object sender, EventArgs e)
        {
            (sender as Panel).BackColor = Color.Black;
            (sender as Panel).Refresh();
        }

        private void BlackPanel_MouseHover(object sender, EventArgs e)
        {
            (sender as Panel).BackColor = Color.BlueViolet;
            (sender as Panel).Refresh();
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
            lblQues.BackColor = Color.Red;

            
        }

        private void lblQues_Paint(object sender, PaintEventArgs e)
        {
            
        }


        
    }
}
