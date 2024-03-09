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
			this.rtbIPinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtbIPinput.Location = new System.Drawing.Point(9, 10);
			this.rtbIPinput.Margin = new System.Windows.Forms.Padding(2);
			this.rtbIPinput.Name = "rtbIPinput";
			this.rtbIPinput.Size = new System.Drawing.Size(283, 32);
			this.rtbIPinput.TabIndex = 0;
			this.rtbIPinput.Text = "";
			this.rtbIPinput.TextChanged += new System.EventHandler(this.rtbIPinput_TextChanged);
			// 
			// labelIpInfo
			// 
			this.labelIpInfo.AutoSize = true;
			this.labelIpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelIpInfo.Location = new System.Drawing.Point(11, 44);
			this.labelIpInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelIpInfo.Name = "labelIpInfo";
			this.labelIpInfo.Size = new System.Drawing.Size(0, 26);
			this.labelIpInfo.TabIndex = 1;
			// 
			// cbMask
			// 
			this.cbMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbMask.FormattingEnabled = true;
			this.cbMask.IntegralHeight = false;
			this.cbMask.Location = new System.Drawing.Point(296, 8);
			this.cbMask.Margin = new System.Windows.Forms.Padding(2);
			this.cbMask.Name = "cbMask";
			this.cbMask.Size = new System.Drawing.Size(69, 34);
			this.cbMask.TabIndex = 2;
			this.cbMask.SelectedIndexChanged += new System.EventHandler(this.cbMask_SelectedIndexChanged);
			// 
			// btnCalculate
			// 
			this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCalculate.Location = new System.Drawing.Point(370, 8);
			this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(72, 35);
			this.btnCalculate.TabIndex = 3;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 146);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.cbMask);
			this.Controls.Add(this.labelIpInfo);
			this.Controls.Add(this.rtbIPinput);
			this.Margin = new System.Windows.Forms.Padding(2);
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

