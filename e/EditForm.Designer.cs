
namespace Normirovanie
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.distrCombobox = new System.Windows.Forms.ComboBox();
            this.usrCombobox = new System.Windows.Forms.ComboBox();
            this.btnAddDistrictUser = new System.Windows.Forms.Button();
            this.btnDeleteDistrictUser = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.districtsEditEnable_CheckBox = new System.Windows.Forms.CheckBox();
            this.usersEditEnable_CheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // distrCombobox
            // 
            this.distrCombobox.FormattingEnabled = true;
            this.distrCombobox.Location = new System.Drawing.Point(18, 39);
            this.distrCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.distrCombobox.Name = "distrCombobox";
            this.distrCombobox.Size = new System.Drawing.Size(463, 26);
            this.distrCombobox.Sorted = true;
            this.distrCombobox.TabIndex = 0;
            this.distrCombobox.SelectedIndexChanged += new System.EventHandler(this.distrCombobox_SelectedIndexChanged);
            // 
            // usrCombobox
            // 
            this.usrCombobox.FormattingEnabled = true;
            this.usrCombobox.Location = new System.Drawing.Point(18, 107);
            this.usrCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.usrCombobox.Name = "usrCombobox";
            this.usrCombobox.Size = new System.Drawing.Size(463, 26);
            this.usrCombobox.Sorted = true;
            this.usrCombobox.TabIndex = 1;
            this.usrCombobox.SelectedIndexChanged += new System.EventHandler(this.usrCombobox_SelectedIndexChanged);
            // 
            // btnAddDistrictUser
            // 
            this.btnAddDistrictUser.Location = new System.Drawing.Point(13, 197);
            this.btnAddDistrictUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDistrictUser.Name = "btnAddDistrictUser";
            this.btnAddDistrictUser.Size = new System.Drawing.Size(116, 55);
            this.btnAddDistrictUser.TabIndex = 2;
            this.btnAddDistrictUser.Text = "Добавить";
            this.btnAddDistrictUser.UseVisualStyleBackColor = true;
            this.btnAddDistrictUser.Click += new System.EventHandler(this.btnAddDistrictUser_Click);
            // 
            // btnDeleteDistrictUser
            // 
            this.btnDeleteDistrictUser.Location = new System.Drawing.Point(372, 197);
            this.btnDeleteDistrictUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteDistrictUser.Name = "btnDeleteDistrictUser";
            this.btnDeleteDistrictUser.Size = new System.Drawing.Size(116, 55);
            this.btnDeleteDistrictUser.TabIndex = 3;
            this.btnDeleteDistrictUser.Text = "Удалить";
            this.btnDeleteDistrictUser.UseVisualStyleBackColor = true;
            this.btnDeleteDistrictUser.Click += new System.EventHandler(this.btnDeleteDistrictUser_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(192, 197);
            this.editButton.Margin = new System.Windows.Forms.Padding(4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(116, 55);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // districtsEditEnable_CheckBox
            // 
            this.districtsEditEnable_CheckBox.AutoSize = true;
            this.districtsEditEnable_CheckBox.Location = new System.Drawing.Point(18, 140);
            this.districtsEditEnable_CheckBox.Name = "districtsEditEnable_CheckBox";
            this.districtsEditEnable_CheckBox.Size = new System.Drawing.Size(191, 22);
            this.districtsEditEnable_CheckBox.TabIndex = 5;
            this.districtsEditEnable_CheckBox.Text = "Редактировать участки";
            this.districtsEditEnable_CheckBox.UseVisualStyleBackColor = true;
            this.districtsEditEnable_CheckBox.CheckedChanged += new System.EventHandler(this.districtsEditEnable_CheckBox_CheckedChanged);
            // 
            // usersEditEnable_CheckBox
            // 
            this.usersEditEnable_CheckBox.AutoSize = true;
            this.usersEditEnable_CheckBox.Location = new System.Drawing.Point(18, 168);
            this.usersEditEnable_CheckBox.Name = "usersEditEnable_CheckBox";
            this.usersEditEnable_CheckBox.Size = new System.Drawing.Size(219, 22);
            this.usersEditEnable_CheckBox.TabIndex = 6;
            this.usersEditEnable_CheckBox.Text = "Редактировать работников";
            this.usersEditEnable_CheckBox.UseVisualStyleBackColor = true;
            this.usersEditEnable_CheckBox.CheckedChanged += new System.EventHandler(this.usersEditEnable_CheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Участок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Работник";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 258);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usersEditEnable_CheckBox);
            this.Controls.Add(this.districtsEditEnable_CheckBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.btnDeleteDistrictUser);
            this.Controls.Add(this.btnAddDistrictUser);
            this.Controls.Add(this.usrCombobox);
            this.Controls.Add(this.distrCombobox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Нормирование: БД пользователей";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox distrCombobox;
        private System.Windows.Forms.ComboBox usrCombobox;
        private System.Windows.Forms.Button btnAddDistrictUser;
        private System.Windows.Forms.Button btnDeleteDistrictUser;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox districtsEditEnable_CheckBox;
        public System.Windows.Forms.CheckBox usersEditEnable_CheckBox;
    }
}