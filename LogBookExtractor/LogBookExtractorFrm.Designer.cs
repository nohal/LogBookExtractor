namespace LogBookExtractor
{
    partial class LogBookExtractorFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogBookExtractorFrm));
            this.btnGo = new System.Windows.Forms.Button();
            this.tbInputLog = new System.Windows.Forms.TextBox();
            this.btnBrowseLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseGpx = new System.Windows.Forms.Button();
            this.tbOutputGpx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(205, 100);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbInputLog
            // 
            this.tbInputLog.Location = new System.Drawing.Point(12, 25);
            this.tbInputLog.Name = "tbInputLog";
            this.tbInputLog.Size = new System.Drawing.Size(187, 20);
            this.tbInputLog.TabIndex = 1;
            // 
            // btnBrowseLog
            // 
            this.btnBrowseLog.Location = new System.Drawing.Point(205, 25);
            this.btnBrowseLog.Name = "btnBrowseLog";
            this.btnBrowseLog.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseLog.TabIndex = 2;
            this.btnBrowseLog.Text = "...";
            this.btnBrowseLog.UseVisualStyleBackColor = true;
            this.btnBrowseLog.Click += new System.EventHandler(this.btnBrowseLog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "OpenCPN Logfile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "GPX Output";
            // 
            // btnBrowseGpx
            // 
            this.btnBrowseGpx.Location = new System.Drawing.Point(205, 64);
            this.btnBrowseGpx.Name = "btnBrowseGpx";
            this.btnBrowseGpx.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseGpx.TabIndex = 5;
            this.btnBrowseGpx.Text = "...";
            this.btnBrowseGpx.UseVisualStyleBackColor = true;
            this.btnBrowseGpx.Click += new System.EventHandler(this.btnBrowseGpx_Click);
            // 
            // tbOutputGpx
            // 
            this.tbOutputGpx.Location = new System.Drawing.Point(12, 64);
            this.tbOutputGpx.Name = "tbOutputGpx";
            this.tbOutputGpx.Size = new System.Drawing.Size(187, 20);
            this.tbOutputGpx.TabIndex = 4;
            // 
            // LogBookExtractorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 135);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseGpx);
            this.Controls.Add(this.tbOutputGpx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowseLog);
            this.Controls.Add(this.tbInputLog);
            this.Controls.Add(this.btnGo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogBookExtractorFrm";
            this.Text = "LogBookExtractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox tbInputLog;
        private System.Windows.Forms.Button btnBrowseLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowseGpx;
        private System.Windows.Forms.TextBox tbOutputGpx;
    }
}

