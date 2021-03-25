using System;

namespace SoloLearn
{
    class SearchTree
    {
        public class Node
        {
            public int data;
            public Node left, right;
            public Node(int item)
            {
                data = item;
                left = null;
                right = null;
            }
        }
        public Node root;
        public SearchTree() //конструктор корня дерева
        {
            root = null;
        }
        public Node DeleteNode(int deleteData, Node root)
        {
            if (root == null)
                return root;
            if (deleteData < root.data)
            {
                root.left = DeleteNode(deleteData, root.left);
            }
            else if (deleteData > root.data)
            {
                root.right = DeleteNode(deleteData, root.right);
            }
            else if (root.left != null && root.right != null)
            {
                root.data = Minimum(root.right).data;
                root.right = DeleteNode(root.data, root.right);
                OnlyDelete(root);
            }
            else if (root.left != null)
            {
                return root.left;
            }
            else
            {
                return root.right;
            }

            return root;

        }
        static void OnlyDelete(Node root)
        {
            if (root.left != null)
            {
                OnlyDelete(root.left);
            }
            else
            {
                if (root.right == null)
                {
                    root = null;
                }
                else
                {
                    root = root.right;
                }
            }
        }
        static Node Minimum(Node root)
        {
            if (root != null)
            {
                if (root.left != null) root = Minimum(root.left);
            }
            return root;
        }
        public void Print(Node root)
        {
            if (root != null)
            {
                if (root.left != null)
                {
                    Print(root.left);
                }

                Console.WriteLine(root.data);
                if (root.right != null)
                {
                    Print(root.right);
                }
            }
        }
        public void PrintPr(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data);
                if (root.left != null)
                {
                    Print(root.left);
                }


                if (root.right != null)
                {
                    Print(root.right);
                }
            }
        }
        public void PrintOb(Node root)
        {
            if (root != null)
            {
                if (root.left != null)
                {
                    Print(root.left);
                }


                if (root.right != null)
                {
                    Print(root.right);
                }
                Console.WriteLine(root.data);
            }
        }
        public void print(int x, int y, Node root, int delta)
        {
            if (root != null)
            {
                if (delta == 0) delta = x / 2;
                Console.SetCursorPosition(x, y);
                Console.Write(root.data);
                print(x - delta, y + 3, root.left, delta / 2);
                print(x + delta, y + 3, root.right, delta / 2);
                Console.Clear();
            }
            return;
        }
        public Node search(Node root, int data)
        {
            if (root == null)
            {
                Console.Write("Not found\n");
                return null;
            }
            if (root.data == data)
            {
                Console.Write("Found at: " + root.data + "\n");
                return root;
            }


            if (root.data < data)
            {
                search(root.right, data);
                return root;
            }
            else
            {
                search(root.left, data);
                return root;
            }
        }
        public void insert(int data)
        {
            root = recInsert(root, data);
        }
        Node recInsert(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data);
                return root;
            }
            if (data <= root.data)
                root.left = recInsert(root.left, data);
            else
                root.right = recInsert(root.right, data);

            return root;
        }
    }
}

