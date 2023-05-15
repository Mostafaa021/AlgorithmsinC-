using System.Data;
using System.Globalization;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace AlgorithmsCShp
{


    public class Program
    {
        #region insertion
        //public static void InsertionSort(int[] x)
        //{
        //    int i;
        //    int j;

        //    for (i = 0; i < x.Length; i++)
        //    {
        //        var key = x[i];
        //        for (j = i - 1; j >= 0; --j)
        //        {
        //            if (key < x[j])
        //                x[j + 1] = x[j];
        //            else
        //                break;
        //        }
        //        x[j + 1] = key;
        //    }
        //    for ( i = 0; i < x.Length; i++)
        //    {
        //        Console.WriteLine($"Sorted Elements = {x[i]} ");
        //    }

        //}
        #endregion
        #region MergeSort
        //public static void MergeSort(int[] arr , int start , int end)
        // {
        //     if (end <= start)
        //         return;

        //     int midPoint = (start + end) / 2;
        //     MergeSort( arr , start , midPoint);
        //     MergeSort(arr , midPoint+1 , end);
        //     Merge(arr , start , midPoint , end);
        // }
        // public static void Merge(int[] arr , int start , int midPoint , int end)
        // {
        //     int i, j, k;
        //     int LeftLength = midPoint - start +1;
        //     int RightLength = end - midPoint;
        //     int[] LeftArray = new int[LeftLength];
        //     for ( i = 0; i < LeftLength; i++)
        //     {
        //         LeftArray[i] = arr[start + i];
        //     }
        //     int[] RightArray = new int[RightLength];
        //     for ( j = 0; j < RightLength; j++)
        //     {
        //         RightArray[j] = arr[midPoint + 1 + j];
        //     }
        //     i = j = 0;
        //     k = start;
        //     while(i< LeftLength && j < RightLength)
        //     {
        //         if (LeftArray[i] <= RightArray[j])
        //         {
        //             arr[k] = LeftArray[i];
        //             i++;
        //         }
        //         else
        //         {
        //             arr[k] = RightArray[j];
        //             j++;
        //         }
        //         k++;
        //     }
        //     while (i < LeftLength)
        //     {
        //         arr[k] = LeftArray[i];
        //         i++;
        //         k++;
        //     }
        //     while (j < RightLength)
        //     {
        //         arr[k] = RightArray[j];
        //         j++;
        //         k++;
        //     }
        // }
        #endregion
        #region BinarySearch
        // public static int BinarySearch(int[] arr , int key)
        //{
        //    int low = 0;
        //    int high = arr.Length - 1;
        //    while(low <= high)
        //    {
        //        int midPoint = (low + high) / 2;
        //        if (key == arr[midPoint])
        //            return midPoint;
        //        else
        //        {
        //            if (key > arr[midPoint])
        //                low = midPoint + 1;
        //            else
        //                high = midPoint - 1;

        //        }
        //    }
        //    return -1;
        //}
        #endregion
        #region Segrigation
        //public static void Segregiation(int[] arr , int start , int end  )
        //{
        //    if (end <= start)
        //        return;
        //    int midpoint = (start + end) / 2;
        //    Segregiation(arr, start, midpoint);
        //    Segregiation(arr, midpoint + 1, end);
        //    Merge(arr, start, midpoint, end);
        //}
        //public static void Merge(int[] arr , int start , int midpoint , int end )
        //{
        //    int i, j, k;
        //    int LeftLength = midpoint - start + 1;
        //    int [] LeftArray = new int[LeftLength];
        //    for (i = 0; i < LeftLength; i++)
        //    {
        //        LeftArray[i] = arr[start+i];
        //    }
        //    int RightLength = end-midpoint;
        //    int[] RightArray = new int[RightLength];
        //    for (j = 0; j < RightLength; j++)
        //    {
        //        RightArray[j] = arr[midpoint+ 1 +j];
        //    }
        //    i = j = 0;
        //    k = start;
        //    while (i<LeftLength && LeftArray[i] <= 0)
        //    {
        //        arr[k] = LeftArray[i];
        //        i++;
        //        k++;
        //    }
        //    while (j < RightLength && RightArray[j] <= 0)
        //    {
        //        arr[k] = RightArray[j];
        //        j++;
        //        k++;
        //    }
        //    while (i < LeftLength )
        //    {
        //        arr[k] = LeftArray[i];
        //        i++;
        //        k++;
        //    }
        //    while (j < RightLength )
        //    {
        //        arr[k] = RightArray[j];
        //        j++;
        //        k++;
        //    }
        //}
        #endregion
        #region GreedyStrategy(ActivitySelection Problem)
        //public static void GreedyActivitySelection (int[] start, int[] end)
        //{

        //    int i = 1;
        //    int j = 0;
        //    List<int> results = new List<int>() { 0 };
        //    for ( ; i < start.Length; i++)
        //    {
        //        if (start[i]>= end[j])
        //        {
        //            results.Add(i);
        //            j = i;
        //        }
        //    }

        //    int[] ResultArray = results.ToArray();
        //    Console.WriteLine(string.Join(" , " , ResultArray));
        //}
        #endregion
        #region MergeSort for KnapSack
        //public static void MergeSort(List<item> arr, int start, int end)
        //{
        //    if (end <= start)
        //        return;

        //    int midPoint = (start + end) / 2;
        //    MergeSort(arr, start, midPoint);
        //    MergeSort(arr, midPoint + 1, end);
        //    Merge(arr, start, midPoint, end);
        //}
        //public static void Merge(List<item> arr, int start, int midPoint, int end)
        //{
        //    int i, j, k;
        //    int LeftLength = midPoint - start + 1;
        //    int RightLength = end - midPoint;
        //    List<item> LeftArray = new List<item>();
        //    for (i = 0; i < LeftLength; i++)
        //    {
        //        LeftArray[i] = arr[start + i];
        //    }

        //     List<item> RightArray = new List<item>();
        //    for (j = 0; j < RightLength; j++)
        //    {
        //        RightArray[j] = arr[midPoint + 1 + j];
        //    }
        //    i = j = 0;
        //    k = start;
        //    while (i < LeftLength && j < RightLength)
        //    {
        //        if (LeftArray[i].Ratio>= RightArray[j].Ratio)
        //        {
        //            arr[k] = LeftArray[i];
        //            i++;
        //        }
        //        else
        //        {
        //            arr[k] = RightArray[j];
        //            j++;
        //        }
        //        k++;
        //    }
        //    while (i < LeftLength)
        //    {
        //        arr[k] = LeftArray[i];
        //        i++;
        //        k++;
        //    }
        //    while (j < RightLength)
        //    {
        //        arr[k] = RightArray[j];
        //        j++;
        //        k++;
        //    }
        //}

        #endregion
        
       
        static void Main(string[] args)
        {
            #region InsertionSort
            // Console.WriteLine("Please Enter length of Array = ");
            // int num = int.Parse(Console.ReadLine());
            //int[] arr = new int [num] ;
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     Console.WriteLine($"Please Enter Value of {i + 1} element =  ");
            //       arr[i] = int.Parse(Console.ReadLine());
            // }
            // InsertionSort(arr);
            #endregion
            #region MergeSort
            //int[] arr = { 50, 100, -2, 20, -30, 0 , 7 , 12 , 1000 };
            //Console.WriteLine(string.Join(" , ", arr));
            //MergeSort(arr, 0, arr.Length - 1);
            //Console.WriteLine(string.Join(" , ", arr));
            #endregion
            #region BinarySearch

            //int[] arr = { 5, 8, 9, 10, 12, 13, 15, 17, 50 };
            //Console.Write("Please Enter Value you Want to search = ");
            //int value = int.Parse(Console.ReadLine());
            //if (BinarySearch(arr,value)==-1)
            //{
            //    Console.WriteLine("Not Found in Array ");
            //}
            //else
            //{
            //    Console.WriteLine( $" value at index = {BinarySearch(arr, value)}" );
            //}
            #endregion
            #region Segregation
            //int[] arr = { 9, -20 , 5, 0, 8, -10 };
            //Console.WriteLine(string.Join(" , ", arr));
            //Segregiation(arr, 0, arr.Length - 1);
            //Console.WriteLine(string.Join(" , ", arr));
            #endregion
            #region GreedyStrategy(ActivitySelection Problem)

            //int[] StartArray = { 9, 10, 11, 12, 13, 15 };
            //int[] EndArray = { 11, 11, 12, 14, 15, 16 };
            //GreedyActivitySelection(StartArray, EndArray);

            #endregion
            #region Greedy Sorted Characters Frequencies Algorithm
            //CharFreq cf = new CharFreq();
            //string msg ="Confidentiality: This e-mail communication and any attachments there to contain information that is confidential and is intended only for the use of the individuals or entities named above. If you are not the intended recipient, you are hereby notified that any disclosure, copying, distribution, or taking any action in reliance on the contents of these documents are strictly prohibited and may be illegal. Please notify us of your receipt of this e-mail in error and delete the e-mail and any copies of it. Monitoring/Viruses: PCP may monitor all incoming & outgoing e-mails in line with current legislation. Although we have taken steps to ensure that this e-mail and attachments are free from any virus, we advise that in keeping with good computing practice the recipient should ensure they are actually virus free ";
            //cf.ASCIIMethod(msg);
            //cf.AnyMethodCode(msg);
            #endregion
            #region Greedy Huffman 
            //string msg = "Confidentiality: This e-mail communication and any attachments there to contain information that is confidential and is intended only for the use of the individuals or entities named above. If you are not the intended recipient, you are hereby notified that any disclosure, copying, distribution, or taking any action in reliance on the contents of these documents are strictly prohibited and may be illegal. Please notify us of your receipt of this e-mail in error and delete the e-mail and any copies of it. Monitoring/Viruses: PCP may monitor all incoming & outgoing e-mails in line with current legislation. Although we have taken steps to ensure that this e-mail and attachments are free from any virus, we advise that in keeping with good computing practice the recipient should ensure they are actually virus free";
            //Huffman huff = new Huffman(msg);
            //// print every character with its generated code ;
            //foreach (char K  in huff.codes.Keys)
            //{
            //    Console.Write(K + " ");
            //    Console.WriteLine(huff.codes[K]);
            //}
            #endregion
            #region  Greedy Fractional Knapsack Problem
            // note that knapsack should be sorted from large to minimum 
            ////initializing 2 lists for weights and values 
            //List<int> weights = new List<int> { 4, 9, 12, 11, 6, 5 };
            //List<int> values = new List<int> { 1, 2, 10, 4, 3, 5 };
            //// initialize list to add item to it after looping through knapsack
            //List<item> items = new List<item>();
            //// note that 2 lists or arrays must have the same length or count so assign it to variable
            //int length = values.Count;
            //for (int i = 0; i < length; i++)
            //{
            //    item newitem = new item("#" + i, values[i], weights[i]);
            //    items.Add(newitem);
            //}
            //// then after adding all items to list or array .. sort them from Large to lowest using MergeSort
            //MergeSort(items, 0, length);

            //// make objects from Knapsack 
            //Knapsack bag = new Knapsack(12);
            //// fill this object with items until achieve max capacity so i need counter j = 0 ;
            //int j = 0;
            //while(bag.CurrentCapacity < bag.MaxCapacity)
            //{
            //    bag.AddItem(items[j]);
            //    j++;
            //}
            #endregion
            #region Dynamic-Programming StageCoach
            // Create array reperesnt name of Points 
            // string[] labels = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            // // Create MultiDimensional Array represent grapgh into data 
            // int[,] data = {
            //     // j --------------------------> Forward
            //     { 0, 2 ,4, 3, 0, 0, 0, 0, 0, 0},    // ^
            //     { 0, 0, 0, 0, 7, 4, 6, 0, 0, 0},    // |
            //     { 0, 0, 0, 0, 3, 2, 4, 0, 0, 0},    // |
            //     { 0, 0, 0, 0, 4, 1, 5, 0, 0, 0},    // |  i   BackWard 
            //     { 0, 0, 0, 0, 0, 0, 0, 1, 4, 0},    // |
            //     { 0, 0, 0, 0, 0, 0, 0, 6, 3, 0},    // | 
            //     { 0, 0, 0, 0, 0, 0, 0, 3, 3, 0},    // |
            //     { 0, 0, 0, 0, 0, 0, 0, 0, 0, 3},    // |
            //     { 0, 0, 0, 0, 0, 0, 0, 0, 0, 4},    // |
            //     { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}     // |
            // };
            // // assign lenght of MultiDimensional array in variable 
            // int n = data.GetLength(0);

            // // Create empty Array or list of Objects so we will make class State

            // // add object of state to last item as we working backward
            // State[] states = new State[n];
            //states[n - 1] = new State() { From =" ", To = " ", Cost = 0 };
            // //make nested loops 
            // //why n-2 ? as n is length so the last item will be with index n-1 
            // // then already last point or object has no operation so i will start from n-2 
            // // as we working backWard then we will start from n-2 and decrement as Previous table

            // for (int i = n - 2; i >= 0; i--)
            // {
            //     // add obejct represent from Point to Point and Value = MaxNumber which i will use in Comparison ;
            //     // current_Point_total_cost = Max_Number;
            //     states[i] = new State() { From = labels[i], To = labels[i + 1], Cost = 10000000 };
            //     // here we will work forward 
            //     for (int j = i + 1; j < n; j++)
            //     {
            //         // if data value == 0 go to next step 
            //         if (data[i, j] == 0)
            //         {
            //             continue;
            //         }
            //         // cost of Current Point  = Cost to The Next Point  + total Cost of the Next Point 
            //         // NewCost = Matrix(i , j) + totalCost(j)
            //         int NewCost = data[i, j] + states[j].Cost;
            //         // Current_Point_Total_Cost = Min(Current_Point_Total_Cost,NewCost)
            //         // if cost calculated from previous smaller than stored in State
            //         if (NewCost < states[i].Cost)
            //         {
            //             //  already (from)  will be fixed as (to) only changing to get minimum route cost  from ---> to 
            //             // then change (to) when get minimum cost route as per j Labels
            //             states[i].To = labels[j];
            //             // total cost(i,j) = Current_Point_Total_Cost
            //             // after itterate all routes from each point(state) and check which minimum route cost 
            //             // then assign last minimum value to state.cost 
            //             states[i].Cost = NewCost;
            //         }
            //     }

            // }
            // //i will already start from state or point A so i will make array with first index A
            // List<string> path = new List<string> { "A" /*after first iteration add "C" and so on */ };

            // // counter for states array 
            // int y = 0;
            // // counter for path array 
            // int z = 0;
            // // while counter y of states array < length of states array 
            // while (y < states.Length)
            // {
            //     // states.From[0]--> "A" == path[0]-->"A"
            //     if (states[y].From == path[z])
            //     {
            //         // then path [1] = states.to[0]---> "C"  
            //         path.Add(states[y].To);
            //         // then increment counter of path 
            //         z++;
            //     }
            //     // if states.from [1]-> B != path[1] -> C 
            //     y++;
            // }
            // //printing each object state from states 
            // foreach (var state in states)
            // {
            //     Console.WriteLine($"from : {state.From} , to : {state.To} , cost : {state.Cost} ");
            // }
            // // Printing Shortest Path 
            // Console.Write("Shortest Path is  : ");
            // foreach (var x in path)
            // {
            //     Console.Write(x + " ");
            // }
            // Console.WriteLine("\n============================== ");
            // // printing Minimum Cost 
            // Console.WriteLine($"Minimum Cost : {states[0].Cost} ");

            #endregion
            #region Dynamic-Programming Longest Common Subsequence

            //string text1 = "HELLOWORLD";
            //string text2 = "OHELOD";
            //int n = text1.Length;
            //int m = text2.Length;
            //// Create one dimentional array which have values of 0 
            //int[] arr = new int[100];
            //// creat new array or list empty 
            //int[,] table = new int[m+1, n+1];
            //int i, j;
            //// for 0 row and 0  column i will take values of 0 from one dimensional array and assign it to each cell in i 
            //for ( i = 0; i <= m; i++)
            //{
            //    table[i, 0] = arr[i * (n + 1)];
            //}

            //for (i = 1; i <= m; i++)
            //{

            //    for ( j = 1; j <= n; j++)
            //    {
            //        // if row of 0 or col of 0 == 0 then add value to (i,J) = 0 
            //        if (i == 0 || j == 0)
            //        {
            //            table[i, j] = 0;
            //        }
            //        // if matching in Char then take top left corner value and assign it to cell 
            //        else if (text2[i-1] == text1[j-1])
            //        {
            //            table[i, j] = 1 + table[i - 1, j - 1];
            //        }
            //        // if not matching then take max value from top cell or left cell and assign it to the cell 
            //        else
            //        {
            //            table[i, j] = Math.Max(table[i - 1, j], table[i, j - 1]);
            //        }
            //    }
            //}
            //Console.WriteLine(table[m, n]);

            ///* pesudo code to get char solutoin or LCS 
            // -- start from the bottom right 
            // - if ( current value  > left value )
            //       -if (current value == top cell value ) 
            //           there is no match in cahrs 
            //          - move to top row 
            //       - else ( current value > top cell value ) 
            //           there are match  in char 
            //           take char in your solution 
            //           then move to top row 
            //           move to left column
            //  - else( current value == left value ) 
            //       move to left column
            //*/
            //// make empty string to concatenate solution to it 
            //string str = "";
            //// assign i to text2 , j to text1 
            //i = m;
            //j = n;
            //while (i > 0 && j >0 )
            //{
            //    //if (current value > left value )
            //    if (table[i,j] > table[i,j-1])
            //    {
            //       //if (current value == top cell value ) 
            //        if (table[i, j] == table[i-1,j])
            //        {
            //            //move to top row
            //            i--;
            //        }
            //        //else (current value > top cell value )
            //        else
            //        {
            //            // take char in your solution 
            //            str = text2[i-1] + str;
            //            // move to top row 
            //            i--;
            //            // move to left column
            //            j--;
            //        }
            //    }
            //    else
            //    {
            //        // move to left column
            //        j--;
            //    }   
            //}
            //Console.WriteLine(str);
            #endregion
            #region  Dynamic Programming 0/1 KnapSack Problem
            // create list of items with inital object that represented on table with rows and col = 0 
            //List<item> items = new List<item>();
            //items.Add(new item { Name = "#00", Value = 0, Weight = 0 });
            //items.Add(new item { Name = "#01", Value = 4, Weight = 1 });
            //items.Add(new item { Name = "#02", Value = 9, Weight = 3 });
            //items.Add(new item { Name = "#03", Value = 12, Weight = 5 });
            //items.Add(new item { Name = "#04", Value = 11, Weight = 4 });
            //// Max Weight of KnapSack 
            //int maxWeight = 8;
            //// convert list to one dimensional array ; 
            //item[] itemsArray = items.ToArray<item>();
            //// creat new multidimensional array or list empty  to store data of table 
            //int[,] table = new int[itemsArray.Length, maxWeight+1];

            //// for 0 row and 0  column i will take values of 0 from one dimensional array and assign it to each cell in i 
            //for ( int i = 0; i < itemsArray.Length; i++)
            //{
            //    for (int  j = 0; j <= maxWeight; j++)
            //    { // when i or j = 0 assign value of 0 to cell (i,j)
            //        if (i == 0 || j == 0)
            //            table[i, j] = 0;
            //        // if item weight <= current stage weight 
            //        else if (itemsArray[i].Weight <= j)
            //        {
            //            // x as cell value = value or profit of item + (value of top row - difference between current stage weight and item weight ) 
            //            table[i, j] = Math.Max(table[i - 1, j], itemsArray[i].Value + table[i - 1, j - itemsArray[i].Weight]);
            //        }
            //        // cell value (i,j) = top cell value (i-1,j) 
            //        else
            //        {
            //            table[i, j] = table[i - 1, j];
            //        }

            //    }
            //}
            //Console.WriteLine($" Max Profit : {table[itemsArray.Length-1, maxWeight]}");
            //for (int i = 0; i < itemsArray.Length; i++)
            //{
            //    for (int j = 0; j <= maxWeight; j++)
            //    {
            //        Console.Write(table[i, j] +  " ");

            //    }
            //    Console.WriteLine("\n----------------");
            //}
            ///* start from bottom right 
            // * var remain = max weight 
            // * while (remain >= 0 && j > 0 ) 
            // * if( cell value > top cell value)  take item as a part of solution  
            // *  remain =  remain - item weight 
            // *  go to column[remain]
            // *  go to the top row 
            // * else 
            // * move to the top row 
            // * 
            // */
            // // make empty list to add name of items after getting solution 
            //List<string> solutions = new List<string>();
            //// i -> counter for items in array and value
            //// j-> counter for maxweight 1---> 8
            //// bottom right point wil be at i , j 
            //  int x = itemsArray.Length - 1;
            //  int y = maxWeight;
            //// set initial value to remain = maxweight 
            //  int remain = maxWeight;
            //// loop until nothing no capcity will be in knapsack and until reach to first kg of j 
            //while (remain >= 0 && y>0 )
            //{
            //    // if cell value > top cell value 
            //    if (table[x, y] > table[x - 1, y])
            //    {
            //        // then add this to solution array 
            //        solutions.Add(itemsArray[x].Name);
            //        // decrement max weight at first itteration  ( remain ) from item weight 
            //        remain -=  itemsArray[x].Weight;
            //        // go to column == remain 
            //        y = remain;
            //        x--;
            //    }
            //    else
            //        x--;
            //}
            //foreach (string solution in solutions)
            //{
            //    Console.Write(solution + " ");
            //}
            #endregion

            




        }
    }
    
}
