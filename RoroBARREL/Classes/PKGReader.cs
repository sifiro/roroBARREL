using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace RoroBARREL.Classes
{
    public static class PKGReader
    {
        public static void ImgExtractor(string pkg, string output)
        {
            Extractor(pkg,"ICON0.PNG",output);
        }

        private static void Extractor(string pkg, string file, string output) {
            Process.Start(new ProcessStartInfo() {
                CreateNoWindow = false,
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "./external/PS3P_PKG_Ripper_1.3.exe",
                /// package.conf XMBPLS
                Arguments = '"' + pkg + '"' +" -s " + file + " -o " +output
            }).WaitForExit();
        }

        private const int Id = 0x037;
        private const int IdSize = 0x009;
        public static string IdReader(string path)
        {
            return Bin2StringReader(new FileStream(path, FileMode.Open), Id, IdSize);
        }

        private const int ContentId=0x030;
        private const int ContentIdSize = 0x024;
        public static string ContentIdReader(string path)
        {
            return Bin2StringReader(new FileStream(path,FileMode.Open),ContentId,ContentIdSize);
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
