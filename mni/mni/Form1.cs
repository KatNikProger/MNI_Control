using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddIntoPerson_Click(object sender, EventArgs e) // Добавить сотрудника в справочник
        {

            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            string notValidSymbols = "',!#$%№^&*()/?+;:"; // Недопустимые символы

            try
            {
                if (notValidSymbols.Intersect(lastNameAdd.Text).Any() || notValidSymbols.Intersect(firstNameAdd.Text).Any() // Проверка на недопустимые символы
                    || notValidSymbols.Intersect(middleNameAdd.Text).Any() || notValidSymbols.Intersect(mailAdd.Text).Any()
                    || notValidSymbols.Intersect(departmentAdd.Text).Any())
                {
                    MessageBox.Show("Используются недопустимые символы: ' , ! # $ % № ^ & * ( ) / ? + ; :");  // Сообщение об ошибке
                }
                else if (lastNameAdd.Text == string.Empty || firstNameAdd.Text == string.Empty || middleNameAdd.Text == string.Empty 
                    || mailAdd.Text == string.Empty || departmentAdd.Text == string.Empty)
                {
                    MessageBox.Show("Присутствуют незаполненные поля ввода");
                }
                else
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = $"BEGIN MNI.PACKAGE2.INSERT_INTO_PERSON (V_LAST_NAME => '{lastNameAdd.Text.Trim()}', " +
                        $"V_FIRST_NAME => '{firstNameAdd.Text.Trim()}', V_MIDDLE_NAME => '{middleNameAdd.Text.Trim()}', " +
                        $"V_COMMUNICATION => '{mailAdd.Text.Trim()}', V_DEPARTMENT_NAME => '{departmentAdd.Text.Trim()}' ); " +
                        $"END;"; // Добавление процедурой в справочник
                    OracleDataReader reader = cmd.ExecuteReader();

                    lastNameAdd.Clear(); // Очистка текстбоксов после добавления записи
                    firstNameAdd.Clear();
                    middleNameAdd.Clear();
                    mailAdd.Clear();
                    departmentAdd.Clear();

                    MessageBox.Show("Запись добавлена");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void DeleteFromPerson_Click(object sender, EventArgs e) // Удалить сотрудника из справочника Person
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            string notValidSymbols = "',!#$%№^&*()/?+;:"; // Недопустимые символы

            try
            {
                if (notValidSymbols.Intersect(lastNameDelete.Text).Any() || notValidSymbols.Intersect(firstNameDelete.Text).Any() // Проверка на недопустимые символы
                    || notValidSymbols.Intersect(middleNameDelete.Text).Any())
                {
                    MessageBox.Show("Используются недопустимые символы: ' , ! # $ % № ^ & * ( ) / ? + ; :");  // Сообщение об ошибке
                }
                else if (lastNameDelete.Text == "" || firstNameDelete.Text == "" || middleNameDelete.Text == "")
                {
                    MessageBox.Show("Присутствуют незаполненные поля ввода");
                }
                else
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = $"DELETE FROM MNI.PERSON WHERE LOWER(LAST_NAME) = LOWER('{lastNameDelete.Text.Trim()}') " +
                                      $"AND LOWER(FIRST_NAME) = LOWER('{firstNameDelete.Text.Trim()}') " +
                                      $"AND LOWER(MIDDLE_NAME) = LOWER('{middleNameDelete.Text.Trim()}')"; // Удаление сотрудника из справочника
                    OracleDataReader reader = cmd.ExecuteReader();

                    lastNameDelete.Clear(); // Очистка текстбоксов после добавления записи
                    firstNameDelete.Clear();
                    middleNameDelete.Clear();

                    MessageBox.Show("Запись удалена");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ShowPersons_Click(object sender, EventArgs e) // Показать таблицу сотрудников
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            try
            {
                dataGridView1.Columns.Clear(); // Очистка dataGridView
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT LAST_NAME, FIRST_NAME, MIDDLE_NAME, COMMUNICATION, MNI.DEPARTMENT.DEPARTMENT_NAME FROM MNI.PERSON " +
                    "INNER JOIN MNI.DEPARTMENT ON MNI.DEPARTMENT.DEPARTMENT_ID = MNI.PERSON.DEPARTMENT_ID ORDER BY PERSON_ID"; // Вывод информации по сотрудникам

                dataGridView1.Columns.Add("lastName", "Фамилия"); // Добавление столбцов в таблицу
                dataGridView1.Columns.Add("firstName", "Имя");
                dataGridView1.Columns.Add("middleName", "Отчество");
                dataGridView1.Columns.Add("email", "Почта");
                dataGridView1.Columns.Add("depart", "Отдел");

                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetOracleString(0), reader.GetOracleString(1),  // Добавление записей в таблицу
                                           reader.GetOracleString(2), reader.GetOracleString(3),
                                           reader.GetOracleString(4));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void AddIntoDepartment_Click(object sender, EventArgs e) // Добавить отдел в справочник
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            string notValidSymbols = "',!#$%^&*()/?+;:"; // Недопустимые символы

            try
            {
                if (notValidSymbols.Intersect(departmentInsert.Text).Any())
                {
                    MessageBox.Show("Используются недопустимые символы: ' , ! # $ % ^ & * ( ) / ? + ; :");  // Сообщение об ошибке
                }
                else if (departmentInsert.Text == "")
                {
                    MessageBox.Show("Присутствуют незаполненные поля ввода");
                }
                else
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = $"INSERT INTO MNI.DEPARTMENT (DEPARTMENT_NAME) VALUES ('{departmentInsert.Text.Trim()}')"; // Добавление отделов в справочник
                    OracleDataReader reader = cmd.ExecuteReader();

                    departmentInsert.Clear(); // Очистка тестбокса после добавления записи

                    MessageBox.Show("Запись добавлена");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void DeleteFromDepartment_Click(object sender, EventArgs e) // Удалить отдел из справочника Department
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            string notValidSymbols = "',!#$%^&*()/?+;:"; // Недопустимые символы

            try
            {
                if (notValidSymbols.Intersect(departmentDelete.Text).Any())
                {
                    MessageBox.Show("Используются недопустимые символы: ' , ! # $ % № ^ & * ( ) / ? + ; :");  // Сообщение об ошибке
                }
                else if (departmentDelete.Text == "")
                {
                    MessageBox.Show("Присутствуют незаполненные поля ввода");
                }
                else
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = $"DELETE FROM MNI.DEPARTMENT WHERE DEPARTMENT_NAME = '{departmentDelete.Text.Trim()}'"; // Удаление отдела из справочника
                    OracleDataReader reader = cmd.ExecuteReader();

                    departmentDelete.Clear(); // Очистка текстбокса после добавления записи

                    MessageBox.Show("Запись удалена");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ShowDeparment_Click(object sender, EventArgs e)  // Показать таблицу с отделами предприятия
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            try
            {
                dataGridView2.Columns.Clear(); // Очистка dataGridView
                dataGridView2.Rows.Clear();
                dataGridView2.Refresh();

                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT DEPARTMENT_NAME FROM MNI.DEPARTMENT ORDER BY DEPARTMENT_ID"; // Вывод информации по отделам
                dataGridView2.Columns.Add("depName", "Отдел"); // Добавление столбцов в таблицу

                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView2.Rows.Add(reader.GetOracleString(0)); // Добавление записей в таблицу
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void AddIntoDevice_Click(object sender, EventArgs e) // Добавить новое МНИ в справочник
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            string notValidSymbols = "',!#$%^&*()/?+;:"; // Недопустимые символы

            try
            {
                if (notValidSymbols.Intersect(mniNumber.Text).Any() || notValidSymbols.Intersect(useTime.Text).Any())
                {
                    MessageBox.Show("Используются недопустимые символы: ' , ! # $ % ^ & * ( ) / ? + ; :");  // Сообщение об ошибке
                }
                else if (mniNumber.Text == "" || useTime.Text == "")
                {
                    MessageBox.Show("Присутствуют незаполненные поля ввода");
                }
                else
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = $"INSERT INTO MNI.DEVICE (DEVICE_NAME, NUMBER_OF_HOURS, STATUS) " +
                        $"VALUES ('{mniNumber.Text.Trim()}', '{useTime.Text.Trim()}', '{status.Text}')"; // Добавление записи в справочник МНИ
                    OracleDataReader reader = cmd.ExecuteReader();

                    mniNumber.Clear(); // Очистка тестбоксов после добавления записей
                    useTime.Clear();

                    MessageBox.Show("Запись добавлена");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void DeleteFromDevice_Click(object sender, EventArgs e) // Удалить МНИ из справочника
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            string notValidSymbols = "',!#$%^&*()/?+;:"; // Недопустимые символы

            try
            {
                if (notValidSymbols.Intersect(mniNumberDelete.Text).Any())
                {
                    MessageBox.Show("Используются недопустимые символы: ' , ! # $ % № ^ & * ( ) / ? + ; :");  // Сообщение об ошибке
                }
                else if (mniNumberDelete.Text == string.Empty)
                {
                    MessageBox.Show("Присутствуют незаполненные поля ввода");
                }
                else
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = $"DELETE FROM MNI.DEVICE WHERE DEVICE_NAME = '{mniNumberDelete.Text.Trim()}'"; // Удаление МНИ из справочника
                    OracleDataReader reader = cmd.ExecuteReader();

                    mniNumberDelete.Clear(); // Очистка текстбокса после добавления записи

                    MessageBox.Show("Запись удалена");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ShowDevices_Click(object sender, EventArgs e) // Показать таблицу с данными о МНИ
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            try
            {
                dataGridView3.Columns.Clear(); // Очистка dataGridView
                dataGridView3.Rows.Clear();
                dataGridView3.Refresh();

                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT DEVICE_NAME, NUMBER_OF_HOURS, STATUS FROM MNI.DEVICE ORDER BY DEVICE_ID"; // Вывод информации по МНИ

                dataGridView3.Columns.Add("deviceName", "Номер МНИ"); // Добавление столбцов в таблицу
                dataGridView3.Columns.Add("hours", "Время использования");
                dataGridView3.Columns.Add("status", "Статус");

                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView3.Rows.Add(reader.GetOracleString(0), reader.GetOracleString(1), // Добавление записей в таблицу
                                           reader.GetOracleString(2));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void UpdateDevice_Click(object sender, EventArgs e) // Получить МНИ после использования
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            string notValidSymbols = "',!#$%^&*()/?+;:"; // Недопустимые символы

            try
            {
                if (notValidSymbols.Intersect(mniNumberUpdate.Text).Any())
                {
                    MessageBox.Show("Используются недопустимые символы: ' , ! # $ % ^ & * ( ) / ? + ; :");  // Сообщение об ошибке
                }
                else if (mniNumberUpdate.Text == "")
                {
                    MessageBox.Show("Присутствуют незаполненные поля ввода");
                }
                else
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = $"UPDATE MNI.DEVICE SET STATUS = 'Готово к выдаче' WHERE DEVICE_NAME = '{mniNumberUpdate.Text.Trim()}'"; // Изменение статуса МНИ в справочнике
                    OracleDataReader reader = cmd.ExecuteReader();

                    mniNumberUpdate.Clear(); // Очистка текстбокса

                    MessageBox.Show("МНИ получено");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ShowIssuedDevices_Click(object sender, EventArgs e)  // Показать таблицу пользователей, получивших МНИ
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            try
            {
                dataGridView5.Columns.Clear(); // Очистка dataGridView
                dataGridView5.Rows.Clear();
                dataGridView5.Refresh();

                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT DEVICE_NAME, STATUS FROM MNI.DEVICE WHERE STATUS = 'Выдано'"; // Вывод информации по МНИ, находящихся у пользователей

                dataGridView5.Columns.Add("devisename", "Номер МНИ"); // Добавление столбцов в таблицу
                dataGridView5.Columns.Add("devstatus", "Статус");

                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView5.Rows.Add(reader.GetOracleString(0), reader.GetOracleString(1)); // Добавление строк в таблицу
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void AddIntoDeviceUser_Click(object sender, EventArgs e) // Добавить в справочник DDEVICE_USER
                                                                         // сотрудников, взявших в пользование МНИ
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            string notValidSymbols = "',!#$%^&*()/?+;:"; // Недопустимые символы

            try
            {
                if (notValidSymbols.Intersect(lastNameDeviceUser.Text).Any() || notValidSymbols.Intersect(firstNameDevaceUser.Text).Any()
                    || notValidSymbols.Intersect(middleNameDeviceUser.Text).Any() || notValidSymbols.Intersect(mniNumberDeviceUser.Text).Any())
                {
                    MessageBox.Show("Используются недопустимые символы: ' , ! # $ % № ^ & * ( ) / ? + ; :");  // Сообщение об ошибке
                }
                else if (lastNameDeviceUser.Text == string.Empty || firstNameDevaceUser.Text == string.Empty 
                    || middleNameDeviceUser.Text == string.Empty || mniNumberDeviceUser.Text == string.Empty)
                {
                    MessageBox.Show("Присутствуют незаполненные поля ввода");
                }
                else
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = $"BEGIN MNI.PACKAGE1.INSERT_INTO_DEVICE_USER " +
                        $"(V_FIRST_NAME => '{firstNameDevaceUser.Text.Trim()}', V_LAST_NAME => '{lastNameDeviceUser.Text.Trim()}', " +
                        $"V_MIDDLE_NAME => '{middleNameDeviceUser.Text.Trim()}', V_DEVICE_NAME => '{mniNumberDeviceUser.Text.Trim()}', " +
                        $"V_NUMBER_OF_HOURS => '{int.Parse(useTimeDeviceUser.Text.Trim())}'); END;"; // Добавление в справочник DEVICE_USER процедурой
                    OracleDataReader reader = cmd.ExecuteReader();

                    lastNameDeviceUser.Clear(); // Очистка текстбоксов после добавления записи
                    firstNameDevaceUser.Clear();
                    middleNameDeviceUser.Clear();
                    mniNumberDeviceUser.Clear();
                    useTimeDeviceUser.Clear();

                    MessageBox.Show("МНИ выдано");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ShowDeviceUser_Click(object sender, EventArgs e) // Показать таблицу с пользователями МНИ
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            try
            {
                dataGridView4.Columns.Clear(); // Очистка dataGridView
                dataGridView4.Rows.Clear();
                dataGridView4.Refresh();

                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT pers.LAST_NAME, pers.FIRST_NAME, pers.MIDDLE_NAME, pers.COMMUNICATION, " +
                    "dep.DEPARTMENT_NAME, dev.DEVICE_NAME, to_char(devuse.DATE_TIME, 'yyyy-mm-dd HH24:MI:SS'), " +
                    "to_char(devuse.DATE_TIME_END, 'yyyy-mm-dd HH24:MI:SS'), IS_PENALTY FROM MNI.DEVICE_USER devuse " +
                    "INNER JOIN MNI.PERSON pers ON devuse.PERSON_ID = pers.PERSON_ID INNER JOIN MNI.DEVICE dev " +
                    "ON devuse.DEVICE_ID = dev.DEVICE_ID INNER JOIN MNI.DEPARTMENT dep ON dep.DEPARTMENT_ID = pers.DEPARTMENT_ID " +
                    "ORDER BY DATE_TIME DESC"; // Вывод полной информации по пользователям МНИ

                dataGridView4.Columns.Add("last", "Фамилия"); // Добавление столбцов в таблицу
                dataGridView4.Columns.Add("first", "Имя");
                dataGridView4.Columns.Add("middle", "Отчество");
                dataGridView4.Columns.Add("email", "Почта");
                dataGridView4.Columns.Add("depart", "Отдел");
                dataGridView4.Columns.Add("devname", "Номер МНИ");
                dataGridView4.Columns.Add("time", "Время выдачи");
                dataGridView4.Columns.Add("timeend", "Время возврата");
                dataGridView4.Columns.Add("penalty", "Штрафник");

                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView4.Rows.Add(reader.GetOracleString(0), reader.GetOracleString(1), // Добавление записей в таблицу
                                           reader.GetOracleString(2), reader.GetOracleString(3),
                                           reader.GetOracleString(4), reader.GetOracleString(5),
                                           reader.GetOracleString(6), reader.GetOracleString(7),
                                           reader.GetOracleString(8));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}