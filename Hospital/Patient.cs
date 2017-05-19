namespace Hospital
{
    public class Patient
    {
        public string Name;
        public string Surname;
        Department instance = new Department();
        public void SelectDepartment()
        {
            
        }

        public Patient(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
    }
}
