using System;
using System.Collections.Generic;
using System.ComponentModel;
using Unosquare.Labs.EmbedIO;
using Unosquare.Labs.EmbedIO.Modules;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace RoroBARREL
{
    public partial class Main : Form
    {
        private API api;
        private WebServer server;
        private bool server_status;
        private JObject settings;
        public Main()
        {
            InitializeComponent();
            server_status=false;
            l_webstatus.Text = "Stopped";
            if (File.Exists("./config.json")) 
            {
                settings=Classes.Utils.LoadJson("./config.json");
                t_address.Text = settings.SelectToken("serveripaddress").Value<string>();
                t_localipaddress.Text = settings.SelectToken("localipaddress").Value<string>();
                folderPath.Text = settings.SelectToken("defaultfolder").Value<string>();

            } else t_localipaddress.Text = Classes.Utils.GetLocalIPAddress();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ShowTable_Click(object sender, EventArgs e)
        {
            setup();
            new ShowTable(api).ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
               folderPath.Text=folderBrowserDialog1.SelectedPath;
            }
        }

        private void setup()
        {
            if (api==null) 
            {
                api = new API(t_address.Text);
            }
        }

        private void b_showSettings_Click(object sender, EventArgs e)
        {
            setup();
            new ShowParameters(api).ShowDialog();
        }

        private void b_send_Click(object sender, EventArgs e)
        {
            var pkgs = Directory.GetFiles(folderPath.Text, "*.pkg");
            var list=new Dictionary<string, string>();
            foreach (var file in pkgs) {
                try {
                    list.Add(Path.GetFileName(file),Classes.PKGReader.ContentIdReader(file));
                } catch {
                    throw;
                }
            }
            
            setup();
           api.setTable(new Table() {table = list });
            api.SetLocalIPAddress(t_localipaddress.Text);
           MessageBox.Show("The List and parameters was sent to Server", "Done", MessageBoxButtons.OK);
        }

        private void b_maketoolbox_Click(object sender, EventArgs e)
        {
            Classes.PKGMaker.GenerateHANToolbox(t_address.Text);
        }

        private void b_webbutton_Click(object sender, EventArgs e)
        {
            if (!server_status) 
            {
                server_status = true;
                l_webstatus.Text = "Running";
                b_webbutton.Text = "Stop";
                server = new WebServer();
                server.RegisterModule(new StaticFilesModule(folderPath.Text));
                server.RunAsync();
                
            } else 
            {
                server.Dispose();
                l_webstatus.Text = "Stopped";
                b_webbutton.Text = "Start";
                server_status = false;
            }
        }
    }
}
