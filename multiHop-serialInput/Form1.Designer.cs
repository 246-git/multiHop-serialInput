namespace sample_0007
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナ変数です。
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

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpSetting = new System.Windows.Forms.GroupBox();
            this.cmbHandShake = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.grpSend = new System.Windows.Forms.GroupBox();
            this.sndTextBox = new System.Windows.Forms.TextBox();
            this.sndButton = new System.Windows.Forms.Button();
            this.grpRecv = new System.Windows.Forms.GroupBox();
            this.rcvTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.grpSetting.SuspendLayout();
            this.grpSend.SuspendLayout();
            this.grpRecv.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSetting
            // 
            this.grpSetting.Controls.Add(this.cmbHandShake);
            this.grpSetting.Controls.Add(this.cmbBaudRate);
            this.grpSetting.Controls.Add(this.cmbPortName);
            this.grpSetting.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.grpSetting.Location = new System.Drawing.Point(8, 16);
            this.grpSetting.Name = "grpSetting";
            this.grpSetting.Size = new System.Drawing.Size(466, 50);
            this.grpSetting.TabIndex = 0;
            this.grpSetting.TabStop = false;
            this.grpSetting.Text = "シリアルポート設定";
            // 
            // cmbHandShake
            // 
            this.cmbHandShake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHandShake.FormattingEnabled = true;
            this.cmbHandShake.Location = new System.Drawing.Point(272, 22);
            this.cmbHandShake.Name = "cmbHandShake";
            this.cmbHandShake.Size = new System.Drawing.Size(176, 24);
            this.cmbHandShake.TabIndex = 2;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(140, 22);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(112, 24);
            this.cmbBaudRate.TabIndex = 1;
            // 
            // cmbPortName
            // 
            this.cmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(26, 22);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(96, 24);
            this.cmbPortName.TabIndex = 0;
            // 
            // grpSend
            // 
            this.grpSend.Controls.Add(this.sndTextBox);
            this.grpSend.Controls.Add(this.sndButton);
            this.grpSend.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.grpSend.Location = new System.Drawing.Point(8, 72);
            this.grpSend.Name = "grpSend";
            this.grpSend.Size = new System.Drawing.Size(592, 87);
            this.grpSend.TabIndex = 1;
            this.grpSend.TabStop = false;
            this.grpSend.Text = "送信データ";
            // 
            // sndTextBox
            // 
            this.sndTextBox.Location = new System.Drawing.Point(10, 22);
            this.sndTextBox.Multiline = true;
            this.sndTextBox.Name = "sndTextBox";
            this.sndTextBox.Size = new System.Drawing.Size(576, 36);
            this.sndTextBox.TabIndex = 1;
            // 
            // sndButton
            // 
            this.sndButton.Location = new System.Drawing.Point(472, 58);
            this.sndButton.Name = "sndButton";
            this.sndButton.Size = new System.Drawing.Size(112, 24);
            this.sndButton.TabIndex = 0;
            this.sndButton.Text = "送信";
            this.sndButton.UseVisualStyleBackColor = true;
            this.sndButton.Click += new System.EventHandler(this.sndButton_Click);
            // 
            // grpRecv
            // 
            this.grpRecv.Controls.Add(this.rcvTextBox);
            this.grpRecv.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.grpRecv.Location = new System.Drawing.Point(8, 165);
            this.grpRecv.Name = "grpRecv";
            this.grpRecv.Size = new System.Drawing.Size(592, 283);
            this.grpRecv.TabIndex = 2;
            this.grpRecv.TabStop = false;
            this.grpRecv.Text = "受信データ";
            // 
            // rcvTextBox
            // 
            this.rcvTextBox.Location = new System.Drawing.Point(10, 24);
            this.rcvTextBox.Multiline = true;
            this.rcvTextBox.Name = "rcvTextBox";
            this.rcvTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rcvTextBox.Size = new System.Drawing.Size(576, 259);
            this.rcvTextBox.TabIndex = 0;
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.connectButton.Location = new System.Drawing.Point(480, 34);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(112, 24);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "接続";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.exitButton.Location = new System.Drawing.Point(480, 456);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 24);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "終了";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AcceptButton = this.sndButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 488);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.grpRecv);
            this.Controls.Add(this.grpSend);
            this.Controls.Add(this.grpSetting);
            this.Name = "Form1";
            this.Text = "シリアル通信プログラム";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSetting.ResumeLayout(false);
            this.grpSend.ResumeLayout(false);
            this.grpSend.PerformLayout();
            this.grpRecv.ResumeLayout(false);
            this.grpRecv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSetting;
        private System.Windows.Forms.ComboBox cmbHandShake;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.GroupBox grpSend;
        private System.Windows.Forms.TextBox sndTextBox;
        private System.Windows.Forms.Button sndButton;
        private System.Windows.Forms.GroupBox grpRecv;
        private System.Windows.Forms.TextBox rcvTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button exitButton;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

