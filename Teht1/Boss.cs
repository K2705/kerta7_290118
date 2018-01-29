using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Boss : Employee
    {
        public string Car;
        public int Bonus;

        public Boss(string name, string profession, int salary, string car, int bonus)
        {
            this.Name = name;
            this.Profession = profession;
            this.Salary = salary;
            this.Car = car;
            this.Bonus = bonus;
        }

        public Boss() : this("","",0,"",0)
        {

        }

        public override string ToString()
        {
            return "Boss:\n- Name: " + Name + "\n- Profession: " + Profession + "\n- Salary: " + Salary + "\n- Car: " + Car + "\n- Bonus: " + Bonus + "\n";
        }
    }
}
