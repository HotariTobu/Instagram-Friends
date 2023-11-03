using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Instagram_Friends
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FileStream stream = null;
            string file = null;

            if (File.Exists("option.txt"))
            {
                try
                {
                    stream = File.OpenRead("option.txt");

                    byte[] vs = new byte[stream.Length];
                    stream.Read(vs, 0, vs.Length);
                    file = Encoding.UTF8.GetString(vs);
                }
                catch (Exception ee)
                {
                    MessageBox.Show($"{ee.Message}\n{ee.StackTrace}", "例外");
                }
                finally
                {
                    stream?.Close();
                }
            }

            if (file != null && File.Exists(file))
            {
                Open(file);
            }
            else
            {
                NewSubMenu_Click(null, null);
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Effect == DragDropEffects.Copy)
            {
                Open(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
            }
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                if (((string[])e.Data.GetData(DataFormats.FileDrop))[0].EndsWith(".xml"))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (edited)
            {
                switch (MessageBox.Show("編集内容を破棄しますか？", "終了確認", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2))
                {
                    case DialogResult.No:
                        SaveSubMenu_Click(null, null);
                        break;

                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(file))
            {
                return;
            }

            FileStream stream = null;

            try
            {
                stream = File.OpenWrite("option.txt");

                byte[] vs = Encoding.UTF8.GetBytes(file);
                stream.Write(vs, 0, vs.Length);
            }
            catch (Exception ee)
            {
                MessageBox.Show($"{ee.Message}\n{ee.StackTrace}", "例外");
            }
            finally
            {
                stream?.Close();
            }
        }

        /// <summary>
        /// XMLファイルを読み込む。
        /// </summary>
        /// <param name="path">XMLファイルのパス</param>
        private void Open(string path)
        {
            XDocument document = XDocument.Load(path);

            RootPanel.Controls.Clear();
            TextMenu.Text = Path.GetFileName(path);

            foreach (XElement element in document.Root.Elements("User"))
            {
                FriendItem item = AddItem();

                item.FamilyName = element.Element("FamilyName").Value;
                item.FirstName = element.Element("FirstName").Value;
                item.UserName = element.Element("UserName").Value;
                item.AccountName = element.Element("AccountName").Value;
                item.Class = element.Element("Class").Value;
                item.Club = element.Element("Club").Value;
                item.Remarks = element.Element("Remarks").Value.Replace("\n", "\r\n");

                item.Apply(element.Element("IconPath").Value, element.Element("ImagePaths").Value);
                item.ReadOnly = true;
            }

            file = path;
            edited = false;
            selectionIndex = -1;
        }

        /// <summary>
        /// XMLファイルを保存する。
        /// </summary>
        private void Save()
        {
            XElement root = new XElement("Root");
            XDocument document = new XDocument(root);

            foreach (FriendItem item in RootPanel.Controls)
            {
                XElement element = new XElement("User");

                element.Add(new XElement("FamilyName", item.FamilyName));
                element.Add(new XElement("FirstName", item.FirstName));
                element.Add(new XElement("UserName", item.UserName));
                element.Add(new XElement("AccountName", item.AccountName));
                element.Add(new XElement("Class", item.Class));
                element.Add(new XElement("Club", item.Club));
                element.Add(new XElement("Remarks", item.Remarks));
                element.Add(new XElement("IconPath", item.GetIconPath()));
                element.Add(new XElement("ImagePaths", item.GetImagePaths()));

                root.Add(element);
            }

            document.Save(file);

            edited = false;
        }

        private void Changed(object sender, EventArgs e)
        {
            edited = true;
        }

        /// <summary>
        /// アイテムを追加する。
        /// </summary>
        /// <returns>追加されたアイテム</returns>
        private FriendItem AddItem()
        {
            int count = RootPanel.Controls.Count;

            FriendItem item = new FriendItem();
            RootPanel.Controls.Add(item);

            item.BackColor = Color.FromArgb(new Random().Next());
            item.Edited += Changed;
            item.MouseDown += RootPanel_MouseDown;
            item.MouseMove += RootPanel_MouseMove;
            item.MouseUp += RootPanel_MouseUp;

            selectionIndex = count;

            return item;
        }

        private void RootPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                selectionIndex = RootPanel.Controls.IndexOf(RootPanel.GetChildAtPoint(RootPanel.PointToClient(Cursor.Position)));
                if (CheckSelection())
                {
                    dragIndex = selectionIndex;
                }
                else
                {
                    dragIndex = -1;
                }
            }
            else
            {
                dragIndex = -1;
            }
        }

        private void RootPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragIndex != -1)
            {
                if (!((Control)sender).ClientRectangle.Contains(e.Location))
                {
                    Control dragItem = (Control)sender;
                    Size dragItemSize = dragItem.Size;
                    Bitmap dragBitmap = new Bitmap(dragItemSize.Width, dragItemSize.Height);
                    dragItem.DrawToBitmap(dragBitmap, new Rectangle(new Point(), dragItemSize));

                    if (dragIndex + 1 < RootPanel.Controls.Count)
                    {
                        RootPanel.Controls[dragIndex + 1].Focus();
                    }
                    else if (dragIndex - 1 > -1)
                    {
                        RootPanel.Controls[dragIndex - 1].Focus();
                    }

                    RootPanel.Controls.Remove(dragItem);
                    RootPanel.Refresh();

                    dragIndex = -1;
                    dragForm.Size = dragItemSize;
                    dragForm.SetImage(dragBitmap);
                    dragForm.Show();

                    this.Focus();
                }
            }
            else if (dragForm.Visible)
            {
                Point cursorPos = Cursor.Position;
                cursorPos.Offset(1, 1);
                dragForm.Location = cursorPos;
            }
        }

        private void RootPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (dragForm.Visible)
            {
                Control dragItem = (Control)sender;
                RootPanel.Controls.Add(dragItem);
                RootPanel.Controls.SetChildIndex(dragItem, RootPanel.Controls.IndexOf(RootPanel.GetChildAtPoint(RootPanel.PointToClient(Cursor.Position))));
                RootPanel.Refresh();

                dragForm.Hide();

                edited = true;

                dragItem.Focus();
            }

            dragIndex = -1;
        }

        private void RootPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen ap = new Pen(SystemColors.Highlight);
            Pen bp = new Pen(SystemColors.WindowFrame);

            ap.Width = itemBorderThickness;
            bp.Width = itemBorderThickness;

            Control.ControlCollection controls = RootPanel.Controls;

            for (int i = 0; i < controls.Count; i++)
            {
                Rectangle rectangle = controls[i].Bounds;

                rectangle.X += shadowParallax;
                rectangle.Y += shadowParallax;

                g.FillRectangle(SystemBrushes.ControlLight, rectangle);

                rectangle.X -= shadowParallax;
                rectangle.Y -= shadowParallax;

                rectangle.X -= itemBorderThickness / 2;
                rectangle.Y -= itemBorderThickness / 2;
                rectangle.Width += itemBorderThickness;
                rectangle.Height += itemBorderThickness;

                if (i == selectionIndex)
                {
                    g.DrawRectangle(ap, rectangle);
                }
                else
                {
                    g.DrawRectangle(bp, rectangle);
                }
            }

            g.Dispose();
        }

        private void SearchTextBoxSubMenu_Click(object sender, EventArgs e)
        {
            SearchTextBoxSubMenu.SelectAll();
        }

        private void SearchTextBoxSubMenu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Shift)
            {
                ToolStripItemCollection stripItemCollection = SearchResultSubMenu.DropDownItems;
                stripItemCollection.Clear();

                if (SearchTextBoxSubMenu.Text.Length != 0)
                {
                    Regex regex = new Regex(SearchTextBoxSubMenu.Text, RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    for (int i = 0; i < RootPanel.Controls.Count; i++)
                    {
                        string data = RootPanel.Controls[i].ToString();
                        if (regex.IsMatch(data))
                        {
                            string[] name = data.Split(',');
                            ToolStripMenuItem menuItem = new ToolStripMenuItem(name[0] + name[1]);
                            menuItem.Tag = i;
                            SearchResultSubMenu.DropDownItems.Add(menuItem);

                            menuItem.Click += (object _sender, EventArgs _e) =>
                            {
                                selectionIndex = (int)(((ToolStripMenuItem)_sender).Tag);
                            };
                        }
                    }
                }

                SearchResultSubMenu.Select();
            }
        }
    }
}
