using System;
using System.Windows.Forms;
using SPZ_Lab5.Model;
using SPZ_Lab5.View;
using System.IO;


namespace SPZ_Lab5
{
    public partial class Form1 : Form
    {
        BindingSource binding;
        BindingSource bsCombobox;
         static string StoragePath { get; } = "Repository.json";//запись инфы о хранении данных
         static string GroupListPath { get; } = "Group.json";//запись инфы о группе

        public Form1()
        {
            InitializeComponent();
             
            if(File.Exists(StoragePath) && File.Exists(GroupListPath))
            {
                Repository.Students = Serialization.Deserialize(StoragePath, Repository.Students);
                Groups.GroupNamesList = Serialization.Deserialize(GroupListPath, Groups.GroupNamesList);
                File.Delete(StoragePath);
            }
            else Repository.Generate();
            binding = new BindingSource();
            
            binding.DataSource = Repository.Students;
            dataGridView.DataSource = binding;

            bsCombobox = new BindingSource();
            bsCombobox.DataSource = Groups.GroupNamesList;
            output_comboBox.DataSource = bsCombobox;
            
            dataGridView.ColumnHeaderMouseDoubleClick += OnMouseDoubleClick;
            output_comboBox.SelectedIndexChanged += OnSelectedIndexChanged;
        }

        private void OnMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)//обработка сортировки по дабл клику
        { 
            string selectedState = output_comboBox.SelectedItem.ToString();
            switch(e.ColumnIndex)
            {
                case 0://первая колонка фамилия
                    if (output_comboBox.SelectedItem != output_comboBox.Items[0])
                    {
                        binding.DataSource = Repository.SortByLastName(Repository.OutputList(selectedState));
                    }
                    else
                    {
                        Repository.Students = Repository.SortByLastName(Repository.Students);
                        binding.DataSource = Repository.Students;
                    }
                    
                    break;
                case 2://третья колонка группа
                    if (output_comboBox.SelectedItem == output_comboBox.Items[0])
                        binding.DataSource = Repository.SortByGroupNumber(Repository.Students);
                    break;
            }
        }
        private void OnSelectedIndexChanged(object sender, EventArgs e)//сохранение выделенного объекта
        {
            string selectedState = output_comboBox.SelectedItem.ToString();
            if(output_comboBox.SelectedItem == output_comboBox.Items[0])
            {
                binding.DataSource = Repository.Students;
            }
            else binding.DataSource = Repository.OutputList(selectedState);
        }

        private void StudentInfo_button_Click(object sender, EventArgs e)//Вызов диалогового окна о студенте
        {
            StudentInfo StudentInfo = new StudentInfo(binding.Current);
            StudentInfo.ShowDialog();
            binding.ResetBindings(true);
        }

        private void button1_Click(object sender, EventArgs e)//Вызов диалогового окна о группе
        {
            GroupInfo GroupInfo = new GroupInfo(binding.Current);
            GroupInfo.ShowDialog();
            binding.ResetBindings(true);
            bsCombobox.ResetBindings(true);
        }
    }
}
