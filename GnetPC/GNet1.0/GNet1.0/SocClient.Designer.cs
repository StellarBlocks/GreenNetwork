namespace GNet1._0
{
    partial class SocClient
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
            this.components = new System.ComponentModel.Container();
            this.服务器设置 = new System.Windows.Forms.GroupBox();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.txtServerIp = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tmrGetMess = new System.Windows.Forms.Timer(this.components);
            this.rtxChatInfo = new System.Windows.Forms.RichTextBox();
            this.rtxSendMessage = new System.Windows.Forms.RichTextBox();
            this.服务器设置.SuspendLayout();
            this.SuspendLayout();
            // 
            // 服务器设置
            // 
            this.服务器设置.Controls.Add(this.txtServerPort);
            this.服务器设置.Controls.Add(this.txtServerIp);
            this.服务器设置.Location = new System.Drawing.Point(12, 2);
            this.服务器设置.Name = "服务器设置";
            this.服务器设置.Size = new System.Drawing.Size(560, 83);
            this.服务器设置.TabIndex = 0;
            this.服务器设置.TabStop = false;
            this.服务器设置.Text = "服务器设置";
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(259, 35);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(100, 25);
            this.txtServerPort.TabIndex = 1;
            this.txtServerPort.TextChanged += new System.EventHandler(this.txtServerPort_TextChanged);
            // 
            // txtServerIp
            // 
            this.txtServerIp.Location = new System.Drawing.Point(68, 35);
            this.txtServerIp.Name = "txtServerIp";
            this.txtServerIp.Size = new System.Drawing.Size(100, 25);
            this.txtServerIp.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(80, 387);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "button1";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(207, 387);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "button2";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(332, 387);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "button3";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // tmrGetMess
            // 
            this.tmrGetMess.Tick += new System.EventHandler(this.tmrGetMess_Tick);
            // 
            // rtxChatInfo
            // 
            this.rtxChatInfo.Location = new System.Drawing.Point(12, 93);
            this.rtxChatInfo.Name = "rtxChatInfo";
            this.rtxChatInfo.ReadOnly = true;
            this.rtxChatInfo.Size = new System.Drawing.Size(560, 96);
            this.rtxChatInfo.TabIndex = 4;
            this.rtxChatInfo.Text = "";
            // 
            // rtxSendMessage
            // 
            this.rtxSendMessage.Location = new System.Drawing.Point(16, 208);
            this.rtxSendMessage.Name = "rtxSendMessage";
            this.rtxSendMessage.Size = new System.Drawing.Size(556, 96);
            this.rtxSendMessage.TabIndex = 5;
            this.rtxSendMessage.Text = "";
            this.rtxSendMessage.TextChanged += new System.EventHandler(this.rtxSendMessage_TextChanged);
            // 
            // SocClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 443);
            this.Controls.Add(this.rtxSendMessage);
            this.Controls.Add(this.rtxChatInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.服务器设置);
            this.Name = "SocClient";
            this.Text = "SocClient";
            this.服务器设置.ResumeLayout(false);
            this.服务器设置.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox 服务器设置;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.TextBox txtServerIp;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer tmrGetMess;
        private System.Windows.Forms.RichTextBox rtxChatInfo;
        private System.Windows.Forms.RichTextBox rtxSendMessage;
    }
}