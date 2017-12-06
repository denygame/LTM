using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.View
{
    public partial class frmCourse : Form
    {
        private int idcourse;

        private event EventHandler evtSend;
        public event EventHandler EvtSend
        {
            add { evtSend += value; }
            remove { evtSend -= value; }
        }

        public frmCourse(int idcourse = -1)
        {
            InitializeComponent();
            this.idcourse = idcourse;
        }

        private void btnImgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCourse_Load(object sender, EventArgs e)
        {
            this.txtNameCourse.Select();
            if (idcourse != -1)
            {
                var course = Controller.CourseController.getCourseByid(idcourse);
                if (course != null)
                {
                    this.txtNumCourse.Text = course.Id.ToString();
                    this.txtNameCourse.Text = course.Name;
                }
            }
            else
            {
                this.txtNumCourse.Text = (Controller.CourseController.get_last_id() + 1).ToString();
                this.btnDelete.Visible = false;
            }
        }

        private void txtNumCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int total_ques = Controller.QuestionController.countInCourse(this.idcourse);
            DialogResult yn = MessageBox.Show("Có tất cả " + total_ques + " câu hỏi trong khóa học này! Có chắc rằng bạn muốn xóa?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yn == DialogResult.Yes)
            {
                var lsIdQuesInCourse = Controller.QuestionController.getListIdInCourse(this.idcourse);
                foreach (var idques in lsIdQuesInCourse)
                {
                    Controller.AnswerController.deleteByIdQues(idques);
                    Controller.QuestionController.delete(idques);
                }
                Controller.CourseController.delete(this.idcourse);
                evtSend(this, new EventArgs());
                this.Close();
            }
        }

        private void btnCreateOrOK_Click(object sender, EventArgs e)
        {
            if (txtNameCourse.Text.Trim().Length == 0)
            {
                if (MessageBox.Show("Bạn có chắc tên khóa học là trống?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }

            if (this.idcourse == -1)//insert
            {
                Controller.CourseController.insert(Convert.ToInt32(txtNumCourse.Text), txtNameCourse.Text);
            }
            else //update
            {
                Controller.CourseController.update(this.idcourse, txtNameCourse.Text);
            }

            evtSend(this, new EventArgs());
            this.Close();
        }
    }
}
