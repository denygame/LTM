using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Server.View
{
    public partial class ucSetting : UserControl
    {
        public ucSetting()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
            }
        }



        private void ucSetting_Load(object sender, EventArgs e)
        {
            txtIP.Text = Controller.Ip.getIpLocal();
            resizeFill();

            cbNumCourse.DataSource = Controller.CourseController.getList();
            cbNumCourse.DisplayMember = "id";
        }

        private void lblCSDL_Click(object sender, EventArgs e)
        {
            if (checkBoxCSDL.Checked) checkBoxCSDL.Checked = false;
            else checkBoxCSDL.Checked = true;
        }

        private void lblFile_Click(object sender, EventArgs e)
        {
            if (checkBoxFile.Checked) checkBoxFile.Checked = false;
            else checkBoxFile.Checked = true;
        }

        //textbox number only
        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) { e.Handled = true; }
        }

        private void txtIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void lbl_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.FromArgb(25, 33, 94);
        }

        private void lblCSDL_MouseLeave(object sender, EventArgs e)
        {
            lblCSDL.ForeColor = Color.FromArgb(146, 18, 36);
        }

        private void lblFile_MouseLeave(object sender, EventArgs e)
        {
            lblFile.ForeColor = Color.FromArgb(104, 7, 71);
        }

        private void cbNumCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            var count = Controller.QuestionController.countInCourse((cbNumCourse.SelectedItem as Model.Course).Id);
            lblQuesDB.Text = "Có " + count + " câu hỏi";
        }










        public void resizeFill()
        {
            this.Width = this.Parent.Width;
            this.Height = this.Parent.Height;
        }

        private void btnCreateOrOK_Click(object sender, EventArgs e)
        {
            string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
            string[] directorysPath = Directory.GetDirectories(pathRoot);//lấy danh sách folder con cho vào mảng
            string path_save = pathRoot + Controller.Constant.nameFolderSaveFile;
            if (!directorysPath.Contains(path_save))
            {
                Directory.CreateDirectory(path_save);
            }

            string folder_name = DateTime.Now.Date.ToString("dd-MM-yyyy");

            //Controller.IO_INI ini = new Controller.IO_INI("E:\\test.ini");
            //ini.IniWriteValue("section", "key", "giatri");
        }
    }
}
