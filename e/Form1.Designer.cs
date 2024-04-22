
namespace Normirovanie
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label13;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DataKemz_dataGridView = new System.Windows.Forms.DataGridView();
            this.ID_DataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_DataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistrictName_DataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.users_DataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkColumn_DataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStart_DataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeEnd_DataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTime_DataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_DataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timeStartCheck_Picker = new System.Windows.Forms.DateTimePicker();
            this.AddButton = new System.Windows.Forms.Button();
            this.timeEndCheck_Picker = new System.Windows.Forms.DateTimePicker();
            this.deleteButton = new System.Windows.Forms.Button();
            this.Description_textBox = new System.Windows.Forms.TextBox();
            this.Work_textBox = new System.Windows.Forms.TextBox();
            this.SearchTextBoxID = new System.Windows.Forms.TextBox();
            this.WorkSearch_TextBox = new System.Windows.Forms.TextBox();
            this.SearchDistrict_ComboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.workTime_textBox = new System.Windows.Forms.TextBox();
            this.NoTime_checkBox = new System.Windows.Forms.CheckBox();
            this.edit_Button = new System.Windows.Forms.Button();
            this.district_comboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TimeBegin_TimePicker_Search = new System.Windows.Forms.DateTimePicker();
            this.TimeEnd_TimePicker_Search = new System.Windows.Forms.DateTimePicker();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchByTime_checkBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Users_comboBox = new System.Windows.Forms.ComboBox();
            this.BreakTime_CheckBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ClearAll_Button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SearchUser_ComboBox = new System.Windows.Forms.ComboBox();
            this.BreakTime_TextBox = new System.Windows.Forms.TextBox();
            this.colour_ComboBox = new System.Windows.Forms.ComboBox();
            this.copyButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataKemz_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(17, 22);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Работа: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(350, 22);
            label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(56, 20);
            label3.TabIndex = 5;
            label3.Text = "Дата: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(350, 74);
            label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(141, 20);
            label4.TabIndex = 6;
            label4.Text = "Время проверки: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(18, 82);
            label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(79, 20);
            label5.TabIndex = 14;
            label5.Text = "Участок: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 793);
            label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 20);
            label2.TabIndex = 26;
            label2.Text = "Поиск по ID";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(795, 793);
            label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label.Name = "label";
            label.Size = new System.Drawing.Size(138, 20);
            label.TabIndex = 28;
            label.Text = "Поиск по участку";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(581, 793);
            label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(135, 20);
            label8.TabIndex = 29;
            label8.Text = "Поиск по работе";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(18, 140);
            label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(85, 20);
            label6.TabIndex = 47;
            label6.Text = "Работник:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(1000, 793);
            label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(159, 20);
            label13.TabIndex = 50;
            label13.Text = "Поиск по работнику";
            // 
            // DataKemz_dataGridView
            // 
            this.DataKemz_dataGridView.AllowUserToAddRows = false;
            this.DataKemz_dataGridView.AllowUserToDeleteRows = false;
            this.DataKemz_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataKemz_dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataKemz_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataKemz_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_DataGridViewTextBox,
            this.Date_DataGridViewTextBox,
            this.DistrictName_DataGridViewTextBox,
            this.users_DataGridViewTextBox,
            this.WorkColumn_DataGridViewTextBox,
            this.TimeStart_DataGridViewTextBox,
            this.TimeEnd_DataGridViewTextBox,
            this.TotalTime_DataGridViewTextBox,
            this.desc_DataGridViewTextBox});
            this.DataKemz_dataGridView.Location = new System.Drawing.Point(18, 236);
            this.DataKemz_dataGridView.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DataKemz_dataGridView.Name = "DataKemz_dataGridView";
            this.DataKemz_dataGridView.ReadOnly = true;
            this.DataKemz_dataGridView.RowHeadersVisible = false;
            this.DataKemz_dataGridView.RowHeadersWidth = 51;
            this.DataKemz_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataKemz_dataGridView.Size = new System.Drawing.Size(1479, 546);
            this.DataKemz_dataGridView.TabIndex = 0;
            this.DataKemz_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKemz_dataGridView_CellClick_1);
            this.DataKemz_dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataKemz_dataGridView_CellMouseClick);
            this.DataKemz_dataGridView.ColumnSortModeChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.DataKemz_dataGridView_ColumnSortModeChanged);
            this.DataKemz_dataGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataKemz_dataGridView_KeyUp);
            // 
            // ID_DataGridViewTextBox
            // 
            this.ID_DataGridViewTextBox.DataPropertyName = "ID";
            this.ID_DataGridViewTextBox.FillWeight = 4.743856F;
            this.ID_DataGridViewTextBox.HeaderText = "ID";
            this.ID_DataGridViewTextBox.MinimumWidth = 6;
            this.ID_DataGridViewTextBox.Name = "ID_DataGridViewTextBox";
            this.ID_DataGridViewTextBox.ReadOnly = true;
            this.ID_DataGridViewTextBox.Width = 50;
            // 
            // Date_DataGridViewTextBox
            // 
            this.Date_DataGridViewTextBox.DataPropertyName = "CheckDate";
            this.Date_DataGridViewTextBox.FillWeight = 219.114F;
            this.Date_DataGridViewTextBox.HeaderText = "Дата проверки";
            this.Date_DataGridViewTextBox.MinimumWidth = 6;
            this.Date_DataGridViewTextBox.Name = "Date_DataGridViewTextBox";
            this.Date_DataGridViewTextBox.ReadOnly = true;
            this.Date_DataGridViewTextBox.Width = 80;
            // 
            // DistrictName_DataGridViewTextBox
            // 
            this.DistrictName_DataGridViewTextBox.DataPropertyName = "District";
            this.DistrictName_DataGridViewTextBox.HeaderText = "Участок";
            this.DistrictName_DataGridViewTextBox.MinimumWidth = 6;
            this.DistrictName_DataGridViewTextBox.Name = "DistrictName_DataGridViewTextBox";
            this.DistrictName_DataGridViewTextBox.ReadOnly = true;
            this.DistrictName_DataGridViewTextBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DistrictName_DataGridViewTextBox.Width = 150;
            // 
            // users_DataGridViewTextBox
            // 
            this.users_DataGridViewTextBox.DataPropertyName = "User";
            this.users_DataGridViewTextBox.HeaderText = "ФИО";
            this.users_DataGridViewTextBox.Name = "users_DataGridViewTextBox";
            this.users_DataGridViewTextBox.ReadOnly = true;
            // 
            // WorkColumn_DataGridViewTextBox
            // 
            this.WorkColumn_DataGridViewTextBox.DataPropertyName = "Job";
            this.WorkColumn_DataGridViewTextBox.FillWeight = 76.14214F;
            this.WorkColumn_DataGridViewTextBox.HeaderText = "Работа";
            this.WorkColumn_DataGridViewTextBox.MinimumWidth = 6;
            this.WorkColumn_DataGridViewTextBox.Name = "WorkColumn_DataGridViewTextBox";
            this.WorkColumn_DataGridViewTextBox.ReadOnly = true;
            this.WorkColumn_DataGridViewTextBox.Width = 350;
            // 
            // TimeStart_DataGridViewTextBox
            // 
            this.TimeStart_DataGridViewTextBox.DataPropertyName = "StartCheckDate";
            this.TimeStart_DataGridViewTextBox.HeaderText = "Время (начало)";
            this.TimeStart_DataGridViewTextBox.MinimumWidth = 6;
            this.TimeStart_DataGridViewTextBox.Name = "TimeStart_DataGridViewTextBox";
            this.TimeStart_DataGridViewTextBox.ReadOnly = true;
            // 
            // TimeEnd_DataGridViewTextBox
            // 
            this.TimeEnd_DataGridViewTextBox.DataPropertyName = "EndCheckDate";
            this.TimeEnd_DataGridViewTextBox.HeaderText = "Время (конец)";
            this.TimeEnd_DataGridViewTextBox.MinimumWidth = 6;
            this.TimeEnd_DataGridViewTextBox.Name = "TimeEnd_DataGridViewTextBox";
            this.TimeEnd_DataGridViewTextBox.ReadOnly = true;
            // 
            // TotalTime_DataGridViewTextBox
            // 
            this.TotalTime_DataGridViewTextBox.DataPropertyName = "WorkTime";
            this.TotalTime_DataGridViewTextBox.HeaderText = "Итого времени (мин.)";
            this.TotalTime_DataGridViewTextBox.MinimumWidth = 6;
            this.TotalTime_DataGridViewTextBox.Name = "TotalTime_DataGridViewTextBox";
            this.TotalTime_DataGridViewTextBox.ReadOnly = true;
            this.TotalTime_DataGridViewTextBox.Width = 60;
            // 
            // desc_DataGridViewTextBox
            // 
            this.desc_DataGridViewTextBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desc_DataGridViewTextBox.DataPropertyName = "Description";
            this.desc_DataGridViewTextBox.HeaderText = "Примечания";
            this.desc_DataGridViewTextBox.MinimumWidth = 6;
            this.desc_DataGridViewTextBox.Name = "desc_DataGridViewTextBox";
            this.desc_DataGridViewTextBox.ReadOnly = true;
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(354, 45);
            this.datePicker.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.datePicker.MinDate = new System.DateTime(1902, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(347, 26);
            this.datePicker.TabIndex = 7;
            this.ToolTip.SetToolTip(this.datePicker, "Выберете дату");
            // 
            // timeStartCheck_Picker
            // 
            this.timeStartCheck_Picker.CustomFormat = "HH:mm";
            this.timeStartCheck_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeStartCheck_Picker.Location = new System.Drawing.Point(354, 99);
            this.timeStartCheck_Picker.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.timeStartCheck_Picker.Name = "timeStartCheck_Picker";
            this.timeStartCheck_Picker.ShowUpDown = true;
            this.timeStartCheck_Picker.Size = new System.Drawing.Size(166, 26);
            this.timeStartCheck_Picker.TabIndex = 8;
            this.ToolTip.SetToolTip(this.timeStartCheck_Picker, "Время начала проверки");
            this.timeStartCheck_Picker.Value = new System.DateTime(2024, 3, 21, 0, 0, 0, 0);
            this.timeStartCheck_Picker.ValueChanged += new System.EventHandler(this.timeStartCheckPicker_ValueChanged);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddButton.Location = new System.Drawing.Point(1248, 112);
            this.AddButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 78);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "➕ Добавить";
            this.ToolTip.SetToolTip(this.AddButton, "Добавить новую строку из полей");
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // timeEndCheck_Picker
            // 
            this.timeEndCheck_Picker.CustomFormat = "HH:mm";
            this.timeEndCheck_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeEndCheck_Picker.Location = new System.Drawing.Point(354, 173);
            this.timeEndCheck_Picker.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.timeEndCheck_Picker.Name = "timeEndCheck_Picker";
            this.timeEndCheck_Picker.ShowUpDown = true;
            this.timeEndCheck_Picker.Size = new System.Drawing.Size(166, 26);
            this.timeEndCheck_Picker.TabIndex = 10;
            this.ToolTip.SetToolTip(this.timeEndCheck_Picker, "Время конца проверки");
            this.timeEndCheck_Picker.Value = new System.DateTime(2024, 3, 21, 23, 59, 0, 0);
            this.timeEndCheck_Picker.ValueChanged += new System.EventHandler(this.timeEndCheckPicker_ValueChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deleteButton.Location = new System.Drawing.Point(1377, 22);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(120, 78);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "❌Удалить";
            this.ToolTip.SetToolTip(this.deleteButton, "Удалить выбранную ячейку");
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Description_textBox
            // 
            this.Description_textBox.Location = new System.Drawing.Point(761, 44);
            this.Description_textBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Description_textBox.Multiline = true;
            this.Description_textBox.Name = "Description_textBox";
            this.Description_textBox.Size = new System.Drawing.Size(442, 158);
            this.Description_textBox.TabIndex = 17;
            this.ToolTip.SetToolTip(this.Description_textBox, "Примечания к работе.");
            this.Description_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DescriptionTextBox_KeyUp);
            // 
            // Work_textBox
            // 
            this.Work_textBox.Location = new System.Drawing.Point(20, 48);
            this.Work_textBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Work_textBox.Name = "Work_textBox";
            this.Work_textBox.Size = new System.Drawing.Size(214, 26);
            this.Work_textBox.TabIndex = 20;
            this.ToolTip.SetToolTip(this.Work_textBox, "Введите название работы в заданном поле");
            this.Work_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WorkTextBox_KeyUp);
            // 
            // SearchTextBoxID
            // 
            this.SearchTextBoxID.Location = new System.Drawing.Point(20, 818);
            this.SearchTextBoxID.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SearchTextBoxID.Name = "SearchTextBoxID";
            this.SearchTextBoxID.Size = new System.Drawing.Size(172, 26);
            this.SearchTextBoxID.TabIndex = 25;
            this.SearchTextBoxID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchTextBoxID_KeyUp);
            // 
            // WorkSearch_TextBox
            // 
            this.WorkSearch_TextBox.Location = new System.Drawing.Point(584, 818);
            this.WorkSearch_TextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.WorkSearch_TextBox.Name = "WorkSearch_TextBox";
            this.WorkSearch_TextBox.Size = new System.Drawing.Size(202, 26);
            this.WorkSearch_TextBox.TabIndex = 30;
            this.WorkSearch_TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchTextBoxWork_KeyUp);
            // 
            // SearchDistrict_ComboBox
            // 
            this.SearchDistrict_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchDistrict_ComboBox.FormattingEnabled = true;
            this.SearchDistrict_ComboBox.Items.AddRange(new object[] {
            ""});
            this.SearchDistrict_ComboBox.Location = new System.Drawing.Point(798, 817);
            this.SearchDistrict_ComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SearchDistrict_ComboBox.Name = "SearchDistrict_ComboBox";
            this.SearchDistrict_ComboBox.Size = new System.Drawing.Size(200, 28);
            this.SearchDistrict_ComboBox.Sorted = true;
            this.SearchDistrict_ComboBox.TabIndex = 31;
            this.SearchDistrict_ComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchDistrict_ComboBox_SelectedIndexChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SearchButton.Location = new System.Drawing.Point(1356, 793);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(141, 52);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.Text = "🔎 Найти";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(528, 74);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Общее время работы (мин):";
            // 
            // workTime_textBox
            // 
            this.workTime_textBox.Location = new System.Drawing.Point(535, 99);
            this.workTime_textBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.workTime_textBox.Name = "workTime_textBox";
            this.workTime_textBox.ReadOnly = true;
            this.workTime_textBox.Size = new System.Drawing.Size(166, 26);
            this.workTime_textBox.TabIndex = 34;
            // 
            // NoTime_checkBox
            // 
            this.NoTime_checkBox.AutoSize = true;
            this.NoTime_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoTime_checkBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NoTime_checkBox.Location = new System.Drawing.Point(532, 126);
            this.NoTime_checkBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.NoTime_checkBox.Name = "NoTime_checkBox";
            this.NoTime_checkBox.Size = new System.Drawing.Size(153, 44);
            this.NoTime_checkBox.TabIndex = 35;
            this.NoTime_checkBox.Text = "Время проверки \r\nнеизвестно";
            this.ToolTip.SetToolTip(this.NoTime_checkBox, "Если вам неизвестно время, то Вы можете вставить лишь значение общего отработанно" +
        "го времени.");
            this.NoTime_checkBox.UseVisualStyleBackColor = true;
            this.NoTime_checkBox.CheckedChanged += new System.EventHandler(this.NoTime_checkBox_CheckedChanged);
            // 
            // edit_Button
            // 
            this.edit_Button.Location = new System.Drawing.Point(1248, 22);
            this.edit_Button.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.edit_Button.Name = "edit_Button";
            this.edit_Button.Size = new System.Drawing.Size(120, 78);
            this.edit_Button.TabIndex = 36;
            this.edit_Button.Text = "📝Изменить";
            this.ToolTip.SetToolTip(this.edit_Button, "Элементы с полей сверху применят изменения в выбранной ячейке");
            this.edit_Button.UseVisualStyleBackColor = true;
            this.edit_Button.Click += new System.EventHandler(this.edit_Button_Click);
            // 
            // district_comboBox
            // 
            this.district_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.district_comboBox.FormattingEnabled = true;
            this.district_comboBox.Location = new System.Drawing.Point(21, 107);
            this.district_comboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.district_comboBox.Name = "district_comboBox";
            this.district_comboBox.Size = new System.Drawing.Size(214, 28);
            this.district_comboBox.Sorted = true;
            this.district_comboBox.TabIndex = 15;
            this.ToolTip.SetToolTip(this.district_comboBox, "Выберете нужный участок");
            this.district_comboBox.SelectedIndexChanged += new System.EventHandler(this.district_comboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(321, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 176);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "До";
            // 
            // TimeBegin_TimePicker_Search
            // 
            this.TimeBegin_TimePicker_Search.Enabled = false;
            this.TimeBegin_TimePicker_Search.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimeBegin_TimePicker_Search.Location = new System.Drawing.Point(205, 818);
            this.TimeBegin_TimePicker_Search.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TimeBegin_TimePicker_Search.MinDate = new System.DateTime(1902, 1, 1, 0, 0, 0, 0);
            this.TimeBegin_TimePicker_Search.Name = "TimeBegin_TimePicker_Search";
            this.TimeBegin_TimePicker_Search.Size = new System.Drawing.Size(166, 26);
            this.TimeBegin_TimePicker_Search.TabIndex = 40;
            this.TimeBegin_TimePicker_Search.Value = new System.DateTime(2024, 4, 4, 14, 31, 33, 0);
            // 
            // TimeEnd_TimePicker_Search
            // 
            this.TimeEnd_TimePicker_Search.Enabled = false;
            this.TimeEnd_TimePicker_Search.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimeEnd_TimePicker_Search.Location = new System.Drawing.Point(402, 818);
            this.TimeEnd_TimePicker_Search.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TimeEnd_TimePicker_Search.MinDate = new System.DateTime(1902, 1, 1, 0, 0, 0, 0);
            this.TimeEnd_TimePicker_Search.Name = "TimeEnd_TimePicker_Search";
            this.TimeEnd_TimePicker_Search.Size = new System.Drawing.Size(166, 26);
            this.TimeEnd_TimePicker_Search.TabIndex = 41;
            this.TimeEnd_TimePicker_Search.Value = new System.DateTime(2024, 4, 4, 14, 32, 16, 0);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel.Location = new System.Drawing.Point(1248, 192);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(148, 22);
            this.outputLabel.TabIndex = 21;
            this.outputLabel.Text = "Записей  в базе: 0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(373, 822);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 20);
            this.label12.TabIndex = 42;
            this.label12.Text = "—";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(732, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(492, 193);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Примечания:";
            this.ToolTip.SetToolTip(this.groupBox1, "Примечания к работе");
            // 
            // SearchByTime_checkBox
            // 
            this.SearchByTime_checkBox.AutoSize = true;
            this.SearchByTime_checkBox.Location = new System.Drawing.Point(205, 791);
            this.SearchByTime_checkBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SearchByTime_checkBox.Name = "SearchByTime_checkBox";
            this.SearchByTime_checkBox.Size = new System.Drawing.Size(142, 24);
            this.SearchByTime_checkBox.TabIndex = 44;
            this.SearchByTime_checkBox.Text = "Поиск по дате:";
            this.SearchByTime_checkBox.UseVisualStyleBackColor = true;
            this.SearchByTime_checkBox.CheckedChanged += new System.EventHandler(this.SearchByTime_checkBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(1208, 793);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 52);
            this.button1.TabIndex = 45;
            this.button1.Text = "🛑 Отменить поиск";
            this.ToolTip.SetToolTip(this.button1, "Использовать, если сортировка не требуется.");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Clear_DataGridViewer);
            // 
            // Users_comboBox
            // 
            this.Users_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Users_comboBox.FormattingEnabled = true;
            this.Users_comboBox.Location = new System.Drawing.Point(21, 165);
            this.Users_comboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Users_comboBox.Name = "Users_comboBox";
            this.Users_comboBox.Size = new System.Drawing.Size(214, 28);
            this.Users_comboBox.Sorted = true;
            this.Users_comboBox.TabIndex = 48;
            this.ToolTip.SetToolTip(this.Users_comboBox, "Выберете нужный участок");
            // 
            // BreakTime_CheckBox
            // 
            this.BreakTime_CheckBox.AutoSize = true;
            this.BreakTime_CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BreakTime_CheckBox.Location = new System.Drawing.Point(533, 205);
            this.BreakTime_CheckBox.Name = "BreakTime_CheckBox";
            this.BreakTime_CheckBox.Size = new System.Drawing.Size(178, 24);
            this.BreakTime_CheckBox.TabIndex = 53;
            this.BreakTime_CheckBox.Text = "Учитывать перерыв";
            this.ToolTip.SetToolTip(this.BreakTime_CheckBox, "Если известно, что работа была сделана с перерывом, то её необходимо занести в по" +
        "ле выше, \r\nпредварительно поставив галочку.\r\n");
            this.BreakTime_CheckBox.UseVisualStyleBackColor = true;
            this.BreakTime_CheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 86);
            this.button2.TabIndex = 55;
            this.button2.Text = "📚";
            this.ToolTip.SetToolTip(this.button2, "Редактирование базы данных");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClearAll_Button
            // 
            this.ClearAll_Button.Location = new System.Drawing.Point(1377, 112);
            this.ClearAll_Button.Name = "ClearAll_Button";
            this.ClearAll_Button.Size = new System.Drawing.Size(120, 78);
            this.ClearAll_Button.TabIndex = 46;
            this.ClearAll_Button.Text = "🧹Очистить";
            this.ClearAll_Button.UseVisualStyleBackColor = true;
            this.ClearAll_Button.Click += new System.EventHandler(this.ClearAll_Button_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(421, 138);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 20);
            this.label11.TabIndex = 49;
            this.label11.Text = "—";
            // 
            // SearchUser_ComboBox
            // 
            this.SearchUser_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchUser_ComboBox.FormattingEnabled = true;
            this.SearchUser_ComboBox.Items.AddRange(new object[] {
            ""});
            this.SearchUser_ComboBox.Location = new System.Drawing.Point(1003, 817);
            this.SearchUser_ComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SearchUser_ComboBox.Name = "SearchUser_ComboBox";
            this.SearchUser_ComboBox.Size = new System.Drawing.Size(200, 28);
            this.SearchUser_ComboBox.TabIndex = 51;
            // 
            // BreakTime_TextBox
            // 
            this.BreakTime_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.BreakTime_TextBox.Enabled = false;
            this.BreakTime_TextBox.Location = new System.Drawing.Point(535, 173);
            this.BreakTime_TextBox.Name = "BreakTime_TextBox";
            this.BreakTime_TextBox.Size = new System.Drawing.Size(166, 26);
            this.BreakTime_TextBox.TabIndex = 52;
            this.BreakTime_TextBox.Text = "Время перерыва ";
            this.BreakTime_TextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.BreakTime_TextBox.TextChanged += new System.EventHandler(this.breakTime_TextBox_TextChanged);
            // 
            // colour_ComboBox
            // 
            this.colour_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colour_ComboBox.FormattingEnabled = true;
            this.colour_ComboBox.Items.AddRange(new object[] {
            "Стандарт",
            "Красный",
            "Фиолетовый",
            "Розовый",
            "Синий"});
            this.colour_ComboBox.Location = new System.Drawing.Point(1237, 275);
            this.colour_ComboBox.Name = "colour_ComboBox";
            this.colour_ComboBox.Size = new System.Drawing.Size(246, 28);
            this.colour_ComboBox.TabIndex = 56;
            this.colour_ComboBox.SelectedIndexChanged += new System.EventHandler(this.colour_ComboBox_SelectedIndexChanged);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(1237, 241);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(249, 28);
            this.copyButton.TabIndex = 57;
            this.copyButton.Text = "Копировать значения строки";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1512, 852);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.colour_ComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BreakTime_CheckBox);
            this.Controls.Add(this.BreakTime_TextBox);
            this.Controls.Add(label13);
            this.Controls.Add(this.SearchUser_ComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Users_comboBox);
            this.Controls.Add(label6);
            this.Controls.Add(this.ClearAll_Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchByTime_checkBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.edit_Button);
            this.Controls.Add(this.NoTime_checkBox);
            this.Controls.Add(this.workTime_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(label8);
            this.Controls.Add(label);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(label2);
            this.Controls.Add(this.Work_textBox);
            this.Controls.Add(this.Description_textBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.district_comboBox);
            this.Controls.Add(label5);
            this.Controls.Add(this.timeEndCheck_Picker);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.timeStartCheck_Picker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label1);
            this.Controls.Add(this.DataKemz_dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TimeEnd_TimePicker_Search);
            this.Controls.Add(this.TimeBegin_TimePicker_Search);
            this.Controls.Add(this.SearchDistrict_ComboBox);
            this.Controls.Add(this.WorkSearch_TextBox);
            this.Controls.Add(this.SearchTextBoxID);
            this.Controls.Add(this.SearchButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Нормирование. Таблица и Запись";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.DataKemz_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DateTimePicker timeEndCheck_Picker;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox Description_textBox;
        private System.Windows.Forms.TextBox Work_textBox;
        public System.Windows.Forms.DataGridView DataKemz_dataGridView;
        private System.Windows.Forms.TextBox SearchTextBoxID;
        private System.Windows.Forms.TextBox WorkSearch_TextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox workTime_textBox;
        private System.Windows.Forms.CheckBox NoTime_checkBox;
        private System.Windows.Forms.Button edit_Button;
        private System.Windows.Forms.ComboBox district_comboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker TimeBegin_TimePicker_Search;
        private System.Windows.Forms.DateTimePicker TimeEnd_TimePicker_Search;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.CheckBox SearchByTime_checkBox;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Button ClearAll_Button;
        private System.Windows.Forms.ComboBox Users_comboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox SearchUser_ComboBox;
        private System.Windows.Forms.TextBox BreakTime_TextBox;
        private System.Windows.Forms.CheckBox BreakTime_CheckBox;
        private System.Windows.Forms.ComboBox SearchDistrict_ComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_DataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistrictName_DataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn users_DataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkColumn_DataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStart_DataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeEnd_DataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTime_DataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_DataGridViewTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox colour_ComboBox;
        private System.Windows.Forms.Button copyButton;
        public System.Windows.Forms.DateTimePicker timeStartCheck_Picker;
    }
}

