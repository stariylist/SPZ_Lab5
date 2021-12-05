using System;
using System.Windows.Forms;
using SPZ_Lab5.Model;

namespace SPZ_Lab5.View
{
    public partial class GroupInfo : Form
    {
        Student current;
        public GroupInfo()
        {
            InitializeComponent();
        }
        public GroupInfo(object obj)
        {
            InitializeComponent();
            current = obj as Student;
            listGroup_comboBox.Items.AddRange(Groups.GroupNamesList.ToArray());
            listGroup_comboBox.Items.Remove(Groups.GroupNamesList[0]);
            if (current != null)
            {
                listGroup_comboBox.SelectedItem = current.Group.ToString();
                newGroup_textBox.Text = current.Group.ToString();
            }
            //Form1.binding.ResetBindings(true);
        }
        private void deleteGroup_button_Click(object sender, EventArgs e)//вызов метода удаления группы
        {
            string groupName;
            if((groupName = listGroup_comboBox.SelectedItem.ToString()) != null)
            Repository.RemoveGroup(groupName);
            this.Close();
        }

        private void rename_button_Click(object sender, EventArgs e)//вызов метода переименования группы
        {
            string newGroup = newGroup_textBox.Text;
            string oldGroup = listGroup_comboBox.SelectedItem.ToString();
            Groups.Rename(oldGroup, newGroup);
            Repository.RenameGroup(oldGroup, newGroup);
            this.Close();
        }

        private void addGroup_button_Click(object sender, EventArgs e)//вызов метода добавления группы
        {
            Groups.Add(newGroup_textBox.Text);
            this.Close();
        }
    }
}
