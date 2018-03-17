using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RoroBARREL
{
    public partial class ShowParameters : Form
    {
        private API api;

        public ShowParameters(API api)
        {
            InitializeComponent();
            this.api = api;
            l_address.Text = api.host;
            refresh();
        }

        private void ShowParameters_Load(object sender, EventArgs e)
        {

        }

        private void refresh()
        {
            dataGridView.DataSource = api.getSettings().ToList();
        }

        private void b_connect_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
