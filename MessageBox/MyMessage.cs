using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyMessageBox
{
    public static class MyMessage
    {

        //Message
        public static DialogResult Show(string message)
        {
            using (MsgOK msgOk = new MsgOK())
            {
                msgOk.Message = message;
                return msgOk.ShowDialog();
            }
        }

        ///Message, caption
        public static DialogResult Show(string message, string caption)
        {
            using (MsgOK msgOk = new MsgOK())
            {
                msgOk.Caption = caption;
                msgOk.Message = message;
                return msgOk.ShowDialog();
            }
        }

        //Message, button
        public static DialogResult Show(string message, MessageBoxButtons button)
        {
            DialogResult result = DialogResult.None;
            switch (button)
            {
                case MessageBoxButtons.OK:
                    using (MsgOK msgOk = new MsgOK())
                    {
                        msgOk.Message = message;
                        return msgOk.ShowDialog();
                    }
                    break;

                case MessageBoxButtons.YesNo:
                    using (MsgYesNo msgYesNo = new MsgYesNo())
                    {
                        msgYesNo.Message = message;
                        return msgYesNo.ShowDialog();
                    }
                    break;

                case MessageBoxButtons.YesNoCancel:
                    using (MsgYesNoCancel msgYesNoCancel = new MsgYesNoCancel())
                    {
                        msgYesNoCancel.Message = message;
                        return msgYesNoCancel.ShowDialog();
                    }
                    break;
            }
            return result;
        }

        //Message, icon
        public static DialogResult Show(string message, MessageBoxIcon icon)
        {
            using (MsgOK msgOk = new MsgOK())
            {
                msgOk.Message = message;
                switch (icon)
                {
                    case MessageBoxIcon.Information:
                        msgOk.MessageIcon = Properties.Resources.ok;
                        break;
                    case MessageBoxIcon.Warning:
                        msgOk.MessageIcon = Properties.Resources.warning;
                        break;
                    case MessageBoxIcon.Error:
                        msgOk.MessageIcon = Properties.Resources.errer;
                        break;
                    case MessageBoxIcon.Question:
                        msgOk.MessageIcon = Properties.Resources.que;
                        break;
                }
                return msgOk.ShowDialog();
            }
        }

        //Message, icon, button
        public static DialogResult Show(string message, MessageBoxButtons button, MessageBoxIcon icon)
        {
            DialogResult result = DialogResult.None;
            switch (button)
            {
                case MessageBoxButtons.OK:
                    using (MsgOK msgOk = new MsgOK())
                    {
                        msgOk.Message = message;
                        switch (icon)
                        {
                            case MessageBoxIcon.Information:
                                msgOk.MessageIcon = Properties.Resources.ok;
                                break;
                            case MessageBoxIcon.Warning:
                                msgOk.MessageIcon = Properties.Resources.warning;
                                break;
                            case MessageBoxIcon.Error:
                                msgOk.MessageIcon = Properties.Resources.errer;
                                break;
                            case MessageBoxIcon.Question:
                                msgOk.MessageIcon = Properties.Resources.que;
                                break;
                        }
                        return msgOk.ShowDialog();
                    }
                    break;

                case MessageBoxButtons.YesNo:
                    using (MsgYesNo msgYesNo = new MsgYesNo())
                    {
                        msgYesNo.Message = message;
                        switch (icon)
                        {
                            case MessageBoxIcon.Information:
                                msgYesNo.MessageIcon = Properties.Resources.infor;
                                break;
                            case MessageBoxIcon.Warning:
                                msgYesNo.MessageIcon = Properties.Resources.warning;
                                break;
                            case MessageBoxIcon.Error:
                                msgYesNo.MessageIcon = Properties.Resources.errer;
                                break;
                            case MessageBoxIcon.Question:
                                msgYesNo.MessageIcon = Properties.Resources.que;
                                break;
                        }
                        return msgYesNo.ShowDialog();
                    }
                    break;

                case MessageBoxButtons.YesNoCancel:
                    using (MsgYesNoCancel msgYesNoCancel = new MsgYesNoCancel())
                    {
                        msgYesNoCancel.Message = message;
                        switch (icon)
                        {
                            case MessageBoxIcon.Information:
                                msgYesNoCancel.MessageIcon = Properties.Resources.infor;
                                break;
                            case MessageBoxIcon.Warning:
                                msgYesNoCancel.MessageIcon = Properties.Resources.warning;
                                break;
                            case MessageBoxIcon.Error:
                                msgYesNoCancel.MessageIcon = Properties.Resources.errer;
                                break;
                            case MessageBoxIcon.Question:
                                msgYesNoCancel.MessageIcon = Properties.Resources.que;
                                break;
                        }
                        return msgYesNoCancel.ShowDialog();
                    }
                    break;
            }
            return result;
        }

        //Message, caption, icon
        public static DialogResult Show(string message, string caption, MessageBoxIcon icon)
        {
            using (MsgOK msgOk = new MsgOK())
            {
                msgOk.Caption = caption;
                msgOk.Message = message;
                switch (icon)
                {
                    case MessageBoxIcon.Information:
                        msgOk.MessageIcon = Properties.Resources.ok;
                        break;
                    case MessageBoxIcon.Warning:
                        msgOk.MessageIcon = Properties.Resources.warning;
                        break;
                    case MessageBoxIcon.Error:
                        msgOk.MessageIcon = Properties.Resources.errer;
                        break;
                    case MessageBoxIcon.Question:
                        msgOk.MessageIcon = Properties.Resources.que;
                        break;
                }
                return msgOk.ShowDialog();
            }
        }

        //Message, caption, button
        public static DialogResult Show(string message, string caption, MessageBoxButtons button)
        {
            DialogResult result = DialogResult.None;
            switch (button)
            {
                case MessageBoxButtons.OK:
                    using (MsgOK msgOk = new MsgOK())
                    {
                        msgOk.Caption = caption;
                        msgOk.Message = message;
                        return msgOk.ShowDialog();
                    }
                    break;

                case MessageBoxButtons.YesNo:
                    using (MsgYesNo msgYesNo = new MsgYesNo())
                    {
                        msgYesNo.Caption = caption;
                        msgYesNo.Message = message;
                        return msgYesNo.ShowDialog();
                    }
                    break;

                case MessageBoxButtons.YesNoCancel:
                    using (MsgYesNoCancel msgYesNoCancel = new MsgYesNoCancel())
                    {
                        msgYesNoCancel.Caption = caption;
                        msgYesNoCancel.Message = message;
                        return msgYesNoCancel.ShowDialog();
                    }
                    break;
            }
            return result;
        }

        //Message, caption, button, icon
        public static DialogResult Show(string message, string caption, MessageBoxButtons button, MessageBoxIcon icon)
        {
            DialogResult result = DialogResult.None;
            switch (button)
            {
                case MessageBoxButtons.OK:
                    using (MsgOK msgOk = new MsgOK())
                    {
                        msgOk.Caption = caption;
                        msgOk.Message = message;
                        switch (icon)
                        {
                            case MessageBoxIcon.Information:
                                msgOk.MessageIcon = Properties.Resources.ok;
                                break;
                            case MessageBoxIcon.Warning:
                                msgOk.MessageIcon = Properties.Resources.warning;
                                break;
                            case MessageBoxIcon.Error:
                                msgOk.MessageIcon = Properties.Resources.errer;
                                break;
                            case MessageBoxIcon.Question:
                                msgOk.MessageIcon = Properties.Resources.que;
                                break;
                        }
                        return msgOk.ShowDialog();
                    }
                    break;

                case MessageBoxButtons.YesNo:
                    using (MsgYesNo msgYesNo = new MsgYesNo())
                    {
                        msgYesNo.Caption = caption;
                        msgYesNo.Message = message;
                        switch (icon)
                        {
                            case MessageBoxIcon.Information:
                                msgYesNo.MessageIcon = Properties.Resources.infor;
                                break;
                            case MessageBoxIcon.Warning:
                                msgYesNo.MessageIcon = Properties.Resources.warning;
                                break;
                            case MessageBoxIcon.Error:
                                msgYesNo.MessageIcon = Properties.Resources.errer;
                                break;
                            case MessageBoxIcon.Question:
                                msgYesNo.MessageIcon = Properties.Resources.que;
                                break;
                        }
                        return msgYesNo.ShowDialog();
                    }
                    break;

                case MessageBoxButtons.YesNoCancel:
                    using (MsgYesNoCancel msgYesNoCancel = new MsgYesNoCancel())
                    {
                        msgYesNoCancel.Caption = caption;
                        msgYesNoCancel.Message = message;
                        switch (icon)
                        {
                            case MessageBoxIcon.Information:
                                msgYesNoCancel.MessageIcon = Properties.Resources.infor;
                                break;
                            case MessageBoxIcon.Warning:
                                msgYesNoCancel.MessageIcon = Properties.Resources.warning;
                                break;
                            case MessageBoxIcon.Error:
                                msgYesNoCancel.MessageIcon = Properties.Resources.errer;
                                break;
                            case MessageBoxIcon.Question:
                                msgYesNoCancel.MessageIcon = Properties.Resources.que;
                                break;
                        }
                        return msgYesNoCancel.ShowDialog();
                    }
                    break;
            }
            return result;
        }

        //==============Set Font=====================
        //Message, Font
        public static DialogResult Show(string message, string fontName, int size)
        {
            using (MsgOK msgOk = new MsgOK())
            {
                msgOk.Message = message;
                msgOk.setFont(fontName, size);
                return msgOk.ShowDialog();
            }
        }

        ///Message, caption, font
        public static DialogResult Show(string message, string caption, string fontName, int size)
        {
            using (MsgOK msgOk = new MsgOK())
            {
                msgOk.Caption = caption;
                msgOk.Message = message;
                msgOk.setFont(fontName, size);
                return msgOk.ShowDialog();
            }
        }

        //Message, button, font
        public static DialogResult Show(string message, string fontName, int size, MessageBoxButtons button)
        {
            DialogResult result = DialogResult.None;
            switch (button)
            {
                case MessageBoxButtons.OK:
                    using (MsgOK msgOk = new MsgOK())
                    {
                        msgOk.Message = message;
                        msgOk.setFont(fontName, size);
                        return msgOk.ShowDialog();
                    }
                    break;

                case MessageBoxButtons.YesNo:
                    using (MsgYesNo msgYesNo = new MsgYesNo())
                    {
                        msgYesNo.Message = message;
                        msgYesNo.setFont(fontName, size);
                        return msgYesNo.ShowDialog();
                    }
                    break;

                case MessageBoxButtons.YesNoCancel:
                    using (MsgYesNoCancel msgYesNoCancel = new MsgYesNoCancel())
                    {
                        msgYesNoCancel.Message = message;
                        msgYesNoCancel.setFont(fontName, size);
                        return msgYesNoCancel.ShowDialog();
                    }
                    break;
            }
            return result;
        }

        //Message, icon, font
        public static DialogResult Show(string message, string fontName, int size, MessageBoxIcon icon )
        {
            using (MsgOK msgOk = new MsgOK())
            {
                msgOk.Message = message;
                msgOk.setFont(fontName, size);
                switch (icon)
                {
                    case MessageBoxIcon.Information:
                        msgOk.MessageIcon = Properties.Resources.ok;
                        break;
                    case MessageBoxIcon.Warning:
                        msgOk.MessageIcon = Properties.Resources.warning;
                        break;
                    case MessageBoxIcon.Error:
                        msgOk.MessageIcon = Properties.Resources.errer;
                        break;
                    case MessageBoxIcon.Question:
                        msgOk.MessageIcon = Properties.Resources.que;
                        break;
                }
                return msgOk.ShowDialog();
            }
        }

        //Message, icon, button, font
        public static DialogResult Show(string message, string fontName, int size, MessageBoxButtons button, MessageBoxIcon icon)
        {
            DialogResult result = DialogResult.None;
            switch (button)
            {
                case MessageBoxButtons.OK:
                    using (MsgOK msgOk = new MsgOK())
                    {
                        msgOk.Message = message;
                        msgOk.setFont(fontName, size);
                        switch (icon)
                        {
                            case MessageBoxIcon.Information:
                                msgOk.MessageIcon = Properties.Resources.ok;
                                break;
                            case MessageBoxIcon.Warning:
                                msgOk.MessageIcon = Properties.Resources.warning;
                                break;
                            case MessageBoxIcon.Error:
                                msgOk.MessageIcon = Properties.Resources.errer;
                                break;
                            case MessageBoxIcon.Question:
                                msgOk.MessageIcon = Properties.Resources.que;
                                break;
                        }
                        return msgOk.ShowDialog();
                    }
                    break;

                case MessageBoxButtons.YesNo:
                    using (MsgYesNo msgYesNo = new MsgYesNo())
                    {
                        msgYesNo.Message = message;
                        msgYesNo.setFont(fontName, size);
                        switch (icon)
                        {
                            case MessageBoxIcon.Information:
                                msgYesNo.MessageIcon = Properties.Resources.infor;
                                break;
                            case MessageBoxIcon.Warning:
                                msgYesNo.MessageIcon = Properties.Resources.warning;
                                break;
                            case MessageBoxIcon.Error:
                                msgYesNo.MessageIcon = Properties.Resources.errer;
                                break;
                            case MessageBoxIcon.Question:
                                msgYesNo.MessageIcon = Properties.Resources.que;
                                break;
                        }
                        return msgYesNo.ShowDialog();
                    }
                    break;

                case MessageBoxButtons.YesNoCancel:
                    using (MsgYesNoCancel msgYesNoCancel = new MsgYesNoCancel())
                    {
                        msgYesNoCancel.Message = message;
                        msgYesNoCancel.setFont(fontName, size);
                        switch (icon)
                        {
                            case MessageBoxIcon.Information:
                                msgYesNoCancel.MessageIcon = Properties.Resources.infor;
                                break;
                            case MessageBoxIcon.Warning:
                                msgYesNoCancel.MessageIcon = Properties.Resources.warning;
                                break;
                            case MessageBoxIcon.Error:
                                msgYesNoCancel.MessageIcon = Properties.Resources.errer;
                                break;
                            case MessageBoxIcon.Question:
                                msgYesNoCancel.MessageIcon = Properties.Resources.que;
                                break;
                        }
                        return msgYesNoCancel.ShowDialog();
                    }
                    break;
            }
            return result;
        }

        //Message, caption, icon, font
        public static DialogResult Show(string message, string caption, string fontName, int size, MessageBoxIcon icon)
        {
            using (MsgOK msgOk = new MsgOK())
            {
                msgOk.Caption = caption;
                msgOk.Message = message;
                msgOk.setFont(fontName, size);
                switch (icon)
                {
                    case MessageBoxIcon.Information:
                        msgOk.MessageIcon = Properties.Resources.ok;
                        break;
                    case MessageBoxIcon.Warning:
                        msgOk.MessageIcon = Properties.Resources.warning;
                        break;
                    case MessageBoxIcon.Error:
                        msgOk.MessageIcon = Properties.Resources.errer;
                        break;
                    case MessageBoxIcon.Question:
                        msgOk.MessageIcon = Properties.Resources.que;
                        break;
                }
                return msgOk.ShowDialog();
            }
        }

        //Message, caption, button, font
        public static DialogResult Show(string message, string caption, string fontName, int size, MessageBoxButtons button)
        {
            DialogResult result = DialogResult.None;
            switch (button)
            {
                case MessageBoxButtons.OK:
                    using (MsgOK msgOk = new MsgOK())
                    {
                        msgOk.Caption = caption;
                        msgOk.Message = message;
                        msgOk.setFont(fontName, size);
                        return msgOk.ShowDialog();
                    }
                    break;

                case MessageBoxButtons.YesNo:
                    using (MsgYesNo msgYesNo = new MsgYesNo())
                    {
                        msgYesNo.Caption = caption;
                        msgYesNo.Message = message;
                        msgYesNo.setFont(fontName, size);
                        return msgYesNo.ShowDialog();
                    }
                    break;

                case MessageBoxButtons.YesNoCancel:
                    using (MsgYesNoCancel msgYesNoCancel = new MsgYesNoCancel())
                    {
                        msgYesNoCancel.Caption = caption;
                        msgYesNoCancel.Message = message;
                        msgYesNoCancel.setFont(fontName, size);
                        return msgYesNoCancel.ShowDialog();
                    }
                    break;
            }
            return result;
        }

        //Message, caption, button, icon, font
        public static DialogResult Show(string message, string caption, string fontName, int size, MessageBoxButtons button, MessageBoxIcon icon)
        {
            DialogResult result = DialogResult.None;
            switch (button)
            {
                case MessageBoxButtons.OK:
                    using (MsgOK msgOk = new MsgOK())
                    {
                        msgOk.Caption = caption;
                        msgOk.Message = message;
                        msgOk.setFont(fontName, size);
                        switch (icon)
                        {
                            case MessageBoxIcon.Information:
                                msgOk.MessageIcon = Properties.Resources.ok;
                                break;
                            case MessageBoxIcon.Warning:
                                msgOk.MessageIcon = Properties.Resources.warning;
                                break;
                            case MessageBoxIcon.Error:
                                msgOk.MessageIcon = Properties.Resources.errer;
                                break;
                            case MessageBoxIcon.Question:
                                msgOk.MessageIcon = Properties.Resources.que;
                                break;
                        }
                        return msgOk.ShowDialog();
                    }
                    break;

                case MessageBoxButtons.YesNo:
                    using (MsgYesNo msgYesNo = new MsgYesNo())
                    {
                        msgYesNo.Caption = caption;
                        msgYesNo.Message = message;
                        msgYesNo.setFont(fontName, size);
                        switch (icon)
                        {
                            case MessageBoxIcon.Information:
                                msgYesNo.MessageIcon = Properties.Resources.infor;
                                break;
                            case MessageBoxIcon.Warning:
                                msgYesNo.MessageIcon = Properties.Resources.warning;
                                break;
                            case MessageBoxIcon.Error:
                                msgYesNo.MessageIcon = Properties.Resources.errer;
                                break;
                            case MessageBoxIcon.Question:
                                msgYesNo.MessageIcon = Properties.Resources.que;
                                break;
                        }
                        return msgYesNo.ShowDialog();
                    }
                    break;

                case MessageBoxButtons.YesNoCancel:
                    using (MsgYesNoCancel msgYesNoCancel = new MsgYesNoCancel())
                    {
                        msgYesNoCancel.Caption = caption;
                        msgYesNoCancel.Message = message;
                        msgYesNoCancel.setFont(fontName, size);
                        switch (icon)
                        {
                            case MessageBoxIcon.Information:
                                msgYesNoCancel.MessageIcon = Properties.Resources.infor;
                                break;
                            case MessageBoxIcon.Warning:
                                msgYesNoCancel.MessageIcon = Properties.Resources.warning;
                                break;
                            case MessageBoxIcon.Error:
                                msgYesNoCancel.MessageIcon = Properties.Resources.errer;
                                break;
                            case MessageBoxIcon.Question:
                                msgYesNoCancel.MessageIcon = Properties.Resources.que;
                                break;
                        }
                        return msgYesNoCancel.ShowDialog();
                    }
                    break;
            }
            return result;
        }

    }
}
