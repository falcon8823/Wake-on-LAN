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
            this.btnNewHostWakeup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMacAddress = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBroadcast = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewHostWakeup
            // 
            this.btnNewHostWakeup.Location = new System.Drawing.Point(336, 52);
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
            this.label1.Location = new System.Drawing.Point(54, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "MAC Address:";
            // 
            // txtMacAddress
            // 
            this.txtMacAddress.AsciiOnly = true;
            this.txtMacAddress.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtMacAddress.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtMacAddress.Location = new System.Drawing.Point(159, 14);
            this.txtMacAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtMacAddress.Mask = "AA:AA:AA:AA:AA:AA";
            this.txtMacAddress.Name = "txtMacAddress";
            this.txtMacAddress.Size = new System.Drawing.Size(169, 28);
            this.txtMacAddress.TabIndex = 0;
            this.txtMacAddress.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBroadcast);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMacAddress);
            this.groupBox1.Controls.Add(this.btnNewHostWakeup);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Host";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Broadcast\r\n(ex.192.168.0.255):";
            // 
            // txtBroadcast
            // 
            this.txtBroadcast.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBroadcast.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtBroadcast.Location = new System.Drawing.Point(159, 50);
            this.txtBroadcast.Margin = new System.Windows.Forms.Padding(4);
            this.txtBroadcast.Name = "txtBroadcast";
            this.txtBroadcast.Size = new System.Drawing.Size(169, 28);
            this.txtBroadcast.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 112);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Wake on LAN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewHostWakeup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtMacAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox txtBroadcast;
        private System.Windows.Forms.Label label3;

    }
}

