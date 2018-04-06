using System.Collections.Generic;

namespace ProjetoGrafos.DataStructure
{

    /// <summary>
    /// Fila de prioridade para usar na busca A*.
    /// </summary>
    public class PriorityQueue: LinkedList<Node>
    {

        /// <summary>
        /// Remove um nó da fila.
        /// </summary>
        /// <returns></returns>
        public Node Dequeue()
        {
            Node n = this.First.Value;
            this.RemoveFirst();
            return n;
        }

        /// <summary>
        /// Adiciona um nó na fila.
        /// </summary>
        /// <param name="n"></param>
        public void Enqueue(Node item)
        {
            LinkedListNode<Node> node = this.First;
            while(node != null)
            {
                if(item.Edges.Count > node.Value.Edges.Count)
                {
                    this.AddBefore(node, item);
                    break;
                }
                node = node.Next;
            }
            if(node == null)
            {
                this.AddLast(item);
            }
        }
    }
}
