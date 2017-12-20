using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _1451120025_HTTPClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate void UpdateGUI(string s);
        void UpdateTextBox(string s)
        {
            txtContent.Text += s + "\r\n";
        }
        void OutputText(string s)
        {
            txtContent.Invoke(new UpdateGUI(UpdateTextBox), new object[] { s });
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            txtContent.Clear();
            string link = txtUrl.Text;
            //Tao object thuc hien Http request
            HttpWebRequest request = WebRequest.CreateHttp(link);
            //Tao object nhan Http response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //Doc du lieu 
            StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string content = sr.ReadToEnd();
            sr.Close();

            OutputText(content);


        }
    }
}
