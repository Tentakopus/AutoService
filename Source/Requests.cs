using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5_V2
{
    public partial class Requests : Form
    {
        int AllRequestCount = 0;
        string baseSearchString = "";
        string searchString = "where 1 = 1";
        string userLogin;
        string userRole;
        public Requests(string role, string login)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            RequestsView.AllowUserToAddRows = false;
            RequestsView.AllowUserToDeleteRows = false;
            RequestsView.ReadOnly = true;

            CarModelFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            CarTypeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            columnSearch.DropDownStyle = ComboBoxStyle.DropDownList;

            columnSearch.Items.Add("Имя Заказчика");
            columnSearch.Items.Add("Фамилия Заказчика");
            columnSearch.Items.Add("Отчество Заказчика");
            columnSearch.Items.Add("Имя Автомеханика");
            columnSearch.Items.Add("Фамилия Автомеханика");
            columnSearch.Items.Add("Отчество Автомеханика");
            columnSearch.Text = columnSearch.Items[0].ToString();

            SearchMode.Checked = true;

            DataBaseIntegration.GetFilterData(CarModelFilter, "CarModelsName", "carModels");
            DataBaseIntegration.GetFilterData(CarTypeFilter, "CarTypeName", "carTypes");
            DataBaseIntegration.GetFilterData(StatusFilter, "StatusName", "requestStatuses");

            userRole = role;
            switch (role)
            {
                case "Заказчик":
                    CreateRequest.Visible = true;
                    baseSearchString = $" and clientLogin = '{login}'";
                    break;
                case "Автомеханик":
                    baseSearchString = $" and masterLogin = '{login}'";
                    break;
                default:
                    break;
            }


            DataBaseIntegration.setDataTodataGridView(RequestsView, "RequestsView", searchString + baseSearchString);
            RequestsView.Columns[14].Visible = false;
            RequestsView.Columns[15].Visible = false;
            RequestsView.Columns[16].Visible = false;

            AllRequestCount = RequestsView.RowCount;
            RequestCountLable.Text = RequestsView.RowCount.ToString() + " из " + AllRequestCount;
            userLogin = login;
        }

        private void Filter_TextChanged(object sender, EventArgs e)
        {
            searchString = "where 1 = 1" + baseSearchString;

            searchString += CarModelFilter.Text != "" ? $" and CarModel = '{CarModelFilter.Text}'" : "";
            searchString += CarTypeFilter.Text != "" ? $" and CarType = '{CarTypeFilter.Text}'" : "";
            searchString += StatusFilter.Text != "" ? $" and requestStatus = '{StatusFilter.Text}'" : "";

            DataBaseIntegration.setDataTodataGridView(RequestsView, "RequestsView", searchString);
        }

        private string GetCorrectColumnName(string column)
        {
            switch (column)
            {
                case "Имя Заказчика":
                    return "clientName";
                case "Фамилия Заказчика":
                    return "clientSurname";
                case "Отчество Заказчика":
                    return "clientPatronymic";
                case "Имя Автомеханика":
                    return "masterName";
                case "Фамилия Автомеханика":
                    return "masterSurname";
                case "Отчество Автомеханика":
                    return "masterPatronymic";
                default:
                    return "";
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchString = "where 1 = 1" + baseSearchString +  $" and {GetCorrectColumnName(columnSearch.Text)} like '%{SearchTextBox.Text}%'";
            DataBaseIntegration.setDataTodataGridView(RequestsView, "RequestsView", searchString);
        }

        private void RequestsView_DataSourceChanged(object sender, EventArgs e)
        {
            RequestsView.Columns[0].HeaderCell.Value = "Модель машины";
            RequestsView.Columns[1].HeaderCell.Value = "Тип машины";
            RequestsView.Columns[2].HeaderCell.Value = "Дата подачи";
            RequestsView.Columns[3].HeaderCell.Value = "Дата завершения";
            RequestsView.Columns[4].HeaderCell.Value = "Описание проблемы";
            RequestsView.Columns[5].HeaderCell.Value = "Комментарии Автомеханика";
            RequestsView.Columns[6].HeaderCell.Value = "Использованные запчасти";
            RequestsView.Columns[7].HeaderCell.Value = "Статус заявки";
            RequestsView.Columns[8].HeaderCell.Value =  "Имя Заказчика";
            RequestsView.Columns[9].HeaderCell.Value = "Фамилия Заказчика";
            RequestsView.Columns[10].HeaderCell.Value = "Отчество Заказчика";
            RequestsView.Columns[11].HeaderCell.Value = "Имя Автомеханика";
            RequestsView.Columns[12].HeaderCell.Value = "Фамилия Автомеханика";
            RequestsView.Columns[13].HeaderCell.Value = "Отчество Автомеханика";

            RequestCountLable.Text = RequestsView.RowCount.ToString() + " из " + AllRequestCount;

        }

        private void RequestsView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ReportForm form = new ReportForm(Convert.ToInt32(RequestsView.Rows[RequestsView.CurrentCell.RowIndex].Cells[14].Value), userRole, userLogin);
            Hide();
            form.ShowDialog();
            Show();
            searchString = "where 1 = 1";
            DataBaseIntegration.setDataTodataGridView(RequestsView, "RequestsView", searchString + baseSearchString);
            AllRequestCount = RequestsView.RowCount;
            RequestCountLable.Text = RequestsView.RowCount.ToString() + " из " + AllRequestCount;
        }

        private void CreateRequest_Click(object sender, EventArgs e)
        {
            ClientRequestCreateAlertForm form = new ClientRequestCreateAlertForm(userLogin, true);
            Hide();
            form.ShowDialog();
            Show();
            searchString = "where 1 = 1";
            DataBaseIntegration.setDataTodataGridView(RequestsView, "RequestsView", searchString + baseSearchString);
            AllRequestCount = RequestsView.RowCount;
            RequestCountLable.Text = RequestsView.RowCount.ToString() + " из " + AllRequestCount;

        }

        private void SearchMode_CheckedChanged(object sender, EventArgs e)
        {
            CarModelFilter.Visible = false;
            CarTypeFilter.Visible = false;
            StatusFilter.Visible = false;
            SearchTextBox.Visible = true;
            columnSearch.Visible = true;
        }

        private void FiltreMode_CheckedChanged(object sender, EventArgs e)
        {
            CarModelFilter.Visible = true;
            CarTypeFilter.Visible = true;
            StatusFilter.Visible = true;
            SearchTextBox.Visible = false;
            columnSearch.Visible = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
