using System.Collections.Generic;
using System.Threading;

namespace Data.Model
{
    public class Employee
    {
        public string name { get; }

        public Employee(string name)
        {
            this.name = name;
        }

        public Employee(string name, bool isBusy)
        {
            this.name = name;
        }

        public override string ToString()
        {
            string employeeInfo = "\n";
            employeeInfo += "\tName       : " + name;
            return employeeInfo;
        }

        public override bool Equals(object value)
        {
            if ((value == null) || !this.GetType().Equals(value.GetType()))
            {
                return false;
            }

            Employee employee = value as Employee;

            return (employee != null)
                && (name == employee.name);
        }

        public override int GetHashCode()
        {
            var hashCode = -1068211290;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            return hashCode;
        }
    }
}
