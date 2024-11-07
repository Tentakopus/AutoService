using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5_V2
{
    internal static class DataBaseIntegration
    {
        internal const string ConnectionString = "Data Source=ADCLG1;Initial Catalog=!!!!!!!!!!!!Миронов_УП;Integrated Security=True;";
        static SqlConnection sqlConnection = new SqlConnection(ConnectionString);
        static DataSet dataSet;
        static SqlDataAdapter sql;


        internal static void OpenDB()
        {
            try
            {
                sqlConnection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключени к базе данных \"!!!!!!!!!!!!Миронов_УП\"", "Ошибка подключения к базе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        internal static void CloseDB()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        internal static bool IsPasswordCorrect(string login, string password)
        {
            SqlCommand getSqlResult = new SqlCommand($"select Count(*) from Users where login = '{login}' and Convert(varchar(100), DecryptByPassphrase('12345', password)) = '{password}'", sqlConnection);
            OpenDB();
            try
            {
                int result = Convert.ToInt32(getSqlResult.ExecuteScalar());
                CloseDB();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль. Для повторной попытки входа попробуйте заново ввести логин и пароль.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            catch (Exception)
            {
                CloseDB();
                MessageBox.Show("Неверный логин или пароль. Для повторной попытки входа попробуйте заново ввести логин и пароль.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            
        }

        internal static void AddingToLoginhistory(string login, int success)
        {
            SqlCommand Sql = new SqlCommand($"Insert into LogInHistory (login, password, time) Values ('{login}',{success}, '{DateTime.Now}' )", sqlConnection);
            OpenDB();
            try
            {
                Sql.ExecuteNonQuery();
                CloseDB();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка сохранения истории входа, пожалуйста не вводите в текстовые поля символ \"'\"", "Ошибка сохранения истории входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseDB();
            }
            
        }

        internal static string GetUserDatabyLogin(string login, string column)
        {
            SqlCommand Sql = new SqlCommand($"Select {column} from Users where login = '{login}'", sqlConnection);
            OpenDB();
            try
            {
                string result = Sql.ExecuteScalar().ToString();
                CloseDB();
                return result;
            }
            catch (Exception)
            {
                MessageBox.Show("Убедитесь, что база данных \"!!!!!!!!!!!!Миронов_УП\" присутствует на сервере и её структура корректна.", "Ошибка подключения к базе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseDB();
            }
            return null;

        }

        internal static string getRoleById(int roleId)
        {
            SqlCommand Sql = new SqlCommand($"Select RoleName from Roles where roleId =  {roleId}", sqlConnection);
            OpenDB();
            try
            {
                string result = Sql.ExecuteScalar().ToString();
                CloseDB();
                return result;
            }
            catch (Exception)
            {
                MessageBox.Show("Убедитесь, что база данных \"!!!!!!!!!!!!Миронов_УП\" присутствует на сервере и её структура корректна.", "Ошибка подключения к базе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseDB();
            }
            return null;
        }

        internal static void setDataTodataGridView(DataGridView dataGridView, string table, string str = "")
        {
            OpenDB();
            dataSet = new DataSet();
            sql = new SqlDataAdapter($"select * from {table} {str}",sqlConnection);
            SqlCommandBuilder sqlCommand = new SqlCommandBuilder(sql);
            sql.Fill(dataSet);
            CloseDB();
            dataGridView.DataSource = dataSet.Tables[0];
        }

        internal static void GetFilterData(ComboBox comboBox,string column, string table)
        {
            SqlDataReader reader;
            SqlCommand sqlCommand = new SqlCommand($"select Distinct({column}) from {table}", sqlConnection);

            comboBox.Items.Add("");

            OpenDB();
            reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                comboBox.Items.Add(reader[0].ToString());
            }
            CloseDB();
        }

        internal static void CreateRequest(int carModel, string problemDescription, int clientId)
        {

            SqlCommand Sql = new SqlCommand($"Insert into Requests (startDate, carModel, problemDescription, requestStatus, completionDate, masterID, clientID) Values ('{DateTime.Now}', {carModel}, '{problemDescription}', 3, NULL,  NULL, {clientId})", sqlConnection);
            OpenDB();
            try
            {
                Sql.ExecuteNonQuery();
                CloseDB();
            }
            catch (Exception)
            {
                MessageBox.Show("Убедитесь, что введены корректные данные.", "Ошибка создания заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseDB();
            }
        }

        internal static void ClientRequestUpdate(int carModel, string problemDescription, int requestId)
        {
            SqlCommand Sql = new SqlCommand($"Update Requests set carModel = {carModel}, problemDescription = '{problemDescription}' where requestID = {requestId}", sqlConnection);
            OpenDB();
            try
            {
                Sql.ExecuteNonQuery();
                CloseDB();
            }
            catch (Exception)
            {
                MessageBox.Show("Убедитесь, что введены корректные данные.", "Ошибка создания заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseDB();
            }
        }

        internal static string[] GetRequestDataById(int requestId)
        {
            SqlDataReader reader;
            SqlCommand sqlCommand = new SqlCommand($"select * from RequestsView where requestId = {requestId}", sqlConnection);

            string[] result = new string[14];

            OpenDB();
            reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = reader[i].ToString();
                }
            }
            CloseDB();
            return result;
        }


        internal static List<List<string>> GetCarModels()
        {
            SqlDataReader reader;
            SqlCommand sqlCommand = new SqlCommand($"select * from carModels", sqlConnection);

            List<List<string>> result = new List<List<string>>();
            List<string> id = new List<string>();
            List<string> Names = new List<string>();

            OpenDB();
            reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                id.Add(reader[0].ToString());
                Names.Add(reader[1].ToString());
                
            }
            CloseDB();

            result.Add(id);
            result.Add(Names);
            return result;
        }

        internal static List<List<string>> GetMastersData(ComboBox comboBox)
        {

            comboBox.Items.Add("Нет");

            SqlDataReader reader;
            SqlCommand sqlCommand = new SqlCommand($"select userId, [Surname],[Name],[Patronymic] from Users where typeId = 2", sqlConnection);
            
            List<List<string>> result = new List<List<string>>();
            List<string> id = new List<string>();
            List<string> Names = new List<string>();

            OpenDB();
            reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                id.Add(reader[0].ToString());
                Names.Add($"{reader[1].ToString()} {reader[2].ToString()} {reader[3].ToString()}");
                comboBox.Items.Add($"{reader[1].ToString()} {reader[2].ToString()} {reader[3].ToString()}");
            }
            CloseDB();
            result.Add(id);
            result.Add(Names);
            return result;
        }

        internal static void OperatorRequestUpdate(int masterId, int requestStatus, string problemDescription, int requestId)
        {
            string setMaster = masterId > -1 ? masterId.ToString() : "NULL";
            SqlCommand Sql = new SqlCommand($"Update Requests set masterID = {setMaster}, problemDescription = '{problemDescription}', requestStatus = {requestStatus} where requestID = {requestId}", sqlConnection);
            OpenDB();
            try
            {
                Sql.ExecuteNonQuery();
                CloseDB();
            }
            catch (Exception)
            {
                MessageBox.Show("Убедитесь, что введены корректные данные.", "Ошибка создания заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseDB();
            }
        }


        internal static List<List<string>> GetStatuses()
        {
            SqlDataReader reader;
            SqlCommand sqlCommand = new SqlCommand($"select * from requestStatuses", sqlConnection);

            List<List<string>> result = new List<List<string>>();
            List<string> id = new List<string>();
            List<string> Names = new List<string>();

            OpenDB();
            reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                id.Add(reader[0].ToString());
                Names.Add(reader[1].ToString());

            }
            CloseDB();

            result.Add(id);
            result.Add(Names);
            return result;
        }

        internal static void UpdateDetails(int requestId, string detailName)
        {
            SqlCommand sqlCommand = new SqlCommand($"select Count(*) from repairParts where detailName = '{detailName}'", sqlConnection);

            OpenDB();
            int checkDetail = Convert.ToInt32(sqlCommand.ExecuteScalar());
            if (checkDetail == 0)
            {
                sqlCommand = new SqlCommand($"Insert into repairParts (detailName) values ('{detailName}')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }

            sqlCommand = new SqlCommand($"Select detailId from repairParts where detailName = '{detailName}'", sqlConnection);
            int detailId = Convert.ToInt32(sqlCommand.ExecuteScalar());

            sqlCommand = new SqlCommand($"Insert into RequestsRepairParts  values ({requestId},{detailId})", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            CloseDB();


        }

        internal static void UpdateComments(int requestId, string comment)
        {
            SqlCommand sqlCommand = new SqlCommand($"Insert into comments (message, requestID) values ('{comment}', {requestId})", sqlConnection);

            OpenDB();
            sqlCommand.ExecuteNonQuery();
            CloseDB();
        }

        internal static void CreateReport(int requestId)
        {
            SqlCommand Sql = new SqlCommand($"Update Requests set requestStatus = 2, completionDate = '{DateTime.Now}' where requestID = {requestId}", sqlConnection);
            OpenDB();
            try
            {
                Sql.ExecuteNonQuery();
                CloseDB();
            }
            catch (Exception)
            {
                MessageBox.Show("Убедитесь, что введены корректные данные.", "Ошибка создания заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseDB();
            }
        }


        internal static void DeleteRequest(int requestId)
        {
            SqlCommand sqlCommand = new SqlCommand($"delete from Requests where requestID = {requestId} delete from RequestsRepairParts where requestID = {requestId}", sqlConnection);
            OpenDB();
            sqlCommand.ExecuteNonQuery();
            CloseDB();
        }


        internal static void setLoginHistoryTodataGridView(DataGridView dataGridView, string searchString = "")
        {
            OpenDB();
            dataSet = new DataSet();
            sql = new SqlDataAdapter($"SELECT [login] as Логин, [password] as [Результат входа], [time] as [Время входа] FROM [LogInHistory] {searchString}", sqlConnection);
            SqlCommandBuilder sqlCommand = new SqlCommandBuilder(sql);
            sql.Fill(dataSet);
            CloseDB();
            dataGridView.DataSource = dataSet.Tables[0];
        }


        internal static void EndDateDelete(int requestId)
        {
            SqlCommand Sql = new SqlCommand($"Update Requests set completionDate = NULL where requestID = {requestId}", sqlConnection);
            OpenDB();
            try
            {
                Sql.ExecuteNonQuery();
                CloseDB();
            }
            catch (Exception)
            {
                MessageBox.Show("Убедитесь, что введены корректные данные.", "Ошибка создания заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseDB();
            }
        }

    }
}
