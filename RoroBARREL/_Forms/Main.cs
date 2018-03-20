using System;
using System.Collections.Generic;
using System.ComponentModel;
using Unosquare.Labs.EmbedIO;
using Unosquare.Labs.EmbedIO.Modules;
using System.IO;
using System.Windows.Forms;

namespace RoroBARREL
{
    public partial class Main : Form
    {
        API api;
        WebServer server;
        bool server_status;
        public Main()
        {
            InitializeComponent();
            server_status=false;
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
           MessageBox.Show("The List was sent to Server", "Done", MessageBoxButtons.OK);
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
                server = new WebServer();
                server.RegisterModule(new StaticFilesModule(folderPath.Text));
                server.RunAsync();
                
            } else 
            {
                server.Dispose();
                server_status = false;
            }
        }
    }
}
