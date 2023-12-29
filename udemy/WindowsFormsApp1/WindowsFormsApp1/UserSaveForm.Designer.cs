namespace WindowsFormsApp1
{
    partial class UserSaveForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.MailCheckBox1 = new System.Windows.Forms.CheckBox();
            this.MailAddressTextBox = new System.Windows.Forms.TextBox();
            this.MailAddressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(56, 45);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(16, 12);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(78, 38);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 19);
            this.IDTextBox.TabIndex = 1;
            // 
            // MailCheckBox1
            // 
            this.MailCheckBox1.AutoSize = true;
            this.MailCheckBox1.Location = new System.Drawing.Point(58, 98);
            this.MailCheckBox1.Name = "MailCheckBox1";
            this.MailCheckBox1.Size = new System.Drawing.Size(104, 16);
            this.MailCheckBox1.TabIndex = 2;
            this.MailCheckBox1.Text = "メールを送信する";
            this.MailCheckBox1.UseVisualStyleBackColor = true;
            this.MailCheckBox1.CheckedChanged += new System.EventHandler(this.MailCheckBox1_CheckedChanged);
            // 
            // MailAddressTextBox
            // 
            this.MailAddressTextBox.Location = new System.Drawing.Point(133, 140);
            this.MailAddressTextBox.Name = "MailAddressTextBox";
            this.MailAddressTextBox.Size = new System.Drawing.Size(100, 19);
            this.MailAddressTextBox.TabIndex = 4;
            // 
            // MailAddressLabel
            // 
            this.MailAddressLabel.AutoSize = true;
            this.MailAddressLabel.Location = new System.Drawing.Point(56, 143);
            this.MailAddressLabel.Name = "MailAddressLabel";
            this.MailAddressLabel.Size = new System.Drawing.Size(69, 12);
            this.MailAddressLabel.TabIndex = 3;
            this.MailAddressLabel.Text = "メールアドレス";
            // 
            // UserSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MailAddressTextBox);
            this.Controls.Add(this.MailAddressLabel);
            this.Controls.Add(this.MailCheckBox1);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.IDLabel);
            this.Name = "UserSaveForm";
            this.Text = "ユーザー登録";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.CheckBox MailCheckBox1;
        private System.Windows.Forms.TextBox MailAddressTextBox;
        private System.Windows.Forms.Label MailAddressLabel;
    }
}

