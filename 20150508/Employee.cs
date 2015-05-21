using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150508
{
    class Employee
    {
        private int _salary;
        private string _name;
        private string _bonus;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int salary
        {
            set
            {
                _salary = value;
                if (value <= 20000)
                {
                    this._salary = 22000;
                }
                else if (value >= 60000)
                {
                    this._salary = 60000;
                }
                else
                {
                    this._salary = salary;
                }
            }
            get
            {
                return this._salary;
            }

        }
        public void setSalary(int salary)
        {
            if (salary <= 20000)
            {
                this.salary = 22000;
            }
            else if (salary >= 60000)
            {
                this.salary = 60000;
            }
            else
            {
                this.salary = salary;
            }

        }
        public int getSalary(int salary)
        {
            return this.salary;
        }

    }
}
