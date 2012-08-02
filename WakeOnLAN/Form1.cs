using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WakeOnLAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewHostWakeup_Click(object sender, EventArgs e)
        {
            string macaddr = this.txtMacAddress.Text;
            string bc = this.txtBroadcast.Text;
            try
            {
                WOLClass.WakeFunction(macaddr, bc);
                MessageBox.Show("Complete.");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid MAC Address or Broadcast.");
                this.txtMacAddress.Focus();
                this.txtMacAddress.SelectAll();
            }
        }
    }
}
