using System;

namespace SoloLearn
{
    class BST
    {
        static void Main(string[] args)
        {
            SearchTree t = new SearchTree();
            int i = new int();
            /*t.insert(5);
            t.insert(3);
            t.insert(8);
            t.insert(1);
            t.insert(4);
            t.insert(7);
            t.insert(9);
            t.insert(0);
            t.insert(2);
            t.insert(6);
            t.insert(10);
            t.search(t.root, 11);
            DeleteNode(5, t.root);
            t.print(Console.WindowWidth / 2, 0, t.root, 0);*/
            while (i < 10)
            {
                Console.WriteLine("1:add " +
                                  "\n2:print" +
                                  "\n3:delete" +
                                  "\n4:search");
                i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        int NewItem = new int();
                        Console.WriteLine("input new item");
                        NewItem = Convert.ToInt32(Console.ReadLine());
                        t.insert(NewItem);
                        break;
                    case 2:
                        /*t.print(Console.WindowWidth / 2, 0, t.root, 0);
                        Console.Read();
                        Console.Write("\r ");*/
                        t.Print(t.root);
                        break;
                    case 3:
                        int DeleteItem = new int();
                        Console.WriteLine("input item");
                        DeleteItem = Convert.ToInt32(Console.ReadLine());
                        t.DeleteNode(DeleteItem, t.root);
                        break;
                    case 4:
                        int ItemSearch = new int();
                        Console.WriteLine("input item");
                        ItemSearch = Convert.ToInt32(Console.ReadLine());
                        t.search(t.root, ItemSearch);
                        break;
                    case 5:
                        t.print(Console.WindowWidth / 2, 0, t.root, 0);
                        break;
                    case 6:
                        t.PrintOb(t.root);
                        break;
                    case 7:
                        t.PrintOb(t.root);
                        break;
                }

                Console.ReadLine();
                Console.Clear();
            }
        }

    }
}

