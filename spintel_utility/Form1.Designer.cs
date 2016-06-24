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
            this.SuspendLayout();
            // 
            // configureModem
            // 
            this.configureModem.Location = new System.Drawing.Point(71, 109);
            this.configureModem.Name = "configureModem";
            this.configureModem.Size = new System.Drawing.Size(282, 123);
            this.configureModem.TabIndex = 0;
            this.configureModem.Text = "button1";
            this.configureModem.UseVisualStyleBackColor = true;
            this.configureModem.Click += new System.EventHandler(this.configureModem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 288);
            this.Controls.Add(this.configureModem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button configureModem;
    }
}

