namespace WinForm6_Update
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPdOld = new System.Windows.Forms.TextBox();
            this.txtPdNew = new System.Windows.Forms.TextBox();
            this.txtConfirmPd = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm";
            // 
            // txtPdOld
            // 
            this.txtPdOld.Location = new System.Drawing.Point(95, 33);
            this.txtPdOld.Name = "txtPdOld";
            this.txtPdOld.PasswordChar = '*';
            this.txtPdOld.Size = new System.Drawing.Size(100, 21);
            this.txtPdOld.TabIndex = 3;
            // 
            // txtPdNew
            // 
            this.txtPdNew.Location = new System.Drawing.Point(95, 68);
            this.txtPdNew.Name = "txtPdNew";
            this.txtPdNew.PasswordChar = '*';
            this.txtPdNew.Size = new System.Drawing.Size(100, 21);
            this.txtPdNew.TabIndex = 4;
            // 
            // txtConfirmPd
            // 
            this.txtConfirmPd.Location = new System.Drawing.Point(95, 99);
            this.txtConfirmPd.Name = "txtConfirmPd";
            this.txtConfirmPd.PasswordChar = '*';
            this.txtConfirmPd.Size = new System.Drawing.Size(100, 21);
            this.txtConfirmPd.TabIndex = 5;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(95, 141);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 6;
            this.update.Text = "修 改";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 267);
            this.Controls.Add(this.update);
            this.Controls.Add(this.txtConfirmPd);
            this.Controls.Add(this.txtPdNew);
            this.Controls.Add(this.txtPdOld);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPdOld;
        private System.Windows.Forms.TextBox txtPdNew;
        private System.Windows.Forms.TextBox txtConfirmPd;
        private System.Windows.Forms.Button update;
    }
}

