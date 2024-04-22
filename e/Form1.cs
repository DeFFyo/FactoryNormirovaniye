using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Normirovanie
{
    public partial class Form1 : Form
    {
        //Необходим для первой инициализации ComboBox, связанный с бд.
        bool ComboBoxInit = false;

        int selectedRow;
        Int32 selectedRowCount;


        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewer_Update();  // Обновление DataGridViewer. Вывод всех значений из таблицы dbo.Works
            ComboBoxUpdate();         // Обновление комбобоксов. Вывод всех значений из dbo.Districts, а также вывод значений из dbo_Users.
            EntryLabel();             // Счётчик элементов.
            DataKemz_dataGridView.Columns[1].DefaultCellStyle.Format = "dd.MM.yy"; //Дата проверки.
            DataKemz_dataGridView.Columns["TimeStart_DataGridViewTextBox"].DefaultCellStyle.Format = "HH:mm"; //Дата начала работы.
            DataKemz_dataGridView.Columns["TimeEnd_DataGridViewTextBox"].DefaultCellStyle.Format = "HH:mm"; //Конца работы.
            CalculateDate(true);
            //Задаётся сначала, чтобы далее не пришлось 
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewRow();
            }
            catch (System.FormatException)
            {
                MessageBox.Show(Text = "Вы ввели неверное значение. Проверьте правильность его написания"
                    , Name = "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Delete(false);
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                Search();
            }
            catch (System.FormatException)
            {
                MessageBox.Show(Text = "Вы ввели неверное значение. Проверьте правильность его написания", Name = "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void SearchTextBoxID_KeyUp(object sender, KeyEventArgs e)
        {
            HotKeys(e, 0);
        }

        private void SearchTextBoxWork_KeyUp(object sender, KeyEventArgs e)
        {
            HotKeys(e, 0);
        }

        private void WorkTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            HotKeys(e, 1);
        }

        private void DescriptionTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            HotKeys(e, 1);
        }


        private void timeEndCheckPicker_ValueChanged(object sender, EventArgs e)
        {
            if (sender != null)
            {
                CalculateDate(true);
            }
        }

        private void timeStartCheckPicker_ValueChanged(object sender, EventArgs e)
        {
            if (sender != null)
            {
                CalculateDate(true);
            }
        }
        private void edit_Button_Click(object sender, EventArgs e)
        {
            if (district_comboBox.SelectedItem is null)
            {
                new ToolTip().Show("Сначала выберите участок!\nИзменение невозможно!", district_comboBox, new Point(0, 20), 2000);
                return;
            }

            if (MessageBox.Show(Text = "Вы уверены, что хотите внести изменения?", Name = "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!CalculateDate(false))
                {
                    MessageBox.Show("Выбрана некорректная дата или время.\nИзменение отменено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                WorkDBContext db = new WorkDBContext();
                var distr = district_comboBox.SelectedItem as District;
                distr = db.Districts.FirstOrDefault(x => x.ID == distr.ID);
                var usr = Users_comboBox.SelectedItem as User;
                usr = db.Users.FirstOrDefault(x => x.ID == usr.ID);


                int currentRow = DataKemz_dataGridView.CurrentCell.RowIndex;

                DataKemz_dataGridView.CurrentCell = DataKemz_dataGridView.Rows[currentRow].Cells[0];

                var index = Convert.ToInt32(DataKemz_dataGridView.CurrentCell.Value);

                try
                {
                    var work = db.Works.Where(x => x.ID == index).SingleOrDefault();

                    work.Job = Work_textBox.Text;
                    work.CheckDate = datePicker.Value;
                    if (!(work.StartCheckDate is null))
                    {
                        work.StartCheckDate = timeStartCheck_Picker.Value;
                        work.EndCheckDate = timeEndCheck_Picker.Value;
                    }
                    else
                    {
                        work.StartCheckDate = null;
                        work.EndCheckDate = null;

                    }
                    work.Description = Description_textBox.Text;
                    if (!(work.StartCheckDate is null))
                    {
                        try
                        {
                            work.WorkTime = Convert.ToDouble((timeEndCheck_Picker.Value - timeStartCheck_Picker.Value).TotalMinutes - Convert.ToDouble(BreakTime_TextBox.Text));
                            work.BreakTime = Convert.ToDouble(BreakTime_TextBox.Text);
                        }
                        catch (FormatException)
                        {
                            work.WorkTime = Convert.ToDouble((timeEndCheck_Picker.Value - timeStartCheck_Picker.Value).TotalMinutes);
                            work.BreakTime = null;
                        }
                    }
                    else
                    {
                        try
                        {
                            work.WorkTime = Convert.ToDouble(workTime_textBox.Text);
                        }
                        catch
                        {
                            return;
                        }
                    }
                    work.District = distr;
                    work.User = usr;

                    outputLabel.Text = $"Запись {index} была изменена.";
                    db.SaveChanges();
                    //???

                    DataKemz_dataGridView.Rows[currentRow].Cells["Date_DataGridViewTextBox"].Value = work.CheckDate.ToString("d");
                    DataKemz_dataGridView.Rows[currentRow].Cells["DistrictName_DataGridViewTextBox"].Value = work.District?.ToString();
                    DataKemz_dataGridView.Rows[currentRow].Cells["WorkColumn_DataGridViewTextBox"].Value = work.Job?.ToString();
                    DataKemz_dataGridView.Rows[currentRow].Cells["TotalTime_DataGridViewTextBox"].Value = work.WorkTime.ToString();
                    DataKemz_dataGridView.Rows[currentRow].Cells["users_DataGridViewTextBox"].Value = work.User;
                    DataKemz_dataGridView.Rows[currentRow].Cells["desc_DataGridViewTextBox"].Value = work.Description?.ToString();
                    if (!(work.StartCheckDate is null))
                    {
                        try
                        {
                            DataKemz_dataGridView.Rows[currentRow].Cells["TimeStart_DataGridViewTextBox"].Value = Convert.ToDateTime(work.StartCheckDate).ToString("HH:mm");
                            DataKemz_dataGridView.Rows[currentRow].Cells["TimeEnd_DataGridViewTextBox"].Value = Convert.ToDateTime(work.EndCheckDate).ToString("HH:mm");
                        }
                        catch { return; }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(Text = $"Не удалось применить изменения. " +
                        $"Проверьте правильность написания значений.\nОшибка:{ex}", Name = "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void dataKemz_dataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRowCount = DataKemz_dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);

                if (selectedRowCount < 1)
                {
                    selectedRow = (int)DataKemz_dataGridView.Rows[e.RowIndex].Cells[0].Value;
                }
            //    else
            //    {
            //        for (int i = 0; i < selectedRowCount; i++)
            //        {
            //            selectedRows.Add((int)DataKemz_dataGridView.Rows[i].Cells[0].Value);
            //        }
            //    }
            }
            catch
            {
                selectedRow = 1;
                return;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            HotKeys(e, 3);
        }

        private void dataKemz_dataGridView_KeyUp(object sender, KeyEventArgs e)
        {
            HotKeys(e, 3);
        }

        void HotKeys(KeyEventArgs e, byte searchOrAdd)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                if (searchOrAdd == 0)
                {
                    Search();
                }
                else if (searchOrAdd == 1)
                {
                    try
                    {
                        AddNewRow();
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show(Text = "Вы ввели неверное значение. Проверьте правильность его написания"
                            , Name = "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else if (e.KeyValue == (char)Keys.Delete)
            {
                if (searchOrAdd == 3)
                {
                    Delete(false);
                }
            }
        }
        bool CalculateDate(bool hasTime) 
        //Метод является Bool для проверки правильности написания введёных значений. (Используется в функции AddNewRow())
        //Однако он предназначен в первую очередь для расчёта времени заполнения контрола BreakTime_TextBox.
        {
            double breakTime;
            if (BreakTime_TextBox.Text != "Время перерыва " &&
                BreakTime_TextBox.Text != "")
            {                
                try
                {
                    breakTime = Convert.ToDouble(BreakTime_TextBox.Text);
                    //Простой перевод в Double
                }
                catch (FormatException)
                {
                    MessageBox.Show("Не число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                breakTime = 0;
            }
            var result = (timeEndCheck_Picker.Value - timeStartCheck_Picker.Value).TotalMinutes - breakTime;
            if (hasTime)
            {
                workTime_textBox.Text = result.ToString();
                return true;
            }
            else if (result < 0)
            {
                new ToolTip().Show("Значение не может быть отрицательным", workTime_textBox, new Point(0, 20), 2000);
                return false;
            }
            else
            {
                return true;
            }
        }
        void DataGridViewer_Update()
        {
            WorkDBContext db = new WorkDBContext();
            try
            {
                var context = new WorkDBContext();
                var jobs = context.Works
                    .Include(x => x.User)
                    .OrderBy(x => x.ID)
                    .ToList();

                var districts = context.Districts.ToList();


                jobs = jobs
                    .OrderBy(x => x.Job)
                    .ThenBy(x => x.StartCheckDate)
                    .ToList();

                jobs.ForEach(x =>
            {
                int n = DataKemz_dataGridView.Rows.Add(new object[]
                {
                        x.ID,
                        x.CheckDate.ToString("d"),
                        x.District?.Name,
                        x.User,
                        x.Job,
                        x.StartCheckDate?.ToString("HH:mm"),
                        x.EndCheckDate?.ToString("HH:mm"),
                        x.WorkTime.ToString(),
                        x.Description
                });
                DataKemz_dataGridView.Rows[n].Tag = x;
                Color currColor = Color.White;
                switch (x.Caution)
                {
                    case 0:
                        DataKemz_dataGridView.Rows[n].DefaultCellStyle.ForeColor = Color.Black;
                        break;
                    case 1:
                        currColor = Color.IndianRed;
                        break;
                    case 2:
                        currColor = Color.MediumPurple;
                        break;
                    case 3:
                        currColor = Color.Pink;
                        DataKemz_dataGridView.Rows[n].DefaultCellStyle.ForeColor = Color.Black;

                        break;
                    case 4:
                        currColor = Color.LightBlue;
                        DataKemz_dataGridView.Rows[n].DefaultCellStyle.ForeColor = Color.Black;

                        break;
                }
                DataKemz_dataGridView.Rows[n].DefaultCellStyle.BackColor = currColor;
                DataKemz_dataGridView.DefaultCellStyle.ForeColor = Color.White;
            });

            }
            catch (Exception ex)
            {
                MessageBox.Show(Text = $"При обработке базы данных произошла ошибка.\nДополнительно: {ex}", Name = "Фатальная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        void ComboBoxUpdate()
        {
            //Начальная инициализация коллекции в комбобоксах и их обновление.

            var db = new WorkDBContext();
            var districts = db.Districts.ToList();
            var users = db.Users;
            Users_comboBox.Items.Clear();
            SearchUser_ComboBox.Items.Clear();
            if (!ComboBoxInit)
            {
                district_comboBox.Items.AddRange(districts.OrderBy(x => x.Name).ToArray());
                SearchDistrict_ComboBox.Items.AddRange(districts.OrderBy(x => x.Name).ToArray());
                ComboBoxInit = true;
                //district_comboBox.Sorted = true;
                district_comboBox.SelectedIndex = 0;

            }
            var selectedDistrict = district_comboBox.SelectedItem as District;
            selectedDistrict = districts.FirstOrDefault(distr => distr.ID == selectedDistrict.ID);
            List<User> Select2InsertUser = users.Include(u => u.District)
                                     .Where(u => u.District.ID == selectedDistrict.ID)
                                     .ToList();
            Users_comboBox.Items.AddRange(Select2InsertUser.ToArray());
            try
            {

                var searchSelectedDistrict = SearchDistrict_ComboBox.SelectedItem as District;

                if (searchSelectedDistrict == null)
                    return;

                searchSelectedDistrict = districts.FirstOrDefault(d => d.ID == searchSelectedDistrict.ID);
                List<User> Select2SearchUser = users.Include(u => u.District)
                                         .Where(u => u.District.ID == searchSelectedDistrict.ID)
                                         .ToList();

                SearchUser_ComboBox.Items.Insert(0, "Все");

                SearchUser_ComboBox.Items.AddRange(Select2SearchUser.ToArray());
            }
            catch
            {
                return;
            }
        }

        public void EntryLabel()
        {
            WorkDBContext db = new WorkDBContext();
            try
            {
                outputLabel.Text = "Записей в списке: " + Convert.ToString(db.Works.Count());
            }
            catch
            {
                outputLabel.Text = "Записей в списке: 0";
            }
        }

        void Delete(bool hard)
        {
            if (hard ||
                MessageBox.Show(Text = "Вы дейтвительно хотите удалить выбранное значение?",
                Text = "Удалить значение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                //Булево значение необходимо для того, чтобы в исключительных ситуациях можно было обойти вопрос
            {

                Work objWork = new Work();
                WorkDBContext db = new WorkDBContext();

                try
                {
                    int currentRow = DataKemz_dataGridView.CurrentCell.RowIndex;

                    int num = Convert.ToInt32(DataKemz_dataGridView.Rows[currentRow].Cells[0].Value);

                    var rowIndex = db.Works.FirstOrDefault(w => w.ID == num);
                    db.Works.Attach(objWork);

                    outputLabel.Text = $"Запись {num} была удалена.";

                    if (!(rowIndex is null))
                    {
                        db.Works.Remove(rowIndex);
                        db.SaveChanges();
                    }
                    foreach (DataGridViewCell item in DataKemz_dataGridView.SelectedCells)
                    {
                        if (item.Selected)
                        {
                            DataKemz_dataGridView.Rows.RemoveAt(item.RowIndex);
                        }
                    }
                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show(Text = "База данных пуста. Удаление невозможно.", Name = "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Text = $"Произошла непредвиденная ошибка.\nОшибка:{ex}", Name = "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        void Search()
        //Метод собирает значения в строовой массив SearchTexts, а затем проверяется
        //Есть ли хотя бы какие-то значений для поиска или нет,
        //Затем очищает DGV и показывает добавляет объекты совпадений.

        {
            string[] SearchTexts;
            WorkDBContext db = new WorkDBContext();
            List<int> index = new List<int>();

            SearchTexts = new string[] {SearchTextBoxID.Text.ToString(),
                                      WorkSearch_TextBox.Text.ToString(),
                                      SearchDistrict_ComboBox.Text.ToString()};
            if (SearchTexts[0].Length > 0 ||
                SearchTexts[1].Length > 0 ||
                SearchTexts[2].Length > 0 ||
                SearchByTime_checkBox.Checked) 
            { 
                List<Work> found;//Лист с найденными объектами
                var DateBegin = TimeBegin_TimePicker_Search.Value.Date;
                var DateEnd = TimeEnd_TimePicker_Search.Value.Date;
                int? ID;
                if (SearchTextBoxID.Text != "")
                {
                    ID = Convert.ToInt32(SearchTextBoxID.Text);
                }
                else
                {
                    ID = null;
                }

                string Job;
                if (WorkSearch_TextBox.Text == "" || WorkSearch_TextBox.Text == " ")
                {
                    Job = null;
                }
                else
                {
                    Job = WorkSearch_TextBox.Text;
                }

                string district;
                if (SearchDistrict_ComboBox.Text == "" || SearchDistrict_ComboBox.Text == " ")
                {
                    district = null;
                }
                else
                {
                    district = SearchDistrict_ComboBox.Text;
                }
                string user;
                if(SearchUser_ComboBox.Text == "Все" || SearchUser_ComboBox.Text == "" || SearchUser_ComboBox.Text == " ")
                {
                    user = null;
                }
                else
                {
                    user = SearchUser_ComboBox.Text;
                }

                if (SearchByTime_checkBox.Checked)
                {
                    if (TimeBegin_TimePicker_Search.Value < TimeEnd_TimePicker_Search.Value)
                    {
                        if (Job != null && district != null && user != null)
                        {
                            // Собствено, сам поиск. Выполняем LINQ-запрос на подключение табличек User и Disticts
                            // А затем проходимся по базе данных, подбирая значения, в которых содержится что-либо из этого.

                            //В случае если есть заданный промежуток времени и дополнительные данные:
                            found = db.Works
                            .Include(result => result.User)
                            .Include(result => result.District)
                            .Where(result => ((result.CheckDate >= DateBegin) &&
                                        (result.CheckDate <= DateEnd)) &&
                                        ((result.Job.Contains(Job)) &&
                                        (result.District.Name.Contains(district)) &&
                                        result.User.Name.Contains(user))).ToList();
                        }
                        else if (Job != null && district != null)
                        {
                            found = db.Works
                            .Include(result => result.User)
                            .Include(result => result.District)
                            .Where(result => ((result.CheckDate >= DateBegin) &&
                            (result.CheckDate <= DateEnd)) &&
                            ((result.Job.Contains(Job)) &&
                            (result.District.Name.Equals(district)))).ToList();
                        }
                        else if (Job != null)
                        {
                            found = db.Works
                            .Include(result => result.User)
                            .Include(result => result.District)
                            .Where(result => ((result.CheckDate >= DateBegin) &&
                                  (result.CheckDate <= DateEnd)) &&
                                  ((result.Job.Contains(Job)))).ToList();
                        }
                        else if (user != null)
                        {
                            found = db.Works
                            .Include(result => result.User)
                            .Include(result => result.District)
                            .Where(result => ((result.CheckDate >= DateBegin) &&
                                   (result.CheckDate <= DateEnd)) &&
                                   (result.District.Name.Equals(district)) &&
                                   (result.User.Name.Equals(user))).ToList();
                        }

                        else if (district != null)
                        {
                            found = db.Works
                            .Include(result => result.User)
                            .Include(result => result.District)
                            .Where(result => ((result.CheckDate >= DateBegin) &&
                                   (result.CheckDate <= DateEnd)) &&
                                   (result.District.Name.Equals(district))).ToList();
                        }
                        else
                        {
                            //В случае если есть только заданный промежуток времени
                            found = db.Works
                            .Include(result => result.User)
                            .Include(result => result.District)
                            .Where(result => ((result.CheckDate >= DateBegin) &&
                                  (result.CheckDate <= DateEnd))).ToList();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ошшибка интервала времени.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                else
                {
                    //В случае, если нет заданного промежутка времени, но есть даннные
                    if (!(user is null))
                    {
                        if (Job is null)
                        {
                            found = db.Works
                           .Include(result => result.User)
                           .Include(result => result.District)
                           .Where(result => (result.ID == ID) ||
                                       ((result.User.Name.Contains(user)) &&
                                       result.District.Name.Contains(district))).ToList();
                        }
                        else
                        {
                            found = db.Works
                           .Include(result => result.User)
                           .Include(result => result.District)
                           .Where(result => (result.ID == ID) ||
                                       (result.Job.Contains(Job)) &&
                                       ((result.User.Name.Contains(user)) &&
                                       result.District.Name.Contains(district))).ToList();
                        }
                    }
                    else if (!(district is null))
                    {
                        if (Job is null)
                        {
                            found = db.Works
                            .Include(result => result.User)
                            .Include(result => result.District)
                            .Where(result => (result.ID == ID) ||
                                         result.District.Name.Contains(district)).ToList();
                        }
                        else
                        {
                            found = db.Works
                            .Include(result => result.User)
                            .Include(result => result.District)
                            .Where(result => (result.ID == ID) ||
                                        (result.Job.Contains(Job)) &&
                                         result.District.Name.Equals(district)).ToList();

                        }
                    }
                    else
                    {
                        found = db.Works
                        .Include(result => result.User)
                        .Include(result => result.District)
                        .Where(result => (result.ID == ID) ||
                              (result.Job.Contains(Job))).ToList();
                    }
                }

                found = found
                .OrderBy(x => x.Job)
                .ThenBy(x => x.StartCheckDate)
                //.ThenBy(x => x.CheckDate)
                .ToList();

                DataKemz_dataGridView.Rows.Clear();
                found.ForEach(x =>
                {
                    int n = DataKemz_dataGridView.Rows.Add(new object[]
                    {
                        x.ID,
                        x.CheckDate.ToString("d"),
                        x.District,
                        x.User,
                        x.Job,
                        x.StartCheckDate?.ToString("HH:mm"),
                        x.EndCheckDate?.ToString("HH:mm"),
                        x.WorkTime.ToString(),
                        x.Description
                    });

                    DataKemz_dataGridView.Rows[n].Tag = x;
                    DataKemz_dataGridView.Rows[n].Tag = x;
                    Color currColor = Color.White;
                    switch (x.Caution)
                    {
                        case 0:
                            DataKemz_dataGridView.Rows[n].DefaultCellStyle.ForeColor = Color.Black;
                            break;
                        case 1:
                            currColor = Color.IndianRed;
                            break;
                        case 2:
                            currColor = Color.MediumPurple;
                            break;
                        case 3:
                            currColor = Color.Pink;
                            DataKemz_dataGridView.Rows[n].DefaultCellStyle.ForeColor = Color.Black;

                            break;
                        case 4:
                            currColor = Color.LightBlue;
                            DataKemz_dataGridView.Rows[n].DefaultCellStyle.ForeColor = Color.Black;

                            break;
                    }
                    DataKemz_dataGridView.Rows[n].DefaultCellStyle.BackColor = currColor;
                    DataKemz_dataGridView.DefaultCellStyle.ForeColor = Color.White;

                });


                outputLabel.Text = $"Найдено Записей:\n{DataKemz_dataGridView.Rows.Count}";
                if (DataKemz_dataGridView.Rows.Count == 0)
                {
                    MessageBox.Show("По Вашему запросу ничего не найдено", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(Text = "Для поиска необходимо ввести хотя бы одно значение.", Name = "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void AddNewRow()
        {
            //Добавляет новый объект в БД и DGV.

            if (district_comboBox.SelectedItem == null)
            {
                new ToolTip().Show("Сначала выберите участок!\nДобавление невозможно!", district_comboBox, new Point(0, 20), 2000);
                return;
            }

            else if (Users_comboBox.SelectedItem == null)
            {
                new ToolTip().Show("Сначала выберите работника!\nДобавление невозможно!", Users_comboBox, new Point(0, 20), 2000);
                return;
            }
            else if (!CalculateDate(false))
            {
                MessageBox.Show("Выбрана неверная дата или время!\nДобавление невозможно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var db = new WorkDBContext();
            var distr = district_comboBox.SelectedItem as District;
            var usr = Users_comboBox.SelectedItem as User;
            distr = db.Districts.FirstOrDefault(x => x.ID == distr.ID);
            usr = db.Users.FirstOrDefault(x => x.ID == usr.ID);

            //Заполнение значений объекта выполненной работы
            Work objWork = new Work();
            objWork.Job = Work_textBox.Text.Trim();
            objWork.Description = Description_textBox.Text.Trim();
            objWork.CheckDate = datePicker.Value.Date;
            if (!NoTime_checkBox.Checked)
            {
                var selectedDate = datePicker.Value;
                var startTime = timeStartCheck_Picker.Value;
                var endTime = timeEndCheck_Picker.Value;

                objWork.StartCheckDate = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, startTime.Hour, startTime.Minute, 0);
                objWork.EndCheckDate = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, endTime.Hour, endTime.Minute, 0);
                try
                {
                    objWork.WorkTime = (endTime - startTime).TotalMinutes - Convert.ToDouble(BreakTime_TextBox.Text);
                    objWork.BreakTime = Convert.ToDouble(BreakTime_TextBox.Text);
                }
                catch (FormatException)
                {
                    objWork.WorkTime = (timeEndCheck_Picker.Value - timeStartCheck_Picker.Value).TotalMinutes;
                    objWork.BreakTime = null;
                }
            }
            else
            {
                objWork.StartCheckDate = null;
                objWork.EndCheckDate = null;
                objWork.WorkTime = Convert.ToDouble(workTime_textBox.Text);
            }
            objWork.District = distr;
            objWork.User = usr;

            objWork = db.Works.Add(objWork);
            db.SaveChanges();

            int n = DataKemz_dataGridView.Rows.Add(new object[]
            {
                 objWork.ID,
                 objWork.CheckDate.ToString("d"),
                 objWork.District?.Name,
                 objWork.User,
                 objWork.Job,
                 objWork.StartCheckDate?.ToString("t"),
                 objWork.EndCheckDate?.ToString("t"),
                 objWork.WorkTime.ToString(),
                 objWork.Description
            }); ;
            DataKemz_dataGridView.Rows[n].Tag = objWork;
            DataKemz_dataGridView.Rows[n].DefaultCellStyle.ForeColor = Color.Black;
        }
        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (MessageBox.Show("Вы дейстивтельно хотите выйти из программы?", "Выход из программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No);
        }

        private void SearchByTime_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            TimeBegin_TimePicker_Search.Enabled = SearchByTime_checkBox.Checked;
            TimeEnd_TimePicker_Search.Enabled = SearchByTime_checkBox.Checked;
            SearchTextBoxID.Enabled = !SearchByTime_checkBox.Checked;
        }

        private void NoTime_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NoTime_checkBox.Checked)
            {
                workTime_textBox.ReadOnly = false;
                timeStartCheck_Picker.Enabled = false;
                timeEndCheck_Picker.Enabled = false;
            }
            else
            {
                workTime_textBox.ReadOnly = true;
                timeStartCheck_Picker.Enabled = true;
                timeEndCheck_Picker.Enabled = true;
            }
            BreakTime_CheckBox.Enabled = !NoTime_checkBox.Checked;
            CalculateDate(true);
        }

        private void Clear_DataGridViewer(object sender, EventArgs e)
        {
            DataKemz_dataGridView.Rows.Clear();
            DataGridViewer_Update();
        }

        private void Reset()
        {
            Work_textBox.ResetText();
            Description_textBox.ResetText();
            BreakTime_TextBox.Text = "Время перерыва ";
        }

        private void ClearAll_Button_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void district_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxUpdate();
        }

        private void SearchDistrict_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxUpdate();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (BreakTime_TextBox.Text == "Время перерыва ")
            {
                BreakTime_TextBox.Clear();
            }
        }

        private void breakTime_TextBox_TextChanged(object sender, EventArgs e)
        {
                if (BreakTime_TextBox.Text != "Время перерыва " &&
                    !String.IsNullOrEmpty(BreakTime_TextBox.Text))
                {
                    CalculateDate(true);
                }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            BreakTime_TextBox.Enabled = BreakTime_CheckBox.Checked;
            NoTime_checkBox.Enabled = !BreakTime_CheckBox.Checked;
            if (!BreakTime_TextBox.Enabled)
            {
                BreakTime_TextBox.Text = "Время перерыва ";
            }
            CalculateDate(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ВНИМАНИЕ! При работе с базой данных сотрудников и участков, нужно соблюдать предельную осторожность.\nПри неосторожной работе есть высокий риск потери данных.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            EditForm editorForm = new EditForm();
            editorForm.Show();
        }

        private void colour_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            WorkDBContext db = new WorkDBContext();

            var newWorkCaution = db.Works.Where(x => x.ID == selectedRow).SingleOrDefault();

            newWorkCaution.Caution = (byte)colour_ComboBox.SelectedIndex;
            db.SaveChanges();

            foreach (DataGridViewRow n in DataKemz_dataGridView.Rows)
            {
                if (newWorkCaution.ID == Convert.ToInt32(n.Cells[0].Value))
                {
                    Color currColor = Color.White;
                    Color currFontColor = Color.Black;
                    switch (newWorkCaution.Caution)
                    {
                        case 0:
                            break;
                        case 1:
                            currColor = Color.IndianRed;
                            break;
                        case 2:
                            currColor = Color.MediumPurple;
                            currFontColor = Color.White;
                            break;
                        case 3:
                            currColor = Color.Pink;
                            currFontColor = Color.Black;

                            break;
                        case 4:
                            currColor = Color.LightBlue;
                            currFontColor = Color.Black;

                            break;
                    }
                    n.DefaultCellStyle.BackColor = currColor;
                    n.DefaultCellStyle.ForeColor = currFontColor;
                }
            }
        }

        private void edit_CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            var db = new WorkDBContext();
            var works = db.Works.Include(x => x.District)
                .Include(x => x.User)
                .OrderBy(x => x.ID)
                .ToList();
            var current_work = works.FirstOrDefault(x => x.ID == selectedRow);
            try
            {
                datePicker.Value = current_work.CheckDate;
                Work_textBox.Text = current_work.Job;
                Description_textBox.Text = current_work.Description;
                district_comboBox.SelectedIndex = district_comboBox.FindString(current_work.District.ToString());
                Users_comboBox.SelectedIndex = Users_comboBox.FindString(current_work.User.ToString());
                colour_ComboBox.SelectedIndex = current_work.Caution;
                try
                {
                    NoTime_checkBox.Checked = false;
                    if (current_work.StartCheckDate != null && current_work.EndCheckDate != null)
                    {
                        timeStartCheck_Picker.Value = Convert.ToDateTime(current_work.StartCheckDate);
                        timeEndCheck_Picker.Value = Convert.ToDateTime(current_work.EndCheckDate);
                    }
                    else
                    {
                        NoTime_checkBox.Checked = true;
                        timeStartCheck_Picker.Value = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, 0, 0, 0);
                        timeEndCheck_Picker.Value = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, 23, 59, 0);
                    }
                    workTime_textBox.Text = current_work.WorkTime.ToString();
                    var workedTime = Convert.ToDouble(workTime_textBox.Text);
                    if (!(current_work.BreakTime is null))
                    {
                        BreakTime_CheckBox.Checked = true;
                        BreakTime_TextBox.Text = current_work.BreakTime.ToString();
                        workTime_textBox.Text = workedTime.ToString();

                    }
                    else
                    {
                        BreakTime_CheckBox.Checked = false;
                        BreakTime_TextBox.Clear();
                    }
                }
                catch
                {
                    NoTime_checkBox.Checked = true;
                    BreakTime_CheckBox.Checked = false;
                    workTime_textBox.Text = current_work.WorkTime.ToString();
                    return;
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
            catch (System.NullReferenceException)
            {
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Проиошла непредвиденная ошибка\nИсклюение:\n{ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void DataKemz_dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void DataKemz_dataGridView_ColumnSortModeChanged(object sender, DataGridViewColumnEventArgs e)
        {
            
        }
    }
}