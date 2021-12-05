using System;
using System.Runtime.Serialization;

namespace SPZ_Lab5.Model
{
    [DataContract]
    [KnownType(typeof(Groups))]
    class Student
    {
        [DataMember]
        public string LastName { get; set; }//гет сет фамилии
        [DataMember]
        public  string FirstName { get; set; }//гет сет имени
        [DataMember]
        public Groups Group{ get; set; }//группа
        static Random random = new Random();
        //массив фамилий
        private static string[] lastNamesArray = new string[] { "Осадчих", "Коротких", "Чепурных", "Рындин", "Зборовских", 
                                                                 "Тарасовых", "Филипьевых", "Зубенко", "Бондаренко", "Коваленко",
                                                                 "Иваненко", "Коваль", "Флекс", "Хайп", "Шмыга", "Поставьте3Пожалуйста"};
       //массив имен
        private static string[] firstNamesArray = new string[] { "Александр","Антон", "Максим", "Алексей", "Михаил", "Артур",
                                                                 "Марина", "Ольга","Виолетта", "Мария", "Дарья","Илья",
                                                                  "Константин", "Владимир", "Виктория", "Анна", "Ксения",
                                                                  "Станислав", "Виктор", "Полина", "Эмма", "Глория", "Пудж"};
        public Student()//по умолчанию
        {
            LastName = lastNamesArray[random.Next(0, lastNamesArray.Length)];
            FirstName = firstNamesArray[random.Next(0, firstNamesArray.Length)];
            Group = new Groups(random);
        }
        public Student(string lastName, string firstName, string groupNumber)//инициализирующий с параметрами
        {
            LastName = lastName;
            FirstName = firstName;
            Group = new Groups(groupNumber);
        }
    }
}
