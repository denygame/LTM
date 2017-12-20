using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;
namespace HTTPClientExample
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
            textBox1.Text+= s + "\r\n";
        }
        void OutputText(string s)
        {
            textBox1.Invoke(new UpdateGUI(UpdateTextBox), new object[] { s});
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String link = "http://www.sjc.com.vn/xml/tygiavang.xml";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string content = sr.ReadToEnd();
            sr.Close();
            //OutputText(content);
            // System.Console.WriteLine(content);
            /*
            <root>
            <title>
                Cong ty TNHH MTV Vang bac da quy Sai gon : Bang Ty gia vang SJC
            </title>
            <url>http://www.sjc.com.vn/</url>
            <ratelist updated="08:11:25 AM 16/06/2015" unit="ngàn đồng/lượng">
                <city name="Hồ Chí Minh">
                    <item buy="34.680" sell="34.740" type="Vàng SJC 1L"/>
                    <item buy="31.600" sell="31.900" type="Vàng nhẫn SJC 99,99 5p,1c,2c,5c"/>
                    <item buy="31.200" sell="31.900" type="Vàng nữ trang 99,99%"/>
                    <item buy="30.884" sell="31.584" type="Vàng nữ trang 99%"/>
                    <item buy="22.777" sell="24.077" type="Vàng nữ trang 75%"/>
                    <item buy="17.450" sell="18.750" type="Vàng nữ trang 58,3%"/>
                    <item buy="12.154" sell="13.454" type="Vàng nữ trang 41,7%"/>
                </city>
                <city name="Hà Nội">
                    <item buy="34.680" sell="34.760" type="Vàng SJC"/>
                </city>
                ... 
            </ratelist>
             */
            XmlReader reader = XmlReader.Create(new StringReader(content));
            reader.ReadToFollowing("ratelist");
            reader.MoveToFirstAttribute(); //thuoc tinh "updated"
            System.Console.WriteLine("Cap nhat luc: " + reader.Value);
            OutputText("Cap nhat luc: " + reader.Value);
            reader.MoveToNextAttribute(); // Thuoc tinh unit
            System.Console.WriteLine("Don vi tinh: " + reader.Value);
            OutputText("Don vi tinh: " + reader.Value);
            while (reader.ReadToFollowing("city")) //duyet cac Element city
            {
                reader.MoveToFirstAttribute();
                System.Console.WriteLine("Thanh pho: " + reader.Value);
                OutputText("Thanh pho: " + reader.Value);
                reader.MoveToElement();
                XmlReader r = reader.ReadSubtree();
                while (r.ReadToFollowing("item"))
                {
                    r.MoveToFirstAttribute();//buy
                    System.Console.WriteLine("Gia mua: " + reader.Value);
                    OutputText("Gia mua: " + reader.Value);
                    r.MoveToNextAttribute(); //sell
                    System.Console.WriteLine("Gia ban: " + reader.Value);
                    OutputText("Gia ban: " + reader.Value);
                    r.MoveToNextAttribute(); //type
                    System.Console.WriteLine("Loai: " + reader.Value);
                    OutputText("Loai: " + reader.Value);
                }
            }


        }
    }
}
