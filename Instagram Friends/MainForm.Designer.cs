namespace Instagram_Friends
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RootPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.SearchTextBoxSubMenu = new System.Windows.Forms.ToolStripTextBox();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TextMenu = new System.Windows.Forms.ToolStripTextBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.QuitSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DelSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PrevSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NextSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchResultSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ReadmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VersionSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // RootPanel
            // 
            this.RootPanel.AllowDrop = true;
            this.RootPanel.AutoScroll = true;
            this.RootPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RootPanel.Location = new System.Drawing.Point(0, 27);
            this.RootPanel.Name = "RootPanel";
            this.RootPanel.Padding = new System.Windows.Forms.Padding(8);
            this.RootPanel.Size = new System.Drawing.Size(800, 423);
            this.RootPanel.TabIndex = 0;
            this.RootPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.RootPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.RootPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RootPanel_Paint);
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.ItemMenu,
            this.HelpMenu,
            this.TextMenu});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(800, 27);
            this.MenuBar.TabIndex = 1;
            this.MenuBar.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenSubMenu,
            this.NewSubMenu,
            this.SaveSubMenu,
            this.SaveAsSubMenu,
            this.toolStripMenuItem1,
            this.QuitSubMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(67, 23);
            this.FileMenu.Text = "ファイル(&F)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // ItemMenu
            // 
            this.ItemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSubMenu,
            this.DelSubMenu,
            this.EditSubMenu,
            this.toolStripMenuItem2,
            this.PrevSubMenu,
            this.NextSubMenu,
            this.toolStripMenuItem3,
            this.SearchTextBoxSubMenu,
            this.SearchResultSubMenu});
            this.ItemMenu.Name = "ItemMenu";
            this.ItemMenu.Size = new System.Drawing.Size(66, 23);
            this.ItemMenu.Text = "アイテム(&I)";
            // 
            // EditSubMenu
            // 
            this.EditSubMenu.Checked = true;
            this.EditSubMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EditSubMenu.Image = global::Instagram_Friends.Properties.Resources.Edit;
            this.EditSubMenu.Name = "EditSubMenu";
            this.EditSubMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.EditSubMenu.Size = new System.Drawing.Size(190, 22);
            this.EditSubMenu.Text = "編集(E)";
            this.EditSubMenu.ToolTipText = "選択されたアイテムが編集化可能かどうかです。";
            this.EditSubMenu.Click += new System.EventHandler(this.EditSubMenu_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(187, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(187, 6);
            // 
            // SearchTextBoxSubMenu
            // 
            this.SearchTextBoxSubMenu.Name = "SearchTextBoxSubMenu";
            this.SearchTextBoxSubMenu.Size = new System.Drawing.Size(130, 23);
            this.SearchTextBoxSubMenu.ToolTipText = "Shift + Enterで入力された文字列を含むアイテムのインデックスを「検索結果」に表示します。";
            this.SearchTextBoxSubMenu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchTextBoxSubMenu_KeyUp);
            this.SearchTextBoxSubMenu.Click += new System.EventHandler(this.SearchTextBoxSubMenu_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReadmeToolStripMenuItem,
            this.VersionSubMenu});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(65, 23);
            this.HelpMenu.Text = "ヘルプ(&H)";
            // 
            // TextMenu
            // 
            this.TextMenu.Enabled = false;
            this.TextMenu.Name = "TextMenu";
            this.TextMenu.Size = new System.Drawing.Size(100, 23);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "|*xml";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "|*.xml";
            // 
            // OpenSubMenu
            // 
            this.OpenSubMenu.Image = global::Instagram_Friends.Properties.Resources.Open;
            this.OpenSubMenu.Name = "OpenSubMenu";
            this.OpenSubMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenSubMenu.Size = new System.Drawing.Size(181, 22);
            this.OpenSubMenu.Text = "開く(&O)...";
            this.OpenSubMenu.ToolTipText = "xmlファイルを開きます。";
            this.OpenSubMenu.Click += new System.EventHandler(this.OpenSubMenu_Click);
            // 
            // NewSubMenu
            // 
            this.NewSubMenu.Image = global::Instagram_Friends.Properties.Resources.New;
            this.NewSubMenu.Name = "NewSubMenu";
            this.NewSubMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewSubMenu.Size = new System.Drawing.Size(181, 22);
            this.NewSubMenu.Text = "新規作成(&N)";
            this.NewSubMenu.ToolTipText = "xmlファイルを新規作成します。";
            this.NewSubMenu.Click += new System.EventHandler(this.NewSubMenu_Click);
            // 
            // SaveSubMenu
            // 
            this.SaveSubMenu.Image = global::Instagram_Friends.Properties.Resources.Save;
            this.SaveSubMenu.Name = "SaveSubMenu";
            this.SaveSubMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveSubMenu.Size = new System.Drawing.Size(181, 22);
            this.SaveSubMenu.Text = "保存(&S)";
            this.SaveSubMenu.ToolTipText = "xmlファイルを保存します。";
            this.SaveSubMenu.Click += new System.EventHandler(this.SaveSubMenu_Click);
            // 
            // SaveAsSubMenu
            // 
            this.SaveAsSubMenu.Image = ((System.Drawing.Image)(resources.GetObject("SaveAsSubMenu.Image")));
            this.SaveAsSubMenu.Name = "SaveAsSubMenu";
            this.SaveAsSubMenu.Size = new System.Drawing.Size(181, 22);
            this.SaveAsSubMenu.Text = "別名保存...";
            this.SaveAsSubMenu.ToolTipText = "xmlファイルを別名保存します。";
            this.SaveAsSubMenu.Click += new System.EventHandler(this.SaveAsSubMenu_Click);
            // 
            // QuitSubMenu
            // 
            this.QuitSubMenu.Image = global::Instagram_Friends.Properties.Resources.Quit;
            this.QuitSubMenu.Name = "QuitSubMenu";
            this.QuitSubMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.QuitSubMenu.Size = new System.Drawing.Size(181, 22);
            this.QuitSubMenu.Text = "終了(&Q)";
            this.QuitSubMenu.ToolTipText = "アプリケーションを終了します。";
            this.QuitSubMenu.Click += new System.EventHandler(this.QuitSubMenu_Click);
            // 
            // AddSubMenu
            // 
            this.AddSubMenu.Image = global::Instagram_Friends.Properties.Resources.Add;
            this.AddSubMenu.Name = "AddSubMenu";
            this.AddSubMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert)));
            this.AddSubMenu.Size = new System.Drawing.Size(190, 22);
            this.AddSubMenu.Text = "追加(&A)";
            this.AddSubMenu.ToolTipText = "アイテムを追加します。";
            this.AddSubMenu.Click += new System.EventHandler(this.AddSubMenu_Click);
            // 
            // DelSubMenu
            // 
            this.DelSubMenu.Image = global::Instagram_Friends.Properties.Resources.Delete;
            this.DelSubMenu.Name = "DelSubMenu";
            this.DelSubMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.DelSubMenu.Size = new System.Drawing.Size(190, 22);
            this.DelSubMenu.Text = "削除(&D)";
            this.DelSubMenu.ToolTipText = "選択されたアイテムを削除します。";
            this.DelSubMenu.Click += new System.EventHandler(this.DelSubMenu_Click);
            // 
            // PrevSubMenu
            // 
            this.PrevSubMenu.Image = global::Instagram_Friends.Properties.Resources.Prev;
            this.PrevSubMenu.Name = "PrevSubMenu";
            this.PrevSubMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.PrevSubMenu.Size = new System.Drawing.Size(190, 22);
            this.PrevSubMenu.Text = "1つ前(&P)";
            this.PrevSubMenu.ToolTipText = "選択されたアイテムの1つ前のアイテムを選択します。";
            this.PrevSubMenu.Click += new System.EventHandler(this.PrevSubMenu_Click);
            // 
            // NextSubMenu
            // 
            this.NextSubMenu.Image = global::Instagram_Friends.Properties.Resources.Next;
            this.NextSubMenu.Name = "NextSubMenu";
            this.NextSubMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.NextSubMenu.Size = new System.Drawing.Size(190, 22);
            this.NextSubMenu.Text = "1つ後(&N)";
            this.NextSubMenu.ToolTipText = "選択されたアイテムの1つ後のアイテムを選択します。";
            this.NextSubMenu.Click += new System.EventHandler(this.NextSubMenu_Click);
            // 
            // SearchResultSubMenu
            // 
            this.SearchResultSubMenu.Image = global::Instagram_Friends.Properties.Resources.Search;
            this.SearchResultSubMenu.Name = "SearchResultSubMenu";
            this.SearchResultSubMenu.Size = new System.Drawing.Size(190, 22);
            this.SearchResultSubMenu.Text = "検索結果(&S)";
            this.SearchResultSubMenu.ToolTipText = "検索結果が表示されます。";
            // 
            // ReadmeToolStripMenuItem
            // 
            this.ReadmeToolStripMenuItem.Image = global::Instagram_Friends.Properties.Resources.Readme;
            this.ReadmeToolStripMenuItem.Name = "ReadmeToolStripMenuItem";
            this.ReadmeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ReadmeToolStripMenuItem.Text = "Readme.txt(&R)";
            this.ReadmeToolStripMenuItem.ToolTipText = "Readme.txtを開きます。";
            this.ReadmeToolStripMenuItem.Click += new System.EventHandler(this.ReadmeToolStripMenuItem_Click);
            // 
            // VersionSubMenu
            // 
            this.VersionSubMenu.Image = global::Instagram_Friends.Properties.Resources.Version;
            this.VersionSubMenu.Name = "VersionSubMenu";
            this.VersionSubMenu.Size = new System.Drawing.Size(148, 22);
            this.VersionSubMenu.Text = "バージョン(&V)...";
            this.VersionSubMenu.ToolTipText = "バージョン情報などを表示します。";
            this.VersionSubMenu.Click += new System.EventHandler(this.VersionSubMenu_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RootPanel);
            this.Controls.Add(this.MenuBar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuBar;
            this.Name = "MainForm";
            this.Text = "Instagram Friends";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel RootPanel;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenSubMenu;
        private System.Windows.Forms.ToolStripMenuItem NewSubMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveAsSubMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveSubMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem QuitSubMenu;
        private System.Windows.Forms.ToolStripMenuItem ItemMenu;
        private System.Windows.Forms.ToolStripMenuItem AddSubMenu;
        private System.Windows.Forms.ToolStripMenuItem DelSubMenu;
        private System.Windows.Forms.ToolStripMenuItem EditSubMenu;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem VersionSubMenu;
        private System.Windows.Forms.ToolStripTextBox TextMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem PrevSubMenu;
        private System.Windows.Forms.ToolStripMenuItem NextSubMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem SearchResultSubMenu;
        private System.Windows.Forms.ToolStripTextBox SearchTextBoxSubMenu;
        private System.Windows.Forms.ToolStripMenuItem ReadmeToolStripMenuItem;
    }
}

