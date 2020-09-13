using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MessageBox
{
    public partial class MsgOK : Form
    {
        public MsgOK()
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
        private void MsgOK_KeyDown(object sender, KeyEventArgs e)
        {
            btOK.Focus();
        }

        public  Image MessageIcon
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
