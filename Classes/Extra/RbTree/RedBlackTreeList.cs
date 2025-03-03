using System;
using System.Collections;
using System.Collections.Generic;

namespace RbTree
{
    public class RedBlackTreeList<T> : IEnumerable<T> where T : IComparable<T>
    {
        private Node<T>? root;
        private uint count = 0;

        public uint Count => count;

        public void Add(T value)
        {
            root = Insert(root, value);
            root.IsRed = false; // A raiz sempre deve ser preta
            count++;
        }

        private Node<T> Insert(Node<T>? node, T value)
        {
            // Se o no estiver vazio, cria um novo 
            if (node == null)
            {
                return new Node<T>(value);
            }

            int cmp = value.CompareTo(node.Data);

            // Se  for menor que o valor insere à esquerda
            if (cmp < 0)
            {
                node.Left = Insert(node.Left, value);
            }
            // Se  for maior que o valor insere à direita
            else if (cmp > 0)
            {
                node.Right = Insert(node.Right, value);
            }

            node = BalanceNode(node);

            return node;
        }

        private Node<T> BalanceNode(Node<T> node)
        {
            // Se o filho direito for vermelho e o esquerdo nao for, rotaciona para a esquerda
            if (IsRed(node.Right) && !IsRed(node.Left))
            {
                node = RotateLeft(node);
            }

            // Se o filho esquerdo e seu filho esquerdo sao vermelhos, rotaciona para a direita
            if (IsRed(node.Left) && IsRed(node.Left!.Left))
            {
                node = RotateRight(node);
            }

            // Se ambos os filhos sao vermelhos, faz a troca de cores
            if (IsRed(node.Left) && IsRed(node.Right))
            {
                FlipColors(node);
            }

            return node;
        }

        public void Remove(T value)
        {
            if (Contains(value))
            {
                // Se ambos forem pretos, marca a raiz como vermelha
                if (!IsRed(root!.Left) && !IsRed(root.Right))
                {
                    root.IsRed = true;
                }

                // Chama o metodo Delete
                root = Delete(root, value);

                // Se a arvore nao estiver vazia, garante que a raiz seja preta
                if (root != null)
                {
                    root.IsRed = false;
                }

                // Diminui contador de elementos
                count--;
            }
        }

        private Node<T>? Delete(Node<T>? node, T value)
        {
            if (node == null)
            {
                return null;
            }

            // Compara com o no atual
            int cmp = value.CompareTo(node.Data);

            // Se o valor for menor, percorre a subarvore esquerda
            if (cmp < 0)
            {
                // Verifica se podemos mover um no vermelho a esquerda
                if (node.Left != null && !IsRed(node.Left) && !IsRed(node.Left.Left))
                {
                    node = MoveRedLeft(node);
                }

                // Recursivamente chama Delete na subarvore esquerda
                node.Left = Delete(node.Left, value);
            }
            else
            {
                // Se o filho esquerdo for vermelho, rotaciona para a direita
                if (IsRed(node.Left))
                {
                    node = RotateRight(node);
                }

                // Se encontramos o valor e o no a direita for nulo, remove o no
                if (cmp == 0 && node.Right == null)
                {
                    return null;
                }

                // Verifica se o filho a direita nao e vermelho e realiza a movimentacao de no vermelho a direita
                if (node.Right != null && !IsRed(node.Right) && !IsRed(node.Right.Left))
                {
                    node = MoveRedRight(node);
                }

                // Se o valor foi encontrado, substitui o no por seu sucessor minimo da subarvore direita
                if (cmp == 0)
                {
                    // Encontra o menor no na subarvore direita
                    Node<T> min = FindMin(node.Right!);

                    // Substitui o valor do no com o valor do menor no
                    node.Data = min.Data;

                    // Recursivamente remove o no minimo da subarvore direita
                    node.Right = Delete(node.Right, min.Data);
                }
                else
                {
                    // Se o valor nao foi encontrado, percorre a direita
                    node.Right = Delete(node.Right, value);
                }
            }

            return BalanceNode(node);
        }

        public bool Contains(T value)
        {
            Node<T>? current = root;

            while (current != null)
            {
                int cmp = value.CompareTo(current.Data);

                // Se os valores forem iguais, o valor foi encontrado
                if (cmp == 0)
                {
                    return true;
                }

                // Se o valor for menor, vai para a subárvore esquerda
                // Se o valor for maior, vai para a subárvore direita
                current = cmp < 0 ? current.Left : current.Right;
            }

            // Se o no nao for encontrado, retorna false
            return false;
        }

