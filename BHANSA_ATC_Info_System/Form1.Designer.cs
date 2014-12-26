namespace BHANSA_ATC_Info_System
{
    partial class Form1
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
            if (disposing && (components != null))
            {
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
            this.listBoxLogWindow = new System.Windows.Forms.ListBox();
            this.Am_I_Server = new System.Windows.Forms.CheckBox();
            this.checkBoxConnect = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Active_Connections = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSend_Box = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxLogWindow
            // 
            this.listBoxLogWindow.FormattingEnabled = true;
            this.listBoxLogWindow.ItemHeight = 16;
            this.listBoxLogWindow.Location = new System.Drawing.Point(12, 106);
            this.listBoxLogWindow.Name = "listBoxLogWindow";
            this.listBoxLogWindow.Size = new System.Drawing.Size(630, 388);
            this.listBoxLogWindow.TabIndex = 0;
            // 
            // Am_I_Server
            // 
            this.Am_I_Server.AutoSize = true;
            this.Am_I_Server.Location = new System.Drawing.Point(13, 13);
            this.Am_I_Server.Name = "Am_I_Server";
            this.Am_I_Server.Size = new System.Drawing.Size(65, 21);
            this.Am_I_Server.TabIndex = 1;
            this.Am_I_Server.Text = "Client";
            this.Am_I_Server.UseVisualStyleBackColor = true;
            this.Am_I_Server.CheckedChanged += new System.EventHandler(this.Am_I_Server_CheckedChanged);
            // 
            // checkBoxConnect
            // 
            this.checkBoxConnect.AutoSize = true;
            this.checkBoxConnect.Location = new System.Drawing.Point(13, 41);
            this.checkBoxConnect.Name = "checkBoxConnect";
            this.checkBoxConnect.Size = new System.Drawing.Size(129, 21);
            this.checkBoxConnect.TabIndex = 2;
            this.checkBoxConnect.Text = "Start Listenning";
            this.checkBoxConnect.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Activity log";
            // 
            // Active_Connections
            // 
            this.Active_Connections.FormattingEnabled = true;
            this.Active_Connections.ItemHeight = 16;
            this.Active_Connections.Location = new System.Drawing.Point(648, 106);
            this.Active_Connections.Name = "Active_Connections";
            this.Active_Connections.Size = new System.Drawing.Size(321, 388);
            this.Active_Connections.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(645, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Active Connections";
            // 
            // textBoxSend_Box
            // 
            this.textBoxSend_Box.Location = new System.Drawing.Point(12, 504);
            this.textBoxSend_Box.Name = "textBoxSend_Box";
            this.textBoxSend_Box.Size = new System.Drawing.Size(630, 22);
            this.textBoxSend_Box.TabIndex = 6;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(649, 502);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(103, 23);
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 538);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxSend_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Active_Connections);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxConnect);
            this.Controls.Add(this.Am_I_Server);
            this.Controls.Add(this.listBoxLogWindow);
            this.Name = "Form1";
            this.Text = "BHANSA ATC INFO SYSTEM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLogWindow;
        private System.Windows.Forms.CheckBox Am_I_Server;
        private System.Windows.Forms.CheckBox checkBoxConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Active_Connections;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSend_Box;
        private System.Windows.Forms.Button buttonSend;
    }
}

