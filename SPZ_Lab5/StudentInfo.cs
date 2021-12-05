using System;
using System.Windows.Forms;
using SPZ_Lab5.Model;

namespace SPZ_Lab5.View
{
    public partial class StudentInfo : Form
    {
        Student current;
        public StudentInfo()
        {
            InitializeComponent();
        }
        public StudentInfo(object obj)
        {
            InitializeComponent();
            current = obj as Student;
            group_comboBox.Items.AddRange(Groups.GroupNamesList.ToArray());
            group_comboBox.Items.Remove(Groups.GroupNamesList[0]);
            if (current != null)
            {
                lastname_textBox.Text = current.LastName;
                firstname_textBox.Text = current.FirstName;
                group_comboBox.SelectedItem = current.Group.ToString(); 
            }
        }
        private void add_button_Click(object sender, EventArgs e)//обработка вызова метода добавления
        {
            if (current != null)
            {
                Repository.Add(new Student(lastname_textBox.Text, firstname_textBox.Text, group_comboBox.SelectedItem.ToString()));
            }
            this.Close();
        }
        private void delete_button_Click(object sender, EventArgs e)//обработка вызова метода удаления
        {
            if(current != null)
            Repository.Remove(current);
            this.Close();
        }
        private void edit_button_Click(object sender, EventArgs e)//обработка вызова метода редактирования
        {
            if (current.LastName != lastname_textBox.Text)
                current.LastName = lastname_textBox.Text;
            if (current.FirstName != firstname_textBox.Text)
                current.FirstName = firstname_textBox.Text;
            if (current.Group.GroupNumber != group_comboBox.SelectedItem.ToString())
                current.Group.GroupNumber = group_comboBox.SelectedItem.ToString();
            this.Close();
        }
    }
}
