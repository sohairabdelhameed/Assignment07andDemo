using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment07
{
    internal struct Person
    {
        //Define a struct "Person" with properties "Name" and "Age". Create an array
        //of three "Person" objects and populate it with data.

        #region Properties
        //we will use Automatic property since we will not validate it
        public string Name { get; set; }
        public int Age { get; set; }

        #endregion

        #region Constructor
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
            
        }

        #endregion

        #region Method
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
        #endregion
    }




}
