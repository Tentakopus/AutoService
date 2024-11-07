using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.BarCode;
using Aspose.BarCode.Generation;

namespace Task5_V2
{
    public partial class ReportForm : Form
    {
        string Role;
        string userLogin;
        int RequestId;
        public ReportForm(int requestId, string role, string login)
        {
            InitializeComponent();
            string[] Data = DataBaseIntegration.GetRequestDataById(requestId);
            SetData(Data, requestId);

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Role = role;
            RequestId = requestId;
            userLogin = login;

            if (Data[7] == "Готова к выдаче" && (role == "Заказчик" || role == "Автомеханик"))
            {
                Edit.Enabled = false;
            }

            if (role != "Оператор")
            {
                Delete.Visible = false;
            }

            if (role == "Заказчик")
            {
                QRCode.Visible = true;
                GeneretaQRCode();
                QRCodeLable.Visible = true;
            }
               


        }

        private void Edit_Click(object sender, EventArgs e)
        {
            switch (Role)
            {
                case "Заказчик":
                    ClientRequestCreateAlertForm Clientform = new ClientRequestCreateAlertForm(userLogin, false, RequestId, DataBaseIntegration.GetRequestDataById(RequestId));
                    Hide();
                    Clientform.ShowDialog();
                    Show();
                    break;
                case "Автомеханик":
                    MasterFomr MasterForn = new MasterFomr(RequestId, DataBaseIntegration.GetRequestDataById(RequestId));
                    Hide();
                    MasterForn.ShowDialog();
                    Show();
                    break;
                case "Оператор":
                    OperatorForm Operatorform = new OperatorForm(RequestId, DataBaseIntegration.GetRequestDataById(RequestId), Role);
                    Hide();
                    Operatorform.ShowDialog();
                    Show();
                    break;
                case "Менеджер":
                    OperatorForm OperatorformManege = new OperatorForm(RequestId, DataBaseIntegration.GetRequestDataById(RequestId), Role);
                    Hide();
                    OperatorformManege.ShowDialog();
                    Show();
                    break;
                default:
                    break;
            }


            string[] Data = DataBaseIntegration.GetRequestDataById(RequestId);
            SetData(Data, RequestId);
        }

        private void SetData(string[] Data, int requestId)
        {
            RequestNumber.Text = $"Отчет по заявке №{requestId}";
            Model.Text = "Модель машины: " + Data[0];
            Type.Text = "Тип машины: " + Data[1];
            StartDate.Text = "Дата подачи :" + Data[2];
            EndDate.Text = "Дата окончания :" + Data[3];
            Description.Text = Data[4];
            Comments.Text = Data[5].Replace(";", ";\n");
            repairDetails.Text = Data[6].Replace(",", ",\n");
            Status.Text = "Статус заявки: " + Data[7];
            ClientName.Text = "Клиент: " + $"{Data[8]} {Data[9]} {Data[10]}";
            MasterName.Text = "Назначенный Автомеханик: " + $"{Data[11]} {Data[12]} {Data[13]}";
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DataBaseIntegration.DeleteRequest(RequestId);
            MessageBox.Show("Заяака удалена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GeneretaQRCode()
        {
           BarcodeGenerator QRCodeGenerator = new BarcodeGenerator(EncodeTypes.QR);
           QRCodeGenerator.CodeText = "https://docs.google.com/spreadsheets/d/1WfPVTqLY6EKSZhXll9o9mZR0kYYH_EiYkf7yceugJ4E/edit?gid=1728874446#gid=1728874446";
           QRCodeGenerator.Save(@"Generated_QR_Code.png", BarCodeImageFormat.Png);
           QRCode.Image = Image.FromFile("Generated_QR_Code.png");
        }
    }
}
