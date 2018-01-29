namespace Teht1
{
    class Employee
    {
        public string Name;
        public string Profession;
        public int Salary;

        public Employee( string name, string profession, int salary)
        {
            this.Name = name;
            this.Profession = profession;
            this.Salary = salary;
        }

        public Employee() : this("","",0)
        {

        }

        public override string ToString()
        {
            return "Employee:\n- Name: " + Name + "\n- Profession: " + Profession + "\n- Salary: " + Salary + "\n";
        }
    }
}
