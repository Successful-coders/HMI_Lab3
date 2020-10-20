using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HMI_Lab3
{
    public partial class SignInForm : Form
    {
        private KeyValuePair<string, string> loginPassword = new KeyValuePair<string, string>("admin", "666");
        private ISignable signedForm;
        WebBrowser browser = new WebBrowser();

        public SignInForm(ISignable signedForm)
        {
           //InitializeComponent();
            string curDir = Directory.GetCurrentDirectory();
            browser.Url = new Uri(String.Format("file:///{0}/index.html", curDir));
            browser.ScriptErrorsSuppressed = true;

            //this.signedForm = signedForm;
        }

        private void cancelLoginButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(loginTextBox.Text != loginPassword.Key)
            {
                MessageBox.Show("Такого пользователя не существует");
            }
            else if (passwordTextBox.Text != loginPassword.Value)
            {
                MessageBox.Show("Неправильно введён пароль");
            }
            else
            {
                signedForm.SignIn(loginTextBox.Text, passwordTextBox.Text);
                this.Close();
            }
        }
        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                loginButton_Click(sender, e);
            }
        }
    }
}
