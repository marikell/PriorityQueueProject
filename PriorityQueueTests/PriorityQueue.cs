using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueueTests
{
    /*Lista de Prioridade que contém um dictionary<string,int>, no qual a chave é uma string(identificação do Node) e o valor é um int (prioridade do Node)*/
    public class PriorityQueue
    {
        #region "Atributos"
        private Dictionary<string, int> Dictionary;
        #endregion

        #region "Construtor"
        public PriorityQueue()
        {
            Dictionary = new Dictionary<string, int>();
        }
        #endregion

        #region "Métodos Públicos"
        /*Método que ordena a lista de prioridade.*/
        public void Order()
        {
            var items = from pair in Dictionary
                        orderby pair.Value ascending
                        select pair;
            Dictionary = new Dictionary<string, int>();
            foreach (KeyValuePair<string, int> pair in items)
            {
                Dictionary.Add(pair.Key, pair.Value);
            }
        }
        /*Método que lista todos os elementos da lista de prioridade */
        public void List()
        {
            foreach (var item in Dictionary)
            {
                Console.WriteLine("Value:" + item.Value);
            }
        }
        /*Método que adiciona um elemento na lista de prioridade*/
        public void Enqueue(string key, int value)
        {
            Dictionary.Add(key, value);
            Order();

        }
        /*Método que remove um elemento da lista de prioridade, baseado no FIFO*/
        public int Dequeue()
        {
            Dictionary.Remove(Dictionary.First().Key);
            return Dictionary.First().Value;
        }
        #endregion
    }
}
