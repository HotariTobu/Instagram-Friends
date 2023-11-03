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
    partial class MainForm
    {
        private string file;
        private bool __edited;
        private bool edited
        {
            get
            {
                return __edited;
            }

            set
            {
                if (value)
                {
                    if (!TextMenu.Text.StartsWith("*"))
                    {
                        TextMenu.Text = TextMenu.Text.Insert(0, "*");
                    }

                    SaveSubMenu.Enabled = true;

                    __edited = true;
                }
                else
                {
                    if (TextMenu.Text.StartsWith("*"))
                    {
                        TextMenu.Text = TextMenu.Text.Substring(1);
                    }

                    SaveSubMenu.Enabled = false;

                    __edited = false;
                }
            }
        }

        private int __selectionIndex;
        private int selectionIndex
        {
            get
            {
                return __selectionIndex;
            }

            set
            {
                if (__selectionIndex != value)
                {
                    __selectionIndex = value;

                    if (__selectionIndex < -1 || __selectionIndex > RootPanel.Controls.Count)
                    {
                        __selectionIndex = -1;
                    }

                    if (CheckSelection())
                    {
                        Control control = RootPanel.Controls[__selectionIndex];
                        Rectangle RootPanelRectangle = RootPanel.ClientRectangle;
                        Rectangle itemRectangle = new Rectangle(control.Location, control.Size);

                        if (!RootPanelRectangle.Contains(itemRectangle))
                        {
                            RootPanel.VerticalScroll.Value += itemRectangle.Y - itemBorderThickness;
                        }

                        control.Focus();

                        RootPanel.Refresh();

                        EditSubMenu.Checked = !((FriendItem)control).ReadOnly;

                        DelSubMenu.Enabled = true;
                        EditSubMenu.Enabled = true;
                    }
                    else
                    {
                        DelSubMenu.Enabled = false;
                        EditSubMenu.Enabled = false;
                    }

                    if (__selectionIndex == -1)
                    {
                        PrevSubMenu.Enabled = false;
                    }
                    else
                    {
                        PrevSubMenu.Enabled = true;
                    }

                    if (__selectionIndex == RootPanel.Controls.Count)
                    {
                        NextSubMenu.Enabled = false;
                    }
                    else
                    {
                        NextSubMenu.Enabled = true;
                    }
                }
            }
        }
        private bool CheckSelection()
        {
            return selectionIndex < RootPanel.Controls.Count && selectionIndex > -1;
        }

        private AboutBox aboutBox = new AboutBox();

        private int dragIndex = -1;
        private DragForm dragForm = new DragForm();

        private int itemBorderThickness = 2;
        private int shadowParallax = 20;
    }
}
