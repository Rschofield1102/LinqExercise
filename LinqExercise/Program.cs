using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine("sum");
            Console.WriteLine("");
            Console.WriteLine(numbers.Sum());

            //TODO: Print the Average of numbers
            Console.WriteLine("average");
            Console.WriteLine("");
            Console.WriteLine(numbers.Average());

            //TODO: Order numbers in ascending order and print to the console

            Console.WriteLine("Assending order");
            Console.WriteLine("");
            var assending = numbers.OrderBy(x => x);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);

            }


            //TODO: Order numbers in descending order and print to the console
            Console.WriteLine("Decending order");
            Console.WriteLine("");
            var collection = numbers.OrderByDescending(x => x);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }


            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Greater than 6");
            Console.WriteLine("");
            var myCollection = numbers.Where(x => x > 6);
            foreach (var item in myCollection)
            { Console.WriteLine(item); }


            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("ascending by 4 only");
            Console.WriteLine("");
            var order = numbers.Take(4).ToList();
            foreach (var item in order)
            { Console.Write(item); }
            Console.WriteLine("");

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            Console.WriteLine("Change to your age");
            Console.WriteLine("");
            numbers[4] = 31;
            foreach (var item in numbers.OrderByDescending(x => x))
            {
                Console.WriteLine(item);
            }

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();


            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("Full name  C or S");
            Console.WriteLine("");
            var list = employees.Where(x => x.FirstName[0] == 'C'|| x.FirstName[0] == 'S').OrderBy(x => x.FirstName);

            foreach (var x in list)
            { Console.Write($"{x.FirstName}"); }


            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console
            //and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Full name ,age");
            Console.WriteLine("");
            var newList = employees.OrderBy(x => x.Age > 26);

            foreach(var x in newList)
            {
                Console.WriteLine($"Age: {x.Age} Name: {x.FirstName}");
            }




            //TODO: Print the Sum of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Total Employees years of experience");
            Console.WriteLine("");
            var oneC = employees.OrderBy(x => x.YearsOfExperience <= 10).OrderBy(x => x.Age >35).Sum(x => x.YearsOfExperience);
            Console.WriteLine($"{oneC}");
            //foreach(var x in oneC)
            //{
            //    Console.WriteLine($"YOE: {x.YearsOfExperience} Age:{x.Age}");
            //}


            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10
            //AND Age is greater than 35.
            Console.WriteLine("Average YOE is equal or less than 10, and Age is greater than 35");
            Console.WriteLine("");
            var YOE = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);
            Console.WriteLine($"{YOE}");

            //fixed had to take Years of experience and get the sum. Return the sum

            //foreach(var item in YOE)
            //{
            //    Console.WriteLine($"YOE:{item.YearsOfExperience} Age :{item.Age}");
            //}


            //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("List of Employess");
            employees =  employees.Append(new Employee("Yoon", "Cha", 45, 1)).ToList();
            foreach(var item in employees)
            {
                Console.WriteLine($"Age: {item.Age} Name: {item.FullName}");
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
