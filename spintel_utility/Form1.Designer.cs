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
            this.configureModem = new System.Windows.Forms.Button();
            this.voipButton = new System.Windows.Forms.Button();
            this.sipDomainText = new System.Windows.Forms.TextBox();
            this.sipUserText = new System.Windows.Forms.TextBox();
            this.sipProxyText = new System.Windows.Forms.TextBox();
            this.sipPasswordText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // configureModem
            // 
            this.configureModem.Location = new System.Drawing.Point(303, 131);
            this.configureModem.Name = "configureModem";
            this.configureModem.Size = new System.Drawing.Size(97, 82);
            this.configureModem.TabIndex = 0;
            this.configureModem.Text = "button1";
            this.configureModem.UseVisualStyleBackColor = true;
            this.configureModem.Click += new System.EventHandler(this.configureModem_Click);
            // 
            // voipButton
            // 
            this.voipButton.Location = new System.Drawing.Point(56, 236);
            this.voipButton.Name = "voipButton";
            this.voipButton.Size = new System.Drawing.Size(126, 52);
            this.voipButton.TabIndex = 1;
            this.voipButton.Text = "button1";
            this.voipButton.UseVisualStyleBackColor = true;
            this.voipButton.Click += new System.EventHandler(this.voipButton_Click);
            // 
            // sipDomainText
            // 
            this.sipDomainText.Location = new System.Drawing.Point(71, 39);
            this.sipDomainText.Name = "sipDomainText";
            this.sipDomainText.Size = new System.Drawing.Size(144, 20);
            this.sipDomainText.TabIndex = 2;
            this.sipDomainText.TextChanged += new System.EventHandler(this.sipDomainText_TextChanged);
            // 
            // sipUserText
            // 
            this.sipUserText.Location = new System.Drawing.Point(71, 110);
            this.sipUserText.Name = "sipUserText";
            this.sipUserText.Size = new System.Drawing.Size(144, 20);
            this.sipUserText.TabIndex = 3;
            this.sipUserText.TextChanged += new System.EventHandler(this.sipUserText_TextChanged);
            // 
            // sipProxyText
            // 
            this.sipProxyText.Location = new System.Drawing.Point(71, 74);
            this.sipProxyText.Name = "sipProxyText";
            this.sipProxyText.Size = new System.Drawing.Size(144, 20);
            this.sipProxyText.TabIndex = 4;
            this.sipProxyText.TextChanged += new System.EventHandler(this.sipProxyText_TextChanged);
            // 
            // sipPasswordText
            // 
            this.sipPasswordText.Location = new System.Drawing.Point(71, 146);
            this.sipPasswordText.Name = "sipPasswordText";
            this.sipPasswordText.Size = new System.Drawing.Size(144, 20);
            this.sipPasswordText.TabIndex = 5;
            this.sipPasswordText.TextChanged += new System.EventHandler(this.sipPasswordText_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 288);
            this.Controls.Add(this.sipPasswordText);
            this.Controls.Add(this.sipProxyText);
            this.Controls.Add(this.sipUserText);
            this.Controls.Add(this.sipDomainText);
            this.Controls.Add(this.voipButton);
            this.Controls.Add(this.configureModem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button configureModem;
        private System.Windows.Forms.Button voipButton;
        private System.Windows.Forms.TextBox sipDomainText;
        private System.Windows.Forms.TextBox sipUserText;
        private System.Windows.Forms.TextBox sipProxyText;
        private System.Windows.Forms.TextBox sipPasswordText;
    }
}

