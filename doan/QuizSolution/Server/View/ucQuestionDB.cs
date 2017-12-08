using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.View
{
    public partial class ucQuestionDB : UserControl
    {
        private int idcourse = -1;
        private bool connectDb;

        public ucQuestionDB()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
            }

            this.connectDb = Controller.DBConnection.connect();
        }


        #region -- Event --

        private void ucQuestionDB_Load(object sender, EventArgs e)
        {
            resizeFill();

            if (connectDb)
            {
                show_course();
                lblCourse.Text = "Có tất cả " + Controller.CourseController.count() + " chủ đề";
            }
            else
            {
                lblCourse.Text = "Vui lòng kiểm tra lại kết nối";
                lblQues.Text = "File " + Controller.Constant.nameFileConnection + " hoặc kết nối có lỗi";
            }
        }

        private void btnCreateCourse_Click(object sender, EventArgs e)
        {
            if (connectDb)
            {
                var frm_course = new View.frmCourse();
                frm_course.EvtSend += Frm_course_EvtSend;
                frm_course.ShowDialog();
            }
        }

        private void btnAddQues_Click(object sender, EventArgs e)
        {
            if (connectDb)
            {
                var f = new View.frmQues(this.idcourse);
                f.EvtSaveOk += F_EvtSaveOk;
                f.ShowDialog();
            }
        }

        private void F_EvtSaveOk(object sender, EventArgs e)
        {
            dGv_Course_SelectionChanged(null, null);
        }

        private void dGv_Course_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_course = int.Parse(get_current_cell_content_dgv(dGv_Course, 0).ToString());
            var frm_course = new View.frmCourse(id_course);
            frm_course.EvtSend += Frm_course_EvtSend;
            frm_course.ShowDialog();
        }

        private void Frm_course_EvtSend(object sender, EventArgs e)
        {
            ucQuestionDB_Load(null, null);
        }

        private void dGv_Ques_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (connectDb)
            {
                int id_ques = int.Parse(get_current_cell_content_dgv(dGv_Ques, 2).ToString());
                if (e.ColumnIndex == 0)//edit
                {
                    if (e.RowIndex != -1)// not header
                    {
                        var f = new View.frmQues(this.idcourse, id_ques);
                        f.EvtSaveOk += F_EvtSaveOk;
                        f.ShowDialog();
                    }
                }

                if (e.ColumnIndex == 1)//xóa
                {
                    DialogResult res = MessageBox.Show("Bạn xác nhận muốn xóa câu hỏi có mã " + id_ques + "?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        Controller.AnswerController.deleteByIdQues(id_ques);
                        Controller.QuestionController.delete(id_ques);
                        dGv_Course_SelectionChanged(null, null);
                    }
                }
            }
        }

        private void dGv_Course_SelectionChanged(object sender, EventArgs e)
        {
            if (connectDb)
            {
                if (dGv_Course.SelectedCells.Count > 0)
                {
                    int id_course = int.Parse(get_current_cell_content_dgv(dGv_Course, 0).ToString());
                    this.idcourse = id_course;
                    fill_dgv_ques(id_course);
                    lblQues.Text = "Khóa học: " + get_current_cell_content_dgv(dGv_Course, 1).ToString() + " có " + Controller.QuestionController.countInCourse(id_course) + " câu hỏi";
                }
            }
        }

        #endregion




        #region -- Method -- 

        private void show_course()
        {
            dGv_Course.DataSource = Controller.CourseController.getCourses();
            dGv_Course.Columns[0].HeaderText = "Mã Chủ Đề";
            dGv_Course.Columns[1].HeaderText = "Tên Khóa Học";
        }

        private object get_current_cell_content_dgv(DataGridView dgv, int cell_num)
        {
            int selectedrowindex = dgv.CurrentCell.RowIndex;
            return dgv.Rows[selectedrowindex].Cells[cell_num].Value;
        }

        private void fill_dgv_ques(int id_course)
        {
            var data = Controller.QuestionController.getQuestionByIdCourse(id_course);
            data.Columns[0].ColumnName = "Mã";//cell 2
            data.Columns[1].ColumnName = "Nội dung";
            data.Columns[2].ColumnName = "Đúng";
            this.dGv_Ques.DataSource = data;
            create_btn_column(dGv_Ques, "edit", "Sửa");//cell 0
            create_btn_column(dGv_Ques, "delete", "Xóa");//cell 1
        }

        private void create_btn_column(DataGridView dgv, string name, string text)
        {
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = name;
            btnColumn.UseColumnTextForButtonValue = true;
            btnColumn.Text = text;
            btnColumn.HeaderText = text;
            btnColumn.Width = 50;
            if (dgv.Columns[name] == null)
            {
                dgv.Columns.Add(btnColumn);
            }
        }

        public void resizeFill()
        {
            this.Width = this.Parent.Width;
            this.Height = this.Parent.Height;
        }

        #endregion
    }
}
