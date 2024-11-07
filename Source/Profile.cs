using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5_V2
{
    public partial class Profile : Form
    {
        string role;
        string login;
        public Profile(string login)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            UserIcon.BackgroundImage = Properties.Resources.Profile;
            UserIcon.BackgroundImageLayout = ImageLayout.Zoom;
            name.Text += DataBaseIntegration.GetUserDatabyLogin(login, "Name");
            Surname.Text += DataBaseIntegration.GetUserDatabyLogin(login, "Surname");
            role = DataBaseIntegration.getRoleById(Convert.ToInt32(DataBaseIntegration.GetUserDatabyLogin(login, "typeId")));
            Role.Text += role;
            this.login = login;
        }

        private void Requests_Click(object sender, EventArgs e)
        {
            Requests form = new Requests(role, login);
            Hide();
            form.ShowDialog();
            Show();
        }

        private void LoginHistory_Click(object sender, EventArgs e)
        {
            LoginHistory form = new LoginHistory();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
