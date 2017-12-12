using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Server.View
{
    public partial class frmMain : Form
    {
        private string ucSelected = null;


        public frmMain()
        {
            InitializeComponent();
        }

        #region -- Event -- 

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

            switch (ucSelected)
            {
                case "ques": (panelContent.Tag as View.ucQuestionDB).resizeFill(); break;
                case "sett": (panelContent.Tag as View.ucSetting).resizeFill(); break;
                case "run": (panelContent.Tag as View.ucRunServer).resizeFill(); break;
                default: break;
            }
            
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            View.ucQuestionDB ucQues = View.ucQuestionDB.Instance;
            ucQues.checkConnect();
            panelContent.Controls.Clear();
            panelContent.Controls.Add(ucQues);
            ucQues.resizeFill();
            panelContent.Tag = ucQues;
            ucSelected = "ques";
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            View.ucSetting ucSett = View.ucSetting.Instance;
            ucSett.checkConnect();
            panelContent.Controls.Clear();
            panelContent.Controls.Add(ucSett);
            ucSett.resizeFill();
            panelContent.Tag = ucSett;
            ucSelected = "sett";
        }

        private void btnRunServer_Click(object sender, EventArgs e)
        {
            View.ucRunServer ucRun = View.ucRunServer.Instance;
            ucRun.EventStartServer += UcRun_EventStartServer;
            ucRun.StopServer += UcRun_StopServer;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(ucRun);
            ucRun.resizeFill();
            panelContent.Tag = ucRun;
            ucSelected = "run";
        }

        private void UcRun_StopServer(object sender, EventArgs e)
        {
            View.ucSetting.Instance.startServer = false;
        }

        private void UcRun_EventStartServer(object sender, Controller.EventSendData e)
        {
            lblInfo.Text = e.Ip + " : " + e.Port;
            View.ucSetting.Instance.startServer = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            panelSlideMenu.Width = 50;
            logo.Visible = false;

            this.btnQuestion_Click(sender, e);
            Controller.DBConnection.connect();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            path = Path.Combine(path, Controller.Constant.nameFolderSaveFile);
            path = Path.Combine(path, Controller.Constant.nameFileSetting);
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            View.ucRunServer.Instance.stopServer("not show txt");
        }

        #endregion







    }
}
