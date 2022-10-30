using SQLViewer.DAL;
using System;
using System.Windows.Forms;

namespace SQLViewer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                RepositoryFactory.GetRepository().LogIn(TbServer.Text.Trim(), TbUsername.Text.Trim(), TbPassword.Text.Trim());
                new MainForm().Show();
                Hide();
            }
            catch (Exception ex)
            {
                LblError.Text = ex.Message;
            }
        }
    }
}
