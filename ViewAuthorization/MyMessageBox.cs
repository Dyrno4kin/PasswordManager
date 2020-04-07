namespace ViewAuthorization
{
    public static class MyMessageBox
    {
        public static System.Windows.Forms.DialogResult ShowMessage(string message, string caption, System.Windows.Forms.MessageBoxButtons button, System.Windows.Forms.MessageBoxIcon icon)
        {
            System.Windows.Forms.DialogResult dlgResult = System.Windows.Forms.DialogResult.None;
            switch (button)
            {
                case System.Windows.Forms.MessageBoxButtons.OK:
                    using (MessegeBoxOk msgOK = new MessegeBoxOk())
                    {
                        //Change text, caption, icon
                        msgOK.Text = caption;
                        msgOK.Message = message;
                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information:
                                msgOK.MessageIcon = ViewAuthorization.Properties.Resources.Error;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Question:
                                msgOK.MessageIcon = ViewAuthorization.Properties.Resources.success;
                                break;
                        }
                        dlgResult = msgOK.ShowDialog();
                    }
                    break;
            }
            return dlgResult;
        }
    }
}
