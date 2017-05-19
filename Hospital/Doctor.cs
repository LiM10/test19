using System;
using System.Collections.Generic;

namespace Hospital
{
    public class Doctor
    {
        public string Name;
        public string Surname;
        Department instance = new Department();

        public static List<string> Doctors = new List<string>() { "Elxan Bashekimi", "Perviz Doxtur", "Baxsi Nevroloq", "Nigar Bashekim", "Cefer Psixoloq" };
        public Doctor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public static void ShowAllDoctors()
        {
            for (int i = 0; i < Doctors.Count; i++)
            {
                Console.WriteLine(i+1 +"."+ Doctors[i]);
            }
        }

        public static string ShowDoctor(int num)
        {
            if (num > Doctors.Count || num <= 0)
            {
                Console.WriteLine("Bele bir hekim yoxdur!!!");
                ShowAllDoctors();
            }
            else
            {
                Console.WriteLine("Hekimin adi: " + Doctors[num - 1]);
                return Doctors[num - 1];
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
