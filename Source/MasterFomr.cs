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
    public partial class MasterFomr : Form
    {
        int RequestId;
        public MasterFomr(int requestId, string[] Data)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            RequestId = requestId;
            Title.Text = $"Отчет по заявке №{requestId}";
            CarModel.Text = "Модель машины: " + Data[0];
            CarType.Text = "Тип машины: " + Data[1];
            StartDate.Text = "Дата подачи заявки: " + Data[2];

            Description.Text = Data[4];
            Comments.Text = Data[5].Replace(";", ";\n");
            repairDetails.Text = Data[6].Replace(",", ",\n");

            AddDetail.Enabled = false;
            AddComment.Enabled = false;


        }

        private void AddDetail_Click(object sender, EventArgs e)
        {
            DataBaseIntegration.UpdateDetails(RequestId, AddDetailTextBox.Text);
            string[] Data = DataBaseIntegration.GetRequestDataById(RequestId);
            repairDetails.Text = Data[6].Replace(",", ",\n");
            AddDetailTextBox.Text = "";
            AddDetail.Enabled = false;
        }

        private void AddDetailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddDetailTextBox.Text != "")
            {
                AddDetail.Enabled = true;
            }
            else AddDetail.Enabled = false;
        }

        private void CommentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddComment.Text != "")
            {
                AddComment.Enabled = true;
            }
            else AddComment.Enabled = false;
        }

        private void AddComment_Click(object sender, EventArgs e)
        {
            DataBaseIntegration.UpdateComments(RequestId, CommentTextBox.Text);
            string[] Data = DataBaseIntegration.GetRequestDataById(RequestId);
            Comments.Text = Data[5].Replace(";", ";\n");
            CommentTextBox.Text = "";
            AddComment.Enabled = false;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            DataBaseIntegration.CreateReport(RequestId);
            MessageBox.Show("Отчет сформирован", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
