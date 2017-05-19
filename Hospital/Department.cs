using System;
using System.Collections.Generic;

namespace Hospital
{
    public class Department
    {
        public static List<string> Departments = new List<string>() { "Department 1", "Department 2", "Department 3", "Department 4", "Department 5" };

        public static void ShowAllDepartment()
        {
            for (int i = 0; i < Departments.Count; i++)
            {
                Console.WriteLine(i+1 +"."+ Departments[i]);
            }
        }
        public static string ShowDepartment(int num)
        {
            if (num > Departments.Count || num <= 0)
            {
                Console.WriteLine("Bele bir sobe yoxdur!!!");
                ShowAllDepartment();
            }
            else
            {
                Console.WriteLine("Sobenin adi: " + Departments[num - 1]);
                return Departments[num - 1];
            }
            return null;
        }

        public static int Input(string message)
        {
            Console.Write(message);
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }


    }
}
