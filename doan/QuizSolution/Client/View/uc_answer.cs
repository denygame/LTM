using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.View
{
    public partial class uc_answer : UserControl
    {
        public event EventHandler radioClick;

        private string txt;
        private int type;

        public uc_answer(string txt, int type)
        {
            InitializeComponent();
            this.txt = txt;
            this.type = type;
        }

        private SizeF getSizeText(string str, Font f)
        {
            using (Graphics g = CreateGraphics())
            {
                SizeF sz = g.MeasureString(str, f);
                return sz;
            }
        }

        public void uncheckRb()
        {
            (pnRB.Controls[0] as RadioButton).Checked = false;
            lblContent.BackColor = Color.Transparent;
            pnRB.BackColor = Color.Transparent;
            panel1.BackColor = Color.Transparent;
        }


        private void test_Load(object sender, EventArgs e)
        {
            if (type == 1)
            {
                RadioButton rb = new RadioButton();
                rb.Dock = DockStyle.Fill;
                rb.MouseHover += lblContent_MouseEnter;
                rb.MouseLeave += lblContent_MouseLeave;
                rb.Click += Rb_Click;
                pnRB.Controls.Add(rb);
            }
            else
            {
                CheckBox cb = new CheckBox();
                cb.MouseHover += lblContent_MouseEnter;
                cb.MouseLeave += lblContent_MouseLeave;
                cb.Click += Cb_Click;
                cb.Dock = DockStyle.Fill;
                pnRB.Controls.Add(cb);
            }

            var sz = getSizeText(txt, lblContent.Font);
            if (sz.Width > lblContent.Width)
            {
                var row = sz.Width / lblContent.Width;
                if (sz.Width % lblContent.Width > 0.5) row = row + 1;
                var heightStr = row * sz.Height;
                if (heightStr > this.Height) this.Height = (int)heightStr + 5;
            }
            else
            {
                if (sz.Height > this.Height) this.Height = (int)sz.Height + 5;
            }

            lblContent.Text = txt;
        }

        private void Cb_Click(object sender, EventArgs e)
        {
            lblContent_MouseEnter(null, null);
        }

        private void Rb_Click(object sender, EventArgs e)
        {
            lblContent_MouseEnter(null, null);
            if (this.radioClick != null && type == 1)
                this.radioClick(this, e);
        }

        private void lblContent_Click(object sender, EventArgs e)
        {
            if (type == 1)
            {
                (pnRB.Controls[0] as RadioButton).Checked = true;

                if (this.radioClick != null && type == 1)
                    this.radioClick(this, e);
            }
            else
            {
                var cb = (pnRB.Controls[0] as CheckBox);
                if (cb.Checked) cb.Checked = false; else cb.Checked = true;
            }
            lblContent_MouseEnter(null, null);
        }

        private void lblContent_MouseLeave(object sender, EventArgs e)
        {
            if (type == 1)
            {
                if (!(pnRB.Controls[0] as RadioButton).Checked)
                {
                    lblContent.BackColor = Color.Transparent;
                    pnRB.BackColor = Color.Transparent;
                    panel1.BackColor = Color.Transparent;
                }
            }
            else
            {
                if (!(pnRB.Controls[0] as CheckBox).Checked)
                {
                    lblContent.BackColor = Color.Transparent;
                    pnRB.BackColor = Color.Transparent;
                    panel1.BackColor = Color.Transparent;
                }
            }
        }

        private void lblContent_MouseDown(object sender, MouseEventArgs e)
        {
            //lblContent.BackColor = Color.Black;
        }

        private void lblContent_MouseEnter(object sender, EventArgs e)
        {
            lblContent.BackColor = Color.FromArgb(Controller.Constant.colorHoverAnswer.Item1, Controller.Constant.colorHoverAnswer.Item2, Controller.Constant.colorHoverAnswer.Item3);
            pnRB.BackColor = Color.FromArgb(Controller.Constant.colorHoverAnswer.Item1, Controller.Constant.colorHoverAnswer.Item2, Controller.Constant.colorHoverAnswer.Item3);
            panel1.BackColor = Color.FromArgb(Controller.Constant.colorHoverAnswer.Item1, Controller.Constant.colorHoverAnswer.Item2, Controller.Constant.colorHoverAnswer.Item3);
        }
    }
}
