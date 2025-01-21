using BasicTree;

Tree<int> tree = new Tree<int>();
tree.Root = new Node<int>(){ Data = 100};
tree.Root.Children = new List<Node<int>> {
    new Node<int>() {Data = 50, Parent = tree.Root},
    new Node<int>() {Data = 10, Parent = tree.Root},
    new Node<int>() {Data = 150, Parent = tree.Root}
};

Node<int> node12 = new Node<int>() {Data = 12, Parent = tree.Root.Children[0]};
Node<int> node45 = new Node<int>() {Data = 45, Parent = node12};
Node<int> node21 = new Node<int>() {Data = 21, Parent = node12};
//node45 e 21 sao filhos de node 12
node12.Children!.Add(node45!);
node12.Children!.Add(node21!);

//Sub arvore
//node 12 e filho de 50
//? apenas adicona se nao for null
tree.Root.Children[0].Children?.Add(node12);

tree.PrintTree(tree.Root);