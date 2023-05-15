using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCShp
{
    public class State
    {
        public string From;
        public string To;
        public int Cost ;

        public State()
        {

        }
        public State( string From , string To  ) : this()
        {
            this.From = From;
            this.To = To;
            
        }
        public State( string From , string To , int Cost) : this (From , To)
        {
            this.Cost = Cost;
        }
       
            public  static int max(int num1, int num2)
            {
                return num1 + num2;
            }
            public static int max(int num1, int num2, int num3 = 5, int num4 = 15)
            {
                return num1 + num2 + num3 + num4;
            }

        

    }
    

}
