namespace TcpClientGui
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxMessage = new TextBox();
            buttonSend = new Button();
            labelResponse = new Label();
            buttonConnect = new Button();
            buttonDisconnect = new Button();
            textBoxIp = new TextBox();
            textBoxPort = new TextBox();
            labelIp = new Label();
            labelPort = new Label();
            textBoxHistory = new TextBox();
            buttonSendFile = new Button();
            labelStatus = new Label();
            statusIndicator = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)statusIndicator).BeginInit();
            SuspendLayout();
            // 
            // textBoxMessage
            // 
            textBoxMessage.Location = new Point(16, 138);
            textBoxMessage.Margin = new Padding(4, 5, 4, 5);
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(345, 27);
            textBoxMessage.TabIndex = 0;
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(295, 189);
            buttonSend.Margin = new Padding(4, 5, 4, 5);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(100, 35);
            buttonSend.TabIndex = 1;
            buttonSend.Text = "Отправить";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // labelResponse
            // 
            labelResponse.AutoSize = true;
            labelResponse.Location = new Point(50, 234);
            labelResponse.Margin = new Padding(4, 0, 4, 0);
            labelResponse.Name = "labelResponse";
            labelResponse.Size = new Size(55, 20);
            labelResponse.TabIndex = 2;
            labelResponse.Text = "Ответ: ";
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(16, 18);
            buttonConnect.Margin = new Padding(4, 5, 4, 5);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(109, 35);
            buttonConnect.TabIndex = 3;
            buttonConnect.Text = "Подключить";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // buttonDisconnect
            // 
            buttonDisconnect.Location = new Point(295, 18);
            buttonDisconnect.Margin = new Padding(4, 5, 4, 5);
            buttonDisconnect.Name = "buttonDisconnect";
            buttonDisconnect.Size = new Size(100, 35);
            buttonDisconnect.TabIndex = 4;
            buttonDisconnect.Text = "Отключить";
            buttonDisconnect.UseVisualStyleBackColor = true;
            buttonDisconnect.Click += buttonDisconnect_Click;
            // 
            // textBoxIp
            // 
            textBoxIp.Location = new Point(69, 65);
            textBoxIp.Margin = new Padding(4, 5, 4, 5);
            textBoxIp.Name = "textBoxIp";
            textBoxIp.Size = new Size(132, 27);
            textBoxIp.TabIndex = 5;
            textBoxIp.Text = "127.0.0.1";
            // 
            // textBoxPort
            // 
            textBoxPort.Location = new Point(69, 105);
            textBoxPort.Margin = new Padding(4, 5, 4, 5);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(132, 27);
            textBoxPort.TabIndex = 6;
            textBoxPort.Text = "8888";
            // 
            // labelIp
            // 
            labelIp.AutoSize = true;
            labelIp.Location = new Point(16, 69);
            labelIp.Margin = new Padding(4, 0, 4, 0);
            labelIp.Name = "labelIp";
            labelIp.Size = new Size(21, 20);
            labelIp.TabIndex = 7;
            labelIp.Text = "IP";
            // 
            // labelPort
            // 
            labelPort.AutoSize = true;
            labelPort.Location = new Point(16, 109);
            labelPort.Margin = new Padding(4, 0, 4, 0);
            labelPort.Name = "labelPort";
            labelPort.Size = new Size(44, 20);
            labelPort.TabIndex = 8;
            labelPort.Text = "Порт";
            // 
            // textBoxHistory
            // 
            textBoxHistory.Location = new Point(50, 319);
            textBoxHistory.Margin = new Padding(4, 5, 4, 5);
            textBoxHistory.Multiline = true;
            textBoxHistory.Name = "textBoxHistory";
            textBoxHistory.ScrollBars = ScrollBars.Vertical;
            textBoxHistory.Size = new Size(345, 152);
            textBoxHistory.TabIndex = 9;
            // 
            // buttonSendFile
            // 
            buttonSendFile.Location = new Point(295, 234);
            buttonSendFile.Margin = new Padding(4, 5, 4, 5);
            buttonSendFile.Name = "buttonSendFile";
            buttonSendFile.Size = new Size(100, 65);
            buttonSendFile.TabIndex = 10;
            buttonSendFile.Text = "Отправить файл";
            buttonSendFile.UseVisualStyleBackColor = true;
            buttonSendFile.Click += buttonSendFile_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(133, 25);
            labelStatus.Margin = new Padding(4, 0, 4, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(52, 20);
            labelStatus.TabIndex = 11;
            labelStatus.Text = "Статус";
            // 
            // statusIndicator
            // 
            statusIndicator.BackColor = Color.Red;
            statusIndicator.Location = new Point(260, 22);
            statusIndicator.Margin = new Padding(4, 5, 4, 5);
            statusIndicator.Name = "statusIndicator";
            statusIndicator.Size = new Size(27, 31);
            statusIndicator.TabIndex = 12;
            statusIndicator.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 590);
            Controls.Add(statusIndicator);
            Controls.Add(labelStatus);
            Controls.Add(buttonSendFile);
            Controls.Add(textBoxHistory);
            Controls.Add(labelPort);
            Controls.Add(labelIp);
            Controls.Add(textBoxPort);
            Controls.Add(textBoxIp);
            Controls.Add(buttonDisconnect);
            Controls.Add(buttonConnect);
            Controls.Add(labelResponse);
            Controls.Add(buttonSend);
            Controls.Add(textBoxMessage);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Tcp Client";
            ((System.ComponentModel.ISupportInitialize)statusIndicator).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelResponse;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxHistory;
        private System.Windows.Forms.Button buttonSendFile;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.PictureBox statusIndicator;
    }
}
