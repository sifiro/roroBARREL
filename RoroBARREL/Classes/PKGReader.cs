using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RoroBARREL.Classes
{
    class PKGReader
    {
        const int ContentID=0x030;
        const int size = 0x024;
        public static string contentidreader(string path)
        {
            return Bin2StringReader(new FileStream(path,FileMode.Open),ContentID,size);
        }
        private static string Bin2StringReader(FileStream fstream,int from, int to)
        {
            BinaryReader breader= new BinaryReader(fstream);
            breader.BaseStream.Position = from;
            string parsed=Encoding.UTF8.GetString(breader.ReadBytes(to));
            breader.Close();
            return parsed;
        }
    }
}
