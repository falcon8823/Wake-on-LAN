namespace WakeOnLAN
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNewHostWakeup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMacAddress = new System.Windows.Forms.MaskedTextBox();
            this.hostList = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSavedHostsWakeup = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHostName
            // 
            this.txtHostName.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtHostName.Location = new System.Drawing.Point(161, 46);
            this.txtHostName.Margin = new System.Windows.Forms.Padding(4);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(169, 28);
            this.txtHostName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(363, 48);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 24);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add to List";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNewHostWakeup
            // 
            this.btnNewHostWakeup.Location = new System.Drawing.Point(363, 16);
            this.btnNewHostWakeup.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewHostWakeup.Name = "btnNewHostWakeup";
            this.btnNewHostWakeup.Size = new System.Drawing.Size(100, 24);
            this.btnNewHostWakeup.TabIndex = 2;
            this.btnNewHostWakeup.Text = "Wake up!";
            this.btnNewHostWakeup.UseVisualStyleBackColor = true;
            this.btnNewHostWakeup.Click += new System.EventHandler(this.btnNewHostWakeup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "MAC Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Host Name(Optinal):";
            // 
            // txtMacAddress
            // 
            this.txtMacAddress.AsciiOnly = true;
            this.txtMacAddress.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtMacAddress.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtMacAddress.Location = new System.Drawing.Point(161, 14);
            this.txtMacAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtMacAddress.Mask = "AA:AA:AA:AA:AA:AA";
            this.txtMacAddress.Name = "txtMacAddress";
            this.txtMacAddress.Size = new System.Drawing.Size(169, 28);
            this.txtMacAddress.TabIndex = 0;
            this.txtMacAddress.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // hostList
            // 
            this.hostList.FormattingEnabled = true;
            this.hostList.Location = new System.Drawing.Point(6, 23);
            this.hostList.Name = "hostList";
            this.hostList.Size = new System.Drawing.Size(347, 156);
            this.hostList.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtHostName);
            this.groupBox1.Controls.Add(this.txtMacAddress);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnNewHostWakeup);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Host";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSavedHostsWakeup);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.hostList);
            this.groupBox2.Location = new System.Drawing.Point(12, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saved Host";
            // 
            // btnSavedHostsWakeup
            // 
            this.btnSavedHostsWakeup.Location = new System.Drawing.Point(363, 127);
            this.btnSavedHostsWakeup.Name = "btnSavedHostsWakeup";
            this.btnSavedHostsWakeup.Size = new System.Drawing.Size(100, 23);
            this.btnSavedHostsWakeup.TabIndex = 1;
            this.btnSavedHostsWakeup.Text = "Wake up!";
            this.btnSavedHostsWakeup.UseVisualStyleBackColor = true;
            this.btnSavedHostsWakeup.Click += new System.EventHandler(this.btnSavedHostsWakeup_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(363, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 299);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Wake on LAN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNewHostWakeup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtMacAddress;
        private System.Windows.Forms.CheckedListBox hostList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSavedHostsWakeup;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.FontDialog fontDialog1;

    }
}

