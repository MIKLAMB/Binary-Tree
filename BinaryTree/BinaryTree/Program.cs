namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(1);
            tree.Add(2);
            tree.Add(8);
            tree.Add(6);
            tree.Add(9);

            Console.WriteLine("PreOrder`");
            foreach (var item in tree.Preorder()) //1.Node 2.Right 3.Left 
                Console.Write(item + ",");
            
            Console.ReadLine();

            Console.WriteLine("PostOrder`");
            foreach (var item in tree.PostOrder()) //1.Right 2.Left 3.Node
                Console.Write(item + ",");
            
            Console.ReadLine();

            Console.WriteLine("InOrder`");
            foreach (var item in tree.Inorder()) //1.Right 2.Elm 3.Node
                Console.Write(item + ",");
            
            Console.ReadLine();

        }
    }

}