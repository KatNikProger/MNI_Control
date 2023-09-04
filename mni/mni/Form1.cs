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

        private void AddIntoPerson_Click(object sender, EventArgs e) // �������� ���������� � ����������
        {

            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            string notValidSymbols = "',!#$%�^&*()/?+;:"; // ������������ �������

            try
            {
                if (notValidSymbols.Intersect(lastNameAdd.Text).Any() || notValidSymbols.Intersect(firstNameAdd.Text).Any() // �������� �� ������������ �������
                    || notValidSymbols.Intersect(middleNameAdd.Text).Any() || notValidSymbols.Intersect(mailAdd.Text).Any()
                    || notValidSymbols.Intersect(departmentAdd.Text).Any())
                {
                    MessageBox.Show("������������ ������������ �������: ' , ! # $ % � ^ & * ( ) / ? + ; :");  // ��������� �� ������
                }
                else if (lastNameAdd.Text == string.Empty || firstNameAdd.Text == string.Empty || middleNameAdd.Text == string.Empty 
                    || mailAdd.Text == string.Empty || departmentAdd.Text == string.Empty)
                {
                    MessageBox.Show("������������ ������������� ���� �����");
                }
                else
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = $"BEGIN MNI.PACKAGE2.INSERT_INTO_PERSON (V_LAST_NAME => '{lastNameAdd.Text.Trim()}', " +
                        $"V_FIRST_NAME => '{firstNameAdd.Text.Trim()}', V_MIDDLE_NAME => '{middleNameAdd.Text.Trim()}', " +
                        $"V_COMMUNICATION => '{mailAdd.Text.Trim()}', V_DEPARTMENT_NAME => '{departmentAdd.Text.Trim()}' ); " +
                        $"END;"; // ���������� ���������� � ����������
                    OracleDataReader reader = cmd.ExecuteReader();

                    lastNameAdd.Clear(); // ������� ����������� ����� ���������� ������
                    firstNameAdd.Clear();
                    middleNameAdd.Clear();
                    mailAdd.Clear();
                    departmentAdd.Clear();

                    MessageBox.Show("������ ���������");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void DeleteFromPerson_Click(object sender, EventArgs e) // ������� ���������� �� ����������� Person
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            string notValidSymbols = "',!#$%�^&*()/?+;:"; // ������������ �������

            try
            {
                if (notValidSymbols.Intersect(lastNameDelete.Text).Any() || notValidSymbols.Intersect(firstNameDelete.Text).Any() // �������� �� ������������ �������
                    || notValidSymbols.Intersect(middleNameDelete.Text).Any())
                {
                    MessageBox.Show("������������ ������������ �������: ' , ! # $ % � ^ & * ( ) / ? + ; :");  // ��������� �� ������
                }
                else if (lastNameDelete.Text == "" || firstNameDelete.Text == "" || middleNameDelete.Text == "")
                {
                    MessageBox.Show("������������ ������������� ���� �����");
                }
                else
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = $"DELETE FROM MNI.PERSON WHERE LOWER(LAST_NAME) = LOWER('{lastNameDelete.Text.Trim()}') " +
                                      $"AND LOWER(FIRST_NAME) = LOWER('{firstNameDelete.Text.Trim()}') " +
                                      $"AND LOWER(MIDDLE_NAME) = LOWER('{middleNameDelete.Text.Trim()}')"; // �������� ���������� �� �����������
                    OracleDataReader reader = cmd.ExecuteReader();

                    lastNameDelete.Clear(); // ������� ����������� ����� ���������� ������
                    firstNameDelete.Clear();
                    middleNameDelete.Clear();

                    MessageBox.Show("������ �������");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ShowPersons_Click(object sender, EventArgs e) // �������� ������� �����������
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            try
            {
                dataGridView1.Columns.Clear(); // ������� dataGridView
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT LAST_NAME, FIRST_NAME, MIDDLE_NAME, COMMUNICATION, MNI.DEPARTMENT.DEPARTMENT_NAME FROM MNI.PERSON " +
                    "INNER JOIN MNI.DEPARTMENT ON MNI.DEPARTMENT.DEPARTMENT_ID = MNI.PERSON.DEPARTMENT_ID ORDER BY PERSON_ID"; // ����� ���������� �� �����������

                dataGridView1.Columns.Add("lastName", "�������"); // ���������� �������� � �������
                dataGridView1.Columns.Add("firstName", "���");
                dataGridView1.Columns.Add("middleName", "��������");
                dataGridView1.Columns.Add("email", "�����");
                dataGridView1.Columns.Add("depart", "�����");

                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetOracleString(0), reader.GetOracleString(1),  // ���������� ������� � �������
                                           reader.GetOracleString(2), reader.GetOracleString(3),
                                           reader.GetOracleString(4));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void AddIntoDepartment_Click(object sender, EventArgs e) // �������� ����� � ����������
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            string notValidSymbols = "',!#$%^&*()/?+;:"; // ������������ �������

            try
            {
                if (notValidSymbols.Intersect(departmentInsert.Text).Any())
                {
                    MessageBox.Show("������������ ������������ �������: ' , ! # $ % ^ & * ( ) / ? + ; :");  // ��������� �� ������
                }
                else if (departmentInsert.Text == "")
                {
                    MessageBox.Show("������������ ������������� ���� �����");
                }
                else
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = $"INSERT INTO MNI.DEPARTMENT (DEPARTMENT_NAME) VALUES ('{departmentInsert.Text.Trim()}')"; // ���������� ������� � ����������
                    OracleDataReader reader = cmd.ExecuteReader();

                    departmentInsert.Clear(); // ������� ��������� ����� ���������� ������

                    MessageBox.Show("������ ���������");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void DeleteFromDepartment_Click(object sender, EventArgs e) // ������� ����� �� ����������� Department
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            string notValidSymbols = "',!#$%^&*()/?+;:"; // ������������ �������

            try
            {
                if (notValidSymbols.Intersect(departmentDelete.Text).Any())
                {
                    MessageBox.Show("������������ ������������ �������: ' , ! # $ % � ^ & * ( ) / ? + ; :");  // ��������� �� ������
                }
                else if (departmentDelete.Text == "")
                {
                    MessageBox.Show("������������ ������������� ���� �����");
                }
                else
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = $"DELETE FROM MNI.DEPARTMENT WHERE DEPARTMENT_NAME = '{departmentDelete.Text.Trim()}'"; // �������� ������ �� �����������
                    OracleDataReader reader = cmd.ExecuteReader();

                    departmentDelete.Clear(); // ������� ���������� ����� ���������� ������

                    MessageBox.Show("������ �������");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ShowDeparment_Click(object sender, EventArgs e)  // �������� ������� � �������� �����������
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            try
            {
                dataGridView2.Columns.Clear(); // ������� dataGridView
                dataGridView2.Rows.Clear();
                dataGridView2.Refresh();

                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT DEPARTMENT_NAME FROM MNI.DEPARTMENT ORDER BY DEPARTMENT_ID"; // ����� ���������� �� �������
                dataGridView2.Columns.Add("depName", "�����"); // ���������� �������� � �������

                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView2.Rows.Add(reader.GetOracleString(0)); // ���������� ������� � �������
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void AddIntoDevice_Click(object sender, EventArgs e) // �������� ����� ��� � ����������
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            string notValidSymbols = "',!#$%^&*()/?+;:"; // ������������ �������

            try
            {
                if (notValidSymbols.Intersect(mniNumber.Text).Any() || notValidSymbols.Intersect(useTime.Text).Any())
                {
                    MessageBox.Show("������������ ������������ �������: ' , ! # $ % ^ & * ( ) / ? + ; :");  // ��������� �� ������
                }
                else if (mniNumber.Text == "" || useTime.Text == "")
                {
                    MessageBox.Show("������������ ������������� ���� �����");
                }
                else
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = $"INSERT INTO MNI.DEVICE (DEVICE_NAME, NUMBER_OF_HOURS, STATUS) " +
                        $"VALUES ('{mniNumber.Text.Trim()}', '{useTime.Text.Trim()}', '{status.Text}')"; // ���������� ������ � ���������� ���
                    OracleDataReader reader = cmd.ExecuteReader();

                    mniNumber.Clear(); // ������� ���������� ����� ���������� �������
                    useTime.Clear();

                    MessageBox.Show("������ ���������");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void DeleteFromDevice_Click(object sender, EventArgs e) // ������� ��� �� �����������
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            string notValidSymbols = "',!#$%^&*()/?+;:"; // ������������ �������

            try
            {
                if (notValidSymbols.Intersect(mniNumberDelete.Text).Any())
                {
                    MessageBox.Show("������������ ������������ �������: ' , ! # $ % � ^ & * ( ) / ? + ; :");  // ��������� �� ������
                }
                else if (mniNumberDelete.Text == string.Empty)
                {
                    MessageBox.Show("������������ ������������� ���� �����");
                }
                else
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = $"DELETE FROM MNI.DEVICE WHERE DEVICE_NAME = '{mniNumberDelete.Text.Trim()}'"; // �������� ��� �� �����������
                    OracleDataReader reader = cmd.ExecuteReader();

                    mniNumberDelete.Clear(); // ������� ���������� ����� ���������� ������

                    MessageBox.Show("������ �������");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ShowDevices_Click(object sender, EventArgs e) // �������� ������� � ������� � ���
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            try
            {
                dataGridView3.Columns.Clear(); // ������� dataGridView
                dataGridView3.Rows.Clear();
                dataGridView3.Refresh();

                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT DEVICE_NAME, NUMBER_OF_HOURS, STATUS FROM MNI.DEVICE ORDER BY DEVICE_ID"; // ����� ���������� �� ���

                dataGridView3.Columns.Add("deviceName", "����� ���"); // ���������� �������� � �������
                dataGridView3.Columns.Add("hours", "����� �������������");
                dataGridView3.Columns.Add("status", "������");

                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView3.Rows.Add(reader.GetOracleString(0), reader.GetOracleString(1), // ���������� ������� � �������
                                           reader.GetOracleString(2));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void UpdateDevice_Click(object sender, EventArgs e) // �������� ��� ����� �������������
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            string notValidSymbols = "',!#$%^&*()/?+;:"; // ������������ �������

            try
            {
                if (notValidSymbols.Intersect(mniNumberUpdate.Text).Any())
                {
                    MessageBox.Show("������������ ������������ �������: ' , ! # $ % ^ & * ( ) / ? + ; :");  // ��������� �� ������
                }
                else if (mniNumberUpdate.Text == "")
                {
                    MessageBox.Show("������������ ������������� ���� �����");
                }
                else
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = $"UPDATE MNI.DEVICE SET STATUS = '������ � ������' WHERE DEVICE_NAME = '{mniNumberUpdate.Text.Trim()}'"; // ��������� ������� ��� � �����������
                    OracleDataReader reader = cmd.ExecuteReader();

                    mniNumberUpdate.Clear(); // ������� ����������

                    MessageBox.Show("��� ��������");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ShowIssuedDevices_Click(object sender, EventArgs e)  // �������� ������� �������������, ���������� ���
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            try
            {
                dataGridView5.Columns.Clear(); // ������� dataGridView
                dataGridView5.Rows.Clear();
                dataGridView5.Refresh();

                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT DEVICE_NAME, STATUS FROM MNI.DEVICE WHERE STATUS = '������'"; // ����� ���������� �� ���, ����������� � �������������

                dataGridView5.Columns.Add("devisename", "����� ���"); // ���������� �������� � �������
                dataGridView5.Columns.Add("devstatus", "������");

                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView5.Rows.Add(reader.GetOracleString(0), reader.GetOracleString(1)); // ���������� ����� � �������
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void AddIntoDeviceUser_Click(object sender, EventArgs e) // �������� � ���������� DDEVICE_USER
                                                                         // �����������, ������� � ����������� ���
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            string notValidSymbols = "',!#$%^&*()/?+;:"; // ������������ �������

            try
            {
                if (notValidSymbols.Intersect(lastNameDeviceUser.Text).Any() || notValidSymbols.Intersect(firstNameDevaceUser.Text).Any()
                    || notValidSymbols.Intersect(middleNameDeviceUser.Text).Any() || notValidSymbols.Intersect(mniNumberDeviceUser.Text).Any())
                {
                    MessageBox.Show("������������ ������������ �������: ' , ! # $ % � ^ & * ( ) / ? + ; :");  // ��������� �� ������
                }
                else if (lastNameDeviceUser.Text == string.Empty || firstNameDevaceUser.Text == string.Empty 
                    || middleNameDeviceUser.Text == string.Empty || mniNumberDeviceUser.Text == string.Empty)
                {
                    MessageBox.Show("������������ ������������� ���� �����");
                }
                else
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = $"BEGIN MNI.PACKAGE1.INSERT_INTO_DEVICE_USER " +
                        $"(V_FIRST_NAME => '{firstNameDevaceUser.Text.Trim()}', V_LAST_NAME => '{lastNameDeviceUser.Text.Trim()}', " +
                        $"V_MIDDLE_NAME => '{middleNameDeviceUser.Text.Trim()}', V_DEVICE_NAME => '{mniNumberDeviceUser.Text.Trim()}', " +
                        $"V_NUMBER_OF_HOURS => '{int.Parse(useTimeDeviceUser.Text.Trim())}'); END;"; // ���������� � ���������� DEVICE_USER ����������
                    OracleDataReader reader = cmd.ExecuteReader();

                    lastNameDeviceUser.Clear(); // ������� ����������� ����� ���������� ������
                    firstNameDevaceUser.Clear();
                    middleNameDeviceUser.Clear();
                    mniNumberDeviceUser.Clear();
                    useTimeDeviceUser.Clear();

                    MessageBox.Show("��� ������");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ShowDeviceUser_Click(object sender, EventArgs e) // �������� ������� � �������������� ���
        {
            SqlConnectionString connectionString = new SqlConnectionString();

            OracleConnection con = new OracleConnection(connectionString.GetConnectionStringByName("DB"));

            con.Open();

            try
            {
                dataGridView4.Columns.Clear(); // ������� dataGridView
                dataGridView4.Rows.Clear();
                dataGridView4.Refresh();

                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT pers.LAST_NAME, pers.FIRST_NAME, pers.MIDDLE_NAME, pers.COMMUNICATION, " +
                    "dep.DEPARTMENT_NAME, dev.DEVICE_NAME, to_char(devuse.DATE_TIME, 'yyyy-mm-dd HH24:MI:SS'), " +
                    "to_char(devuse.DATE_TIME_END, 'yyyy-mm-dd HH24:MI:SS'), IS_PENALTY FROM MNI.DEVICE_USER devuse " +
                    "INNER JOIN MNI.PERSON pers ON devuse.PERSON_ID = pers.PERSON_ID INNER JOIN MNI.DEVICE dev " +
                    "ON devuse.DEVICE_ID = dev.DEVICE_ID INNER JOIN MNI.DEPARTMENT dep ON dep.DEPARTMENT_ID = pers.DEPARTMENT_ID " +
                    "ORDER BY DATE_TIME DESC"; // ����� ������ ���������� �� ������������� ���

                dataGridView4.Columns.Add("last", "�������"); // ���������� �������� � �������
                dataGridView4.Columns.Add("first", "���");
                dataGridView4.Columns.Add("middle", "��������");
                dataGridView4.Columns.Add("email", "�����");
                dataGridView4.Columns.Add("depart", "�����");
                dataGridView4.Columns.Add("devname", "����� ���");
                dataGridView4.Columns.Add("time", "����� ������");
                dataGridView4.Columns.Add("timeend", "����� ��������");
                dataGridView4.Columns.Add("penalty", "��������");

                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView4.Rows.Add(reader.GetOracleString(0), reader.GetOracleString(1), // ���������� ������� � �������
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