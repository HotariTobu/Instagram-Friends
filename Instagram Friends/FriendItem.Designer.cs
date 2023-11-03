namespace Instagram_Friends
{
    partial class FriendItem
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.FamilyNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AccountNameBox = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.ClassBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClubBox = new System.Windows.Forms.TextBox();
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.RemarksBox = new System.Windows.Forms.TextBox();
            this.ImagesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.IconPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.IconPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FamilyNameBox
            // 
            this.FamilyNameBox.Location = new System.Drawing.Point(84, 3);
            this.FamilyNameBox.Name = "FamilyNameBox";
            this.FamilyNameBox.Size = new System.Drawing.Size(72, 19);
            this.FamilyNameBox.TabIndex = 0;
            this.FamilyNameBox.TextChanged += new System.EventHandler(this.Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "氏名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "ユーザーネーム";
            // 
            // UserNameBox
            // 
            this.UserNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNameBox.Location = new System.Drawing.Point(84, 28);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(150, 19);
            this.UserNameBox.TabIndex = 2;
            this.UserNameBox.TextChanged += new System.EventHandler(this.Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "名前";
            // 
            // AccountNameBox
            // 
            this.AccountNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountNameBox.Location = new System.Drawing.Point(84, 53);
            this.AccountNameBox.Name = "AccountNameBox";
            this.AccountNameBox.Size = new System.Drawing.Size(150, 19);
            this.AccountNameBox.TabIndex = 3;
            this.AccountNameBox.TextChanged += new System.EventHandler(this.Changed);
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(162, 3);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(72, 19);
            this.FirstNameBox.TabIndex = 1;
            this.FirstNameBox.TextChanged += new System.EventHandler(this.Changed);
            // 
            // ClassBox
            // 
            this.ClassBox.Location = new System.Drawing.Point(39, 78);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(39, 19);
            this.ClassBox.TabIndex = 4;
            this.ClassBox.TextChanged += new System.EventHandler(this.Changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(3, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "クラス";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(106, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "部活";
            // 
            // ClubBox
            // 
            this.ClubBox.Location = new System.Drawing.Point(142, 78);
            this.ClubBox.Name = "ClubBox";
            this.ClubBox.Size = new System.Drawing.Size(92, 19);
            this.ClubBox.TabIndex = 5;
            this.ClubBox.TextChanged += new System.EventHandler(this.Changed);
            // 
            // IconBox
            // 
            this.IconBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IconBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IconBox.Location = new System.Drawing.Point(0, 0);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(64, 64);
            this.IconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconBox.TabIndex = 11;
            this.IconBox.TabStop = false;
            this.IconBox.Click += new System.EventHandler(this.IconBox_Click);
            this.IconBox.DoubleClick += new System.EventHandler(this.IconBox_DoubleClick);
            // 
            // RemarksBox
            // 
            this.RemarksBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemarksBox.Location = new System.Drawing.Point(5, 103);
            this.RemarksBox.Multiline = true;
            this.RemarksBox.Name = "RemarksBox";
            this.RemarksBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RemarksBox.Size = new System.Drawing.Size(299, 59);
            this.RemarksBox.TabIndex = 6;
            this.RemarksBox.TextChanged += new System.EventHandler(this.Changed);
            // 
            // ImagesPanel
            // 
            this.ImagesPanel.AllowDrop = true;
            this.ImagesPanel.AutoScroll = true;
            this.ImagesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ImagesPanel.Location = new System.Drawing.Point(0, 168);
            this.ImagesPanel.Name = "ImagesPanel";
            this.ImagesPanel.Size = new System.Drawing.Size(307, 80);
            this.ImagesPanel.TabIndex = 13;
            this.ImagesPanel.WrapContents = false;
            this.ImagesPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.ImagesPanel_DragDrop);
            this.ImagesPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.ImagesPanel_DragEnter);
            this.ImagesPanel.DoubleClick += new System.EventHandler(this.ImagesPanel_DoubleClick);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "|*.bmp||*.gif||*.jpeg, *.jpg, *.jpe, *.jfif, *.jfi, *.jif||*png||*.tiff, *.tif||*" +
    ".ico||*.wmf, *.wmz||*.emf, *.emz||*.*";
            // 
            // IconPanel
            // 
            this.IconPanel.AllowDrop = true;
            this.IconPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconPanel.Controls.Add(this.IconBox);
            this.IconPanel.Location = new System.Drawing.Point(240, 3);
            this.IconPanel.Name = "IconPanel";
            this.IconPanel.Size = new System.Drawing.Size(64, 64);
            this.IconPanel.TabIndex = 14;
            this.IconPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.IconBox_DragDrop);
            this.IconPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.IconBox_DragEnter);
            // 
            // FriendItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IconPanel);
            this.Controls.Add(this.ImagesPanel);
            this.Controls.Add(this.RemarksBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClubBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClassBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AccountNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FamilyNameBox);
            this.Margin = new System.Windows.Forms.Padding(16);
            this.MinimumSize = new System.Drawing.Size(307, 220);
            this.Name = "FriendItem";
            this.Size = new System.Drawing.Size(307, 248);
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.IconPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FamilyNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AccountNameBox;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox ClassBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ClubBox;
        private System.Windows.Forms.PictureBox IconBox;
        private System.Windows.Forms.TextBox RemarksBox;
        private System.Windows.Forms.FlowLayoutPanel ImagesPanel;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Panel IconPanel;
    }
}
