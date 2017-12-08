using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Server.Controller
{
    class ReadFileExcel
    {
        private static List<int> lsIdQuesInListObj = new List<int>();


        public static void read(string link)
        {
            // chạy file Excel theo đường dẫn
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(link);
            // Lấy Sheet 1
            Excel.Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets.get_Item(1);
            // Lấy phạm vi dữ liệu
            Excel.Range xlRange = xlWorksheet.UsedRange;
            // Tạo mảng lưu trữ dữ liệu
            object[,] valueArray = (object[,])xlRange.get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);

            addToList(xlWorksheet, valueArray);



            // Đóng Workbook.
            xlWorkbook.Close(false);
            // Đóng application.
            xlApp.Quit();
            //Khử hết đối tượng
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
        }


        private static void addToList(Excel.Worksheet xlWorksheet, object[,] valueArray)
        {
            if (lsIdQuesInListObj.Count > 0)
            {
                ListObj.deleteFile();
                lsIdQuesInListObj.Clear();
            }

            List<Model.Question> lsques = new List<Model.Question>();
            List<Model.Answer> lsans = new List<Model.Answer>();
            int idquesfile = 1;

            for (int row = 1; row <= xlWorksheet.UsedRange.Rows.Count; row++)//đọc row hiện có trong Excel
            {
                string ques_content = "";
                try
                {
                    ques_content = valueArray[row, 1].ToString();
                }
                catch
                {
                    continue;
                }

                int num_ans_right = 0;

                if (checkHasTrue(row, xlWorksheet, valueArray))
                {
                    for (int colum = 2; colum <= xlWorksheet.UsedRange.Columns.Count; colum = colum + 2)//đọc colum trong Excel
                    {
                        string ans_content = "";
                        int tf = 0;
                        try
                        {
                            ans_content = valueArray[row, colum].ToString();
                            string str_tf = valueArray[row, colum + 1].ToString();
                            switch (str_tf)
                            {
                                case "True": tf = 1; num_ans_right++; break;
                                case "False": tf = 0; break;
                                default: tf = 0; break;
                            }
                        }
                        catch (Exception ex)
                        {
                            continue;
                        }

                        Model.Answer ans = new Model.Answer(ans_content, idquesfile, tf);
                        lsans.Add(ans);
                    }
                }

                if (num_ans_right != 0 && ques_content != "")
                {
                    Model.Question ques = new Model.Question(idquesfile, ques_content, num_ans_right);
                    lsques.Add(ques);
                    lsIdQuesInListObj.Add(idquesfile);
                    idquesfile++;
                }

            }

            Controller.ListObj.addWithFile(lsques, lsans);
        }


        private static bool checkHasTrue(int row, Excel.Worksheet xlWorksheet, object[,] valueArray)
        {
            int count = 0;
            for (int test = 3; test <= xlWorksheet.UsedRange.Columns.Count; test = test + 3)
            {
                if (valueArray[row, test].ToString() == "True") count++;
            }
            return count > 0;
        }

    }
}
