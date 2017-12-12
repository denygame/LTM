using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Server.Controller
{
    class FileExcel
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


        /*public static int write(string link, int row, Controller.ObjectClient obj)
        {
            // Khởi động chtr Excell
            Excel.Application exApp = new Excel.Application();


            // Thêm file hay open
            Excel.Workbook exBook = (link == string.Empty) ? exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet) : exApp.Workbooks.Open(link);

            // Lấy sheet 1.
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];

            //exSheet.Name = "Lập trình mạng";


            // Range là ô [1,1] (A1)
            Excel.Range code = (Excel.Range)exSheet.Cells[row, 1];
            Excel.Range name = (Excel.Range)exSheet.Cells[row, 2];
            Excel.Range class_str = (Excel.Range)exSheet.Cells[row, 3];

            // Ghi dữ liệu
            code.Value2 = obj.Code;
            name.Value2 = obj.Name;
            class_str.Value2 = obj.Class_str;

            // Giãn cột
            code.Columns.AutoFit();
            name.Columns.AutoFit();
            class_str.Columns.AutoFit();


            exApp.DisplayAlerts = false;

            exBook.SaveAs(link, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);

            exBook.Close(false, false, false);
            exApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook);

            return row++;
        }*/



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
            for (int test = 3; test <= xlWorksheet.UsedRange.Columns.Count; test = test + 2)
            {
                if (valueArray[row, test] == null) continue;
                if (valueArray[row, test].ToString() == "True") count++;
            }
            
            return count > 0;
        }

    }
}
