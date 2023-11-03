using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instagram_Friends
{
    public partial class DragForm : Form
    {
        public DragForm()
        {
            InitializeComponent();
        }

        public void SetImage(Image image)
        {
            box.Image = image;
        }
    }
}
