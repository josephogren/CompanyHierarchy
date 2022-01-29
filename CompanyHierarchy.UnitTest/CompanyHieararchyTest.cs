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
            List<TreeNode<Employee>> list = Search.listSubLevelEmployees(tree, inputName);
            
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
            List<TreeNode<Employee>> list = Search.listSubLevelEmployees(tree, inputName);
            
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
            List<TreeNode<Employee>> list = Search.listSameLevelEmployees(tree, inputName);
            
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
            List<TreeNode<Employee>> list = Search.listSameLevelEmployees(tree, inputName);
            
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
            List<TreeNode<Employee>> list = Search.listSameLevelEmployees(tree, inputName);
           
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
            List<TreeNode<Employee>> list = Search.listSameLevelEmployees(tree, inputName);           

            // Assert
            Assert.IsTrue(list.Count == expectedNumberOfElements);
        }        
    }
}
