﻿using System;
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
            string macaddr = txtMacAddress.Text;
            try
            {
                WOLClass.WakeFunction(macaddr);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid MAC Address.");
                this.txtMacAddress.Focus();
                this.txtMacAddress.SelectAll();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void btnSavedHostsWakeup_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
