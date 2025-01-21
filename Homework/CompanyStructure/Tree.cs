using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyStructure
{
    public class Tree<T>
    {
        public Node<T>? Root { get; set; }

        public void PrintTree(Node<Person> node)
        {
            Console.WriteLine($"Level: {node.GetHeight()}");
            Console.WriteLine($"Name: {node.Data!.Name}");
            Console.WriteLine($"Role: {node.Data!.Role}");
            Console.WriteLine($"Id: {node.Data!.Id}");
            Console.WriteLine("==========================");

            if (node.Children! != null)
                foreach (var i in node.Children!)
                    PrintTree(i);
        }
    }
}