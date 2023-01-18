namespace BinaryTree;

class Tree<T> where T : IComparable, IComparable<T>
{
    public Node<T> Root { get; private set; }
    public int Count { get; private set; }//Count Elm

    public void Add(T data)
    {
        if (Root == null)
        {
            Root = new Node<T>(data);
            Count = 1;
            return;
        }

        var current = Root;
        Root.Add(data);
        Count++;

        if (current == null)
        {
            Root.Add(data);
            Count += 1;
        }
    }
    public List<T> Preorder()
    {

        if (Root == null)
            return new List<T>();

        return Preorder(Root);
    }
    /// <summary>
    /// 1.Right 2.Left 3.Node
    /// </summary>
    /// <param name="node"></param>
    /// <returns></returns>
    private List<T> Preorder(Node<T> node) { 
        var list = new List<T>();
        if (node != null)
        {
            list.Add(node.Data);

            if (node.Left != null)
                list.AddRange(Preorder(node.Left));

            if (node.Right != null)
                list.AddRange(Preorder(node.Right));    
        }
        return list;
    }
    public List<T> PostOrder()
    {

        if (Root == null)
            return new List<T>();
        
        return PostOrder(Root);
    }
    /// <summary>
    /// 1.Left 2.Right 3.Node
    /// </summary>
    /// <param name="node"></param>
    /// <returns></returns>
    private List<T> PostOrder(Node<T> node)
    {
        var list = new List<T>();
        if (node != null)
        {
            if (node.Left != null)
                list.AddRange(PostOrder(node.Left));
            
            if (node.Right != null)
                list.AddRange(PostOrder(node.Right));

            list.Add(node.Data);

        }
        return list;
    }
    public List<T> Inorder()
    {

        if (Root == null)
            return new List<T>();
        
        return Inorder(Root);
    }
    /// <summary>
    /// 1.Left 2.Elm 3.Node
    /// </summary>
    /// <param name="node"></param>
    /// <returns></returns>
    private List<T> Inorder(Node<T> node)
    {
        var list = new List<T>();
        if (node != null)
        {
            if (node.Left != null)               
                list.AddRange(Inorder(node.Left));               

            list.Add(node.Data);

            if (node.Right != null)
                list.AddRange(Inorder(node.Right));                
        }
        return list;
    }
}

