using System;
using System.Collections.Generic;


namespace CompanyHierarchy
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("COMPANY");

            // Construct the Company
            TreeNode<Employee> Company = CompanyData.BuildCompany();

            // Display the Company Hierarchy
            Display.printTree(Company);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            // Method 1 - Returns all Employees of a given Employee
            Console.WriteLine("*** Method 1 (Input: Bob) ***");
            Display.printSubLevelEmployees(Company, "Bob");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            // Method 1 - Returns all Employees of a given Employee
            Console.WriteLine("*** Method 1 (Input: Charlie) ***");
            Display.printSubLevelEmployees(Company, "Charlie");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            // Method 2 - Returns all the Employees at the same level of the hierarchy as the given Employee
            Console.WriteLine("*** Method 2 (Input: Bob) ***");
            Display.printSameLevelEmployees(Company, "Bob");
            Console.WriteLine("");
            Console.WriteLine("");

            // Method 2 - Returns all the Employees at the same level of the hierarchy as the given Employee
            Console.WriteLine("*** Method 2 (Input: Alice) ***");
            Display.printSameLevelEmployees(Company, "Alice");
            Console.WriteLine("");
            Console.WriteLine("");
        }    
    }
}
