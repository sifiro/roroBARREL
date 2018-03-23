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
            this.b_maketoolbox = new System.Windows.Forms.Button();
            this.b_updatepkg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.l_webstatus = new System.Windows.Forms.Label();
            this.b_webbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.l_hhsStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.t_localipaddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_send
            // 
            this.b_send.Location = new System.Drawing.Point(216, 227);
            this.b_send.Name = "b_send";
            this.b_send.Size = new System.Drawing.Size(75, 23);
            this.b_send.TabIndex = 0;
            this.b_send.Text = "Send List";
            this.b_send.UseVisualStyleBackColor = true;
            this.b_send.Click += new System.EventHandler(this.b_send_Click);
            // 
            // t_address
            // 
            this.t_address.Location = new System.Drawing.Point(195, 25);
            this.t_address.Name = "t_address";
            this.t_address.Size = new System.Drawing.Size(96, 20);
            this.t_address.TabIndex = 1;
            this.t_address.Text = "blanc.lan";
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
            this.folderPath.Size = new System.Drawing.Size(204, 20);
            this.folderPath.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Examine";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_showtable
            // 
            this.b_showtable.Location = new System.Drawing.Point(23, 227);
            this.b_showtable.Name = "b_showtable";
            this.b_showtable.Size = new System.Drawing.Size(86, 23);
            this.b_showtable.TabIndex = 6;
            this.b_showtable.Text = "Show Table";
            this.b_showtable.UseVisualStyleBackColor = true;
            this.b_showtable.Click += new System.EventHandler(this.ShowTable_Click);
            // 
            // b_showSettings
            // 
            this.b_showSettings.Location = new System.Drawing.Point(114, 227);
            this.b_showSettings.Name = "b_showSettings";
            this.b_showSettings.Size = new System.Drawing.Size(96, 23);
            this.b_showSettings.TabIndex = 7;
            this.b_showSettings.Text = "Show Settings";
            this.b_showSettings.UseVisualStyleBackColor = true;
            this.b_showSettings.Click += new System.EventHandler(this.b_showSettings_Click);
            // 
            // b_maketoolbox
            // 
            this.b_maketoolbox.Location = new System.Drawing.Point(23, 198);
            this.b_maketoolbox.Name = "b_maketoolbox";
            this.b_maketoolbox.Size = new System.Drawing.Size(120, 23);
            this.b_maketoolbox.TabIndex = 8;
            this.b_maketoolbox.Text = "Make HANTOOLBOX";
            this.b_maketoolbox.UseVisualStyleBackColor = true;
            this.b_maketoolbox.Click += new System.EventHandler(this.b_maketoolbox_Click);
            // 
            // b_updatepkg
            // 
            this.b_updatepkg.Location = new System.Drawing.Point(196, 198);
            this.b_updatepkg.Name = "b_updatepkg";
            this.b_updatepkg.Size = new System.Drawing.Size(95, 22);
            this.b_updatepkg.TabIndex = 9;
            this.b_updatepkg.Text = "Update PKG";
            this.b_updatepkg.UseVisualStyleBackColor = true;
            this.b_updatepkg.Click += new System.EventHandler(this.b_updatepkg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Web Server Status:";
            // 
            // l_webstatus
            // 
            this.l_webstatus.AutoSize = true;
            this.l_webstatus.Location = new System.Drawing.Point(126, 146);
            this.l_webstatus.Name = "l_webstatus";
            this.l_webstatus.Size = new System.Drawing.Size(53, 13);
            this.l_webstatus.TabIndex = 11;
            this.l_webstatus.Text = "Unknown";
            // 
            // b_webbutton
            // 
            this.b_webbutton.Location = new System.Drawing.Point(196, 141);
            this.b_webbutton.Name = "b_webbutton";
            this.b_webbutton.Size = new System.Drawing.Size(95, 23);
            this.b_webbutton.TabIndex = 12;
            this.b_webbutton.Text = "Start";
            this.b_webbutton.UseVisualStyleBackColor = true;
            this.b_webbutton.Click += new System.EventHandler(this.b_webbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "HANSOLOHAX Server Status:";
            // 
            // l_hhsStatus
            // 
            this.l_hhsStatus.AutoSize = true;
            this.l_hhsStatus.Location = new System.Drawing.Point(175, 115);
            this.l_hhsStatus.Name = "l_hhsStatus";
            this.l_hhsStatus.Size = new System.Drawing.Size(111, 13);
            this.l_hhsStatus.TabIndex = 14;
            this.l_hhsStatus.Text = "NOT IMPLEMENTED";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Local IP Address:";
            // 
            // t_localipaddress
            // 
            this.t_localipaddress.Location = new System.Drawing.Point(116, 170);
            this.t_localipaddress.Name = "t_localipaddress";
            this.t_localipaddress.Size = new System.Drawing.Size(100, 20);
            this.t_localipaddress.TabIndex = 16;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 262);
            this.Controls.Add(this.t_localipaddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.l_hhsStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b_webbutton);
            this.Controls.Add(this.l_webstatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b_updatepkg);
            this.Controls.Add(this.b_maketoolbox);
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
        private System.Windows.Forms.Button b_maketoolbox;
        private System.Windows.Forms.Button b_updatepkg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_webstatus;
        private System.Windows.Forms.Button b_webbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l_hhsStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_localipaddress;
    }
}

