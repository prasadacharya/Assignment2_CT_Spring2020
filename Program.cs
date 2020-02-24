using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2_CT_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Question 1 : TargetRange---"); 
            int[] l1 = new int[] { 5, 6, 6, 9, 9, 12 };
            Console.Write("Input array: ");
            foreach (int n in l1)
            {

                Console.Write(n + ",");

            }
            Console.WriteLine();
            // int target = 9;
            //int target = 10;
            int target = 6;
            Console.WriteLine("Target: "+target);
            int[] r = TargetRange(l1, target);
            Console.WriteLine("Output: "+"["+r[0]+","+r[1] + "]");
            Console.WriteLine();
            

             Console.WriteLine("---Question 2 : StringReverse---");
            // string s = "University of South Florida";
            // string s = "Muma College Of Business";
             string s = "Distributed Information Systems";
             Console.WriteLine("Input String: "+s);
             string rs = StringReverse(s);            
             Console.WriteLine("Reverse String: "+rs);
             Console.WriteLine();


            Console.WriteLine("---Question 3 : MinimumSum---");
            // int[] l2 = new int[] { 2, 2, 3, 5, 6 };
            // int[] l2 = new int[] { 40,40 };
            int[] l2 = new int[] {4,5,6,9};
            Console.Write("Input array: ");
            foreach (int n2 in l2)
            {

                Console.Write(n2 + ",");

            }
            Console.WriteLine();

             int sum = MinimumSum(l2);
             Console.WriteLine("Minimum sum: " +sum);
             Console.WriteLine();

            
            Console.WriteLine("---Question 4 : FreqSort---");
            //string s2 = "Dell";
            //string s2 = "eebhhh";
            string s2 = "yYkk";
            Console.WriteLine("Input String: "+s2);

            string sortedString = FreqSort(s2);
            Console.WriteLine("Frequency sorted String: " +sortedString);
            Console.WriteLine();

            
            Console.WriteLine("---Question 5-Part 1---");
            //int[] nums1 = { 1,2,2,1 }; 
            //int[] nums2 = { 2,2 };
            //int[] nums1 = { 3, 6, 2 };
            //int[] nums2 = { 6, 3, 6, 7, 3 };
            int[] nums1 = { 1, 3, 5, 6, 8, 2, 4 };
            int[] nums2 = { 1, 6, 3, 6, 7, 8, 3, 4 };
            Console.Write("Input Array 1: ");
            foreach (int n3 in nums1)
            {

                Console.Write(n3 + ",");

            }
            Console.WriteLine();
            Console.Write("Input Array 2: ");
            foreach (int n4 in nums2)
            {

                Console.Write(n4 + ",");

            }
            Console.WriteLine();
            int[] intersect1 = Intersect1(nums1, nums2);
            Console.WriteLine("Part 1- Intersection of two arrays is: ");
            DisplayArray(intersect1);
            Console.WriteLine("\n");
            
            Console.WriteLine("---Question 5-Part 2---"); 
            int[] intersect2 = Intersect2(nums1, nums2);
            Console.WriteLine("Part 2- Intersection of two arrays is: ");
            DisplayArray(intersect2);
            Console.WriteLine("\n");
            

            Console.WriteLine("---Question 6 : ContainsDuplicate---");
            //char[] arr = new char[] { 'a', 'g', 'h', 'a' };
            //char[] arr = new char[] { 'k', 'y', 'k', 'k' };
            char[] arr = new char[] { 'a', 'b', 'c', 'a', 'b', 'c' };
            Console.Write("Input array: ");
            foreach (char c in arr)
            {

                Console.Write(c + ",");

            }
            Console.WriteLine();
            //int k = 3;
            //int k = 1;
            int k = 2;
            Console.WriteLine("k :" +k);
            Console.WriteLine("Output: " +ContainsDuplicate(arr, k));
            Console.WriteLine();

            
            Console.WriteLine("---Question 7: GoldRod---"); 
            //int rodLength = 4;
            //int rodLength = 6;
            int rodLength = 15;
            Console.WriteLine("Gold Rod Length: "+rodLength);
            int priceProduct = GoldRod(rodLength);
            Console.WriteLine("PriceProduct: "+priceProduct);
            Console.WriteLine();

            
            Console.WriteLine("---Question 8: DictSearch---");
            string[] userDict = new string[] { "rocky", "usf", "hello", "apple" };
            Console.Write("User Dictionary: ");
            foreach (string str in userDict)
            {

                Console.Write(str + ",");

            }
            Console.WriteLine();
            //string keyword = "hhllo";
            //string keyword = "appl";
            string keyword = "ucf";
            Console.WriteLine("Keyword: " + keyword);
            Console.WriteLine("Output: "+DictSearch(userDict, keyword));
            Console.WriteLine();

            
            Console.WriteLine("---Question 9:SolvePuzzle---");
            SolvePuzzle();
            
        }


        public static void DisplayArray(int[] a)
        {
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
        }


        public static int[] TargetRange(int[] l1, int t)
        {
            try
            {
                /*Logic:
                 * 1.Take 'n1' variable to store Length of the given array.
                 * 2.Take 2 variables 'initial' and 'final' to store the initial and final index of a given target point’s value. 
                 * 3.Initialize both varaiables: 'initial' and 'final' to -1.
                 * 4.Create a 'range' array to return initial and final values at the end. 
                 * 5.Run a for loop and for i = 0 to n1 - 1
                 * 6.When we find element first time then update initial = i
                 * 7.Always update final = i whenever we find the element.
                 * 8.If we find element , We insert initial and final values in range array. 
                 * 9.Otherwise insert -1 in range array.
                 * 10.Time Complexity: O(n)*/

                int n1 = l1.Length;       //  n1 will store Length of the given array
                int initial = -1;         //  to store the initial index of a given target point’s value
                int final = -1;           //  to store the final index of a given target point’s value

                int[] range = new int[2]; //  will store initial and final values in range array.

                for (int i = 0; i < n1; i++) // Run a for loop and for i = 0 to n1 - 1
                {
                    if (t != l1[i])       // if given target point’s value is not matching with array element then pass control to the next iteration
                        continue;        
                    if (initial == -1)    // When we find element first time then update initial = i
                        initial = i;
                    final = i;            // always update final = i whenever we find the element
                }

                if (initial != -1)        // If we find element , We insert initial and final values in range array
                {
                    range[0]=  initial;
                    range[1] = final;
                }
                else                      // Otherwise insert -1 in range array
                {
                    range[0] = -1;
                    range[1] = -1;
                }    

                return range;             // return range int array
            }
            catch (Exception)
            {
                throw;
            }

          //   return new int[] { };
        }
        

        public static string StringReverse(string s)
        {
            try
            {
                /* Logic: Used a stack to push all words before space. 
                 * As soon as we encounter a space, pop contents of stack and append it in string "sb" 
                 * Append space and repeat the same for all words in given String
                 * Time Complexity: O(n) */

                Stack<Char> st = new Stack<Char>();
                StringBuilder sb = new StringBuilder(s.Length);

                // Traverse given string and push all characters to stack until we see a space.  
               
                for (int i = 0; i < s.Length; ++i)
                    {
                        if (s[i] != ' ')
                        {
                            st.Push(s[i]);
                        }

                    // When we see a space, pop contents of stack and append it in string "sb". 

                        else
                        {
                            while (st.Count > 0)
                            {

                            sb.Append(st.Pop());
                            
                            }
                          sb.Append(" "); // after each word append a space
                        }
                    }

                    // Since there may not be  space after last word. 
                
                while (st.Count > 0)
                    {

                    sb.Append(st.Pop());

                    }

                return sb.ToString();
            }
            catch (Exception)
            {
                    throw;
            }
           //     return null;
        } 

        public static int MinimumSum(int[] l2)
        {
            try
            {
                /*Logic:
                 * 1. Take 2 variables to store sum and previous values 
                 * 2. Intiailise both to first element in the array.
                 * 3. Traverse each element of array starting from second element.
                 * 4. If current element(l2[i]) is <= previous elemnt then update previous by adding 1 and update sum by adding previous.
                 * 5. Else update sum by adding current element(l2[i]) and update previous by current element.
                 * 6. After traversing of each element return sum . 
                 * Time Complexity: O(n) */

                int sum = l2[0];      // Intiailise sum to first element in the array
                int previous = l2[0]; // Intiailise previous to first element in the array
                int n2 = l2.Length;   // n2 will store length of the array

                //Traverse each element of array starting from second element

                for (int i = 1; i < n2; i++)
                {

                    // If the current element is <= previous element, make current value as 1 plus previous value and add to sum.

                    if (l2[i] <= previous)
                    {
                        previous = previous + 1;
                        sum = sum + previous;
                    }

                    // Else update sum by adding current element(l2[i]) and update previous by current element. 

                    else
                    {
                        sum = sum + l2[i];
                        previous = l2[i];
                    }
                }

                return sum;  // return sum
            }
            catch (Exception)
            {
            throw;
            }
          // return 0;
        }

       
        public static string FreqSort(string s2)
        {
            try
            {
                // Logic : Create a dictionary which stores character(key) and count(value) of each character in given string. 
                // Sort the dictionary values in descending order.
                // Append the characters(key) in string. return string.
                // Time Complexity : O(n)

                var dict = new Dictionary<char, int>(); // Created a dictionary

                //store character(key) and count(value) of each character in Given string to Dictionary
                foreach (var c in s2)
                {
                 if(dict.ContainsKey(c))
                 {
                    dict[c]++;
                 }
                else
                 {
                    dict.Add(c,1);
                 }
                }

                // Sort the dictionary values in descending order.
                var sortedDict = dict.OrderByDescending(x=>x.Value);

                // Created a stringbuilder to store sorted string
                var res = new StringBuilder();

                //Append the characters(key) in string
                foreach (var d in sortedDict)
                 {
                 for(int i = 0; i < d.Value; i++)
                    res.Append(d.Key);
                 }
               return res.ToString(); // return string
            }
            catch (Exception)
            {
                throw;
            }
           // return null;
        }

        
       public static int[] Intersect1(int[] nums1, int[] nums2)
       {
           try
           {
                /*Logic: Sorted both arrays and then computed the intersection
                 * Used List to store the intersection values and return them 
                 * Time Complexity : O(nlogn)*/

                List<int> list = new List<int>();     // a list created to return the output
                Array.Sort(nums1);                    // sorting first array
                Array.Sort(nums2);                    //  sorting second array
                // intersect array 
                int i = 0, j = 0;
                while (i < nums1.Length && j < nums2.Length)
                {
                    if (nums1[i] < nums2[j])          //comparing the two arrays values   
                        i++;
                    else if (nums2[j] < nums1[i])     // if not matched moving to next increasing the place
                        j++;
                    else
                    {
                        list.Add(nums1[i]);           // adding to the list of common numbers
                        i++;
                    }               
                }
               return list.ToArray();                 // returning the resulting array
            }

            catch
            {
                throw;
            }
            // return new int[] { };
        }

      
       public static int[] Intersect2(int[] nums1, int[] nums2)
       {
           try
           {
                /*Logic: Used Dictionary 
                 *Time Complexity : O(n)*/

                Dictionary<int, int> dict = new Dictionary<int, int>();   //creating a dictionary
                int num;
                int k = 0;
                int[] inter = new int[nums1.Length + nums2.Length];

                for (int i = 0; i < nums1.Length; i++)  // a for loop to check whether dictionary contains a number using Containskey
                {
                    if (dict.ContainsKey(nums1[i]))
                    {
                        dict.TryGetValue(nums1[i], out num);
                        dict[nums1[i]] = ++num;  // for a number increasing the value
                    }
                    else
                    {
                        dict.Add(nums1[i], 1);
                    }
                }
                for (int j = 0; j < nums2.Length; j++)  // dict for second array elements 
                {
                    if (dict.ContainsKey(nums2[j]))  // checking the value
                    {
                        dict.TryGetValue(nums2[j], out num);
                        if (num > 0) 
                        {
                            inter[k] = nums2[j];
                            k++;
                            dict[nums2[j]] = --num;  // if number found in 2nd array decreasing the value
                        }
                    }
                }
                int[] intersect = new int[k];  // new array to store the output intersects
                int p = 0;
                for (p = 0; p < k; p++)
                {
                    intersect[p] = inter[p];
                }
                return intersect;           
           }
           catch
           {
               throw;
           }
          // return new int[] { };
       }

           
        public static bool ContainsDuplicate(char[] arr, int k)
    {
        try
        {
                /*Logic: 
                 * Solved this problem using Hashing.  Added one by one elements to hash. 
                 * Also removed elements which are at more than k distance from current element. 
                 * Following is detailed algorithm:
                 * 1) Create an empty HashSet.
                 * 2) Traverse all elements from left from right. Let the current element be ‘arr[i]’
                 *          a) If current element ‘arr[i]’ is present in hashtable, then return true.
                 *          b) Else add arr[i] to hash and remove arr[i-k] from hash if i is greater than or equal to k. 
                 * Time Complexity : Θ(n) */

                // Created an empty hashset 
                HashSet<int> set = new HashSet<int>();

                // Traversed the input array 
                for (int i = 0; i < arr.Length; i++)
                {
                    // If already present in hash, then we found a duplicate within k distance                  
                    if (set.Contains(arr[i]))
                        return true;

                    // Added this item to hashset 
                    set.Add(arr[i]);

                    // Remove the k+1 distant item 
                    if (i >= k)
                        set.Remove(arr[i - k]);
                }
                return false;
            }
        catch (Exception)
        {
            throw;
        }
       // return default;
    }

      
    public static int GoldRod(int rodLength)
    {
        try
        {
                // Logic: Used Recursion to solve the question.
                // Check the products of all possible breakup can be made in the Gold Rod and return the maximum product.
                // Since for every length there are two options, either a breakup to be made or not. 
                // Solve the problem for both options and choose maximum.
                // After Making the breakup the further options are, Either this breakup will produce the max product OR we need to make further breakups
                // Time Complexity: O(2n).

                // base case

                if (rodLength == 0 || rodLength == 1)
                {

                return 0;

                }

                // make all possible cuts and get the maximum

                int maxproduct = 0;

                 for (int i = 1; i < rodLength; i++) 
                {

                    // Either this cut will produce the max product or we need to make further cuts

                      maxproduct = Math.Max(maxproduct, Math.Max(i * (rodLength - i), i * GoldRod(rodLength - i)));     
                    
                }

               //return the max of all

             return maxproduct;
        }
        catch (Exception)
        {

            throw;
        }
      //  return 0;
    }

       
  public static bool DictSearch(string[] userDict, string keyword)
  {
      try
      {
                // This loop Returns true if there is any word in the Dictionary that equals to the given keyword after modifying exactly one character 
                for (int i = 0; i < userDict.Length; i++)
                {

                // Continue with next iteration if Length of the word does not match with Length of the keyword 
                if (userDict[i].Length != keyword.Length) 
                        continue;

                // count varaible to store number of characters matching
                var count = 0;

                // to check number of matching characters in word and keyword
                for (int j = 0; j < keyword.Length; j++)
                    if (keyword[j] == userDict[i][j]) 
                            count++;

                // if number of characters matching is length-1 which means exactly one character not matching. So, return true.
                    if (count == keyword.Length - 1) 
                        return true;
                }
            //else return false
            return false;
        
      }
      catch (Exception)
      {

          throw;
      }
    //  return default;
  }

        
         public static void SolvePuzzle()
         {
             try
             {
                /* This method will not Solve the Puzzle correctly by assigning correct values. 
                 * We are still thinking on brute force method to assign correct values to each digit. 
                 * This methods collect user inputs, identify unique characters in the strings and
                 * prints currently assigned integer values of the character between 0-25*/

                      // Accept 3 strings from user and convert the Strings to Upper Case

                       String input1, input2, output;

                       Console.WriteLine("Enter 2 input Strings and one output String: ");

                       Console.Write("Enter input String1: ");
                       input1 = Console.ReadLine();
                       input1 = input1.ToUpper();

                       Console.Write("Enter input String2: ");
                       input2 = Console.ReadLine();
                       input2 = input2.ToUpper();

                       Console.Write("Enter output String: ");
                       output = Console.ReadLine();
                       output = output.ToUpper();
                       Console.WriteLine();

                       // Concatnate all strings
                       string  stringconcat = string.Concat(input1, input2, output);

                       // Identify unique characters in the strings
                       string uniquechars = new String(stringconcat.Distinct().ToArray());

                       // Print all unique characters in the strings
                       Console.Write("Unique characters in the strings are:");
                       foreach (char letter in uniquechars)
                       {
                           Console.Write(letter + ",");
                       }
                       Console.WriteLine();                      

                       //Count unique characters  
                       int uniquecount = uniquechars.Length;
                       Console.WriteLine("Number of Unique characters in the strings are:" + uniquecount);
                       Console.WriteLine();

                       //To Print the currently assigned values of the character
                       Console.WriteLine("Currently assigned value of the character is:");
                       foreach (char letter in uniquechars)
                       {
                           // Get the integer value of the character.
                           int value = Convert.ToInt32(letter)-'A';

                           // Print letter and value
                           Console.WriteLine(letter + ":" + value);
                       }
             }
             catch (Exception)
             {

                 throw;
             }
         }
         
    }

}

