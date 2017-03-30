namespace GNet1._0
{
    partial class SocServer
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
            this.rtxChatInfo = new System.Windows.Forms.RichTextBox();
            this.rtxSendMessage = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBeginServer = new System.Windows.Forms.Button();
            this.tmrGetMess = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // rtxChatInfo
            // 
            this.rtxChatInfo.Location = new System.Drawing.Point(12, 93);
            this.rtxChatInfo.Name = "rtxChatInfo";
            this.rtxChatInfo.ReadOnly = true;
            this.rtxChatInfo.Size = new System.Drawing.Size(674, 206);
            this.rtxChatInfo.TabIndex = 0;
            this.rtxChatInfo.Text = "";
            // 
            // rtxSendMessage
            // 
            this.rtxSendMessage.Location = new System.Drawing.Point(12, 317);
            this.rtxSendMessage.Name = "rtxSendMessage";
            this.rtxSendMessage.Size = new System.Drawing.Size(674, 96);
            this.rtxSendMessage.TabIndex = 1;
            this.rtxSendMessage.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(467, 450);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(569, 450);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnBeginServer
            // 
            this.btnBeginServer.Location = new System.Drawing.Point(104, 38);
            this.btnBeginServer.Name = "btnBeginServer";
            this.btnBeginServer.Size = new System.Drawing.Size(102, 23);
            this.btnBeginServer.TabIndex = 4;
            this.btnBeginServer.Text = "启动服务器";
            this.btnBeginServer.UseVisualStyleBackColor = true;
            this.btnBeginServer.Click += new System.EventHandler(this.btnBeginServer_Click);
            // 
            // tmrGetMess
            // 
            this.tmrGetMess.Enabled = true;
            // 
            // SocServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 485);
            this.Controls.Add(this.btnBeginServer);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtxSendMessage);
            this.Controls.Add(this.rtxChatInfo);
            this.Name = "SocServer";
            this.Text = "服务器端";
            this.Load += new System.EventHandler(this.SocServer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxChatInfo;
        private System.Windows.Forms.RichTextBox rtxSendMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBeginServer;
        private System.Windows.Forms.Timer tmrGetMess;
    }
}