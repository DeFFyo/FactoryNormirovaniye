using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Normirovanie
{
    public partial class EditForm : Form
    {
        bool ComboBoxInit = false;

        public DataBank objDataBank = new DataBank();

        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            ComboBoxEditorUpdate();
        }

        private void btnAddDistrictUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Проверьте правильность вводимых данных.\nВы точно уверены?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                WorkDBContext db = new WorkDBContext();
                var districts = distrCombobox.SelectedItem as District;
                var users = usrCombobox.SelectedItem as User;
                //users = db.Users.FirstOrDefault(x => x.ID == users.ID);
                try
                {
                    if (usersEditEnable_CheckBox.Checked)
                    {
                        if (usrCombobox.FindString(usrCombobox.Text) == -1)
                        {
                            districts = db.Districts.FirstOrDefault(x => x.ID == districts.ID);
                            var user = new User();
                            user.Name = usrCombobox.Text;
                            user.District = districts;

                            var UsersDB = db.Users;
                            UsersDB.Add(user);
                            db.SaveChanges();
                        }
                    }

                    else if (districtsEditEnable_CheckBox.Checked)
                    {
                        if (distrCombobox.FindString(distrCombobox.Text) == -1)
                        {
                            var distr = new District();
                            //distr = distrCombobox.SelectedItem as District;
                            distr.Name = distrCombobox.Text;

                            var DistrictsDB = db.Districts;
                            DistrictsDB.Add(distr);
                            db.SaveChanges();
                            ComboBoxInit = false;
                        }
                    }

                    ComboBoxEditorUpdate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteDistrictUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?\nНекорректное удаление может привести к потере данных!!!", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                WorkDBContext db = new WorkDBContext();
                var districts = db.Districts;
                var users = db.Users;
                try
                {
                    if (usersEditEnable_CheckBox.Checked)
                    {
                        if (MessageBox.Show($"Вы уверены, что хотите удалить пользователя {usrCombobox.Text}?",
                            "Удаление",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var user = usrCombobox.SelectedItem as User;
                            var num = user.ID;
                            var selectedUser = db.Users.FirstOrDefault(u => u.ID == num);

                            if (!(selectedUser is null))
                            {
                                users.Remove(selectedUser);
                                db.SaveChanges();

                            }
                        }
                    }
                    else if (districtsEditEnable_CheckBox.Checked)
                    {
                        if (MessageBox.Show($"Вы уверены, что хотите удалить участок {distrCombobox.Text}?",
                           "Удаление",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var district = distrCombobox.SelectedItem as District;
                            var num = district.ID;
                            var selectedDistrict = db.Districts.FirstOrDefault(u => u.ID == num);

                            if (!(selectedDistrict is null))
                            {
                                districts.Remove(selectedDistrict);
                                db.SaveChanges();
                                ComboBoxInit = false;
                            }
                        }
                    }
                    ComboBoxEditorUpdate();

                }
                catch
                {

                }
            }
        }

        public void ComboBoxEditorUpdate()
        {
            WorkDBContext db = new WorkDBContext();
            var districts = db.Districts;
            var users = db.Users;

            usrCombobox.Items.Clear();

            if (!ComboBoxInit)
            {
                distrCombobox.Items.Clear();
                distrCombobox.Items.AddRange(districts.OrderBy(x => x.Name).ToArray());
                ComboBoxInit = true;
                distrCombobox.SelectedIndex = 0;
            }

            var selectedDistrict = distrCombobox.SelectedItem as District;
            selectedDistrict = districts.FirstOrDefault(distr => distr.ID == selectedDistrict.ID);

            List<User> users1 = users.Include(u => u.District)
                                     .Where(u => u.District.ID == selectedDistrict.ID)
                                     .ToList();
            usrCombobox.Items.AddRange(users1.ToArray());
        }

        private void distrCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEditorUpdate();

        }

        private void usrCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBoxEditorUpdate();
        }

        private void districtsEditEnable_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            usersEditEnable_CheckBox.Enabled = !districtsEditEnable_CheckBox.Checked;
        }

        private void usersEditEnable_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            districtsEditEnable_CheckBox.Enabled = !usersEditEnable_CheckBox.Checked;

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (usersEditEnable_CheckBox.Checked || districtsEditEnable_CheckBox.Checked)
            {
                try
                {
                    WorkDBContext db = new WorkDBContext();
                    var districts = db.Districts;
                    var users = db.Users;

                    if (usersEditEnable_CheckBox.Checked)
                    {
                        objDataBank.selectedUser = usrCombobox.SelectedItem as User;
                        objDataBank.selectedUser = db.Users.FirstOrDefault(u => u.ID == objDataBank.selectedUser.ID);
                    }

                    if (districtsEditEnable_CheckBox.Checked)
                    {
                        objDataBank.selectedDistrict = distrCombobox.SelectedItem as District;
                        objDataBank.selectedDistrict = db.Districts.FirstOrDefault(u => u.ID == objDataBank.selectedDistrict.ID);
                    }
                }
                catch
                {
                    MessageBox.Show("Пользователь или участок не был выбран.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var childEditForm = new EnterEditedData(this);
                childEditForm.Show();
            }
            else
            {
                MessageBox.Show("Пользователь или участок не был выбран.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
