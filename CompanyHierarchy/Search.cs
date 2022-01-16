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
        private static LinkedList<TreeNode<Employee>> listOfChildren = new LinkedList<TreeNode<Employee>>();
        private static LinkedList<TreeNode<Employee>> listOfSubLevelEmployees = new LinkedList<TreeNode<Employee>>();
        private static LinkedList<TreeNode<Employee>> listOfSameLevelEmployees = new LinkedList<TreeNode<Employee>>();

        // Helper function to listSublevelEmployees()
        private static LinkedList<TreeNode<Employee>> getChildrenOfNode(TreeNode<Employee> treeNode)
        {
            listOfChildren.AddLast(treeNode);

            foreach (TreeNode<Employee> child in treeNode.Children)
            {
                getChildrenOfNode(child);
            }

            return listOfChildren;
        }

        // General helper function that returns the Node matching the search criteria of input Value
        private static TreeNode<Employee> findNodeByValue(TreeNode<Employee> treeNode, string value)
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
                        result = findNodeByValue(child, value);
                }
                return result;
            }
            return null;
        }


        public static LinkedList<TreeNode<Employee>> listSubLevelEmployees(TreeNode<Employee> searchTree, string name)
        {
            TreeNode<Employee> inputNode = findNodeByValue(searchTree, name);

            listOfSubLevelEmployees.Clear();
            listOfChildren.Clear();
            foreach (TreeNode<Employee> element in getChildrenOfNode(inputNode))
            {
                if (element.Data.Name != name)
                    listOfSubLevelEmployees.AddLast(element);
            }
            return listOfSubLevelEmployees;
        }

        public static LinkedList<TreeNode<Employee>> listSameLevelEmployees(TreeNode<Employee> searchTree, string name)
        {
            TreeNode<Employee> inputNode = findNodeByValue(searchTree, name);
            
            listOfSameLevelEmployees.Clear();
            foreach (TreeNode<Employee> element in TreeNode<Employee>.Index)
            {
                if (element.Level == inputNode.Level && element != inputNode) // Make sure we don't add the input employee to the result list                                  
                    listOfSameLevelEmployees.AddLast(element);
            }
            return listOfSameLevelEmployees;
        }


    }
}