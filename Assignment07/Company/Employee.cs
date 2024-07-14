using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment07.Company
{
    internal class Employee : IComparable<Employee>
    // Implementing IComparable<Employee> interface to define a natural ordering for Employee objects based on their hire date.
    // This allows us to easily sort Employee objects using Array.Sort or similar methods.
    {
        #region Automatic Property
        public int ID { get; set; }
        public string Name { get; set; }

        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HireDate HireDate { get; set; }
        #endregion

        #region FullProperty
        private string gender;

      

        public string Gender
        {
            get { return gender; }
            set
            {
                if (value == "M" || value == "F")
                    gender = value;
                else
                    throw new ArgumentException("Gender must be 'M' or 'F'");
            }
        }
        #endregion

        #region Constructor
        public Employee(int id, string name, string gender, SecurityLevel securityLevel, decimal salary, HireDate hireDate)
        {
            ID = id;
            Name = name;
            Gender = gender;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
        }
        #endregion
        
        #region StringOverride
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Security Level: {SecurityLevel}, Salary: {Salary.ToString("C", CultureInfo.CurrentCulture)}, Hire Date: {HireDate}";
        }
        #endregion

        #region Methods
        public int CompareTo(Employee other)
        {
            if (other == null) return 1;
            return this.HireDate.Year != other.HireDate.Year ? this.HireDate.Year.CompareTo(other.HireDate.Year) :
                   this.HireDate.Month != other.HireDate.Month ? this.HireDate.Month.CompareTo(other.HireDate.Month) :
                   this.HireDate.Day.CompareTo(other.HireDate.Day);
        }
        #endregion


    }
}
