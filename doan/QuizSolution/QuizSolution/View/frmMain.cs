using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class frmMain : Form
    {
        private string ucSelected = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnImgClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            

            if (panelSlideMenu.Width == 50)
            {
                panelSlideMenu.Width = 206;
                LogoTransition.ShowSync(logo);
                SlideMenuTransition.ShowSync(panelSlideMenu);
            }
            else
            {
                LogoTransition.Hide(logo);
                panelSlideMenu.Width = 50;
                SlideMenuTransition.ShowSync(panelSlideMenu);
            }
            
            if (this.ucSelected != null)
                resizeUcPanelContent();
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            View.ucQuestionDB ucQues = new View.ucQuestionDB();
            this.ucSelected = "ques";
            btnQuestion.Tag = ucQues;

            panelContent.Controls.Clear();
            panelContent.Controls.Add(ucQues);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            panelSlideMenu.Width = 50;
            logo.Visible = false;

            this.btnQuestion_Click(sender, e);
        }





        private void resizeUcPanelContent()
        {
            switch (this.ucSelected)
            {
                case "ques":
                    (btnQuestion.Tag as View.ucQuestionDB).resizeFill();
                    break;
                default: break;
            }
        }
    }
}
