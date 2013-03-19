namespace EmailDemo
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
            this.textBox_from = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_To = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Body = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "发件人：";
            // 
            // textBox_from
            // 
            this.textBox_from.Location = new System.Drawing.Point(63, 9);
            this.textBox_from.Name = "textBox_from";
            this.textBox_from.Size = new System.Drawing.Size(162, 21);
            this.textBox_from.TabIndex = 1;
            this.textBox_from.Text = "ec_hdaq@ecidi.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "收件人：";
            // 
            // textBox_To
            // 
            this.textBox_To.Location = new System.Drawing.Point(63, 36);
            this.textBox_To.Name = "textBox_To";
            this.textBox_To.Size = new System.Drawing.Size(162, 21);
            this.textBox_To.TabIndex = 1;
            this.textBox_To.Text = "lin_bb@ecidi.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "主题：";
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(63, 63);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(162, 21);
            this.textBox_Title.TabIndex = 1;
            this.textBox_Title.Text = "测试邮件接收！";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "正文：";
            // 
            // textBox_Body
            // 
            this.textBox_Body.Location = new System.Drawing.Point(63, 90);
            this.textBox_Body.MaxLength = 140;
            this.textBox_Body.Multiline = true;
            this.textBox_Body.Name = "textBox_Body";
            this.textBox_Body.Size = new System.Drawing.Size(162, 99);
            this.textBox_Body.TabIndex = 1;
            this.textBox_Body.Text = "邮件发送测试，请勿回复！";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(234, 11);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(53, 23);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "发送";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 259);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.textBox_Body);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_To);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_from);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "邮件发送测试";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_To;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Body;
        private System.Windows.Forms.Button button_ok;
    }
}

