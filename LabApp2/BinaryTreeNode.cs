using System;

namespace LabApp2
{
    public class BinaryTreeNode<T> : IComparable<T> where T : IComparable<T>
    {
        public T Value { get; }
        public BinaryTreeNode<T> LeftNode { get; set; }
        public BinaryTreeNode<T> RightNode { get; set; }

        public BinaryTreeNode(T value)
        {
            Value = value;
        }

        public int CompareTo(T other)
        {
            return Value.CompareTo(other);
        }
    }
}