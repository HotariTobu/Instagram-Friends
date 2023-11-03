using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Instagram_Friends
{
    partial class MainForm
    {
        private void OpenSubMenu_Click(object sender, EventArgs e)
        {
            if (edited)
            {
                switch (MessageBox.Show("編集内容を破棄しますか？", "開く前の確認", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2))
                {
                    case DialogResult.No:
                        SaveSubMenu_Click(null, null);
                        break;

                    case DialogResult.Cancel:
                        return;
                }
            }

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Open(OpenFileDialog.FileName);
            }
        }

        private void NewSubMenu_Click(object sender, EventArgs e)
        {
            if (edited)
            {
                switch (MessageBox.Show("編集内容を破棄しますか？", "新規作成する前の確認", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2))
                {
                    case DialogResult.No:
                        SaveSubMenu_Click(null, null);
                        break;

                    case DialogResult.Cancel:
                        return;
                }
            }

            RootPanel.Controls.Clear();
            TextMenu.Text = "無題";

            file = null;
            edited = false;
            selectionIndex = -1;
        }

        private void SaveSubMenu_Click(object sender, EventArgs e)
        {
            if (edited)
            {
                if (file == null)
                {
                    SaveAsSubMenu_Click(sender, e);
                }
                else
                {
                    Save();
                }
            }
        }

        private void SaveAsSubMenu_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                file = SaveFileDialog.FileName;

                Save();
            }
        }

        private void QuitSubMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddSubMenu_Click(object sender, EventArgs e)
        {
            AddItem();
            RootPanel.Refresh();

            edited = true;
        }

        private void DelSubMenu_Click(object sender, EventArgs e)
        {
            if (CheckSelection())
            {
                RootPanel.Controls[selectionIndex].Dispose();
                RootPanel.Refresh();

                edited = true;
            }
        }

        private void EditSubMenu_Click(object sender, EventArgs e)
        {
            if (CheckSelection())
            {
                ((FriendItem)RootPanel.Controls[selectionIndex]).ReadOnly = EditSubMenu.Checked;
                EditSubMenu.Checked = !EditSubMenu.Checked;
            }
        }

        private void PrevSubMenu_Click(object sender, EventArgs e)
        {
            if (selectionIndex > -1)
            {
                selectionIndex--;
            }
        }

        private void NextSubMenu_Click(object sender, EventArgs e)
        {
            if (selectionIndex < RootPanel.Controls.Count)
            {
                selectionIndex++;
            }
        }

        private void ReadmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("Readme.txt"))
            {
                using (var process = new Process())
                {
                    process.StartInfo = new ProcessStartInfo
                    {
                        FileName = "Readme.txt",
                    };
                    process.Start();
                }
            }
        }

        private void VersionSubMenu_Click(object sender, EventArgs e)
        {
            aboutBox.ShowDialog();
        }
    }
}
