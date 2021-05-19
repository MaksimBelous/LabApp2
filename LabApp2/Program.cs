using System;
using System.Collections;
using System.Collections.Generic;

namespace LabApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector0 = new Vector("red", 10, 30);
            Vector vector1 = new Vector("green", 9, 40);
            Vector vector2 = new Vector("blue", 20, 60);
            Vector vector3 = new Vector("black", 5, 34);
            Vector vector4 = new Vector("white", 30, 180);

            Console.WriteLine("Generic collection Queue");
            Queue<Vector> queue = new Queue<Vector>();
            queue.Enqueue(vector0);
            queue.Enqueue(vector1);
            queue.Enqueue(vector2);
            queue.Enqueue(vector3);
            queue.Enqueue(vector4);
            
            Console.WriteLine("Dequeuing '{0}'", queue.Dequeue());
            Console.WriteLine("Dequeuing '{0}'", queue.Dequeue());
            Console.WriteLine("Dequeuing '{0}'", queue.Dequeue());
            Console.WriteLine("Dequeuing '{0}'", queue.Dequeue());
            Console.WriteLine("Dequeuing '{0}'", queue.Dequeue());

            Console.WriteLine("Non-Generic collection ArrayList");

            ArrayList arrayList = new ArrayList();
            arrayList.Add(vector0);
            arrayList.Add(vector1);
            arrayList.Add(vector2);
            arrayList.Add(vector3);
            arrayList.Add(vector4);

            Console.WriteLine("Get by index '{0}'", arrayList[0]);
            
            Console.WriteLine("Array");
            
            Vector[] array = {vector0, vector1, vector2, vector3, vector4};
            Console.WriteLine("Get by index '{0}'", array[0]);

            Console.WriteLine("Custom BinaryTree");
            BinaryTree<Vector> binaryTree = new BinaryTree<Vector>();
            binaryTree.Add(vector0);
            binaryTree.Add(vector1);
            binaryTree.Add(vector2);
            binaryTree.Add(vector3);
            binaryTree.Add(vector4);
            
            foreach (Vector vector in binaryTree)
            {
                Console.WriteLine(vector);
            }
        }
    }
}