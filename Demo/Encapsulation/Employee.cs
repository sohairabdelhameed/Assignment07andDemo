using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Encapsulation
{
    internal struct Employee
    {
        #region Atributes
        public int Id;
        private string Name;
        private decimal salary;
        #endregion

        //Encapsulation: seperate the Data Defination[Attribute] from it use
        // Using [Getter Setter ] - [Property]

        //Apply the Encupsulation:

        #region Apply Encupsulation [Getter Setter ]
        
        //private Attribute
        //Create the 2 functions [Getter - Setter ]

        //Getter

        public string? GetName()
        { 
            return Name;

        
        }


        //Setter

        public void SetName(string? Value)
        {

            //Name = Value;
            //Validating the Name
            Name = Value?.Length > 6 ? Value.Substring(0,6) : Value ;


        }

        #endregion

        #region Apply Encupsulation [Property]
        //2.1 Full Property
        //2.2 Automatic Property
        //2.3 Indexer
        
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        
     

        //Full Property:

        //private int age;
        //public int Age
        //{
        //    get { return age; }
        //    set { age = value; }
        //} // no need sense we are not validating it

        //Automatic Property:

        public int Age { get; set; } //Property
                                     //Compiler will generate Hidden Private Attribute [Backing Feild]
                                     //we can see it in the Ill

        #endregion

        #region Derived Attribute
        // private decimal deduction; //we are not using it sense we are calculating it in the runtime like [Derive attribute]
        //We need to use Attribute for it
        public decimal Deduction //Readonly Property
        {
            get { return Salary * 0.2M; }

        } 
        #endregion



        #region Constructor
        public Employee(int id, string name, decimal salary, int age)
        {
            Id = id;
            Name = name;
            this.salary = salary;
            Age = age;
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Id = {Id}\nName = {Name}\nSalary = {salary:c}\nAge = {Age}";
        } 
        #endregion

    }
}
