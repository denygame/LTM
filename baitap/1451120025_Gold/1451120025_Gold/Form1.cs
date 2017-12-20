using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _1451120025_Gold
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            check();
            timer1.Start();
            this.Text = "Start ....";
        }


        private void check()
        {
            int get = solution("http://www.sjc.com.vn/xml/tygiavang.xml");
            if (get != 0)
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("t2hd.faceshop@gmail.com");
                    mail.To.Add(txtEmail.Text);
                    mail.Subject = "Canh Bao Gia Vang";
                    mail.Body = "<h1>http://www.sjc.com.vn/xml/tygiavang.xml</h1>";
                    mail.IsBodyHtml = true;
                    //mail.Attachments.Add(new Attachment("C:\\file.zip"));

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("t2hd.faceshop@gmail.com", "t2hdlalala");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
            }
        }

        private int solution(string link)
        {
            HttpWebRequest request = WebRequest.CreateHttp(link);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string content = sr.ReadToEnd();
            sr.Close();

            int count = 0;

            XmlReader reader = XmlReader.Create(new StringReader(content));
            reader.ReadToFollowing("ratelist");
            reader.MoveToFirstAttribute(); //thuoc tinh "updated"
           // System.Console.WriteLine("Cap nhat luc: " + reader.Value);
            reader.MoveToNextAttribute(); // Thuoc tinh unit
            //System.Console.WriteLine("Don vi tinh: " + reader.Value);
            while (reader.ReadToFollowing("city")) //duyet cac Element city
            {
                reader.MoveToFirstAttribute();
                //System.Console.WriteLine("Thanh pho: " + reader.Value);
                reader.MoveToElement();
                XmlReader r = reader.ReadSubtree();
                while (r.ReadToFollowing("item"))
                {
                    r.MoveToFirstAttribute();//buy
                    System.Console.WriteLine("Gia mua: " + reader.Value);
                    int buy = Convert.ToInt32(reader.Value.Replace(".",""));
                    r.MoveToNextAttribute(); //sell
                    System.Console.WriteLine("Gia ban: " + reader.Value);
                    int sell = Convert.ToInt32(reader.Value.Replace(".",""));
                    //r.MoveToNextAttribute(); //type
                    //System.Console.WriteLine("Loai: " + reader.Value);
                    if (buy < (int)numMax.Value) count++;
                    if (sell > (int)numMin.Value) count++;
                }
            }

            return count;
        }

        //1tieng lam
        private void timer1_Tick(object sender, EventArgs e)
        {
            check();
        }
    }
}
