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
    public partial class ClientRequestCreateAlertForm : Form
    {
        int clientId;
        bool mode;
        int RequestId;
        public ClientRequestCreateAlertForm(string login, bool mode, int requestId = -1, string[] Data = null)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            clientId = Convert.ToInt32(DataBaseIntegration.GetUserDatabyLogin(login, "userId"));
            CarModelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DataBaseIntegration.GetFilterData(CarModelComboBox, "CarModelsName", "carModels");
            this.mode = mode;
            CreateRequest.Enabled = false;
            CreateRequest.Text = mode ? "Отправить" : "Отредактировать";
            Title.Text = mode ? $"Создание заявки" : $"Редактирование заявки №{requestId}";
            this.Text = mode ? $"Создание заявки" : $"Редактирование заявки";
            RequestId = requestId;

            if (!mode)
            {
                CarModelComboBox.Text =  Data[0];
                ProblemDescriptionTextBox.Text = Data[4];
            }
        }

        private void CreateRequest_Click(object sender, EventArgs e)
        {
            if (mode)
            {
                DataBaseIntegration.CreateRequest(GetCarMoselId(CarModelComboBox.Text), ProblemDescriptionTextBox.Text, clientId);
                MessageBox.Show("Заявка отправлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                DataBaseIntegration.ClientRequestUpdate(GetCarMoselId(CarModelComboBox.Text), ProblemDescriptionTextBox.Text, RequestId);
                MessageBox.Show("Заявка отредактирована", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (CarModelComboBox.Text != "" && ProblemDescriptionTextBox.Text != "")
            {
                CreateRequest.Enabled = true;
            }
            else CreateRequest.Enabled = false;
        }


        private int GetCarMoselId(string modelName)
        {
            List<List<string>> table = DataBaseIntegration.GetCarModels();

            for (int i = 0; i < table[1].Count; i++)
            {
                if (table[1][i] == modelName)
                {
                    return Convert.ToInt32(table[0][i]);
                }
            }
            return -1;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
