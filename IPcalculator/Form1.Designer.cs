namespace IPcalculator
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
            this.rtbIPinput = new System.Windows.Forms.RichTextBox();
            this.labelIpInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbIPinput
            // 
            this.rtbIPinput.Location = new System.Drawing.Point(12, 12);
            this.rtbIPinput.Name = "rtbIPinput";
            this.rtbIPinput.Size = new System.Drawing.Size(411, 38);
            this.rtbIPinput.TabIndex = 0;
            this.rtbIPinput.Text = "";
            // 
            // labelIpInfo
            // 
            this.labelIpInfo.AutoSize = true;
            this.labelIpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIpInfo.Location = new System.Drawing.Point(12, 53);
            this.labelIpInfo.Name = "labelIpInfo";
            this.labelIpInfo.Size = new System.Drawing.Size(92, 32);
            this.labelIpInfo.TabIndex = 1;
            this.labelIpInfo.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.labelIpInfo);
            this.Controls.Add(this.rtbIPinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbIPinput;
        private System.Windows.Forms.Label labelIpInfo;
    }
}

