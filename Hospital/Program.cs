using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adinizi daxil edin: ");
            Console.ReadLine();
            Console.WriteLine("Soyadinizi daxil edin: ");
            Console.ReadLine();
            Console.WriteLine();
            Department.ShowAllDepartment();
            Console.WriteLine();
            var selectedDepartment = Department.ShowDepartment(Department.Input("Sobeni secin:"));
            Doctor.ShowAllDoctors();
            Console.WriteLine();
            var selectedDoctor = Doctor.ShowDoctor(Doctor.Input("Hekimi secin:"));
        }
    }
}
