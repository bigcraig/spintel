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
            this.wanIPText = new System.Windows.Forms.TextBox();
            this.secondaryDNSText = new System.Windows.Forms.TextBox();
            this.primaryDNSText = new System.Windows.Forms.TextBox();
            this.wanGatewayIPText = new System.Windows.Forms.TextBox();
            this.wanSubnetText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.staticIPoEButton = new System.Windows.Forms.Button();
            this.StaticIPoEEthernet = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
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
            this.sipUserText.Location = new System.Drawing.Point(163, 111);
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
            this.sipPasswordText.Location = new System.Drawing.Point(163, 147);
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
            this.label3.Location = new System.Drawing.Point(63, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Username /Number";
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.SystemColors.Control;
            this.Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.Color.Red;
            this.Status.Location = new System.Drawing.Point(217, 375);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(555, 19);
            this.Status.TabIndex = 10;
            this.Status.TextChanged += new System.EventHandler(this.Status_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Username /Number";
            // 
            // sipPassword2Text
            // 
            this.sipPassword2Text.Location = new System.Drawing.Point(163, 251);
            this.sipPassword2Text.Name = "sipPassword2Text";
            this.sipPassword2Text.Size = new System.Drawing.Size(166, 20);
            this.sipPassword2Text.TabIndex = 12;
            this.sipPassword2Text.TextChanged += new System.EventHandler(this.sipPassword2Text_TextChanged);
            // 
            // sipUser2Text
            // 
            this.sipUser2Text.Location = new System.Drawing.Point(163, 215);
            this.sipUser2Text.Name = "sipUser2Text";
            this.sipUser2Text.Size = new System.Drawing.Size(166, 20);
            this.sipUser2Text.TabIndex = 11;
            this.sipUser2Text.TextChanged += new System.EventHandler(this.sipUser2Text_TextChanged);
            // 
            // eraseLine2
            // 
            this.eraseLine2.Location = new System.Drawing.Point(199, 288);
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
            this.label7.Location = new System.Drawing.Point(137, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Line 2";
            // 
            // wanIPText
            // 
            this.wanIPText.Location = new System.Drawing.Point(591, 21);
            this.wanIPText.Name = "wanIPText";
            this.wanIPText.Size = new System.Drawing.Size(166, 20);
            this.wanIPText.TabIndex = 17;
            this.wanIPText.TextChanged += new System.EventHandler(this.wanIPText_TextChanged);
            // 
            // secondaryDNSText
            // 
            this.secondaryDNSText.Location = new System.Drawing.Point(591, 168);
            this.secondaryDNSText.Name = "secondaryDNSText";
            this.secondaryDNSText.Size = new System.Drawing.Size(166, 20);
            this.secondaryDNSText.TabIndex = 18;
            // 
            // primaryDNSText
            // 
            this.primaryDNSText.Location = new System.Drawing.Point(591, 130);
            this.primaryDNSText.Name = "primaryDNSText";
            this.primaryDNSText.Size = new System.Drawing.Size(166, 20);
            this.primaryDNSText.TabIndex = 19;
            // 
            // wanGatewayIPText
            // 
            this.wanGatewayIPText.Location = new System.Drawing.Point(591, 92);
            this.wanGatewayIPText.Name = "wanGatewayIPText";
            this.wanGatewayIPText.Size = new System.Drawing.Size(166, 20);
            this.wanGatewayIPText.TabIndex = 20;
            this.wanGatewayIPText.TextChanged += new System.EventHandler(this.wanGatewayIPText_TextChanged);
            // 
            // wanSubnetText
            // 
            this.wanSubnetText.Location = new System.Drawing.Point(591, 59);
            this.wanSubnetText.Name = "wanSubnetText";
            this.wanSubnetText.Size = new System.Drawing.Size(166, 20);
            this.wanSubnetText.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Secondary DNS Server";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(419, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Primary DNS Server";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(419, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Wan gateway IP address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(424, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Wan Subnet Mask";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(419, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "WAN IP address";
            // 
            // staticIPoEButton
            // 
            this.staticIPoEButton.Location = new System.Drawing.Point(422, 251);
            this.staticIPoEButton.Name = "staticIPoEButton";
            this.staticIPoEButton.Size = new System.Drawing.Size(174, 70);
            this.staticIPoEButton.TabIndex = 27;
            this.staticIPoEButton.Text = "Configure Static IP VDSL";
            this.staticIPoEButton.UseVisualStyleBackColor = true;
            this.staticIPoEButton.Click += new System.EventHandler(this.staticIPoEButton_Click);
            // 
            // StaticIPoEEthernet
            // 
            this.StaticIPoEEthernet.Location = new System.Drawing.Point(616, 251);
            this.StaticIPoEEthernet.Name = "StaticIPoEEthernet";
            this.StaticIPoEEthernet.Size = new System.Drawing.Size(174, 70);
            this.StaticIPoEEthernet.TabIndex = 28;
            this.StaticIPoEEthernet.Text = "Configure Static IP Ethernet";
            this.StaticIPoEEthernet.UseVisualStyleBackColor = true;
            this.StaticIPoEEthernet.Click += new System.EventHandler(this.StaticIPoEEthernet_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(137, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "Line 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 456);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.StaticIPoEEthernet);
            this.Controls.Add(this.staticIPoEButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.wanSubnetText);
            this.Controls.Add(this.wanGatewayIPText);
            this.Controls.Add(this.primaryDNSText);
            this.Controls.Add(this.secondaryDNSText);
            this.Controls.Add(this.wanIPText);
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
        private System.Windows.Forms.TextBox wanIPText;
        private System.Windows.Forms.TextBox secondaryDNSText;
        private System.Windows.Forms.TextBox primaryDNSText;
        private System.Windows.Forms.TextBox wanGatewayIPText;
        private System.Windows.Forms.TextBox wanSubnetText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button staticIPoEButton;
        private System.Windows.Forms.Button StaticIPoEEthernet;
        private System.Windows.Forms.Label label13;
    }
}

