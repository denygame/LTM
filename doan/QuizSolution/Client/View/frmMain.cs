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
        List<Model.Question> lsQuesDB, lsQuesFile;
        List<Model.Answer> lsAnsDB, lsAnsFile;

        int total_ques;

        List<Tuple<View.uc_answer, int>> lsSaveUC = new List<Tuple<View.uc_answer, int>>();
        List<Tuple<string, int, bool>> lsResult = new List<Tuple<string, int, bool>>();

        int runQuiz = 0;

        string quesInFileOrDB = "";
        int idques = -1;

        //timer
        int timeRun = 0;
        int second = 60;
        int minute = Controller.Constant.time / 60;
        bool firstTime = true;

        public frmMain(List<Model.Question> lsQuesDB, List<Model.Question> lsQuesFile, List<Model.Answer> lsAnsDB, List<Model.Answer> lsAnsFile)
        {
            InitializeComponent();

            this.lsQuesDB = lsQuesDB;
            this.lsQuesFile = lsQuesFile;
            this.lsAnsDB = lsAnsDB;
            this.lsAnsFile = lsAnsFile;
        }

        #region -- Event --

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
            total_ques = lsQuesDB.Count + lsQuesFile.Count;
            setTimer();
            btnPrev.Visible = false;
            setQuiz(runQuiz);
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
                    minute--;
                    if (minute < 10)
                    {
                        if (minute == 1) lblMinute.Text = "00" + " : ";
                        else lblMinute.Text = "0" + minute + " : ";
                    }
                    else lblMinute.Text = minute + " : ";
                }
            }
            timeRun += 1;
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            runQuiz++;
            if (runQuiz + 1 == lsQuesDB.Count + lsQuesFile.Count)
            {
                btnNext.Visible = false;
            }
            if (runQuiz != 0) btnPrev.Visible = true;
            setQuiz(runQuiz);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < lsSaveUC.Count; i++)
            {
                if ((int)lsSaveUC[i].Item1.Tag == lsSaveUC[i].Item2) count++;
            }

            if (count == lsSaveUC.Count)
            {
                lsResult.Add(new Tuple<string, int, bool>(quesInFileOrDB, idques, true));
            }

            total_ques--;

            if (total_ques != 0)
            {
                if (!btnNext.Visible) btnPrev_Click(null, null);
                else btnNext_Click(null, null);
            }
            else
            {
                panelQuiz.Controls.Clear();
                MessageBox.Show(lsResult.Count.ToString());
            }


        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            runQuiz--;
            if (runQuiz == 0) btnPrev.Visible = false;
            if (runQuiz != lsQuesDB.Count + lsQuesFile.Count) btnNext.Visible = true;
            setQuiz(runQuiz);
        }

        #endregion



        #region -- Method --

        private void setQuiz(int index)
        {
            panelQuiz.Controls.Clear();
            lsSaveUC.Clear();

            Model.Question ques;
            if (lsQuesDB.Count == 0)
            {
                ques = lsQuesFile[index];
            }
            else
            {
                if (lsQuesFile.Count == 0)
                    ques = lsQuesDB[index];
                else
                {
                    if (index < lsQuesDB.Count)
                        ques = lsQuesDB[index];
                    else
                    {
                        int new_index = index - lsQuesDB.Count;
                        ques = lsQuesFile[new_index];
                    }
                }
            }

            var setupQues = setQues((runQuiz + 1) + ") " + ques.Content);

            int width = setupQues.Item1;
            int height = setupQues.Item2;

            if (lsQuesDB.Count == 0)
            {
                setAnswers(setupQues.Item1, setupQues.Item2, ques.Id, ques.Num_answer_right, lsAnsFile);
                quesInFileOrDB = "file";
            }
            else
            {
                setAnswers(setupQues.Item1, setupQues.Item2, ques.Id, ques.Num_answer_right, lsAnsDB);
                quesInFileOrDB = "data";
            }
            idques = ques.Id;
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

        private void setAnswers(int width, int height, int idques, int num_right, List<Model.Answer> ls)
        {
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].Id_ques == idques)
                {
                    var uc = new View.uc_answer(ls[i].Content, num_right);
                    uc.Location = new Point(20, height);
                    uc.Name = "answer" + ls[i].Id;
                    this.lsSaveUC.Add(new Tuple<uc_answer, int>(uc, 0));

                    uc.radioClick += radioClick_click;
                    uc.Tag = ls[i].True_or_false;
                    height += uc.Height + 10;
                    panelQuiz.Controls.Add(uc);

                }
            }

            Panel pn = new Panel();
            pn.Location = new Point(20, height);
            pn.Size = new Size(width, 10);
            pn.BackColor = Color.Transparent;
            panelQuiz.Controls.Add(pn);
        }

        //radio button uncheck
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




        #endregion
    }
}
