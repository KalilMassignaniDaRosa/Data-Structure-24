using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Quiz;

namespace BinaryTree
{
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T>? Root { get; set; }
        public int Count { get; set; }

        public enum TraversalEnum
        {
            PREORDER, INORDER, POSTORDER
        }

        public void TraversePreOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                result.Add(node);
                TraversePreOrder(node.Left, result);
                TraversePreOrder(node.Right, result);
            }
        }

        public void TraverseInOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                TraverseInOrder(node.Left, result);
                result.Add(node);
                TraverseInOrder(node.Right, result);
            }
        }

        public void TraversePostOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                TraversePostOrder(node.Left, result);
                TraversePostOrder(node.Right, result);
                result.Add(node);
            }
        }

        public List<BinaryTreeNode<T>> Traverse(TraversalEnum mode)
        {
            List<BinaryTreeNode<T>> nodes = new();

            switch (mode)
            {
                case TraversalEnum.PREORDER:
                    TraversePreOrder(Root!, nodes);
                    break;
                case TraversalEnum.INORDER:
                    TraverseInOrder(Root!, nodes);
                    break;
                case TraversalEnum.POSTORDER:
                    TraversePostOrder(Root!, nodes);
                    break;
            }
            return nodes;
        }

        public int GetTreeHeight()
        {
            int height = 0;
            foreach (BinaryTreeNode<T> node in Traverse(TraversalEnum.PREORDER))
            {
                height = Math.Max(height, node.GetNodeHeight());
            }
            return height;
        }

        private static BinaryTree<QuizItem> GetTree()
        {
            BinaryTree<QuizItem> tree = new BinaryTree<QuizItem>();
            tree.Root = new BinaryTreeNode<QuizItem>()
            {
                Data = new QuizItem("Do you have experience in developing applications ? "),
                Children = new List<TreeNode<QuizItem>>()
                {
                    new BinaryTreeNode<QuizItem>()
                        {
                            Data = new QuizItem("Have you worked as a developer for more than 5 years"),
                            Children = new List<TreeNode<QuizItem>>()
                            {
                                new BinaryTreeNode<QuizItem>()
                                {
                                    Data = new QuizItem("Apply as a senior developer!")
                                },
                                new BinaryTreeNode<QuizItem>()
                                {
                                    Data = new QuizItem("Apply as a middle developer"!)
                                }
                            }
                        },
                        new BinaryTreeNode<QuizItem>()
                        {
                            Data = new QuizItem("Have you completed the university?"),
                            Children = new List<TreeNode<QuizItem>>()
                            {
                                new BinaryTreeNode<QuizItem>()
                                {
                                    Data = new QuizItem("Apply for a junior developer!")
                                },
                                new BinaryTreeNode<QuizItem>()
                                {
                                    Data = new QuizItem("Will you find some time during the semester?"),
                                    Children = new List<TreeNode<QuizItem>>()
                                    {
                                        new BinaryTreeNode<QuizItem>()
                                        {
                                            Data = new QuizItem("Apply for a junior developer!")
                                        },
                                        new BinaryTreeNode<QuizItem>()
                                        {
                                            Data = new QuizItem("Will you find some time the semester?"),
                                            Children = new List<TreeNode<QuizItem>>()
                                            {
                                                new BinaryTreeNode<QuizItem>()
                                                {
                                                    Data = new QuizItem("Apply for our long-time internship program!")
                                                },
                                                new BinaryTreeNode<QuizItem>()
                                                {
                                                    Data = new QuizItem("Apply for summer internship program!")
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
            };
            tree.Count = 9;
            return tree;
        }

    }
}