        public bool Greatest(out T greatest)
        {
            // Se a arvore estiver vazia, retorna falso e define o maior valor como default
            if (root == null)
            {
                greatest = default!;
                return false;
            }

            Node<T> node = root;

            // Percorre a arvore ate o no mais a direita, que contem o maior valor
            while (node.Right != null)
            {
                node = node.Right;
            }

            greatest = node.Data;

            // Retorna verdadeiro, indicando que o maior valor foi encontrado
            return true;
        }


        public bool Least(out T least)
        {
            if (root == null)
            {
                least = default!;
                return false;
            }

            Node<T> node = root;

            while (node.Left != null)
            {
                node = node.Left;
            }

            least = node.Data;

            return true;
        }

        // Retorna nulo se nao for vermelho
        private bool IsRed(Node<T>? node) => node != null && node.IsRed;

        // Realiza uma rotacao a esquerda em torno do no fornecido
        private Node<T> RotateLeft(Node<T> node)
        {
            // Armazena o filho direito do no para realizar a rotacao
            Node<T> x = node.Right!;

            // A direita de 'node' passa a ser o filho esquerdo de 'x'
            node.Right = x.Left;

            // O no 'x' se torna o novo no pai
            x.Left = node;

            // A cor de 'x' e ajustada para a cor do no original
            x.IsRed = node.IsRed;

            // A cor do no original 'node' passa a ser vermelha apos a rotacao
            node.IsRed = true;

            // Retorna o novo no que se tornou a raiz da subarvore
            return x;
        }

        private Node<T> RotateRight(Node<T> node)
        {
            // O no a esquerda do no atual (node) se tornara o novo no pai
            Node<T> x = node.Left!;

            // O filho direito de x se torna o filho esquerdo de node
            node.Left = x.Right;

            // O no original (node) se torna o filho direito de x
            x.Right = node;

            // A cor de x e ajustada para a cor de node
            x.IsRed = node.IsRed;

            // O no original (node) e colorido de vermelho apos a rotacao
            node.IsRed = true;

            // Retorna o novo no raiz (x), que e agora o pai da subarvore
            return x;
        }

        private void FlipColors(Node<T> node)
        {
            // Troca a cor do no atual (node)
            node.IsRed = !node.IsRed;

            // Troca a cor do no a esquerda, se existir
            if (node.Left != null)
                node.Left.IsRed = !node.Left.IsRed;

            // Troca a cor do no a direita, se existir
            if (node.Right != null)
                node.Right.IsRed = !node.Right.IsRed;
        }

        private Node<T> MoveRedLeft(Node<T> node)
        {
            // Troca as cores do no atual (node) e seus filhos
            FlipColors(node);

            // Se o filho direito existe e o filho esquerdo do filho direito e vermelho
            if (node.Right != null && IsRed(node.Right.Left))
            {
                // Rotaciona o filho direito de node para a direita
                node.Right = RotateRight(node.Right);

                // Realiza uma rotacao a esquerda no no atual (node)
                node = RotateLeft(node);

                // Troca as cores do no atual (node) e seus filhos
                FlipColors(node);
            }

            return node;
        }


        private Node<T> MoveRedRight(Node<T> node)
        {
            // Troca as cores do no atual (node) e seus filhos
            FlipColors(node);

            // Se o filho esquerdo existe e o filho esquerdo do filho esquerdo e vermelho
            if (node.Left != null && IsRed(node.Left.Left))
            {
                // Realiza uma rotacao a direita no no atual (node)
                node = RotateRight(node);

                // Troca as cores do no atual (node) e seus filhos
                FlipColors(node);
            }

            return node;
        }

        private Node<T> FindMin(Node<T> node)
        {
            // Percorre a subarvore esquerda ate encontrar o no mais a esquerda
            while (node.Left != null)
                node = node.Left;
            return node;
        }

        private IEnumerable<T> InOrderTraversal(Node<T>? node)
        {
            // Se o no for nulo, finaliza a execucao do metodo
            // yield = colheita
            // Yield break interrompe a iteracaao
            if (node == null) yield break;

            // Faz a travessia da subarvore esquerda
            // Yield return retorna um item de cada vez
            foreach (var n in InOrderTraversal(node.Left)) yield return n;

            // Retorna o valor do no atual
            yield return node.Data;

            // Faz a travessia da subarvore direita
            foreach (var n in InOrderTraversal(node.Right)) yield return n;
        }

        // Implementacao de IEnumerable<T> para suportar o uso do foreach
        public IEnumerator<T> GetEnumerator()
        {
            // Retorna o enumerador para a travessia em ordem (in-order) da arvore
            return InOrderTraversal(root).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // Retorna o enumerador genérico para a travessia da arvore
            return GetEnumerator();
        }
    }
}
