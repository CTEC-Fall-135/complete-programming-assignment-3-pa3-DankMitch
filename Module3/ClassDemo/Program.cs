/*
Author: Dank Mitchell
Date: 11 Oct 2024
Assignment: PA3 Task 1
 */

using System;

namespace ClassDemo
{
    // define class name as Student
    public class Student
    {
        #region #2 Traditional Get/Set
        // Create field for name
        private string name;

        // Set getter and setter for name
        public string InputName()
        {
            return name;
        }
        public void OutputName(string value)
        {
            name = value;
        }
        #endregion

        #region #3 Property
        // Set field for address
        private string address;

        // Create property for address field
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        #endregion

        #region #4 Auto Property
        // Set field name for ID and auto property
        private int ID { get; set; }

        #endregion

        #region #5 Constructors
        // Create primary constructor that directly initalize all data members of class
        public Student(string name, string address, int id)
        {
            // Use this keyword for name field AND properties for others
            this.name = name;
            Address = address;
            ID = id;
        }
        // Create constructor that only takes name and initializes other with defaults
        public Student(string name) : this(name, "Default Address", 0)
        {
        }

        // Create default constructor with chaining
        public Student() : this("Default Name", "Default Address", 0)
        {
        }

        #endregion

        #region #6 Create Method
        // Demonstrate creation of a method
        // Create PrintState() method that print values of all fields in class
        public void PrintState()
        {
            Console.WriteLine($"Name: {name}\nAddress: {Address}\nID: {ID}\n");
        }

        #endregion

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create instance of Student class using primary constructor
            // and print the state of the object
            Student stud1 = new Student("William Thetiger", "37 Tiger Drive", 3769);
            stud1.PrintState();

            // Create instance of Student class using the constructor w/ name parameter
            // and print the state of the object
            Student stud2 = new Student("William Thetiger");
            stud2.PrintState();

            // Create instance of the student class using the default constructor
            // and print the state of the object
            Student stud3 = new Student();
            stud3.PrintState();
        }
    }
}
