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
        private int id_ans;
        private List<int> lsIdAnsDelete = new List<int>();

        private int idques = -1;

        public frmQues(int idques = -1)
        {
            InitializeComponent();
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

            constuct_dgv_ans();
            this.id_ans = Controller.AnswerController.get_last_id();
        }

        private void dgv_answer_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            id_ans++;
            //if (e.RowIndex > 0)
            //    dgv_answer.Rows[e.RowIndex - 1].Cells[0].Value = id_ans;
            if (e.RowIndex > 0)
                dgv_answer.Rows[e.RowIndex - 1].Tag = id_ans;
        }

        private void dgv_answer_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            constuct_dgv_ans();
            return;
        }

        private void dgv_answer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString());
            if (e.ColumnIndex == 4)//delete
            {
                //MessageBox.Show(e.RowIndex.ToString());
                if (e.RowIndex != -1)//not header
                    if (get_current_row_dgv().Index != dgv_answer.RowCount - 1)
                    {
                        //MessageBox.Show(get_current_row_dgv().Tag.ToString());
                        int idanswer = Convert.ToInt32(get_current_row_dgv().Tag);
                        dgv_answer.Rows.Remove(get_current_row_dgv());
                        if (Controller.AnswerController.findId(idanswer))
                        {
                            lsIdAnsDelete.Add(idanswer);
                        }
                    }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(this.idques!=-1)//edit
            {

            }
            else //insert
            {

            }
        }

        #endregion







        #region -- Method --

        private void constuct_dgv_ans()
        {
            dgv_answer.Columns.Clear();

            dgv_answer.DataSource = Controller.AnswerController.getListAnswer(this.idques);
            dgv_answer.Columns[0].Visible = false;//hide true_or_false
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



        #endregion
    }
}
