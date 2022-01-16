using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompanyHierarchy;
using System.Collections.Generic;

namespace CompanyHierarchy.UnitTest
{
    [TestClass]
    public class CompanyHieararchyTest
    {
        readonly TreeNode<Employee> tree = CompanyData.BuildCompany();
        


        [TestMethod]
        public void ListSubLevelEmployees_InputBob_ReturnsTwoEmployees()
        {
            // Arrange            
            var inputName = "Bob";
            var expectedNumberOfElements = 2;

            // Act                      
            LinkedList<TreeNode<Employee>> list = Search.listSubLevelEmployees(tree, inputName);
            System.Console.WriteLine("Test1: {0}", list.Count);

            // Assert
            Assert.IsTrue(list.Count == expectedNumberOfElements);
        }

        [TestMethod]
        public void ListSubLevelEmployees_InputFrank_ReturnsTwoEmployees()
        {
            // Arrange            
            var inputName = "Frank";
            var expectedNumberOfElements = 2;

            // Act
            LinkedList<TreeNode<Employee>> list = new LinkedList<TreeNode<Employee>>();
            list = Search.listSubLevelEmployees(tree, inputName);
            System.Console.WriteLine("Test2: {0}", list.Count);

            // Assert
            Assert.IsTrue(list.Count == expectedNumberOfElements);
        }

        
        [TestMethod]
        public void ListSameLevelEmployees_InputJoe_ReturnsTwoEmployees()
        {
            // Arrange
            var inputName = "Joe";
            var expectedNumberOfElements = 2;

            // Act
            LinkedList<TreeNode<Employee>> list = new LinkedList<TreeNode<Employee>>();
            list = Search.listSameLevelEmployees(tree, inputName);
            System.Console.WriteLine("Test3: {0}", list.Count);

            // Assert
            Assert.IsTrue(list.Count == expectedNumberOfElements);
        }

        [TestMethod]
        public void ListSameLevelEmployees_InputAlice_ReturnsZeroEmployees()
        {
            // Arrange
            var inputName = "Alice";
            var expectedNumberOfElements = 0;

            // Act
            LinkedList<TreeNode<Employee>> list = new LinkedList<TreeNode<Employee>>();
            list = Search.listSameLevelEmployees(tree, inputName);
            System.Console.WriteLine("Test4: {0}", list.Count);

            // Assert
            Assert.IsTrue(list.Count == expectedNumberOfElements);
        }

        [TestMethod]
        public void ListSameLevelEmployees_InputHenrik_ReturnsOneEmployee()
        {
            // Arrange
            var inputName = "Henrik";
            var expectedNumberOfElements = 1;

            // Act
            LinkedList<TreeNode<Employee>> list = Search.listSameLevelEmployees(tree, inputName);
            System.Console.WriteLine("Test5: {0} {1}", Search.listSameLevelEmployees(tree, inputName).Count, inputName);

            // Assert
            Assert.IsTrue(list.Count == expectedNumberOfElements);
        }

        [TestMethod]
        public void ListSameLevelEmployees_InputGeorge_ReturnsThreeEmployees()
        {
            // Arrange
            var inputName = "George";
            var expectedNumberOfElements = 3;

            // Act
            //LinkedList<TreeNode<Employee>> list = Search.listSameLevelEmployees(tree, inputName);
            //System.Console.WriteLine("Test6: {0}", list.Count);

            // Assert
            Assert.IsTrue(Search.listSameLevelEmployees(tree, inputName).Count == expectedNumberOfElements);
        }        
    }
}