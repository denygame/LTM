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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
        
        public void resizeFill()
        {
            this.Width = this.Parent.Width;
            this.Height = this.Parent.Height;
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

        private void dGv_Course_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
