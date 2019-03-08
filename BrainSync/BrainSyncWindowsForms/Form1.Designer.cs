namespace BrainSyncWindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.showNameSpace = new System.Windows.Forms.Label();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showNameSpace
            // 
            this.showNameSpace.AutoSize = true;
            this.showNameSpace.Location = new System.Drawing.Point(12, 9);
            this.showNameSpace.Name = "showNameSpace";
            this.showNameSpace.Size = new System.Drawing.Size(83, 12);
            this.showNameSpace.TabIndex = 0;
            this.showNameSpace.Text = "Space Details";
            this.showNameSpace.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.Location = new System.Drawing.Point(14, 24);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.Size = new System.Drawing.Size(491, 418);
            this.textBoxDetails.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 454);
            this.Controls.Add(this.textBoxDetails);
            this.Controls.Add(this.showNameSpace);
            this.Name = "Form1";
            this.Text = "BrainSync";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label showNameSpace;
        private System.Windows.Forms.TextBox textBoxDetails;
    }
}

