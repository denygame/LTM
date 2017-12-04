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
        List<Panel> lsPanel = new List<Panel>();
        List<RadioButton> lsRadio = new List<RadioButton>();

        public frmMain()
        {
            InitializeComponent();
        }

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

        private void panelContent_MouseEnter(object sender, EventArgs e)
        {
            foreach (RadioButton item in lsRadio)
                if (!item.Checked)
                    item.Parent.BackColor = Color.Transparent;
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            string ques = "dasklfdjbgajdsf gdsfhgifdsk fsadkdskjadfk sa dsauif hds fhdsa hfjkds hfjkds hafdsahfk ds;hli fhdsui hfuda hfuksd fkjsda ghfkj dsaghfjk dhsagk fjhdsajk fhdsj kafhds jkahfk jdsahfdjska hfkjdsa hfkjdsa hfjkdsa hfkjads hfkjasd hfdsjkfdsf  dfhdskf dsjkf dskjf kdjsh fkjds hfkjdsh fkjd hkjf hsf hsa fhdsugh dsif ghids hgiodsh flksajhf ksahg fksja fkusaj hfs hfsa f;isahf ;iosahfio;sah fisahfisa;f lsahfkjsagfjk saf usa fhsakjfh saklh fklsa hfklsa hfisah fskalh flksah klf end.";

            var setupQues = setQues(ques);

            int width = setupQues.Item1;
            int height = setupQues.Item2;

            setAnswers(setupQues.Item1, setupQues.Item2);

            Panel pn1 = new Panel();
            pn1.Location = new Point(20, height);
            pn1.Size = new Size(width, 10);
            pn1.BackColor = Color.Transparent;
            panelQuiz.Controls.Add(pn1);
        }

        private void Pn_MouseEnter(object sender, EventArgs e)
        {
            var panel = (sender as Panel);
            RadioButton radio = getRadioInPanel(panel);
            if (!radio.Checked)
            {
                panel.BackColor = Color.FromArgb(Controller.Constant.colorHoverAnswer.Item1, Controller.Constant.colorHoverAnswer.Item2, Controller.Constant.colorHoverAnswer.Item3);
            }
        }

        private void Pn_MouseLeave(object sender, EventArgs e)
        {
            var panel = (sender as Panel);
            RadioButton radio = getRadioInPanel(panel);
            if (!radio.Checked)
                panel.BackColor = Color.Transparent;
        }

        private void Pn_Click(object sender, EventArgs e)
        {
            var panel = (sender as Panel);
            RadioButton radio = getRadioInPanel(panel);
            radio.Checked = true;
            Rb_CheckedChanged(radio, null);
        }

        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            var currentRb = (sender as RadioButton);
            if (currentRb.Checked == true)
            {
                foreach (RadioButton radio in lsRadio)
                    if (radio != currentRb) radio.Checked = false;

                currentRb.Parent.BackColor = Color.FromArgb(Controller.Constant.colorHoverAnswer.Item1, Controller.Constant.colorHoverAnswer.Item2, Controller.Constant.colorHoverAnswer.Item3);
            }
            else
            {
                currentRb.Parent.BackColor = Color.Transparent;
            }
        }

        private void Rb_MouseEnter(object sender, EventArgs e)
        {
            var radio = (sender as RadioButton);
            var panel = radio.Parent;
            Pn_MouseEnter(panel, e);
        }






        private RadioButton getRadioInPanel(Panel panel)
        {
            RadioButton radio = null;
            foreach (RadioButton rb in panel.Controls)
            {
                radio = rb;
                break;
            }
            return radio;
        }

        private SizeF getSizeText(string str, Font f)
        {
            Graphics g = this.CreateGraphics();
            SizeF sz = g.MeasureString(str, f);
            return sz;
        }

        // item1: width, item2:height
        private Tuple<int, int> setQues(string ques)
        {
            Font f = lblQues.Font;
            SizeF sz = getSizeText(ques, f);
            //string strDetail = "height: " + sz.Height.ToString() + ", width: " + sz.Width.ToString();
            //MessageBox.Show(strDetail);
            var row = sz.Width / lblQues.Width;
            var a = sz.Height;
            var rowofQues = row + 1;
            var heightQues = (a * rowofQues);

            this.lblQues.Height = (int)heightQues;
            this.lblQues.Text = ques;
            //MessageBox.Show(lblQues.Height.ToString());
            //this.lblQues.BackColor = Color.Blue;

            // width height return for answers
            int width = this.panelQuiz.Width - 40;
            int height = (int)heightQues + 1;

            return new Tuple<int, int>(width, height);
        }

        private void setAnswers(int width, int height)
        {
            for (int i = 0; i < 6; i++)
            {
                Panel pn = new Panel();
                pn.Location = new Point(20, height);
                pn.Text = i.ToString();

                pn.Name = i.ToString();

                

                RadioButton rb = new RadioButton();

                rb.Width = width - 22;
                rb.Location = new Point(10, 0);
                rb.Font = new Font("Verdana", 10);


                string str = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa ssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss sdddddddddddddddddddddd sssssssssssssssssssssssssssssssa";

                var sizeTextAnswer = getSizeText(str, rb.Font);
                var row = sizeTextAnswer.Width / rb.Width;
                var a = sizeTextAnswer.Height;
                var rowofAns = row + 1;
                var heightAnsw = (a * rowofAns);
                //MessageBox.Show(heightAnsw.ToString());

                if (heightAnsw < 50)
                {
                    rb.Height = 50;
                    pn.Size = new Size(width, 50);
                }
                else
                {
                    rb.Height = (int)heightAnsw;
                    pn.Size = new Size(width, (int)heightAnsw);
                }

                rb.Text = str;

                height += pn.Height + 10;




                rb.CheckedChanged += Rb_CheckedChanged;
                rb.MouseEnter += Rb_MouseEnter;

                pn.Controls.Add(rb);

                pn.Click += Pn_Click;
                pn.MouseEnter += Pn_MouseEnter;
                pn.MouseLeave += Pn_MouseLeave;


                this.lsRadio.Add(rb);

                panelQuiz.Controls.Add(pn);

                this.lsPanel.Add(pn);
            }
        }
    }
}
