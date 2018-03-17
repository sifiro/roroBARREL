namespace RoroBARREL
{
    partial class ShowParameters
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
            this.label1 = new System.Windows.Forms.Label();
            this.b_connect = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.l_address = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "HANSOLOHAX IP Address Server";
            // 
            // b_connect
            // 
            this.b_connect.Location = new System.Drawing.Point(287, 341);
            this.b_connect.Name = "b_connect";
            this.b_connect.Size = new System.Drawing.Size(75, 23);
            this.b_connect.TabIndex = 7;
            this.b_connect.Text = "Refresh";
            this.b_connect.UseVisualStyleBackColor = true;
            this.b_connect.Click += new System.EventHandler(this.b_connect_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(32, 88);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(341, 205);
            this.dataGridView.TabIndex = 8;
            // 
            // l_address
            // 
            this.l_address.AutoSize = true;
            this.l_address.Location = new System.Drawing.Point(218, 42);
            this.l_address.Name = "l_address";
            this.l_address.Size = new System.Drawing.Size(35, 13);
            this.l_address.TabIndex = 9;
            this.l_address.Text = "label2";
            // 
            // ShowParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 376);
            this.Controls.Add(this.l_address);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.b_connect);
            this.Controls.Add(this.label1);
            this.Name = "ShowParameters";
            this.Text = "ShowParameters";
            this.Load += new System.EventHandler(this.ShowParameters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_connect;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label l_address;
    }
}