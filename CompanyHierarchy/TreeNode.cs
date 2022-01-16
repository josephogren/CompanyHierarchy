﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class TreeNode<T>
    {
        public T Data { get; set; } 
        public TreeNode<T> Parent { get; set; }
        public LinkedList<TreeNode<T>> Children { get; set; }
        // Index list for search
        public static LinkedList<TreeNode<T>> Index = new LinkedList<TreeNode<T>>();


        public bool isRoot
        {
            get { return Parent == null; }
        }    

        public bool isLeaf { set; get; }
        

        public int Level
        {
            get
            {
                if (this.isRoot)
                    return 0;
                return Parent.Level + 1;
            }


        }

        public TreeNode(T data)
        {
            this.Data = data;
            this.Children = new LinkedList<TreeNode<T>>();            
        }

        public TreeNode<T> AddChild(TreeNode<T> child)
        {
            child.Parent = this;
            if (isLeaf)
                Console.WriteLine("Cannot add: '{0}' to '{1}' [Node is a Leaf]", child.Data, this.Data);
            else
            {
                this.Children.AddLast(child);
                Index.AddLast(child); // Each time a childnode is added to the tree it also gets added to the Index
            }

            return child;
        }
                
    }



    
}
