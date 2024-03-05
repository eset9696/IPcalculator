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
            this.cbMask = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbIPinput
            // 
            this.rtbIPinput.Location = new System.Drawing.Point(12, 12);
            this.rtbIPinput.Name = "rtbIPinput";
            this.rtbIPinput.Size = new System.Drawing.Size(314, 39);
            this.rtbIPinput.TabIndex = 0;
            this.rtbIPinput.Text = "";
            // 
            // labelIpInfo
            // 
            this.labelIpInfo.AutoSize = true;
            this.labelIpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIpInfo.Location = new System.Drawing.Point(12, 54);
            this.labelIpInfo.Name = "labelIpInfo";
            this.labelIpInfo.Size = new System.Drawing.Size(92, 32);
            this.labelIpInfo.TabIndex = 1;
            this.labelIpInfo.Text = "label1";
            // 
            // cbMask
            // 
            this.cbMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbMask.FormattingEnabled = true;
            this.cbMask.IntegralHeight = false;
            this.cbMask.Location = new System.Drawing.Point(332, 12);
            this.cbMask.Name = "cbMask";
            this.cbMask.Size = new System.Drawing.Size(91, 39);
            this.cbMask.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(348, 415);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cbMask);
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
        private System.Windows.Forms.ComboBox cbMask;
        private System.Windows.Forms.Button btnCalculate;
    }
}

