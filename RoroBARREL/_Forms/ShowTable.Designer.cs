namespace RoroBARREL
{
    partial class ShowTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.l_address = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.b_connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // l_address
            // 
            this.l_address.AutoSize = true;
            this.l_address.Location = new System.Drawing.Point(198, 13);
            this.l_address.Name = "l_address";
            this.l_address.Size = new System.Drawing.Size(35, 13);
            this.l_address.TabIndex = 13;
            this.l_address.Text = "label2";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 59);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(341, 205);
            this.dataGridView.TabIndex = 12;
            // 
            // b_connect
            // 
            this.b_connect.Location = new System.Drawing.Point(267, 312);
            this.b_connect.Name = "b_connect";
            this.b_connect.Size = new System.Drawing.Size(75, 23);
            this.b_connect.TabIndex = 11;
            this.b_connect.Text = "Refresh";
            this.b_connect.UseVisualStyleBackColor = true;
            this.b_connect.Click += new System.EventHandler(this.b_connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "HANSOLOHAX IP Address Server";
            // 
            // ShowTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 363);
            this.Controls.Add(this.l_address);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.b_connect);
            this.Controls.Add(this.label1);
            this.Name = "ShowTable";
            this.Text = "ShowTable";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_address;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button b_connect;
        private System.Windows.Forms.Label label1;
    }
}