using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RoroBARREL.Classes
{
    class Utils
    {
        public static JObject LoadJson(string path)
        {
            try {
                string tmp = "";
                using (StreamReader sr = File.OpenText(path)) {
                    string s = String.Empty;
                    while ((s = sr.ReadLine()) != null) {
                        tmp += s;
                    }
                }
                return JObject.Parse(tmp); ;
            } catch (JsonReaderException e) {
                Console.WriteLine("A JSON Parse Error happens\n" + e); return null;
            }
        }
        public static void WritePlainFile(string path, string content)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs)) {
                sw.WriteLine(content);
                sw.Flush();
                sw.Close();
            }
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList) {
                if (ip.AddressFamily == AddressFamily.InterNetwork) {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
        public static string GetSize(string filename) {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = new FileInfo(filename).Length;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1) {
                order++;
                len = len / 1024;
            }

            // Adjust the format string to your preferences. For example "{0:0.#}{1}" would
            // show a single decimal place, and no space.
           return String.Format("{0:0.##} {1}", len, sizes[order]);
        }
    }
}
