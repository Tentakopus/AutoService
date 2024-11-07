using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Task5_V2
{
    public partial class LoginForm : Form
    {
        int LogInCount = 0;
        int SecondsCount = 0;

        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Login.Enabled = false;
            PasswordTextBox.UseSystemPasswordChar = true;

        }

        private void Login_Click(object sender, EventArgs e)
        {
           if (DataBaseIntegration.IsPasswordCorrect(LoginTextBox.Text, PasswordTextBox.Text))
            {
                Profile form = new Profile(LoginTextBox.Text);
                DataBaseIntegration.AddingToLoginhistory(LoginTextBox.Text, 1);
                Hide();
                form.ShowDialog();
                Show();
            }
            else
            {
                DataBaseIntegration.AddingToLoginhistory(LoginTextBox.Text, 0);
                LogInCount++;
                if (LogInCount > 1)
                {
                    Captcha form = new Captcha();
             
                    EnableForm(false);
                    form.ShowDialog();

                    EnableForm(form.CaptchaCompleted);
                    if (LogInCount > 2)
                    {
                        if (form.CaptchaCompleted)
                        {
                            timerLable.Visible = true;
                            timerLable.Text = "До разблокировки осталось: 180 сек";
                            EnableForm(false);
                            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                            timer.Interval = 1000;
                            timer.Start();
                            timer.Tick += Timer_Tick;

                        }
                        else
                        {
                            EnableForm(false);
                        }
                    }
                    form.CaptchaCompleted = false;

                    if (LogInCount > 3)
                    {
                        MessageBox.Show("Превышено число неудачных попыток входа. Программа будет заблокирована до перезапуска.", "Вход не выполнен", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        EnableForm(false);
                        return;
                    }

                    
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            SecondsCount++;
            timerLable.Text = $"До разблокировки осталось: {180 - SecondsCount} сек";
            if (SecondsCount == 180)
            {
                SecondsCount = 0;
                EnableForm(true);
                timerLable.Visible = false;
                (sender as System.Windows.Forms.Timer).Stop();
            }
        }


        private void EnableForm(bool enable)
        {
            LoginTextBox.Enabled = enable;
            PasswordTextBox.Enabled = enable;
            Login.Enabled = enable;
            showPassword.Enabled = enable;
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = !PasswordTextBox.UseSystemPasswordChar;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text != String.Empty && LoginTextBox.Text != String.Empty)
            {
                Login.Enabled = true;
            }
            else
            {
                Login.Enabled = false;
            }
        }
    }
}
