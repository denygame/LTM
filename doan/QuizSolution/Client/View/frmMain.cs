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
        #region -- Parameters --
        private List<Tuple<int, Model.Question, bool>> quesList = null;
        private string info = "";
        private List<Tuple<int, Model.Answer>> ansList = null;

        int total_ques;

        //list save answer in each ques
        List<Tuple<View.uc_answer, int>> lsSaveUC = new List<Tuple<View.uc_answer, int>>();

        //list ket qua dung
        List<Tuple<int, bool>> lsResult = new List<Tuple<int, bool>>();

        Model.Question quesCurrent = null;
        int integerCurrent = 0;

        //timer
        int timeRun = 0;
        int second = 60;
        int minute = Controller.Constant.time / 60;
        bool firstTime = true;

        #endregion

        public frmMain(List<Tuple<int, Model.Question>> quesLs, List<Tuple<int, Model.Answer>> ansList, string info)
        {
            InitializeComponent();

            this.quesList = new List<Tuple<int, Model.Question, bool>>();

            for (int i = 0; i < quesLs.Count; i++)
            {
                this.quesList.Add(new Tuple<int, Model.Question, bool>(quesLs[i].Item1, quesLs[i].Item2, false));
            }
            this.ansList = ansList;

            this.info = info;
        }

        #region -- Event --

        private void btnImgClose_Click(object sender, EventArgs e)
        {
            // Environment.Exit(0);
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
            total_ques = quesList.Count;
            setTimer();
            if (total_ques == 1)
            {
                btnNext.Visible = false;
                btnPrev.Visible = false;
            }
            else btnPrev.Visible = false;
            setQuiz(0);
        }

        private void timerBlock_Tick(object sender, EventArgs e)
        {
            if (firstTime)
            {
                minute--;
                if (minute < 10)
                {
                    if (minute == 1) lblMinute.Text = "00" + " : ";
                    else lblMinute.Text = "0" + minute + " : ";
                }
                else lblMinute.Text = minute + " : ";
                firstTime = false;
            }
            second--;
            if (timeRun == Controller.Constant.time)//end
            {
                timerBlock.Stop();
            }
            else
            {
                if (second < 10) lblSecond.Text = "0" + second;
                else lblSecond.Text = second.ToString();
                if (second == 0)
                {
                    second = 60;
                    if (minute != 0) minute--;
                    if (minute < 10)
                    {
                        if (minute == 1) lblMinute.Text = "00" + " : ";
                        else lblMinute.Text = "0" + minute + " : ";
                    }
                    else lblMinute.Text = minute + " : ";
                }
            }
            timeRun += 1;

            if (Controller.Constant.time == timeRun)
            {
                endQuiz();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int index = -1;
            for (int i = integerCurrent; i < quesList.Count; i++)
            {
                if (!quesList[i].Item3)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1) setQuiz(index);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (checkChoseAns())
            {
                int count = 0;
                for (int i = 0; i < lsSaveUC.Count; i++)
                {
                    if ((int)lsSaveUC[i].Item1.Tag == lsSaveUC[i].Item2) count++;
                }

                if (count == lsSaveUC.Count)
                {
                    lsResult.Add(new Tuple<int, bool>(quesCurrent.Id, true));
                }

                total_ques--;

                if (total_ques != 0)
                {
                    for (int i = 0; i < quesList.Count; i++)
                    {
                        if (quesList[i].Item1 == integerCurrent)
                        {
                            quesList[i] = new Tuple<int, Model.Question, bool>(integerCurrent, quesCurrent, true);
                            break;
                        }
                    }

                    if (!btnNext.Visible) btnPrev_Click(null, null); else btnNext_Click(null, null);
                }
                else
                {
                    endQuiz();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đáp án", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }


        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int index = -1;
            for (int i = integerCurrent - 2; i >= 0; i--)
            {
                if (!quesList[i].Item3)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1) setQuiz(index);
        }

        #endregion


        #region -- Method --

        private void endQuiz()
        {
            double score = Math.Round(((double)100 / (double)quesList.Count) * lsResult.Count, 1);

            panelContent.Controls.Clear();
            Label lbl = new Label();
            lbl.Dock = DockStyle.Fill;
            lbl.Text = score.ToString();
            lbl.Font = new Font("Verdana", 90);
            lbl.ForeColor = Color.FromArgb(0, 128, 128);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            panelContent.Controls.Add(lbl);
            lblInfo.Text = info;
            timerBlock.Stop();
        }

        private void setQuiz(int index)
        {
            panelQuiz.Controls.Clear();
            lsSaveUC.Clear();

            Model.Question ques;

            ques = quesList[index].Item2;

            var setupQues = setQues(quesList[index].Item1 + ") " + ques.Content);

            int width = setupQues.Item1;
            int height = setupQues.Item2;

            setAnswers(setupQues.Item1, setupQues.Item2, ques.Id, ques.Num_answer_right);

            quesCurrent = ques;
            integerCurrent = quesList[index].Item1;


            if (countPrev() != 0) btnPrev.Visible = true; else btnPrev.Visible = false;
            if (countNext() != 0) btnNext.Visible = true; else btnNext.Visible = false;
        }

        private void setTimer()
        {
            if (minute < 10)
            {
                if (minute == 1) lblMinute.Text = "00" + " : ";
                else lblMinute.Text = "0" + minute + " : ";
            }
            else lblMinute.Text = minute + " : ";

            timerBlock.Start();
        }

        private SizeF getSizeText(string str, Font f)
        {
            using (Graphics g = CreateGraphics())
            {
                SizeF sz = g.MeasureString(str, f);
                return sz;
            }
        }

        // item1: width, item2:height
        private Tuple<int, int> setQues(string ques)
        {
            Label lbl = new Label();
            lbl.Font = new Font("Verdana", 12);
            lbl.AutoSize = false;
            lbl.Dock = DockStyle.Top;
            //lbl.BackColor = Color.Red;
            panelQuiz.Controls.Add(lbl);

            SizeF sz = getSizeText(ques, lbl.Font);

            if (sz.Width > lbl.Width)
            {
                var row = sz.Width / lbl.Width;
                if (sz.Width % lbl.Width > 0.5) row = row + 1;
                var heightStr = row * sz.Height;
                if (heightStr > lbl.Height) lbl.Height = (int)heightStr;
            }
            else
            {
                if (sz.Height > lbl.Height) lbl.Height = (int)sz.Height;
            }

            lbl.Text = ques;

            // width height return for answers
            int width = this.panelQuiz.Width - 40;
            int height = (int)lbl.Height + 10;

            return new Tuple<int, int>(width, height);
        }

        private void setAnswers(int width, int height, int idques, int num_right)
        {
            //bool là lấy ra chưa
            List<Model.Answer> listAnsInQues = new List<Model.Answer>();
            for (int i = 0; i < ansList.Count; i++)
            {
                if (ansList[i].Item2.Id_ques == idques)
                    listAnsInQues.Add(ansList[i].Item2);
            }

            // random cac doi tuong trong list
            Random rnd = new Random();
            listAnsInQues = listAnsInQues.OrderBy(item => rnd.Next()).ToList();

            //create answer
            for (int i = 0; i < listAnsInQues.Count; i++)
            {
                if (listAnsInQues[i].Id_ques == idques)
                {
                    var uc = new View.uc_answer(listAnsInQues[i].Content, num_right);
                    uc.Location = new Point(20, height);
                    uc.Name = "answer" + listAnsInQues[i].Id;
                    this.lsSaveUC.Add(new Tuple<uc_answer, int>(uc, 0));
                    uc.CheckboxClick += Uc_CheckboxClick;
                    uc.radioClick += radioClick_click;
                    uc.Tag = listAnsInQues[i].True_or_false;
                    height += uc.Height + 10;
                    panelQuiz.Controls.Add(uc);
                }
            }

            //design phan cuoi cho dep
            Panel pn = new Panel();
            pn.Location = new Point(20, height);
            pn.Size = new Size(width, 10);
            pn.BackColor = Color.Transparent;
            panelQuiz.Controls.Add(pn);
        }

        //event checkbox in user control checked
        private void Uc_CheckboxClick(object sender, Controller.EventCheckBox e)
        {
            var uc = (sender as View.uc_answer);
            for (int i = 0; i < lsSaveUC.Count; i++)
            {
                if (lsSaveUC[i].Item1 == uc)
                {
                    if (e.Check) lsSaveUC[i] = new Tuple<uc_answer, int>(lsSaveUC[i].Item1, 1);
                    else lsSaveUC[i] = new Tuple<uc_answer, int>(lsSaveUC[i].Item1, 0);
                }
            }
        }

        //event radio button in user control checked
        private void radioClick_click(object sender, EventArgs e)
        {
            var uc = (sender as View.uc_answer);
            for (int i = 0; i < lsSaveUC.Count; i++)
            {
                if (lsSaveUC[i].Item1 != uc)
                {
                    lsSaveUC[i].Item1.uncheckRb();
                    lsSaveUC[i] = new Tuple<uc_answer, int>(lsSaveUC[i].Item1, 0);
                }
                else
                {
                    lsSaveUC[i] = new Tuple<uc_answer, int>(uc, 1);
                }
            }
        }

        private bool checkChoseAns()
        {
            int count = 0;
            for (int i = 0; i < lsSaveUC.Count; i++)
            {
                if (lsSaveUC[i].Item2 == 1) count++;
            }
            if (count == 0) return false;
            return true;
        }

        private int countNext()
        {
            int count = 0;
            for (int i = integerCurrent; i < quesList.Count; i++)
                if (!quesList[i].Item3) count++;
            return count;
        }

        private int countPrev()
        {
            int count = 0;
            for (int i = 0; i < integerCurrent - 1; i++)
                if (!quesList[i].Item3) count++;
            return count;
        }

        #endregion
    }
}
