using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Display
    {
        public static void printTree(TreeNode<Employee> treeNode)
        {
            string indent = CreateIndent(treeNode.Level);
            Console.Write(indent);
            Console.WriteLine(treeNode.Data);

            foreach (TreeNode<Employee> child in treeNode.Children)
            {
                printTree(child); // !!-Recursion-!!
            }
                  
        }

        public static void printSubLevelEmployees(TreeNode<Employee> searchTree, string name)
        {
            List<TreeNode<Employee>> list = Search.ListSubLevelEmployees(searchTree, name);
            foreach (TreeNode<Employee> element in list)
            {
                Console.Write("{0}, ", element.Data);
            }          
        }

        public static void printSameLevelEmployees(TreeNode<Employee> searchTree, string name)
        {
            List<TreeNode<Employee>> list = Search.ListSameLevelEmployees(searchTree, name);
            foreach (TreeNode<Employee> element in list)
            {
                Console.Write("{0}, ", element.Data);
            }
        }

        private static String CreateIndent(int depth)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < depth; i++)
            {
                sb.Append(' ').Append(' ').Append(' ');
            }
            return sb.ToString();
        }
    }
}
