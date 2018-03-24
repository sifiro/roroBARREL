using System.Diagnostics;
using System.IO;

namespace RoroBARREL.Classes
{
    public static class PKGMaker
    {
        private const string templateFolder = "PKGTEMPLATES";
        private const string htbx = "HANTOOLBX";
        private const string htbxContentID = "UP0100-HANTOOLBX_00-PINK1000DEVIL303";
        private const string pkglink = "PKGLINKER";
        private const string pkglinkContentID = "UP0100-PKGLINKER_00-PINK1000DEVIL303";

        private static string GenerateHANToolboxXML(string host)
        {
            return new Templates.HANToolBoxXMLGenerator() { Host = host }.TransformText();
        }

        private static string GeneratePKGLinkerXML(string host,string directory,string pkgDirectory,string iconsDirectory, string[] pkgs)
        {
            var x= new Templates.PackageLinkXMLGenerator() { Host = host,
                PKGDirectory = pkgDirectory,
                IconsDirectory = iconsDirectory,
                Directory = directory,
                PKGs = pkgs,
                PKGLinkContentID = pkglinkContentID
            };
            return x.TransformText();
        }

        private static string GenerateConfigurationForPKGGenerator(string contentid) {
            return new Templates.PackageConfigurationTemplate() { ContentID = contentid }.TransformText();
        }

        public static void GenerateHANToolbox(string host)
        {
            /// Make han_toolbox_xmb.xml
            Utils.WritePlainFile("./"+templateFolder+"/"+htbx+"/USRDIR/" + "han_toolbox_xmb.xml", GenerateHANToolboxXML(host));
            /// Make configuration file for PKG Packer
            Utils.WritePlainFile("./" + templateFolder + "/" + "config-hantoolbox.cfg", GenerateConfigurationForPKGGenerator(htbxContentID));
            MakePKG("./" + templateFolder + "/" + "config-hantoolbox.cfg", "./" + templateFolder + "/" + htbx);
        }

        public static void GeneratePKGLinker(string host, string directory, string pkgDirectory, string iconsDirectory , string[] pkgs)
        {
        //    Utils.copyDirectory("./" + templateFolder + "/" + pkglink, "./" + templateFolder + "/" + pkglink_tmp);
            /// Make package_link.xml Template
            Utils.WritePlainFile("./" + templateFolder + "/" + pkglink + "/USRDIR/" + "package_link.xml",
                GeneratePKGLinkerXML(host,directory,pkgDirectory, iconsDirectory, pkgs));
            /// Make configuration file for PKG Packer
            Utils.WritePlainFile("./" + templateFolder + "/" + "config-pkglinker.cfg", GenerateConfigurationForPKGGenerator(pkglinkContentID));
            MakePKG("./" + templateFolder + "/" + "config-pkglinker.cfg", "./" + templateFolder + "/" + pkglink);
            File.Move(".\\"+ pkglinkContentID+".pkg", directory+ "\\Package_List.pkg");
        }

        private static void MakePKG(string config, string dir) {
            Process.Start(new ProcessStartInfo() {
                CreateNoWindow = false,
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "./external/psn_package_npdrm2.exe",
                /// package.conf XMBPLS
                Arguments = config +" " + dir
            }).WaitForExit();
        }
    }
}
