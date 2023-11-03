using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Instagram_Friends
{
    public partial class FriendItem : UserControl
    {
        public FriendItem()
        {
            InitializeComponent();

            ImagePaths = new List<string>();

            int length = ImagesPanel.Height - HScrollBarHeight - 6;
            ImageBoxSize = new Size(length, length);
        }

        public event EventHandler Edited;
        public bool ReadOnly {
            get
            {
                return __ReadOnly;
            }

            set
            {
                __ReadOnly = value;

                FamilyNameBox.ReadOnly = __ReadOnly;
                FirstNameBox.ReadOnly = __ReadOnly;
                UserNameBox.ReadOnly = __ReadOnly;
                AccountNameBox.ReadOnly = __ReadOnly;
                ClassBox.ReadOnly = __ReadOnly;
                ClubBox.ReadOnly = __ReadOnly;
                RemarksBox.ReadOnly = __ReadOnly;
            }
        }

        public string FamilyName { get => FamilyNameBox.Text; set => FamilyNameBox.Text = value; }
        public string FirstName { get => FirstNameBox.Text; set => FirstNameBox.Text = value; }
        public string UserName { get => UserNameBox.Text; set => UserNameBox.Text = value; }
        public string AccountName { get => AccountNameBox.Text; set => AccountNameBox.Text = value; }
        public string Class { get => ClassBox.Text; set => ClassBox.Text = value; }
        public string Club { get => ClubBox.Text; set => ClubBox.Text = value; }
        public string Remarks { get => RemarksBox.Text; set => RemarksBox.Text = value; }

        private string IconPath;
        private List<string> ImagePaths;

        private Size ImageBoxSize;

        private bool __ReadOnly;

        static FriendItem()
        {
            HScrollBarHeight = new HScrollBar().Height;
        }

        private static int HScrollBarHeight;

        /// <summary>
        /// パスから画像を読み込み適用させる。
        /// </summary>
        /// <param name="IconPath">アイコンのパス</param>
        /// <param name="ImagePaths">追加画像のパス</param>
        public void Apply(string IconPath, string ImagePaths)
        {
            if (File.Exists(IconPath))
            {
                SetIcon(IconPath);
            }
            
            foreach (string ImagePath in ImagePaths.Split(','))
            {
                if (File.Exists(ImagePath))
                {
                    AddImage(ImagePath);
                }
            }
        }

        /// <summary>
        /// アイコンのパスを取得する。
        /// </summary>
        /// <returns>アイコンのパス</returns>
        public string GetIconPath()
        {
            return IconPath;
        }

        /// <summary>
        /// 追加画像のパスを取得する。
        /// </summary>
        /// <returns>追加画像のパス</returns>
        public string GetImagePaths()
        {
            int count = ImagePaths.Count;
            if (count == 0)
            {
                return "";
            }
            else
            {
                string result = ImagePaths[0];

                for (int i = 1; i < count; i++)
                {
                    result += "," + ImagePaths[i];
                }

                return result;
            }
        }

        public override string ToString()
        {
            string result = "";

            result += FamilyName + ',';
            result += FirstName + ',';
            result += UserName + ',';
            result += AccountName + ',';
            result += Class + ',';
            result += Club + ',';
            result += Remarks.Replace("\r\n", "") + ',';

            return result;
        }

        private void Changed(object sender, EventArgs e)
        {
            Edited?.Invoke(sender, e);
        }

        private void IconBox_Click(object sender, EventArgs e)
        {
            if (IconPath != null)
            {
                using (var process = new Process())
                {
                    process.StartInfo = new ProcessStartInfo
                    {
                        FileName = IconPath
                    };
                    process.Start();
                }
            }
        }

        private void IconBox_DoubleClick(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                SetIcon(OpenFileDialog.FileName);
            }
        }

        private void IconBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Effect == DragDropEffects.Copy)
            {
                SetIcon(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
            }
        }

        private void IconBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                if (File.Exists(((string[])e.Data.GetData(DataFormats.FileDrop))[0]))
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

        /// <summary>
        /// アイコンを設定する。
        /// </summary>
        /// <param name="path">設定するアイコンのパス</param>
        private void SetIcon(string path)
        {
            if (ReadOnly)
            {
                return;
            }

            /*IconPath = path;

            IconBox.Image = Image.FromFile(IconPath);*/

            IconBox.ImageLocation = IconPath = path;

            Changed(null, null);
        }

        private void ImageBox_Click(object sender, EventArgs e)
        {
            int index = ImagesPanel.Controls.IndexOf(sender as PictureBox);
            if (index != -1)
            {
                using (var process = new Process())
                {
                    process.StartInfo = new ProcessStartInfo
                    {
                        FileName = ImagePaths[index]
                    };
                    process.Start();
                }
            }
        }

        private void ImagesPanel_DoubleClick(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                AddImage(OpenFileDialog.FileName);
            }
        }

        private void ImagesPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Effect == DragDropEffects.Copy)
            {
                foreach (string path in (string[])e.Data.GetData(DataFormats.FileDrop))
                {
                    if (File.Exists(path))
                    {
                        AddImage(path);
                    }
                }
            }
        }

        private void ImagesPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// 画像を追加する。
        /// </summary>
        /// <param name="path">追加する画像のパス</param>
        private void AddImage(string path)
        {
            if (ReadOnly)
            {
                return;
            }

            if (!ImagePaths.Contains(path))
            {
                ImagePaths.Add(path);

                PictureBox ImageBox = new PictureBox();
                ImagesPanel.Controls.Add(ImageBox);

                //ImageBox.Image = Image.FromFile(path);
                ImageBox.ImageLocation = path;
                ImageBox.Size = ImageBoxSize;
                ImageBox.SizeMode = PictureBoxSizeMode.Zoom;
                ImageBox.Click += ImageBox_Click;

                Changed(null, null);
            }
        }
    }
}
