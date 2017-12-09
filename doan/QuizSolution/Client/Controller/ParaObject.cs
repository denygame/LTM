using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controller
{
    class ParaObject
    {
        private int time;
        private int getDB;
        private int getFile;

        public int Time { get => time; set => time = value; }
        public int GetDB { get => getDB; set => getDB = value; }
        public int GetFile { get => getFile; set => getFile = value; }

        /// <summary>
        /// int 4 byte
        /// </summary>
        /// <param name="data"></param>
        public ParaObject(byte[] data)
        {
            Time = BitConverter.ToInt32(data, 0);
            GetDB = BitConverter.ToInt32(data, 4);
            GetFile = BitConverter.ToInt32(data, 8);
        }

        public byte[] toByteArray()
        {
            List<byte> byteList = new List<byte>();
            byteList.AddRange(BitConverter.GetBytes(Time));
            byteList.AddRange(BitConverter.GetBytes(GetDB));
            byteList.AddRange(BitConverter.GetBytes(GetFile));
            return byteList.ToArray();
        }

    }
}
