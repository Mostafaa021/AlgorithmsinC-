using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCShp
{
    public class CharFreq
    {
        public CharFreq(){ }
        public void ASCIIMethod(string message)
        {
            Console.WriteLine("ASCII Method");
            int[] freq = new int[127];
            for (int i = 0; i < message.Length; i++)
            {
                int CurrentASCIICode = (int)message[i];
                freq[CurrentASCIICode]++;
            }
            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i]>0)
                {
                    char c = (char)i;
                    Console.Write(c + " ");
                    Console.WriteLine(freq[i]);
                }
            }
        }
        public void AnyMethodCode(string message)
        {
            Console.WriteLine("AnyMethod Code");
            Hashtable freq = new Hashtable();
            for (int i = 0; i < message.Length; i++)
            {
                if (freq[message[i]] == null)
                {
                    freq[message[i]] = 1;
                }
                else
                {
                    freq[message[i]] =(int?) freq[message[i]] + 1;
                }
            }
            foreach (char K in freq.Keys)
            {
                Console.Write(K + " ");
                Console.WriteLine(freq[K]);
            }
           SortHash(freq);
        }
        public   void SortHash( Hashtable freq )
        {
            
            int[,] freqArray = new int[freq.Count, 2];
            int i = 0;
            foreach (char K in freq.Keys)
            {
                freqArray[i, 0] = (int)K;
                freqArray[i, 1] = (int)freq[K];
                i++;
            }
            this.Sort(freqArray, 0, freq.Count-1);
            Console.WriteLine("After Sorting Data");
            for ( i = 0; i < freq.Count; i++)
            {
                Console.Write((char)freqArray[i, 0] + " ");
                Console.WriteLine(freqArray[i, 1]);
            }
        }
        public  void Sort(int[,] arr , int start , int end)
        {
            if (end <= start)
                return;

            int midPoint = (start + end) / 2;
            Sort(arr , start , midPoint);
            Sort( arr , midPoint+1 , end);
            Merge(arr ,start , midPoint , end);
        }
        public  void Merge(int[,] arr, int start , int mid, int end )
        {

            int i, j, k;
            int LeftLength = mid - start + 1;
            int RightLength = end - mid;

            int[,] LeftArray = new int [LeftLength, 2];
            int[,] RightArray = new int[RightLength, 2];
            for ( i = 0; i < LeftLength; i++)
            {
                LeftArray[i, 0] = arr[start + i, 0];
                LeftArray[i, 1] = arr[start + i, 1];
            }
            for (j = 0; j < RightLength; j++)
            {
                RightArray[j, 0] = arr[mid+1 + j, 0];
                RightArray[j, 1] = arr[mid+1 + j, 1];
            }
            i = j = 0;
            k = start;
            while (i < LeftLength && j < RightLength)
            {
                if (LeftArray[i , 1] <= RightArray[j , 1])
                {
                    arr[k, 0] = LeftArray[i, 0];
                    arr[k, 1] = LeftArray[i, 1];
                    i++;
                }
                else
                {
                    arr[k, 0] = RightArray[j, 0];
                    arr[k, 1] = RightArray[j, 1];
                    j++;
                }
                k++;
            }
            while (i< LeftLength)
            {
                    arr[k, 0] = LeftArray[i, 0];
                    arr[k, 1] = LeftArray[i, 1];
                    i++;
                    k++;
            }
            while (j <  RightLength)
            {
                arr[k, 0] = RightArray[j, 0];
                arr[k, 1] = RightArray[j, 1];
                j++;
                k++;
            }
        }
        
    }
}
