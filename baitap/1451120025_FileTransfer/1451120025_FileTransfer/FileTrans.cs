using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _1451120025_FileTransfer
{
    public class FileTrans
    {
        private static int DATA_BYTES = 1024 * 100;
        private static string pathSaveFile = "";

        private static Stream streamWriter = null;
        private static Stream streamReader = null;
        private static NetworkStream networkStream = null;

        /// <summary>
        /// type == 0 : receive (nhận) -> server
        /// type == 1 : send (gửi) -> client
        /// </summary>
        /// <param name="type"></param>
        public static void solution(int type)
        {
            switch (type)
            {
                case 0:
                    mode_ReceiveFile(9999);
                    break;
                case 1:
                    mode_SendFile(9999);
                    break;
                default:
                    break;
            }
        }

        //receive -> server
        private static void mode_ReceiveFile(int port)
        {
            Socket sckServer = null;
            Socket sckClient = null;

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("\t1451120025 - Nguyen Thanh Huy");
            Console.WriteLine("------------------ Nhan File (Server) ------------------\r\n");

            try
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Any, port);
                sckServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sckServer.Bind(ipep);
                sckServer.Listen(10);

                //nhập đường dẫn upload
                inputPathSaveFile();

                Console.WriteLine("Dang cho ket noi......");
                sckClient = sckServer.Accept();
                Console.WriteLine("Ket noi tu: " + sckClient.RemoteEndPoint + Environment.NewLine);


                var data = new byte[1024];
                //nhận file name
                int sizeInfo = sckClient.Receive(data);
                string fileName = Encoding.ASCII.GetString(data, 0, sizeInfo);
                //nhận file size (lưu ý biến long)
                sizeInfo = sckClient.Receive(data);
                long fileSize = BitConverter.ToInt64(data, 0);


                //tạo bộ nhớ đệm
                var buff = new byte[DATA_BYTES];

                //tạo file rỗng truyền lên
                string pathUpload = createFile(pathSaveFile, fileName);

                /* Lưu ý:  
                 *      networkStream: ở đây là nhận từ socket
                 *      streamReader: ở đầy là biến stream nhận được từ socket accpet
                 *      streamWriter: ở đây là ghi vào file
                 */
                networkStream = new NetworkStream(sckClient);
                streamReader = networkStream;
                streamWriter = File.OpenWrite(pathUpload);

                int sizeEachTime = 0;
                while ((sizeEachTime = streamReader.Read(buff, 0, DATA_BYTES)) != 0)
                {
                    streamWriter.Write(buff, 0, sizeEachTime);
                    streamWriter.Flush();

                    Console.WriteLine("Receive: " + sizeEachTime + " bytes / " + fileSize + " bytes");
                    fileSize -= sizeEachTime;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }
            finally
            {
                networkStream.Close();
                sckClient.Close();
                sckServer.Close();
                streamWriter.Close();
                streamReader.Close();
                Console.ReadKey();
            }

        }

        //send -> client
        private static void mode_SendFile(int port)
        {
            Socket sckConnectServer = null;

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("\t1451120025 - Nguyen Thanh Huy");
            Console.WriteLine("------------------ Gui File (Client) ------------------\r\n");

            pathOfFile:
            Console.Write("Nhap duong dan file: ");
            string path = Console.ReadLine();
            //string path = @"C:\Users\thanh\Pictures\001.jpg";
            if (File.Exists(path))
            {
                ipReceiveFile:
                Console.Write("Nhap vao IP nhan file: ");
                string ip = Console.ReadLine();
                //string ip = "127.0.0.1";
                try
                {
                    IPAddress.Parse(ip);
                }
                catch
                {
                    goto ipReceiveFile;
                }

                try
                {
                    IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), port);
                    sckConnectServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    sckConnectServer.Connect(ipep);
                    Console.WriteLine("Ket noi thanh cong! \r\n");


                    var fileInfo = getNameSizeOfFile(path);
                    long fileSize = fileInfo.Item2;
                    Console.WriteLine("Kich thuoc tap tin: " + fileSize + "\r\n");
                    //truyền tên file
                    byte[] data_fName = Encoding.ASCII.GetBytes(fileInfo.Item1);
                    sckConnectServer.Send(data_fName);
                    //truyền kích thước file(lưu ý biến long)
                    byte[] data_fSize = BitConverter.GetBytes(fileSize);
                    sckConnectServer.Send(data_fSize);


                    //tạo bộ nhớ đệm
                    byte[] buff = new byte[DATA_BYTES];


                    /* Lưu ý:  
                     *      networkStream: ở đây là nhận từ socket
                     *      streamReader: ở đầy là biến đọc file biến thành stream
                     *      streamWriter: ở đây là truyền đi đền server
                     */
                    networkStream = new NetworkStream(sckConnectServer);
                    streamReader = File.OpenRead(path);
                    streamWriter = networkStream;

                    int sizeEachTime = 0;
                    while ((sizeEachTime = streamReader.Read(buff, 0, DATA_BYTES)) != 0)
                    {
                        streamWriter.Write(buff, 0, sizeEachTime);
                        streamWriter.Flush();

                        Console.WriteLine("Send: " + sizeEachTime + " bytes / " + fileSize + " bytes");
                        fileSize -= sizeEachTime;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.ReadKey();
                }
                finally
                {
                    sckConnectServer.Close();
                    networkStream.Close();
                    streamReader.Close();
                    streamWriter.Close();
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("\r\nDuong dan khong ton tai!\r\n");
                goto pathOfFile;
            }
        }


        private static long getBufferCount(long fileSize)
        {
            long bufferCount = 0;
            if (fileSize % DATA_BYTES == 0) bufferCount = fileSize / DATA_BYTES;
            else bufferCount = fileSize / DATA_BYTES + 1;
            return bufferCount;
        }

        private static string createFile(string pathSaveFile, string fileName)
        {
            string pathString = Path.Combine(pathSaveFile, fileName);

            if (File.Exists(pathString))
            {
                FileInfo fileRoute = new FileInfo(fileName);
                fileRoute.Delete();
            }
            FileStream fs = File.Create(pathString);
            fs.Close();
            return pathString;
        }

        // Item1: name, Item2: size
        private static Tuple<string, long> getNameSizeOfFile(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            string fileName = fileInfo.Name;
            long fileSize = fileInfo.Length;

            return new Tuple<string, long>(fileName, fileSize);
        }

        private static void inputPathSaveFile()
        {
            label:
            Console.Write("Nhap duong dan save file: ");
            string path = Console.ReadLine();
            if (!Directory.Exists(path))
            {
                Console.WriteLine("=> Duong dan khong ton tai!\r\n");
                goto label;
            }
            pathSaveFile = path;
        }
    }
}
