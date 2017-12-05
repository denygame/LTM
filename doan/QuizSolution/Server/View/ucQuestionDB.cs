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
        public ucQuestionDB()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
            }
        }

        private void ucQuestionDB_Load(object sender, EventArgs e)
        {
            resizeFill();

            try
            {
                dGv_Course.DataSource = Controller.CourseController.getCourses();
                dGv_Course.Columns[0].HeaderText = "Mã Khóa Học";
                dGv_Course.Columns[1].HeaderText = "Tên Khóa Học";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCreateCourse_Click(object sender, EventArgs e)
        {
            (new frmCourse()).ShowDialog();
        }

        private void btnAddQues_Click(object sender, EventArgs e)
        {
            (new View.frmQues()).ShowDialog();
        }

        private void dGv_Course_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            (new View.frmCourse()).ShowDialog();
        }

        private void dGv_Ques_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)//edit
            {
                if (e.RowIndex != -1)// not header
                    if (dGv_Ques.CurrentRow.Index != dGv_Ques.RowCount - 1)
                    {
                        int id_ques = int.Parse(get_current_cell_content_dgv(dGv_Ques, 2).ToString());
                        (new View.frmQues(id_ques)).ShowDialog();
                    }
            }

            if (e.ColumnIndex == 1)//xóa
            {
                MessageBox.Show("Xóa");
            }
        }

        private void dGv_Course_SelectionChanged(object sender, EventArgs e)
        {
            if (dGv_Course.SelectedCells.Count > 0)
            {
                int id_course = int.Parse(get_current_cell_content_dgv(dGv_Course, 0).ToString());
                fill_dgv_ques(id_course);
            }
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

    }
}
