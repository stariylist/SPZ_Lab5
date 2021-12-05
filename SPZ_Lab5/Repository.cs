using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace SPZ_Lab5.Model
{
    static class Repository
    {
        [DataMember]
        static public List<Student> Students { get; set; }//гет сет студентов
        static Repository()
        { 
            Students = new List<Student>(); //инициализирующий конструктор
        }
        static public void Generate()
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                Students.Add(new Student());//создаем лист студентов
            }
        }
       static public List<Student> SortByLastName(List<Student> students)
        {
            return students.OrderBy(student => student.LastName).ToList();//сортировка по имени
        }
        static public List<Student> SortByGroupNumber(List<Student> students)
        {
           return students.OrderBy(student => student.Group.GroupNumber).ToList();//сортировкa по группе
        }
        static public List<Student> OutputList(string groupName)
        {
            return Students.Where(student => student.Group.GroupNumber == groupName).ToList();//вывод студентов определенной группы
        }
        static public void Remove(Student student)//удаление студента
        {
            if(Students.Contains(student))
            {
                Students.Remove(student);
            }
        }
        static public void RemoveGroup(string groupName)//удаление группы и студентов
        {
            Groups.Remove(groupName);
            Students.RemoveAll(student => student.Group.GroupNumber == groupName);
        }
        static public void RenameGroup(string groupName, string newGroupName)//метод переименования группы
        {
            foreach(var student in Students)
            {
                if (student.Group.GroupNumber == groupName)
                    student.Group.GroupNumber = newGroupName;
            }
        }
        static public void Add(Student student)
        {
                Students.Add(student);//добавляем студента
        }
    }
}
