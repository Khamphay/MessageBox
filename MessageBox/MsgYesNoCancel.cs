using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyMessageBox
{
    public partial class MsgYesNoCancel: Form
    {
        public MsgYesNoCancel()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MsgYesNo_KeyDown(object sender, KeyEventArgs e)
        {
            btCancel.Focus();
        }

        private void btYes_KeyDown(object sender, KeyEventArgs e)
        {
            btNo.Focus();
        }

        private void btNo_MouseDown(object sender, MouseEventArgs e)
        {
            btYes.Focus();
        }

        private void btCancel_MouseDown(object sender, MouseEventArgs e)
        {
            btYes.Focus();
        }


        public Image MessageIcon
        {
            get { return picIcon.Image; }
            set { picIcon.Image = value; }
        }

        public string Message
        {
            get { return lbMessage.Text; }
            set { lbMessage.Text = value; }
        }

        public string Caption
        {
            get { return lbCaption.Text; }
            set { lbCaption.Text = value; }
        }

        public void setFont(string font, int size)
        {
            lbMessage.Font = new Font(font, size);
        }



        bool mouse = false;
        int mouX = 0, mouY = 0;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            mouX = e.X;
            mouY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouX, MousePosition.Y - mouY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }
    }
}
