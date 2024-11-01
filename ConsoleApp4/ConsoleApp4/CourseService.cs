using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class CourseService
    {
        static Group[] groups = new Group[0];

        public static void AddGroup(Group group)
        {
            Array.Resize(ref groups, groups.Length + 1);
            groups[groups.Length - 1] = group;
        }
        public Group[] RemoveGroup(Group group)
        {
            Group[] newArr = new Group[0];

            for (int i = 0; i < groups.Length; i++) 
            {
                if (groups[i] != group)
                {
                    newArr[i] = groups[i];
                }
            }
            groups = newArr;
            return groups;
        }
        public static void ShowAllGroups()
        {
            for (int i = 0; i < groups.Length; i++)
            {
                Console.WriteLine($"Group name : {group._name}"
            }
        }
        public static string Capitalise(string name)
        {
            return name.Trim().Substring(0, 1).ToUpper().Substring(1).ToLower();
        }
        public static void ChangeNum()
        {
            int number = Convert.ToInt32(Console.ReadLine());

            int groupNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < groups.Length; i++)
            {
                if (i == groupNum)
                {
                    groups[i]._num = number;
                }
            }
        }
    }
}
