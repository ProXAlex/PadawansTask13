namespace PadawansTask13
{
    public class Employee
    {
        public Employee()
        {
        }

        public Employee(string surname, int age)
        {
            Surname = surname;
            Age = age;
        }

        private string Surname { get; set; }

        private int Age { get; set; }

        private string GetAgeAsString() => Age.ToString();

        public void ChangeSurname(string newSurname) => Surname = newSurname;

        public string GetInfo() => $"Surname: {Surname}, Age: {Age}";
    }
}