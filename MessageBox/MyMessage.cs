using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MyMessageBox
{
    public static class MyMessage
    {
        public static DialogResult Show(string message, string caption, MessageBoxButtons button, MessageBoxIcon icon)
        {
            DialogResult result = DialogResult.None;
            switch (button)
            {
                case MessageBoxButtons.OK:
                    using(MsgOK msgOk=new MsgOK())
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
                        }
                        return msgOk.ShowDialog();
                    }
                    break;

                case MessageBoxButtons.YesNo:
                    using(MsgYesNo msgYesNo=new MsgYesNo())
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
                        }
                        return msgYesNoCancel.ShowDialog();
                    }
                    break;
            }
            return result;
        }
    }
}
