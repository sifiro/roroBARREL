using System.Diagnostics;
using System.IO;

namespace RoroBARREL.Classes
{
    class PKGMaker
    {
        private const string templateFolder = "PKGTEMPLATES";
        private const string htbx = "HANTOOLBX";
        private const string htbxContentID = "UP0100-HANTOOLBX_00-PINK1000DEVIL303";
        private const string pkglink = "PKGLINKER";
        private const string pkglinkContentID = "UP0100-PKGLINKER_00-PINK1000DEVIL303";

        private static string GenerateHANToolboxXML(string host) {
            return new Templates.HANToolBoxXMLGenerator() { Host = host }.TransformText(); ;
        }

        private static string GenerateConfigurationForPKGGenerator(string contentid) {
            return new Templates.PackageConfigurationTemplate() { ContentID = contentid }.TransformText();
        }


        public static void GenerateHANToolbox(string host) {
            /// Make han_toolbox_xmb.xml
            WritePlainFile("./"+templateFolder+"/"+htbx+"/USRDIR/" + "han_toolbox_xmb.xml", GenerateHANToolboxXML(host));
            /// Make configuration file for PKG Packer
            WritePlainFile("./" + templateFolder + "/" + "config-hantoolbox.cfg", GenerateConfigurationForPKGGenerator(htbxContentID));
            MakePKG("./" + templateFolder + "/" + "config-hantoolbox.cfg", "./" + templateFolder + "/" + htbx);
        }

        public static void GeneratePKGLinker(string host)
        {
            /// TODO: Make package_link.xml Template
            WritePlainFile("./" + templateFolder + "/" + pkglink + "/USRDIR/" + "package_link.xml", null);
            /// Make configuration file for PKG Packer
            WritePlainFile("./" + templateFolder + "/" + "config-pkglinker.cfg", GenerateConfigurationForPKGGenerator(pkglinkContentID));
            MakePKG("./" + templateFolder + "/" + "config-pkglinker.cfg", "./" + templateFolder + "/" + pkglink);
        }

        private static void WritePlainFile(string path, string content) {
        using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs)) {
                sw.WriteLine(content);
                sw.Flush();
                sw.Close();
            }

        }

        private static void MakePKG(string config, string dir) {
            Process.Start(new ProcessStartInfo() {
                CreateNoWindow = false,
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "./external/psn_package_npdrm2.exe",
                /// package.conf XMBPLS
                Arguments = config +" " + dir
            });
           
        }
    }
}
