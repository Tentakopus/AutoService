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
    public partial class LoginHistory : Form
    {
        public LoginHistory()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            LoginHistoryTable.AllowUserToAddRows = false;
            LoginHistoryTable.AllowUserToDeleteRows = false;
            LoginHistoryTable.ReadOnly = true;
            DataBaseIntegration.setLoginHistoryTodataGridView(LoginHistoryTable);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataBaseIntegration.setLoginHistoryTodataGridView(LoginHistoryTable, $"where login like '%{Search.Text}%'");
        }
    }
}
