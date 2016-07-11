namespace spintel_utility
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
            this.voipButton = new System.Windows.Forms.Button();
            this.sipDomainText = new System.Windows.Forms.TextBox();
            this.sipUserText = new System.Windows.Forms.TextBox();
            this.sipProxyText = new System.Windows.Forms.TextBox();
            this.sipPasswordText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sipPassword2Text = new System.Windows.Forms.TextBox();
            this.sipUser2Text = new System.Windows.Forms.TextBox();
            this.eraseLine2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // voipButton
            // 
            this.voipButton.Location = new System.Drawing.Point(5, 351);
            this.voipButton.Name = "voipButton";
            this.voipButton.Size = new System.Drawing.Size(154, 71);
            this.voipButton.TabIndex = 1;
            this.voipButton.Text = "Configure VOIP";
            this.voipButton.UseVisualStyleBackColor = true;
            this.voipButton.Click += new System.EventHandler(this.voipButton_Click);
            // 
            // sipDomainText
            // 
            this.sipDomainText.Location = new System.Drawing.Point(163, 23);
            this.sipDomainText.Name = "sipDomainText";
            this.sipDomainText.Size = new System.Drawing.Size(166, 20);
            this.sipDomainText.TabIndex = 2;
            this.sipDomainText.TextChanged += new System.EventHandler(this.sipDomainText_TextChanged);
            // 
            // sipUserText
            // 
            this.sipUserText.Location = new System.Drawing.Point(163, 94);
            this.sipUserText.Name = "sipUserText";
            this.sipUserText.Size = new System.Drawing.Size(166, 20);
            this.sipUserText.TabIndex = 3;
            this.sipUserText.TextChanged += new System.EventHandler(this.sipUserText_TextChanged);
            // 
            // sipProxyText
            // 
            this.sipProxyText.Location = new System.Drawing.Point(163, 58);
            this.sipProxyText.Name = "sipProxyText";
            this.sipProxyText.Size = new System.Drawing.Size(166, 20);
            this.sipProxyText.TabIndex = 4;
            this.sipProxyText.TextChanged += new System.EventHandler(this.sipProxyText_TextChanged);
            // 
            // sipPasswordText
            // 
            this.sipPasswordText.Location = new System.Drawing.Point(163, 130);
            this.sipPasswordText.Name = "sipPasswordText";
            this.sipPasswordText.Size = new System.Drawing.Size(166, 20);
            this.sipPasswordText.TabIndex = 5;
            this.sipPasswordText.TextChanged += new System.EventHandler(this.sipPasswordText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "SipDomain";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sip Proxy (if different)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Username /Number";
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.SystemColors.Control;
            this.Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.Color.Red;
            this.Status.Location = new System.Drawing.Point(188, 380);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(194, 13);
            this.Status.TabIndex = 10;
            this.Status.TextChanged += new System.EventHandler(this.Status_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Username /Number";
            // 
            // sipPassword2Text
            // 
            this.sipPassword2Text.Location = new System.Drawing.Point(163, 234);
            this.sipPassword2Text.Name = "sipPassword2Text";
            this.sipPassword2Text.Size = new System.Drawing.Size(166, 20);
            this.sipPassword2Text.TabIndex = 12;
            this.sipPassword2Text.TextChanged += new System.EventHandler(this.sipPassword2Text_TextChanged);
            // 
            // sipUser2Text
            // 
            this.sipUser2Text.Location = new System.Drawing.Point(163, 198);
            this.sipUser2Text.Name = "sipUser2Text";
            this.sipUser2Text.Size = new System.Drawing.Size(166, 20);
            this.sipUser2Text.TabIndex = 11;
            this.sipUser2Text.TextChanged += new System.EventHandler(this.sipUser2Text_TextChanged);
            // 
            // eraseLine2
            // 
            this.eraseLine2.Location = new System.Drawing.Point(187, 277);
            this.eraseLine2.Name = "eraseLine2";
            this.eraseLine2.Size = new System.Drawing.Size(130, 44);
            this.eraseLine2.TabIndex = 15;
            this.eraseLine2.Text = "Clear Line 2";
            this.eraseLine2.UseVisualStyleBackColor = true;
            this.eraseLine2.Click += new System.EventHandler(this.eraseLine2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(137, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Line 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 456);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.eraseLine2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sipPassword2Text);
            this.Controls.Add(this.sipUser2Text);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sipPasswordText);
            this.Controls.Add(this.sipProxyText);
            this.Controls.Add(this.sipUserText);
            this.Controls.Add(this.sipDomainText);
            this.Controls.Add(this.voipButton);
            this.Name = "Form1";
            this.Text = "Ram VOIP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button voipButton;
        private System.Windows.Forms.TextBox sipDomainText;
        private System.Windows.Forms.TextBox sipUserText;
        private System.Windows.Forms.TextBox sipProxyText;
        private System.Windows.Forms.TextBox sipPasswordText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sipPassword2Text;
        private System.Windows.Forms.TextBox sipUser2Text;
        private System.Windows.Forms.Button eraseLine2;
        private System.Windows.Forms.Label label7;
    }
}

