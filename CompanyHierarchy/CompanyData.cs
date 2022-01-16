using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class CompanyData
    {
        public static TreeNode<Employee> BuildCompany()
        {
            TreeNode<Employee>.Index.Clear();
            Employee Alice = new Employee("Alice", employeeType.Chief);
            Employee Bob = new Employee("Bob", employeeType.Manager);
            Employee Charlie = new Employee("Charlie", employeeType.Manager);
            Employee Joe = new Employee("Joe", employeeType.Contributor);
            Employee David = new Employee("David", employeeType.Contributor);
            Employee Eric = new Employee("Eric", employeeType.Contributor);
            Employee Frank = new Employee("Frank", employeeType.Manager);
            Employee George = new Employee("George", employeeType.Contributor);
            Employee Henrik = new Employee("Henrik", employeeType.Contributor);
            Employee Irena = new Employee("Irena", employeeType.Contributor);
            
            // Test Employee
            Employee Test = new Employee("Test", employeeType.Contributor);

            TreeNode<Employee> root = new TreeNode<Employee>(Alice);
            TreeNode<Employee> node1 = root.AddChild(new TreeNode<Employee>(Bob));
            TreeNode<Employee> node2 = root.AddChild(new TreeNode<Employee>(Charlie));
            TreeNode<Employee> node3 = root.AddChild(new TreeNode<Employee>(Joe)); node3.isLeaf = true;
            TreeNode<Employee> node11 = node1.AddChild(new TreeNode<Employee>(David)); node11.isLeaf = true;
            TreeNode<Employee> node12 = node1.AddChild(new TreeNode<Employee>(Eric)); node12.isLeaf = true;
            TreeNode<Employee> node21 = node2.AddChild(new TreeNode<Employee>(Frank)); 
            TreeNode<Employee> node22 = node2.AddChild(new TreeNode<Employee>(George)); node22.isLeaf = true;
            TreeNode<Employee> node211 = node21.AddChild(new TreeNode<Employee>(Henrik)); node211.isLeaf = true;
            TreeNode<Employee> node212 = node21.AddChild(new TreeNode<Employee>(Irena)); node212.isLeaf = true;

            // Attempting to add Employee to a Contributor
            TreeNode<Employee> node31 = node3.AddChild(new TreeNode<Employee>(Test));


            return root;
        }
        

        
    }
}
