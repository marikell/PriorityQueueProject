﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueueTests
{
    /*Classe de Testes relacionados a PriorityQueue*/
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue list = new PriorityQueue();

            list.Enqueue("123", 30);
            list.Enqueue("456", 10);
            list.Enqueue("789", 5);
            list.Enqueue("1020", 82);
            list.Enqueue("5615", 55);
            list.Enqueue("26262", 22);
            list.Enqueue("626262", 3);
            list.Enqueue("2226", 5);
            //siojdsiosdijosijode
            //wdwdwdwdwdwd
            list.Enqueue("2222", 3);
            list.List();
            list.Dequeue();
            list.Enqueue("44554", 1);
            Console.WriteLine("\n");
            list.List();

            Console.ReadKey();

        }
    }
}
