using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Task5_V2
{
    public partial class OperatorForm : Form
    {
        List<List<string>> MastersData;
        int RequestId;
        public OperatorForm(int requestId, string[] Data, string role)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            RequestId = requestId;
            Edit.Enabled = false;

            Status.DropDownStyle = ComboBoxStyle.DropDownList;
            Master.DropDownStyle = ComboBoxStyle.DropDownList;

            Title.Text = $"Отчет по заявке №{requestId}";
            ModelName.Text = "Модель машины: " + Data[0];
            Type.Text = "Тип машины: " + Data[1];
            StartDate.Text = "Дата подачи : " + Data[2];
            Description.Text = Data[4];
            ClientName.Text =  $"{Data[8]} {Data[9]} {Data[10]}";
           
            DataBaseIntegration.GetFilterData(Status, "StatusName", "requestStatuses");
            MastersData = DataBaseIntegration.GetMastersData(Master);

            Master.Text = Data[11] + Data[12] + Data[13];
            Status.Text = Data[7];

            if (role == "Менеджер")
                DeleteEndDate.Visible = true;

        }


        private int GetId(string Name, List<List<string>> Data)
        {

            for (int i = 0; i < Data[1].Count; i++)
            {
                if (Data[1][i] == Name)
                {
                    return Convert.ToInt32(Data[0][i]);
                }
            }
            return -1;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            DataBaseIntegration.OperatorRequestUpdate(GetId(Master.Text, MastersData), GetId(Status.Text, DataBaseIntegration.GetStatuses()), Description.Text, RequestId);
            MessageBox.Show("Заявка отредактирована", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Status.Text != "" && Description.Text != "" && Master.Text != "")
            {
                Edit.Enabled = true;
            }
            else Edit.Enabled = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteEndDate_Click(object sender, EventArgs e)
        {
            DataBaseIntegration.EndDateDelete(RequestId);
            MessageBox.Show("Дата окончания продлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}
