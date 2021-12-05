using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SPZ_Lab5.Model
{
    [DataContract]
    class Groups
    {
        [DataMember]
        public string GroupNumber { get; set; } //геттер и сеттер номера группы
        [DataMember]
        public static List<string> GroupNamesList { get; set; }//список групп
        private static string[] groupNamesArray = new string[] {"КИУКИ", "ПЗПИ", "КНТ"};//названия групп
        public Groups(Random random)
        {
            GroupNumber = groupNamesArray[random.Next(0, groupNamesArray.Length)] + '-' + 19 + '-' + random.Next(1, 4);//создаем рандомную группу
        }
        public Groups(string groupNumber)
        {
            GroupNumber = groupNumber;
        }
        public Groups()
        { }
        static Groups()
       {
           GroupNamesList = new List<string>();
            GroupNamesList.Add("All groups");
           for (int j = 0; j < groupNamesArray.Length; j++)
           {
               for(int i = 1; i < 4; i++)
                   GroupNamesList.Add(groupNamesArray[j] + '-' + 19 + '-' + i);//добавляем в список группу
           }
       }
        public static void Remove(string groupName)
        {
            GroupNamesList.Remove(groupName);//метод удаления группы
        }
        public static void Rename(string groupName, string newGroupName)
        {
           int index = GroupNamesList.IndexOf(groupName);
            GroupNamesList[index] = newGroupName;//по индексу переименовываем группу
        }
        public static void Add(string groupName)
        {
            if(!GroupNamesList.Contains(groupName))
            GroupNamesList.Add(groupName);//добавляем группу вручную
        }
        public override string ToString()
        {
            return GroupNumber;//переобределение метода ToString()
        }
    }
}
