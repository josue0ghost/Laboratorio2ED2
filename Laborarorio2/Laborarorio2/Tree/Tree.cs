using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laborarorio2.Interface;

namespace Laborarorio2.Tree
{
    public class Tree<T, K> where T : IComparable, IFixedSizeText
    {
        public keyComparer<T> keyComparer = new keyComparer<T>();
        public Node<T> root;
        int order;


        public Tree(int order)
        {
            //this.root = new Node<T>();
            this.order = order;
        }

        public void Add(T element)
        {
            Insert(this.root, element);
        }

        private void Insert(Node<T> root, T element)
        {

            //if (!(root.PositionInNode(element) != -1)) // el dato no está incluido en el nodo
            //{
            if (root.IsLeaf) // si es un nodo hoja 
            {
                InsertData(root, element);
            }
            else
            {
                int position = AproxChild(root, element); //numero del hijo donde se insertará
                int son = root.Children[position];
                Node<T> aux = this.root;

                while (aux.ID != son)
                {                    
                }
                //Insert(root.Children[position], element);
            }
            //}            
        }

        internal void InsertData(Node<T> root, T data)
        {
            if (!root.Full)
            {
                root.Data.Add(data);
                root.Data.Sort(keyComparer); //ordenar datos con comparación de objetos especificada                
            }
            else
            {
                //SplitNode(root, data);
            }
        }

        public int AproxChild(Node<T> root, T data)
        {
            int position = 0;
            for (int i = 0; i < root.Data.Count; i++)
            {
                if ((keyComparer.Compare(data, root.Data[i]) < 0) || root.Data[i] == null)
                {
                    position = i;
                    i = root.Data.Count;
                }
                if (i == root.Data.Count - 1)
                {
                    position = i + 1;
                    i = root.Data.Count;
                }
            }
            return position;
        }

    }
}
