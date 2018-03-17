namespace RoroBARREL
{
    partial class Main
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.b_send = new System.Windows.Forms.Button();
            this.t_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderPath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.b_showtable = new System.Windows.Forms.Button();
            this.b_showSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_send
            // 
            this.b_send.Location = new System.Drawing.Point(250, 150);
            this.b_send.Name = "b_send";
            this.b_send.Size = new System.Drawing.Size(75, 23);
            this.b_send.TabIndex = 0;
            this.b_send.Text = "Send";
            this.b_send.UseVisualStyleBackColor = true;
            this.b_send.Click += new System.EventHandler(this.b_send_Click);
            // 
            // t_address
            // 
            this.t_address.Location = new System.Drawing.Point(195, 25);
            this.t_address.Name = "t_address";
            this.t_address.Size = new System.Drawing.Size(130, 20);
            this.t_address.TabIndex = 1;
            this.t_address.Text = "localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "HANSOLOHAX IP Address Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Directory to Scan";
            // 
            // folderPath
            // 
            this.folderPath.Location = new System.Drawing.Point(23, 77);
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(221, 20);
            this.folderPath.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Examine";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_showtable
            // 
            this.b_showtable.Location = new System.Drawing.Point(23, 150);
            this.b_showtable.Name = "b_showtable";
            this.b_showtable.Size = new System.Drawing.Size(99, 23);
            this.b_showtable.TabIndex = 6;
            this.b_showtable.Text = "Show Table";
            this.b_showtable.UseVisualStyleBackColor = true;
            this.b_showtable.Click += new System.EventHandler(this.ShowTable_Click);
            // 
            // b_showSettings
            // 
            this.b_showSettings.Location = new System.Drawing.Point(144, 150);
            this.b_showSettings.Name = "b_showSettings";
            this.b_showSettings.Size = new System.Drawing.Size(91, 23);
            this.b_showSettings.TabIndex = 7;
            this.b_showSettings.Text = "Show Settings";
            this.b_showSettings.UseVisualStyleBackColor = true;
            this.b_showSettings.Click += new System.EventHandler(this.b_showSettings_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 195);
            this.Controls.Add(this.b_showSettings);
            this.Controls.Add(this.b_showtable);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.folderPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_address);
            this.Controls.Add(this.b_send);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button b_send;
        private System.Windows.Forms.TextBox t_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button b_showtable;
        private System.Windows.Forms.Button b_showSettings;
    }
}

