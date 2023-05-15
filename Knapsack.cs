using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCShp
{
    // inizializing Class for Item which will be added to KnapSack with the following members 
     public class item
    {
         public string Name;
         public int Value;
         public int Weight;
         public float Ratio;
        // initialize  Constructor  with members  values ;
        //public item(string Name  , int Value , int Weight )
        //{
        //    this.Name = Name;
        //    this.Value = Value;
        //    this.Weight = Weight;
        //   this.Ratio = (Value / Weight);
        //}

    }
    // initialize Class for knapsack which will include Items
    public class Knapsack
    {
         public int CurrentCapacity = 0;
         public int MaxCapacity = 0;
         public float TotalValue = 0;
        public List<item> items = new List<item>();
        // Constructor will initialize Class of Knapsack with input of MaxCapcity 
        public Knapsack(int MaxCapacity)
        {
            this.MaxCapacity = MaxCapacity;
        }

        // Function to Add Items from Item Class
        public void AddItem(item NewItem)
        {
            // Difference ( diff) = MaxCapacity of KnapSack - Current Capactity of KnapSack 
            int diff = this.MaxCapacity - this.CurrentCapacity;
            // if item Added weight > Differnce between Two capacities then take fraction from this item 
            if (NewItem.Weight > diff)
            {
                // new item weight calue will be difference between two capacities
                NewItem.Weight = diff;
                // new value ( profit ) will be weight of new item * its ratio 
                NewItem.Value = NewItem.Weight * (int)NewItem.Ratio;
            }
            //add item to list( even whole item or Fractional after getting new values from previous code 
            items.Add(NewItem);
            // modify current capacity with added weight for each item 
            this.CurrentCapacity += NewItem.Weight;
            // modify total value with added value for each item 
            this.TotalValue += NewItem.Value;

        }
 
    }
   
    
}
