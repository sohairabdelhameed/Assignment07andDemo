using Assignment07.Company;
using System;
using System.ComponentModel;
using System.Xml.Linq;

namespace Assignment07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part02
            #region Question01
            //write a C# program to
            //display the details of all the persons in the array.
            //Person[] persons = new Person[3];
            //persons[0] = new Person("Sohair",23);
            //persons[1] = new Person("Morad", 5);
            //persons[2] = new Person("Malak", 18);

            //foreach (Person person in persons)
            //{
            //    person.Display();
            //}
            #endregion

            #region Question02
            // Write a C#
            //program that takes details of 3 persons as
            //input from the user and displays the
            //name and age of the oldest person.

            //Person[] persons = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Enter name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Enter age: ");
            //    int age = int.Parse(Console.ReadLine());
            //    persons[i] = new Person(name, age);
            //}

            //Person oldest = persons[0];
            //foreach (var person in persons)
            //{
            //    if (person.Age > oldest.Age)
            //    {
            //        oldest = person;
            //    }
            //}

            //Console.WriteLine($"The oldest person is {oldest.Name} with {oldest.Age} years.");
            #endregion
            #endregion

            #region Part03
            #region Question03

            Employee[] employees = new Employee[3];
            employees[0] = new Employee(1, "Sohair", "F", SecurityLevel.DBA, 70000, new HireDate(12, 5, 2024));
            employees[1] = new Employee(2, "Morad", "M", SecurityLevel.Guest, 50000, new HireDate(15, 8, 2023));
            employees[2] = new Employee(3, "AbdelHameed", "M", SecurityLevel.Developer, 60000, new HireDate(18, 3, 2000));

            Array.Sort(employees);

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            #endregion
            #endregion


        }
    }
}
