namespace Mni
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage4 = new TabPage();
            useTimeDeviceUser = new TextBox();
            label33 = new Label();
            ShowIssuedDevices = new Button();
            label23 = new Label();
            dataGridView5 = new DataGridView();
            label18 = new Label();
            UpdateDevice = new Button();
            mniNumberUpdate = new TextBox();
            lastNameDeviceUser = new TextBox();
            firstNameDevaceUser = new TextBox();
            middleNameDeviceUser = new TextBox();
            mniNumberDeviceUser = new TextBox();
            label24 = new Label();
            label16 = new Label();
            ShowDeviceUser = new Button();
            label17 = new Label();
            dataGridView4 = new DataGridView();
            AddIntoDeviceUser = new Button();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            tabPage3 = new TabPage();
            label29 = new Label();
            DeleteFromDevice = new Button();
            mniNumberDelete = new TextBox();
            label28 = new Label();
            status = new ComboBox();
            ShowDevices = new Button();
            label15 = new Label();
            dataGridView3 = new DataGridView();
            label11 = new Label();
            AddIntoDevice = new Button();
            mniNumber = new TextBox();
            useTime = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            tabPage2 = new TabPage();
            label30 = new Label();
            DeleteFromDepartment = new Button();
            departmentDelete = new TextBox();
            label31 = new Label();
            label10 = new Label();
            ShowDeparment = new Button();
            label8 = new Label();
            dataGridView2 = new DataGridView();
            AddIntoDepartment = new Button();
            departmentInsert = new TextBox();
            label7 = new Label();
            tabPage1 = new TabPage();
            label32 = new Label();
            middleNameDelete = new TextBox();
            firstNameDelete = new TextBox();
            lastNameDelete = new TextBox();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            DeleteFromPerson = new Button();
            label9 = new Label();
            ShowPersons = new Button();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            AddIntoPerson = new Button();
            departmentAdd = new TextBox();
            mailAdd = new TextBox();
            middleNameAdd = new TextBox();
            firstNameAdd = new TextBox();
            lastNameAdd = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(useTimeDeviceUser);
            tabPage4.Controls.Add(label33);
            tabPage4.Controls.Add(ShowIssuedDevices);
            tabPage4.Controls.Add(label23);
            tabPage4.Controls.Add(dataGridView5);
            tabPage4.Controls.Add(label18);
            tabPage4.Controls.Add(UpdateDevice);
            tabPage4.Controls.Add(mniNumberUpdate);
            tabPage4.Controls.Add(lastNameDeviceUser);
            tabPage4.Controls.Add(firstNameDevaceUser);
            tabPage4.Controls.Add(middleNameDeviceUser);
            tabPage4.Controls.Add(mniNumberDeviceUser);
            tabPage4.Controls.Add(label24);
            tabPage4.Controls.Add(label16);
            tabPage4.Controls.Add(ShowDeviceUser);
            tabPage4.Controls.Add(label17);
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.Controls.Add(AddIntoDeviceUser);
            tabPage4.Controls.Add(label19);
            tabPage4.Controls.Add(label20);
            tabPage4.Controls.Add(label21);
            tabPage4.Controls.Add(label22);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(880, 661);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Учет МНИ";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox19
            // 
            useTimeDeviceUser.Location = new Point(186, 177);
            useTimeDeviceUser.Name = "textBox19";
            useTimeDeviceUser.Size = new Size(560, 27);
            useTimeDeviceUser.TabIndex = 38;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(14, 181);
            label33.Name = "label33";
            label33.Size = new Size(166, 20);
            label33.TabIndex = 37;
            label33.Text = "Время использования";
            // 
            // ShowIssuedDevices
            // 
            ShowIssuedDevices.Location = new Point(241, 292);
            ShowIssuedDevices.Name = "ShowIssuedDevices";
            ShowIssuedDevices.Size = new Size(120, 28);
            ShowIssuedDevices.TabIndex = 36;
            ShowIssuedDevices.Text = "Показать";
            ShowIssuedDevices.UseVisualStyleBackColor = true;
            ShowIssuedDevices.Click += ShowIssuedDevices_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(14, 296);
            label23.Name = "label23";
            label23.Size = new Size(181, 20);
            label23.TabIndex = 35;
            label23.Text = "Список выданных МНИ";
            // 
            // dataGridView5
            // 
            dataGridView5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView5.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(3, 326);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 51;
            dataGridView5.RowTemplate.Height = 29;
            dataGridView5.Size = new Size(874, 118);
            dataGridView5.TabIndex = 34;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(14, 222);
            label18.Name = "label18";
            label18.Size = new Size(171, 20);
            label18.TabIndex = 33;
            label18.Text = "Форма возврата МНИ";
            // 
            // UpdateDevice
            // 
            UpdateDevice.Location = new Point(757, 254);
            UpdateDevice.Name = "UpdateDevice";
            UpdateDevice.Size = new Size(120, 28);
            UpdateDevice.TabIndex = 32;
            UpdateDevice.Text = "Получить";
            UpdateDevice.UseVisualStyleBackColor = true;
            UpdateDevice.Click += UpdateDevice_Click;
            // 
            // textBox10
            // 
            mniNumberUpdate.Location = new Point(186, 254);
            mniNumberUpdate.Name = "textBox10";
            mniNumberUpdate.Size = new Size(560, 27);
            mniNumberUpdate.TabIndex = 31;
            // 
            // textBox11
            // 
            lastNameDeviceUser.Location = new Point(186, 45);
            lastNameDeviceUser.Name = "textBox11";
            lastNameDeviceUser.Size = new Size(560, 27);
            lastNameDeviceUser.TabIndex = 23;
            // 
            // textBox12
            // 
            firstNameDevaceUser.Location = new Point(186, 78);
            firstNameDevaceUser.Name = "textBox12";
            firstNameDevaceUser.Size = new Size(560, 27);
            firstNameDevaceUser.TabIndex = 22;
            // 
            // textBox13
            // 
            middleNameDeviceUser.Location = new Point(186, 111);
            middleNameDeviceUser.Name = "textBox13";
            middleNameDeviceUser.Size = new Size(560, 27);
            middleNameDeviceUser.TabIndex = 21;
            // 
            // textBox14
            // 
            mniNumberDeviceUser.Location = new Point(186, 144);
            mniNumberDeviceUser.Name = "textBox14";
            mniNumberDeviceUser.Size = new Size(560, 27);
            mniNumberDeviceUser.TabIndex = 20;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(14, 258);
            label24.Name = "label24";
            label24.Size = new Size(96, 20);
            label24.TabIndex = 30;
            label24.Text = "Номер МНИ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(12, 9);
            label16.Name = "label16";
            label16.Size = new Size(161, 20);
            label16.TabIndex = 29;
            label16.Text = "Форма выдачи МНИ";
            // 
            // ShowDeviceUser
            // 
            ShowDeviceUser.Location = new Point(241, 450);
            ShowDeviceUser.Name = "ShowDeviceUser";
            ShowDeviceUser.Size = new Size(120, 28);
            ShowDeviceUser.TabIndex = 28;
            ShowDeviceUser.Text = "Показать";
            ShowDeviceUser.UseVisualStyleBackColor = true;
            ShowDeviceUser.Click += ShowDeviceUser_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(10, 454);
            label17.Name = "label17";
            label17.Size = new Size(214, 20);
            label17.TabIndex = 27;
            label17.Text = "Список пользователей МНИ";
            // 
            // dataGridView4
            // 
            dataGridView4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView4.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(3, 484);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 29;
            dataGridView4.Size = new Size(874, 174);
            dataGridView4.TabIndex = 26;
            // 
            // AddIntoDeviceUser
            // 
            AddIntoDeviceUser.Location = new Point(757, 44);
            AddIntoDeviceUser.Name = "AddIntoDeviceUser";
            AddIntoDeviceUser.Size = new Size(120, 28);
            AddIntoDeviceUser.TabIndex = 25;
            AddIntoDeviceUser.Text = "Выдать";
            AddIntoDeviceUser.UseVisualStyleBackColor = true;
            AddIntoDeviceUser.Click += AddIntoDeviceUser_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(12, 147);
            label19.Name = "label19";
            label19.Size = new Size(96, 20);
            label19.TabIndex = 18;
            label19.Text = "Номер МНИ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(12, 114);
            label20.Name = "label20";
            label20.Size = new Size(72, 20);
            label20.TabIndex = 17;
            label20.Text = "Отчество";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(12, 81);
            label21.Name = "label21";
            label21.Size = new Size(39, 20);
            label21.TabIndex = 16;
            label21.Text = "Имя";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(12, 47);
            label22.Name = "label22";
            label22.Size = new Size(73, 20);
            label22.TabIndex = 15;
            label22.Text = "Фамилия";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label29);
            tabPage3.Controls.Add(DeleteFromDevice);
            tabPage3.Controls.Add(mniNumberDelete);
            tabPage3.Controls.Add(label28);
            tabPage3.Controls.Add(status);
            tabPage3.Controls.Add(ShowDevices);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(AddIntoDevice);
            tabPage3.Controls.Add(mniNumber);
            tabPage3.Controls.Add(useTime);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(label14);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(880, 661);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "МНИ";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label29.Location = new Point(28, 177);
            label29.Name = "label29";
            label29.Size = new Size(245, 20);
            label29.TabIndex = 30;
            label29.Text = "Форма удаления МНИ из списка";
            // 
            // DeleteFromDevice
            // 
            DeleteFromDevice.Location = new Point(752, 209);
            DeleteFromDevice.Name = "DeleteFromDevice";
            DeleteFromDevice.Size = new Size(120, 28);
            DeleteFromDevice.TabIndex = 29;
            DeleteFromDevice.Text = "Удалить";
            DeleteFromDevice.UseVisualStyleBackColor = true;
            DeleteFromDevice.Click += DeleteFromDevice_Click;
            // 
            // textBox17
            // 
            mniNumberDelete.Location = new Point(135, 209);
            mniNumberDelete.Name = "textBox17";
            mniNumberDelete.Size = new Size(611, 27);
            mniNumberDelete.TabIndex = 28;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(28, 211);
            label28.Name = "label28";
            label28.Size = new Size(96, 20);
            label28.TabIndex = 27;
            label28.Text = "Номер МНИ";
            // 
            // comboBox2
            // 
            status.FormattingEnabled = true;
            status.Items.AddRange(new object[] { "Готово к выдаче", "Выдано" });
            status.Location = new Point(135, 116);
            status.Name = "comboBox2";
            status.Size = new Size(611, 28);
            status.TabIndex = 26;
            // 
            // ShowDevices
            // 
            ShowDevices.Location = new Point(752, 274);
            ShowDevices.Name = "ShowDevices";
            ShowDevices.Size = new Size(120, 28);
            ShowDevices.TabIndex = 25;
            ShowDevices.Text = "Показать";
            ShowDevices.UseVisualStyleBackColor = true;
            ShowDevices.Click += ShowDevices_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(23, 278);
            label15.Name = "label15";
            label15.Size = new Size(169, 20);
            label15.TabIndex = 24;
            label15.Text = "Показать список МНИ";
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView3.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(0, 308);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(877, 353);
            dataGridView3.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(28, 14);
            label11.Name = "label11";
            label11.Size = new Size(259, 20);
            label11.TabIndex = 22;
            label11.Text = "Форма добавления МНИ в список";
            // 
            // AddIntoDevice
            // 
            AddIntoDevice.Location = new Point(752, 50);
            AddIntoDevice.Name = "AddIntoDevice";
            AddIntoDevice.Size = new Size(120, 28);
            AddIntoDevice.TabIndex = 21;
            AddIntoDevice.Text = "Добавить";
            AddIntoDevice.UseVisualStyleBackColor = true;
            AddIntoDevice.Click += AddIntoDevice_Click;
            // 
            // textBox7
            // 
            mniNumber.Location = new Point(135, 50);
            mniNumber.Name = "textBox7";
            mniNumber.Size = new Size(611, 27);
            mniNumber.TabIndex = 20;
            // 
            // textBox8
            // 
            useTime.Location = new Point(135, 83);
            useTime.Name = "textBox8";
            useTime.Size = new Size(611, 27);
            useTime.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(28, 119);
            label12.Name = "label12";
            label12.Size = new Size(52, 20);
            label12.TabIndex = 17;
            label12.Text = "Статус";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(28, 86);
            label13.Name = "label13";
            label13.Size = new Size(86, 20);
            label13.TabIndex = 16;
            label13.Text = "Время исп.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(28, 52);
            label14.Name = "label14";
            label14.Size = new Size(96, 20);
            label14.TabIndex = 15;
            label14.Text = "Номер МНИ";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label30);
            tabPage2.Controls.Add(DeleteFromDepartment);
            tabPage2.Controls.Add(departmentDelete);
            tabPage2.Controls.Add(label31);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(ShowDeparment);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(AddIntoDepartment);
            tabPage2.Controls.Add(departmentInsert);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(880, 661);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Отделы";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label30.Location = new Point(24, 113);
            label30.Name = "label30";
            label30.Size = new Size(258, 20);
            label30.TabIndex = 21;
            label30.Text = "Форма удаления отдела из списка";
            // 
            // DeleteFromDepartment
            // 
            DeleteFromDepartment.Location = new Point(752, 144);
            DeleteFromDepartment.Name = "DeleteFromDepartment";
            DeleteFromDepartment.Size = new Size(120, 28);
            DeleteFromDepartment.TabIndex = 20;
            DeleteFromDepartment.Text = "Удалить";
            DeleteFromDepartment.UseVisualStyleBackColor = true;
            DeleteFromDepartment.Click += DeleteFromDepartment_Click;
            // 
            // textBox18
            // 
            departmentDelete.Location = new Point(158, 144);
            departmentDelete.Name = "textBox18";
            departmentDelete.Size = new Size(588, 27);
            departmentDelete.TabIndex = 19;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(24, 148);
            label31.Name = "label31";
            label31.Size = new Size(128, 20);
            label31.TabIndex = 18;
            label31.Text = "Название отдела";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(24, 14);
            label10.Name = "label10";
            label10.Size = new Size(272, 20);
            label10.TabIndex = 17;
            label10.Text = "Форма добавления отдела в список";
            // 
            // ShowDeparment
            // 
            ShowDeparment.Location = new Point(752, 216);
            ShowDeparment.Name = "ShowDeparment";
            ShowDeparment.Size = new Size(120, 28);
            ShowDeparment.TabIndex = 16;
            ShowDeparment.Text = "Показать";
            ShowDeparment.UseVisualStyleBackColor = true;
            ShowDeparment.Click += ShowDeparment_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(24, 220);
            label8.Name = "label8";
            label8.Size = new Size(192, 20);
            label8.TabIndex = 15;
            label8.Text = "Показать список отделов";
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 250);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(869, 408);
            dataGridView2.TabIndex = 14;
            // 
            // AddIntoDepartment
            // 
            AddIntoDepartment.Location = new Point(752, 47);
            AddIntoDepartment.Name = "AddIntoDepartment";
            AddIntoDepartment.Size = new Size(120, 28);
            AddIntoDepartment.TabIndex = 13;
            AddIntoDepartment.Text = "Добавить";
            AddIntoDepartment.UseVisualStyleBackColor = true;
            AddIntoDepartment.Click += AddIntoDepartment_Click;
            // 
            // textBox6
            // 
            departmentInsert.Location = new Point(158, 47);
            departmentInsert.Name = "textBox6";
            departmentInsert.Size = new Size(588, 27);
            departmentInsert.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 51);
            label7.Name = "label7";
            label7.Size = new Size(128, 20);
            label7.TabIndex = 11;
            label7.Text = "Название отдела";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label32);
            tabPage1.Controls.Add(middleNameDelete);
            tabPage1.Controls.Add(firstNameDelete);
            tabPage1.Controls.Add(lastNameDelete);
            tabPage1.Controls.Add(label25);
            tabPage1.Controls.Add(label26);
            tabPage1.Controls.Add(label27);
            tabPage1.Controls.Add(DeleteFromPerson);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(ShowPersons);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(AddIntoPerson);
            tabPage1.Controls.Add(departmentAdd);
            tabPage1.Controls.Add(mailAdd);
            tabPage1.Controls.Add(middleNameAdd);
            tabPage1.Controls.Add(firstNameAdd);
            tabPage1.Controls.Add(lastNameAdd);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(880, 661);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Сотрудники";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label32.Location = new Point(464, 12);
            label32.Name = "label32";
            label32.Size = new Size(300, 20);
            label32.TabIndex = 22;
            label32.Text = "Форма удаления сотрудников из списка";
            // 
            // textBox9
            // 
            middleNameDelete.Location = new Point(542, 114);
            middleNameDelete.Name = "textBox9";
            middleNameDelete.Size = new Size(330, 27);
            middleNameDelete.TabIndex = 21;
            // 
            // textBox15
            // 
            firstNameDelete.Location = new Point(542, 81);
            firstNameDelete.Name = "textBox15";
            firstNameDelete.Size = new Size(330, 27);
            firstNameDelete.TabIndex = 20;
            // 
            // textBox16
            // 
            lastNameDelete.Location = new Point(542, 48);
            lastNameDelete.Name = "textBox16";
            lastNameDelete.Size = new Size(330, 27);
            lastNameDelete.TabIndex = 19;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(464, 117);
            label25.Name = "label25";
            label25.Size = new Size(72, 20);
            label25.TabIndex = 18;
            label25.Text = "Отчество";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(464, 84);
            label26.Name = "label26";
            label26.Size = new Size(39, 20);
            label26.TabIndex = 17;
            label26.Text = "Имя";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(464, 51);
            label27.Name = "label27";
            label27.Size = new Size(73, 20);
            label27.TabIndex = 16;
            label27.Text = "Фамилия";
            // 
            // DeleteFromPerson
            // 
            DeleteFromPerson.Location = new Point(752, 147);
            DeleteFromPerson.Name = "DeleteFromPerson";
            DeleteFromPerson.Size = new Size(120, 28);
            DeleteFromPerson.TabIndex = 15;
            DeleteFromPerson.Text = "Удалить";
            DeleteFromPerson.UseVisualStyleBackColor = true;
            DeleteFromPerson.Click += DeleteFromPerson_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(33, 12);
            label9.Name = "label9";
            label9.Size = new Size(314, 20);
            label9.TabIndex = 14;
            label9.Text = "Форма добавления сотрудников в список";
            // 
            // ShowPersons
            // 
            ShowPersons.Location = new Point(752, 253);
            ShowPersons.Name = "ShowPersons";
            ShowPersons.Size = new Size(120, 28);
            ShowPersons.TabIndex = 13;
            ShowPersons.Text = "Показать";
            ShowPersons.UseVisualStyleBackColor = true;
            ShowPersons.Click += ShowPersons_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(27, 261);
            label6.Name = "label6";
            label6.Size = new Size(224, 20);
            label6.TabIndex = 12;
            label6.Text = "Показать список сотрудников";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 287);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(874, 371);
            dataGridView1.TabIndex = 11;
            // 
            // AddIntoPerson
            // 
            AddIntoPerson.Location = new Point(321, 213);
            AddIntoPerson.Name = "AddIntoPerson";
            AddIntoPerson.Size = new Size(120, 28);
            AddIntoPerson.TabIndex = 10;
            AddIntoPerson.Text = "Добавить";
            AddIntoPerson.UseVisualStyleBackColor = true;
            AddIntoPerson.Click += AddIntoPerson_Click;
            // 
            // textBox5
            // 
            departmentAdd.Location = new Point(111, 180);
            departmentAdd.Name = "textBox5";
            departmentAdd.Size = new Size(330, 27);
            departmentAdd.TabIndex = 9;
            // 
            // textBox4
            // 
            mailAdd.Location = new Point(111, 147);
            mailAdd.Name = "textBox4";
            mailAdd.Size = new Size(330, 27);
            mailAdd.TabIndex = 8;
            // 
            // textBox3
            // 
            middleNameAdd.Location = new Point(111, 114);
            middleNameAdd.Name = "textBox3";
            middleNameAdd.Size = new Size(330, 27);
            middleNameAdd.TabIndex = 7;
            // 
            // textBox2
            // 
            firstNameAdd.Location = new Point(111, 81);
            firstNameAdd.Name = "textBox2";
            firstNameAdd.Size = new Size(330, 27);
            firstNameAdd.TabIndex = 6;
            // 
            // textBox1
            // 
            lastNameAdd.Location = new Point(111, 48);
            lastNameAdd.Name = "textBox1";
            lastNameAdd.Size = new Size(330, 27);
            lastNameAdd.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 183);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 4;
            label5.Text = "Отдел";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 150);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 3;
            label4.Text = "Почта";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 117);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Отчество";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 84);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Имя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 50);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Фамилия";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(888, 694);
            tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 694);
            Controls.Add(tabControl1);
            MinimumSize = new Size(906, 741);
            Name = "Form1";
            Text = "Контроль и учет МНИ";
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage4;
        private Button ShowIssuedDevices;
        private Label label23;
        private DataGridView dataGridView5;
        private Label label18;
        private Button UpdateDevice;
        private TextBox mniNumberUpdate;
        private TextBox lastNameDeviceUser;
        private TextBox firstNameDevaceUser;
        private TextBox middleNameDeviceUser;
        private TextBox mniNumberDeviceUser;
        private Label label24;
        private Label label16;
        private Button ShowDeviceUser;
        private Label label17;
        private DataGridView dataGridView4;
        private Button AddIntoDeviceUser;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private TabPage tabPage3;
        private ComboBox status;
        private Button ShowDevices;
        private Label label15;
        private DataGridView dataGridView3;
        private Label label11;
        private Button AddIntoDevice;
        private TextBox mniNumber;
        private TextBox useTime;
        private Label label12;
        private Label label13;
        private Label label14;
        private TabPage tabPage2;
        private Label label10;
        private Button ShowDeparment;
        private Label label8;
        private DataGridView dataGridView2;
        private Button AddIntoDepartment;
        private TextBox departmentInsert;
        private Label label7;
        private TabPage tabPage1;
        private Label label9;
        private Button ShowPersons;
        private Label label6;
        private DataGridView dataGridView1;
        private Button AddIntoPerson;
        private TextBox departmentAdd;
        private TextBox mailAdd;
        private TextBox middleNameAdd;
        private TextBox firstNameAdd;
        private TextBox lastNameAdd;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabControl tabControl1;
        private Button DeleteFromPerson;
        private Button DeleteFromDevice;
        private TextBox mniNumberDelete;
        private Label label28;
        private TextBox middleNameDelete;
        private TextBox firstNameDelete;
        private TextBox lastNameDelete;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label29;
        private Label label30;
        private Button DeleteFromDepartment;
        private TextBox departmentDelete;
        private Label label31;
        private Label label32;
        private TextBox useTimeDeviceUser;
        private Label label33;
    }
}