namespace BasicTree
{
    public class Node<T>
    {
        public T? Data { get; set; }
        public Node<T>? Parent { get; set; }
        //Inicializando vazia
        public List<Node<T>>? Children { get; set;} = [];
        

        public int GetHeight()
        {
            int height = 1;
            //This e a instancia do objeto
            Node<T> current = this;
            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }
            return height;
        }
    }
}