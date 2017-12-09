using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server.Controller
{
    class ObjectForThread
    {
        private int time;
        private int getDB;
        private int getFile;

        public int Time { get => time; set => time = value; }
        public int GetDB { get => getDB; set => getDB = value; }
        public int GetFile { get => getFile; set => getFile = value; }
        
        public ObjectForThread() { }

        public ObjectForThread(int time, int getDB, int getFile)
        {
            this.Time = time;
            this.GetDB = getDB;
            this.GetFile = getFile;
        }

        /// <summary>
        /// int 4 byte
        /// </summary>
        /// <param name="data"></param>
        public ObjectForThread(byte[] data)
        {
            Time = BitConverter.ToInt32(data,0);
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
