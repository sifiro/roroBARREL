using System.Diagnostics;
using System.IO;

namespace RoroBARREL.Classes
{
    class PKGMaker
    {
        private const string templateFolder = "PKGTEMPLATES";
        private const string HTBX = "HANTOOLBX";

        public static string GenerateHANToolboxXML(string host) {
            return new Templates.HANToolBoxXMLGenerator() { Host = host }.TransformText(); ;
        }

        public static void GenerateHANToolbox(string host) {
            WritePlainFile("./"+templateFolder+"/"+HTBX+"/USRDIR/" + "han_toolbox_xmb.xml", GenerateHANToolboxXML(host));

        }

        public static void WritePlainFile(string path, string content) {
        using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs)) {
                sw.WriteLine(content);
                sw.Flush();
                sw.Close();
            }

        }

        public static void MakePKG(string config, string dir) {
            ProcessStartInfo psn_package = new ProcessStartInfo() {
                CreateNoWindow = false,
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "psn_package_npdrm2.exe",
                /// package.conf XMBPLS
                Arguments = config +" " + dir
            };
        }
    }
}