/*Self Reflection:
Overall time taken to complete the assignment: 75 hrs.

Learning from the assignment:
1.  Learned how to properly do String, StringBuilder and Array manipulation.
        String and StringBuilder(Append)-  Implemented in Question 2 and 4 
        Array (Manipulation and Sort) - Implemented in Question 1,3,5(Part-2) and 8

2.  Learned to manipulate loops and nested loops to get the desired sequences.
        Loops - Implemented in all Questions

3.  Developed understanding on working with List, dictionary, Stack, Hashset and how it can help to solve problems easily. 
        Stack(Push and Pop) - Implemented in Question 2
        Dictionary(Add, TryGetValue and ContainsKey) -  Implemented in Question 4 and 5(Part-2)
        List(Add) - Implemented in Question 5(Part-1)
        Hashset(Contain, Add and Remove) - Implemented in Question 6

4.  Learned how recursion will help to solve big problems by breaking down into smaller versions of itself.
        Recursion - Implemented in Question 7

5.  Understood what is Time complexity and Big O Notation, how it affects the complexity of an Program and how to work around it to come to an optimal coding algorithm
        Big O Notation - Implemented in Question 1,2,3,5 and 6

6.  Challenging Problems from this assignment helped to get more knowledge and skills in C# Programming.

Recommendations for the assignment for future semesters:
1.	Overall very nice assignment and covered many interesting topics. I would recommend that more number of such practice assignments that would enhance both Programming skills and logical thinking.

2.	Since the implementation of programs like Puzzle is time consuming, this assignment 2 can be provided along with Assignment 1(Basic), so that whoever completes Assignment 1 can start thinking about these Advanced programs logic and concepts. 
*/