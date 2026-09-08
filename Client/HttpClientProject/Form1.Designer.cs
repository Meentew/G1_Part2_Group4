namespace HttpClientApp
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
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.txtURI = new System.Windows.Forms.TextBox();
            this.Server_IP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoHttp = new System.Windows.Forms.RadioButton();
            this.rdoHttps = new System.Windows.Forms.RadioButton();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtResponseText = new System.Windows.Forms.TextBox();
            this.txtResponseHex = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.ResponseText = new System.Windows.Forms.Label();
            this.ResponseHex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(124, 32);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(316, 26);
            this.txtServerIP.TabIndex = 0;
            // 
            // txtURI
            // 
            this.txtURI.Location = new System.Drawing.Point(124, 70);
            this.txtURI.Name = "txtURI";
            this.txtURI.Size = new System.Drawing.Size(316, 26);
            this.txtURI.TabIndex = 1;
            // 
            // Server_IP
            // 
            this.Server_IP.AutoSize = true;
            this.Server_IP.Location = new System.Drawing.Point(44, 38);
            this.Server_IP.Name = "Server_IP";
            this.Server_IP.Size = new System.Drawing.Size(74, 20);
            this.Server_IP.TabIndex = 2;
            this.Server_IP.Text = "Server IP";
            this.Server_IP.Click += new System.EventHandler(this.Server_IP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "URI";
            // 
            // rdoHttp
            // 
            this.rdoHttp.AutoSize = true;
            this.rdoHttp.Location = new System.Drawing.Point(83, 131);
            this.rdoHttp.Name = "rdoHttp";
            this.rdoHttp.Size = new System.Drawing.Size(78, 24);
            this.rdoHttp.TabIndex = 4;
            this.rdoHttp.TabStop = true;
            this.rdoHttp.Text = " HTTP";
            this.rdoHttp.UseVisualStyleBackColor = true;
            // 
            // rdoHttps
            // 
            this.rdoHttps.AutoSize = true;
            this.rdoHttps.Location = new System.Drawing.Point(206, 131);
            this.rdoHttps.Name = "rdoHttps";
            this.rdoHttps.Size = new System.Drawing.Size(85, 24);
            this.rdoHttps.TabIndex = 5;
            this.rdoHttps.TabStop = true;
            this.rdoHttps.Text = "HTTPS";
            this.rdoHttps.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(324, 127);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(131, 32);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send Request";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtResponseText
            // 
            this.txtResponseText.Location = new System.Drawing.Point(139, 180);
            this.txtResponseText.Multiline = true;
            this.txtResponseText.Name = "txtResponseText";
            this.txtResponseText.Size = new System.Drawing.Size(433, 67);
            this.txtResponseText.TabIndex = 7;
            // 
            // txtResponseHex
            // 
            this.txtResponseHex.Location = new System.Drawing.Point(139, 253);
            this.txtResponseHex.Multiline = true;
            this.txtResponseHex.Name = "txtResponseHex";
            this.txtResponseHex.Size = new System.Drawing.Size(433, 67);
            this.txtResponseHex.TabIndex = 8;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(48, 353);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1021, 500);
            this.webBrowser1.TabIndex = 9;
            // 
            // ResponseText
            // 
            this.ResponseText.AutoSize = true;
            this.ResponseText.Location = new System.Drawing.Point(12, 206);
            this.ResponseText.Name = "ResponseText";
            this.ResponseText.Size = new System.Drawing.Size(112, 20);
            this.ResponseText.TabIndex = 10;
            this.ResponseText.Text = "ResponseText";
            this.ResponseText.Click += new System.EventHandler(this.ResponseText_Click);
            // 
            // ResponseHex
            // 
            this.ResponseHex.AutoSize = true;
            this.ResponseHex.Location = new System.Drawing.Point(14, 278);
            this.ResponseHex.Name = "ResponseHex";
            this.ResponseHex.Size = new System.Drawing.Size(110, 20);
            this.ResponseHex.TabIndex = 11;
            this.ResponseHex.Text = "ResponseHex";
            this.ResponseHex.Click += new System.EventHandler(this.ResponseHex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 875);
            this.Controls.Add(this.ResponseHex);
            this.Controls.Add(this.ResponseText);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txtResponseHex);
            this.Controls.Add(this.txtResponseText);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rdoHttps);
            this.Controls.Add(this.rdoHttp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Server_IP);
            this.Controls.Add(this.txtURI);
            this.Controls.Add(this.txtServerIP);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.TextBox txtURI;
        private System.Windows.Forms.Label Server_IP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoHttp;
        private System.Windows.Forms.RadioButton rdoHttps;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtResponseText;
        private System.Windows.Forms.TextBox txtResponseHex;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label ResponseText;
        private System.Windows.Forms.Label ResponseHex;
    }
}

