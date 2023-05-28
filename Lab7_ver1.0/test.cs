using System;

public class Program
{
    public static void Main(string[] args)
    {
        BinaryTree<int> binaryTree = new BinaryTree<int>();
        binaryTree.Add(5);
        binaryTree.Add(2);
        binaryTree.Add(7);
        binaryTree.Add(1);
        binaryTree.Add(3);
        binaryTree.Add(6);
        binaryTree.Add(8);

        // Прямой обход дерева с использованием итераторов
        Console.WriteLine("Прямой обход дерева:");
        while (binaryTree.Next())
        {
            int value = binaryTree.Current();
            Console.WriteLine(value);
        }

        // Обратный обход дерева с использованием итераторов
        Console.WriteLine("Обратный обход дерева:");
        while (binaryTree.Previous())
        {
            int value = binaryTree.Current();
            Console.WriteLine(value);
        }
    }
}