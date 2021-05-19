using System;
using System.Collections;
using System.Collections.Generic;

namespace LabApp2
{
    class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private BinaryTreeNode<T> Head { get; set; }
        
        public void Add(T value)
        {
            if (Head == null)
            {
                Head = new BinaryTreeNode<T>(value);
            }
            else
            {
                AddTo(Head, value);
            }
        }

        private void AddTo(BinaryTreeNode<T> node, T value)
        {
            while (true)
            {
                if (value.CompareTo(node.Value) < 0)
                {
                    if (node.LeftNode == null)
                    {
                        node.LeftNode = new BinaryTreeNode<T>(value);
                    }
                    else
                    {
                        node = node.LeftNode;
                        continue;
                    }
                }
                else
                {
                    if (node.RightNode == null)
                    {
                        node.RightNode = new BinaryTreeNode<T>(value);
                    }
                    else
                    {
                        node = node.RightNode;
                        continue;
                    }
                }

                break;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (Head == null)
            {
                yield break;
            }

            Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();
            BinaryTreeNode<T> current = Head;
            bool goLeftNext = true;
            stack.Push(current);

            while (stack.Count > 0)
            {
                if (goLeftNext)
                {
                    while (current.LeftNode != null)
                    {
                        stack.Push(current);
                        current = current.LeftNode;
                    }
                }

                yield return current.Value;

                if (current.RightNode != null)
                {
                    current = current.RightNode;
                    goLeftNext = true;
                }
                else
                {
                    current = stack.Pop();
                    goLeftNext = false;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}