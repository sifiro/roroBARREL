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
    public partial class ShowTable : Form
    {
        private API api;
        public ShowTable(API api)
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
            dataGridView.DataSource = new BindingSource() { DataSource = api.getTable().table };

        }

        private void b_connect_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
