using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Normirovanie
{
    public partial class EnterEditedData : Form
    {
        public bool entered = false;
        EditForm MainForm;
        public EnterEditedData(EditForm f)
        {
            InitializeComponent();
            MainForm = f;
        }

        private void EnterEditedData_Load(object sender, EventArgs e)
        {
            if (MainForm.districtsEditEnable_CheckBox.Checked)
            {
                label1.Text += "участка " + MainForm.objDataBank.selectedDistrict.Name;
            }
            if (MainForm.usersEditEnable_CheckBox.Checked)
            {
                label1.Text += "работника " + MainForm.objDataBank.selectedUser.Name;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            WorkDBContext db = new WorkDBContext();
            var districts = db.Districts;
            var users = db.Users;

            var newValue = newNameTextBox.Text;

            if (MainForm.usersEditEnable_CheckBox.Checked)
            {
                var selectedUser = MainForm.objDataBank.selectedUser;

                selectedUser = users.Where(u => u.ID == selectedUser.ID).SingleOrDefault();

                selectedUser.Name = newNameTextBox.Text;

                if (selectedUser.Name.Length > 0)
                {
                    db.SaveChanges();
                }
            }
            else if (MainForm.districtsEditEnable_CheckBox.Checked)
            {
                var selectedDistrict = MainForm.objDataBank.selectedDistrict;

                selectedDistrict = districts.Where(u => u.ID == selectedDistrict.ID).SingleOrDefault();

                selectedDistrict.Name = newNameTextBox.Text;

                if (selectedDistrict.Name.Length > 0)
                {
                    db.SaveChanges();
                }
            }

            MainForm.ComboBoxEditorUpdate();
            Close();
        }

        private void newNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
