using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerUdp
{
    public class PathInfo
    {
        public static Tuple<List<string>, List<string>> getInfo(string path)
        {
            if (Directory.Exists(path))
            {
                string[] directorysPath = Directory.GetDirectories(path);//lấy danh sách folder con cho vào mảng
                string[] filesPath = Directory.GetFiles(path);//lay danh sách file cho vao mảng

                List<string> folderList = new List<string>();
                List<string> fileList = new List<string>();

                foreach(var folder in directorysPath)
                    folderList.Add(Path.GetFileName(folder));
                foreach(var file in filesPath)
                    fileList.Add(Path.GetFileName(file));

                return new Tuple<List<string>, List<string>>(folderList, fileList);
            }
            else return null;
        }
    }
}
