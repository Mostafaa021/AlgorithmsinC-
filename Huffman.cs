using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCShp
{
    public class HeapNode
    {
        public char data;
        public int freq;
        public HeapNode Left;
        public HeapNode Right;
        public HeapNode(char data , int freq )
        {
            this.data = data;
            this.freq = freq;
            this.Left = this.Right = null;
        }
    }
    public class Huffman
    {
        // making char with number 0 in ascii code that mean it`s empty ( special char )
        char InternalChar = (char)0;
        // making data structure to contain codes generated from Generate code function 
        public Hashtable codes = new Hashtable();
        // initializing piriority Queue 
        private PriorityQueue<HeapNode, int> minHeap = new PriorityQueue<HeapNode, int>();
        public Huffman( string message)
        {
            // Getting Frequencies of Charachters in message send from user ; 
            /* inizializing HashTable in Constructor of Class then loop 
              through user message to get charachters if charachter has no frequency before give char value of 1 
            else  add 1 to previous frequency 
             */
            Hashtable freqHash = new Hashtable();
            for (int i = 0; i < message.Length; i++)
            {
                if (freqHash[message[i]]==null)
                {
                    freqHash[message[i]] = 1;
                }
                else
                {
                    freqHash[message[i]] = (int?)freqHash[message[i]] + 1;
                }
            }
            /* Heapify (Convert from data structure to heap Data Structure ) HashTable  to Pirority Queue (MinHeap)
             * with no sorting as pirority queue already sort from min to max */
            // loop throw chars in hashtable
            foreach (char K in freqHash.Keys)
            {
                // for each item in hash table make new node 
                HeapNode newNode = new HeapNode(K, (int)freqHash[K]);
                // then add it to pirority queue 
                minHeap.Enqueue(newNode, (int)freqHash[K]);
            }
            // make new variables
            // top=> newNode After sum left and right then enqueue it pirority queue will bu automatically sorted 
            // left and right node
            // new frequency to Topnode 
            HeapNode left, right, top;
            int newFreq;
            // looping through piriority queue count  until reach to 1 node 
            while (minHeap.Count != 1 )
            {
                // remove first node from pirority queue then assign it in new left node
                left = minHeap.Dequeue();
                // remove second node after removing first node as previous from pirority queue then assign it in new rigth node
                right = minHeap.Dequeue();
                // get new frequency for TopNode from summing right and left old frequencies 
                newFreq = left.freq + right.freq;
                // assign new frequency to Top Node
                top = new HeapNode( InternalChar, newFreq);
                // assign nodes child nodes ( left , Right ) to parent Node (top node )
                top.Left = left;
                top.Right = right;
                // then i shoud add Top node to pirority queue 
                minHeap.Enqueue(top, newFreq);
            }
            // Here after mading binary tree i should add 0 , 1 for branches 
            // after finishing while loop there where are only one node will be remained containting all nodes as per binary tree method 
            // so i will use peek function which return node without dequeueing it from pirority queue 

            this.generateCodes(minHeap.Peek(), "");

        }
        private void generateCodes (HeapNode node , string str)
        {
            // making recursion to add codes of 0 , 1 as per binary tree method 
            //base Case 
            if (node == null)
            {
                return;
            }
            // that means i already need this char to add it codes hash table as internal char i already declared is special char with no use in any word
            if (node.data != InternalChar)
            {
                codes[node.data] = str;
            }
            // making recursion with adding
            generateCodes(node.Left, str + "0");
            generateCodes(node.Right, str + "1");

        }
    }
}
