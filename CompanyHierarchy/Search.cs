using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class Search
    {
        // Lists used by the search functions
        // private static LinkedList<TreeNode<Employee>> listOfChildren = new LinkedList<TreeNode<Employee>>();
        // private static LinkedList<TreeNode<Employee>> listOfSubLevelEmployees = new LinkedList<TreeNode<Employee>>();
        // private static LinkedList<TreeNode<Employee>> listOfSameLevelEmployees = new LinkedList<TreeNode<Employee>>();

        // Helper function to listSublevelEmployees()
        private static List<TreeNode<Employee>> GetChildrenOfNode(TreeNode<Employee> treeNode)
        {
            List<TreeNode<Employee>> listOfChildren = new List<TreeNode<Employee>>();            
             //listOfChildren.AddLast(treeNode);

            foreach (TreeNode<Employee> child in treeNode.Children)
            {
                //getChildrenOfNode(child);
                listOfChildren.Add(child);
                listOfChildren.Concat(GetChildrenOfNode(child));               
                
            }

            return listOfChildren;
        }

        // General helper function that returns the Node matching the search criteria of input Value
        private static TreeNode<Employee> FindNodeByValue(TreeNode<Employee> treeNode, string value)
        {
            if (treeNode.Data.Name == value)
            {
                return treeNode;
            }

            else if (treeNode.Children != null)
            {
                TreeNode<Employee> result = null;
                foreach (TreeNode<Employee> child in treeNode.Children)
                {
                    if (result == null)
                        result = FindNodeByValue(child, value);
                }
                return result;
            }
            return null;
        }


        public static List<TreeNode<Employee>> ListSubLevelEmployees(TreeNode<Employee> searchTree, string name)
        {
            TreeNode<Employee> inputNode = FindNodeByValue(searchTree, name);
            List<TreeNode<Employee>> listOfSubLevelEmployees = new List<TreeNode<Employee>>();

            //listOfSubLevelEmployees.Clear();
            //listOfChildren.Clear();
            foreach (TreeNode<Employee> element in GetChildrenOfNode(inputNode))
            {
                if (element.Data.Name != name)
                    listOfSubLevelEmployees.Add(element);
            }
            return listOfSubLevelEmployees;
        }

        public static List<TreeNode<Employee>> ListSameLevelEmployees(TreeNode<Employee> searchTree, string name)
        {
            TreeNode<Employee> inputNode = FindNodeByValue(searchTree, name);
            List<TreeNode<Employee>> listOfSameLevelEmployees = new List<TreeNode<Employee>>();

        //listOfSameLevelEmployees.Clear();
            foreach (TreeNode<Employee> element in TreeNode<Employee>.Index)
            {
                if (element.Level == inputNode.Level && element != inputNode) // Make sure we don't add the input employee to the result list                                  
                    listOfSameLevelEmployees.Add(element);
            }
            return listOfSameLevelEmployees;
        }


    }
}