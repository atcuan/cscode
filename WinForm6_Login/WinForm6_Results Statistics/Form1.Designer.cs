namespace WinForm6_Results_Statistics
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.count = new System.Windows.Forms.Button();
            this.txtcj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(32, 162);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(75, 23);
            this.count.TabIndex = 1;
            this.count.Text = "统计";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // txtcj
            // 
            this.txtcj.Location = new System.Drawing.Point(12, 40);
            this.txtcj.Multiline = true;
            this.txtcj.Name = "txtcj";
            this.txtcj.Size = new System.Drawing.Size(219, 107);
            this.txtcj.TabIndex = 0;
            this.txtcj.Text = "Alex=200\r\nTom=203\r\nJack=210";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 244);
            this.Controls.Add(this.count);
            this.Controls.Add(this.txtcj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button count;
        private System.Windows.Forms.TextBox txtcj;
    }
}

