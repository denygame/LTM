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
    public partial class frmQues : Form
    {
        private List<int> lsIdAnsDelete = new List<int>();
        private bool checkRowAddNotConstruct = false; //khoi tao dgv luc show frm => false

        private int idques = -1;
        private int idcourse;

        private event EventHandler evtSaveOk;
        public event EventHandler EvtSaveOk
        {
            add { evtSaveOk += value; }
            remove { evtSaveOk -= value; }
        }

        public frmQues(int idcourse, int idques = -1)
        {
            InitializeComponent();
            this.idcourse = idcourse;
            if (idques != -1) this.idques = idques;
        }

        #region -- Event --

        private void btnImgClose_Click(object sender, EventArgs e)
        {
            this.Close();

            //int run = 0;
            //foreach (DataGridViewRow i in dgv_answer.Rows)
            //{
            //    if (run < dgv_answer.Rows.Count - 1)
            //        MessageBox.Show(i.Tag.ToString());
            //    run++;
            //}
        }

        private void frmQues_Load(object sender, EventArgs e)
        {
            //dgv_answer.ReadOnly = false;
            //dgv_answer.Columns[0].ReadOnly = true;

            if (this.idques != -1)
            {
                this.txtQues.Text = Controller.QuestionController.getQues(this.idques).Content;
            }

            constuct_dgv_ans(Controller.AnswerController.getListAnswer(this.idques));

            this.txtQues.Select(txtQues.Text.Length, 0);
            this.txtQues.ScrollToCaret();
        }

        private void dgv_answer_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //if (e.RowIndex > 0)
            //    dgv_answer.Rows[e.RowIndex - 1].Cells[0].Value = id_ans;
            if (e.RowIndex > 0)
            {
                // add new row when not contruct
                if (checkRowAddNotConstruct)
                {
                    //set default false
                    dgv_answer.Rows[e.RowIndex - 1].Cells["myComboColumn"].Value = (dgv_answer.Rows[e.RowIndex - 1].Cells["myComboColumn"] as DataGridViewComboBoxCell).Items[1];

                    dgv_answer.Rows[e.RowIndex - 1].Cells["true_or_false"].Value = 0;

                    dgv_answer.Rows[e.RowIndex - 1].Tag = Controller.Constant.id_tag_new_row_add_dgv_answer;
                }
            }
        }

        private void dgv_answer_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            checkRowAddNotConstruct = false;
            constuct_dgv_ans(Controller.AnswerController.getListAnswer(this.idques));
            return;
        }

        private void dgv_answer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // MessageBox.Show(e.ColumnIndex.ToString());
            if (e.ColumnIndex == 4)//delete
            {
                //MessageBox.Show(e.RowIndex.ToString());
                if (e.RowIndex != -1)//not header
                    if (get_current_row_dgv().Index != dgv_answer.RowCount - 1)
                    {
                        //MessageBox.Show(get_current_row_dgv().Tag.ToString());
                        int idanswer = Convert.ToInt32(get_current_row_dgv().Tag);
                        dgv_answer.Rows.Remove(get_current_row_dgv());
                        if (idanswer != Controller.Constant.id_tag_new_row_add_dgv_answer)
                        {
                            lsIdAnsDelete.Add(idanswer);
                        }
                    }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.txtQues.Focus();
            if (this.idques != -1)//edit
            {
                edit();
            }
            else //insert
            {
                insert();
            }
            this.evtSaveOk(this, new EventArgs());
            this.Close();
        }

        #endregion


        #region -- Method --

        private void constuct_dgv_ans(DataTable data)
        {
            dgv_answer.Columns.Clear();

            dgv_answer.DataSource = data;
            dgv_answer.Columns[0].Visible = false;//hide id
            dgv_answer.Columns[2].Visible = false;//hide true_or_false
            dgv_answer.Columns[1].HeaderText = "Nội dung";
            dgv_answer.Columns[1].Width = 263;

            create_cb_tf();
            create_btndelete_column();

            // save id to tag row
            int run = 0;
            foreach (DataGridViewRow row in dgv_answer.Rows)
            {
                if (run < dgv_answer.RowCount - 1)
                    row.Tag = dgv_answer.Rows[row.Index].Cells[0].Value;
                run++;
            }

            checkRowAddNotConstruct = true;
        }

        private void create_cb_tf()
        {
            DataGridViewComboBoxColumn cmbCol = new DataGridViewComboBoxColumn();
            cmbCol.HeaderText = "T/F";
            cmbCol.Name = "myComboColumn";
            cmbCol.Items.Add("True");
            cmbCol.DataSource = Controller.Constant.ls_cb_answers_dgv;
            dgv_answer.Columns.Add(cmbCol);

            int run = 0;
            foreach (DataGridViewRow row in dgv_answer.Rows)
            {
                if (run < dgv_answer.RowCount - 1)
                {
                    if ((int)row.Cells["true_or_false"].Value == 0)
                        row.Cells["myComboColumn"].Value = (row.Cells["myComboColumn"] as DataGridViewComboBoxCell).Items[1];
                    else row.Cells["myComboColumn"].Value = (row.Cells["myComboColumn"] as DataGridViewComboBoxCell).Items[0];
                }
                run++;
            }
        }

        private void create_btndelete_column()
        {
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "delete";
            btnColumn.UseColumnTextForButtonValue = true;
            btnColumn.Text = "Xóa";
            btnColumn.HeaderText = "Xóa";
            btnColumn.Width = 50;
            if (dgv_answer.Columns["delete"] == null)
            {
                dgv_answer.Columns.Add(btnColumn);
            }
        }

        private DataGridViewRow get_current_row_dgv()
        {
            int selectedrowindex = dgv_answer.CurrentCell.RowIndex;
            return dgv_answer.Rows[selectedrowindex];
        }

        // get each row on dgv_answer and add to datatable
        private DataTable convert_dgv_to_dt()
        {
            DataTable data = new DataTable();
            DataColumn col;
            col = new DataColumn();
            col.DataType = Type.GetType("System.Int32");
            col.ColumnName = "id";
            data.Columns.Add(col);

            col = new DataColumn();
            col.DataType = Type.GetType("System.String");
            col.ColumnName = "content";
            data.Columns.Add(col);

            col = new DataColumn();
            col.DataType = Type.GetType("System.Int32");
            col.ColumnName = "true_or_false";
            data.Columns.Add(col);

            int run = 0;
            foreach (DataGridViewRow row in dgv_answer.Rows)
            {
                if (run < dgv_answer.RowCount - 1)
                {
                    DataRow r = data.NewRow();
                    r["id"] = (row.Cells["id"].Value.ToString() == String.Empty) ? Controller.Constant.id_tag_new_row_add_dgv_answer : Convert.ToInt32(row.Cells["id"].Value);

                    r["content"] = row.Cells["content"].Value.ToString();

                    if (row.Cells["myComboColumn"].Value.ToString() == Controller.Constant.ls_cb_answers_dgv[0])
                        r["true_or_false"] = 1;
                    else r["true_or_false"] = 0;

                    data.Rows.Add(r);
                }
                run++;
            }

            return data;
        }

        private int get_num_right_ans()
        {
            int run = 0, count = 0;
            foreach (DataGridViewRow row in dgv_answer.Rows)
            {
                if (run < dgv_answer.RowCount - 1)
                {
                    if (row.Cells["myComboColumn"].Value.ToString() == Controller.Constant.ls_cb_answers_dgv[0])
                        count++;
                }
                run++;
            }
            return count;
        }


        private void edit()
        {
            string ques = this.txtQues.Text;
            if (ques.Trim().Length == 0)
            {
                if (MessageBox.Show("Bạn có chắc câu hỏi sẽ trống?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.txtQues.Focus();
                    this.txtQues.Select();
                    return;
                }
            }

            int num_right = get_num_right_ans();
            if (num_right == 0)
            {
                MessageBox.Show("Các câu trả lời không thể trống và có ít nhất 1 câu đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //update question
            Controller.QuestionController.update(this.idques, ques, num_right);

            //delete answer
            if (this.lsIdAnsDelete.Count > 0)
            {
                foreach (var i in lsIdAnsDelete)
                    Controller.AnswerController.delete(i);
            }

            //update old answer, insert new answer
            var data = convert_dgv_to_dt();
            foreach (DataRow row in data.Rows)
            {
                if (Convert.ToInt32(row["id"]) == -1)//insert
                {
                    Controller.AnswerController.insert(row["content"].ToString(), this.idques, Convert.ToInt32(row["true_or_false"]));
                }
                else//update
                {
                    Model.Answer ans = new Model.Answer(Convert.ToInt32(row["id"]), row["content"].ToString(), this.idques, Convert.ToInt32(row["true_or_false"]));
                    Controller.AnswerController.update(ans);
                }
            }
        }

        private void insert()
        {
            string ques = this.txtQues.Text;
            if (ques.Trim().Length == 0)
            {
                if (MessageBox.Show("Bạn có chắc câu hỏi sẽ trống?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.txtQues.Focus();
                    this.txtQues.Select();
                    return;
                }
            }

            int num_right = get_num_right_ans();
            if (num_right == 0)
            {
                MessageBox.Show("Các câu trả lời không thể trống và có ít nhất 1 câu đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //insert ques
            Controller.QuestionController.insert(ques, this.idcourse, num_right);

            int id = Controller.QuestionController.get_last_id();

            //insert new answer
            var data = convert_dgv_to_dt();
            foreach (DataRow row in data.Rows)
            {
                Controller.AnswerController.insert(row["content"].ToString(), id, Convert.ToInt32(row["true_or_false"]));
            }
        }



        #endregion


    }
}
