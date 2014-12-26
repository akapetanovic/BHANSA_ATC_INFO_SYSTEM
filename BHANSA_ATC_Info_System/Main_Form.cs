using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BHANSA_ATC_Info_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (textBoxSend_Box.Text.Length > 0)
            {

            }
        }

        private void Am_I_Server_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Am_I_Server.Checked)
            {
                Shared_Data.I_Am_Server = true;
                this.Am_I_Server.Text = "Server";
                this.checkBoxConnect.Text = "Listen";
            } 
            else
            {
                Shared_Data.I_Am_Server = false;
                this.Am_I_Server.Text = "Client";
                this.checkBoxConnect.Text = "Connect";
            }
        }
    }
}
