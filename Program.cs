using System;
using System.Collections.Generic;

namespace Assignment2_DIS_Spring2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1:");
            int[] ar1 = { 2,5,1,3,4,7};
            int n1 = 3;
            ShuffleArray(ar1, n1);
            Console.WriteLine();
           

            //Question 2 
            Console.WriteLine("Question 2:");
            int[] ar2 = { 0, 1, 0, 3, 12 };
            MoveZeroes(ar2);
            Console.WriteLine();

            //Question3
            Console.WriteLine("Question 3:");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4:");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5:");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            RestoreString(s5, indices);
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6:");
            string s61 = "bulls";
            string s62 = "sunny";
            if (Isomorphic(s61, s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7:");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8:");
            int n8 = 19;
            if (HappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9:");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10:");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine();

        }

        //Question 1
        /// <summary>
        /// Shuffle the input array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        /// Print the array in the form[x1, y1, x2, y2, ..., xn, yn].
        ///Example 1:
        ///Input: nums = [2,5,1,3,4,7], n = 3
        ///Output: [2,3,5,4,1,7]
        ///  Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2,3,5,4,1,7].
        ///Example 2:
        ///Input: nums = [1,2,3,4,4,3,2,1], n = 4
        ///Output: [1,4,2,3,3,2,4,1]
        ///Example 3:
        ///Input: nums = [1,1,2,2], n = 2
        ///Output: [1,2,1,2]
        /// </summary>

        private static void ShuffleArray(int[] nums, int n)
        {
            try
            {
                int count = 1;
                if (nums == null || nums.Length == 0)  // if array contains null or no value 
                    Console.WriteLine("invalid input");

                int[] res = new int[2 * n];           // res array of size 2 * n
                
                int idx1 = 0, idx2 = n;

                for (int i = 0; i < 2 * n; i++)      
                {
                    if (i % 2 == 0)                  // Shuffling the array based on the index of the array
                        res[i] = nums[idx1++];     
                    else
                        res[i] = nums[idx2++];
                }
                foreach (int i in res)
                {
                    if (count == res.Length)        // Printing the shuffled array
                        Console.Write(i);
                    else
                        Console.Write(i + ",");
                    count++;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        //    //Question 2:
        //    /// <summary>
        //    /// Write a method to move all 0's to the end of the given array. You should maintain the relative order of the non-zero elements. 
        //    /// You must do this in-place without making a copy of the array.
        //    /// Example:
        //    ///Input: [0,1,0,3,12]
        //    /// Output: [1,3,12,0,0]
        //    /// </summary>

        private static void MoveZeroes(int[] ar2)
        {
            try
            {
                int temp;                                           //Initialize the variables
                int flag = 0;
                int count = 1;
                for (int i = 0; i < ar2.Length; i++)                //loop the array
                {
                    if (ar2[i] == 0)                                 // if array element equal to zero
                    {
                        for (int j = i + 1; j < ar2.Length; j++)        // loop the array after initializing j=i+1
                        {
                            if (ar2[j] != 0)                            // if jth element not equal to zero
                            {
                                temp = ar2[j];                         // Assign jth element to zero and ith element to the value of jth element 
                                ar2[j] = 0;                            //Move the Zeros to the end
                                flag = 1;
                                ar2[i] = temp;
                                break;
                            }
                        }
                        if (flag == 0)
                            break;
                    }
                }
                foreach (int i in ar2)                              // Printing the array
                {
                    if (count == ar2.Length)
                        Console.Write(i);
                    else
                        Console.Write(i + ",");
                    count++;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        //    //Question 3
        //    /// <summary>
        //    /// For an array of integers - nums
        //    ///A pair(i, j) is called cool if nums[i] == nums[j] and i<j
        //    ///Print the number of cool pairs
        //    ///Example 1
        //    ///Input: nums = [1,2,3,1,1,3]
        //    ///Output: 4
        //    ///Explanation: There are 4 cool pairs (0,3), (0,4), (3,4), (2,5) 
        //    ///Example 3:
        //    ///Input: nums = [1, 2, 3]
        //    ///Output: 0
        //    ///Constraints: time complexity should be O(n).
        //    /// </summary>

        private static void CoolPairs(int[] nums)
        {
            try
            {
                if (nums == null || nums.Length < 1)
                    Console.WriteLine("Invalid Input");                 //checking the valid input

                int cnt = 0;                                           // initialize the count variable
                Dictionary<int, int> dic = new Dictionary<int, int>();          // initialize the dictionary
                for (int i = 0; i < nums.Length; i++)                       // loop the array
                {                                                                           
                    if (!dic.ContainsKey(nums[i]))                        // if dictionary doesnot contain value add the value
                        dic.Add(nums[i], 1);
                    else
                    {                                                    
                        cnt += dic[nums[i]];                             // count the no of times the value is there
                        dic[nums[i]]++;
                    }
                }

                Console.WriteLine(cnt);                                 // print the value of count of pairs
            }
            catch (Exception)
            {

                throw;
            }
        }
        //    //Question 4:
        //    /// <summary>
        //    /// Given integer target and an array of integers, print indices of the two numbers such that they add up to the target.
        //    ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        //    /// You can print the answer in any order
        //    ///Example 1:
        //    ///Input: nums = [2,7,11,15], target = 9
        //    /// Output: [0,1]
        //    ///Output: Because nums[0] + nums[1] == 9, we print [0, 1].
        //    ///Example 2:
        //    ///Input: nums = [3,2,4], target = 6
        //    ///Output: [1,2]
        //    ///Example 3:
        //    ///Input: nums = [3,3], target = 6
        //    ///Output: [0,1]
        //    ///Constraints: Time complexity should be O(n)
        //    /// </summary>
        private static void TwoSum(int[] nums, int target)
        {
            try
            {
                int size = nums.Length;
                int temp2 = 0;
                int count = 0;
                int temp = 0;
                HashSet<int> hs = new HashSet<int>();// list of numbers already read in the loop
                for (int i = 0; i < size; i++)
                {
                    temp = target - nums[i];//if target-nums[i] if already there in the list, it means that the pair is the index position of temp, and i

                    if (hs.Contains(temp))
                    {
                        temp2 = i;//value of i is stored into another temp variable 
                        break;
                    }
                    hs.Add(nums[i]);
                }
                for (int i = 0; i < size; i++)//searches for the index position of the required temp
                {
                    if (nums[i] == temp)
                    {
                        Console.Write(i + ",");
                        count++;
                    }
                    if (count == 1)
                        break;
                }
                Console.Write(temp2);// temp2 is displayed as is because it is already an index position of the array
            }
            catch (Exception)
            {

                throw;
            }

        }

        //    //Question 5:
        //    /// <summary>
        //    /// Given a string s and an integer array indices of the same length.
        //    ///The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        //    ///Print the shuffled string.
        //    ///Example 1
        //    ///Input: s = "korfsucy", indices = [6,4,3,2,1,0,5,7]
        //    ///Output: "usfrocky"
        //    ///Explanation: As shown in the assignment document, “K” should be at index 6, “O” should be at index 4 and so on. “korfsucy” becomes “usfrocky”
        //    ///Example 2:
        //    ///Input: s = "USF", indices = [0,1,2]
        //    ///Output: "USF"
        //    ///Explanation: After shuffling, each character remains in its position.
        //    ///Example 3:
        //    ///Input: s = "ockry", indices = [1, 2, 3, 0, 4]
        //    ///Output: "rocky"
        //    /// </summary>
        private static void RestoreString(string s, int[] indices)
        {
            try
            {
                char[] charArray = new char[s.Length];              //initialize the character array

                for (int i = 0; i < indices.Length; i++)            // loop the indices array
                {
                    charArray[indices[i]] = s[i];                   //the string at the index i is assigned to the charArray at indices[i] position
                }

                string restore = string.Empty;
                foreach (char c in charArray)
                {
                    restore += c.ToString();                  // convert charArray to string
                }

                Console.WriteLine(restore);                     // print the Restoredstring
            }
            catch (Exception)
            {

                throw;
            }
        }

        //    //Question 6
        //    /// <summary>
        //    /// Determine whether two give strings s1 and s2, are isomorphic.
        //    ///Two strings are isomorphic if the characters in s1 can be replaced to get s2.
        //    ///All occurrences of a character must be replaced with another character while preserving the order of characters.
        //    ///No two characters may map to the same character but a character may map to itself.
        //    ///Example 1:
        //    ///Input:s1 = “bulls” s2 = “sunny” 
        //    ///Output : True
        //    ///Explanation: ‘b’ can be replaced with ‘s’ and similarly ‘u’ with ‘u’, ‘l’ with ‘n’ and ‘s’ with ‘y’.
        //    ///Example 2:
        //    ///Input: s1 = “usf” s2 = “add”
        //    ///Output : False
        //    ///Explanation: ‘u’ can be replaced with ‘a’, but ‘s’ and ‘f’ should be replaced with ‘d’ to produce s2, which is not possible. So False.
        //    ///Example 3:
        //    ///Input : s1 = “ab” s2 = “aa”
        //    ///Output: False
        //    /// </summary>
        private static bool Isomorphic(string s1, string s2)
        {
            try
            {

                int m = s1.Length;
                int n = s2.Length;
                if (m != n)                         // length of both strings must be same
                    return false;
                int size = 256;
                bool[] marked = new bool[size];     //To mark visited characters in s2

                for (int i = 0; i < size; i++)
                    marked[i] = false;
                int[] map = new int[size];          //To store mapping of every character from s1 to that of s2 and Initialize all entries of map as -1. 

                for (int i = 0; i < size; i++)
                    map[i] = -1;
                for (int i = 0; i < n; i++)         //loop through the string and check each character
                {
                    if (map[s1[i]] == -1)
                    {
                        if (marked[s2[i]] == true)          //if current char of s2 is already seen, 1 to 1 mapping is not possible
                            return false;
                        marked[s2[i]] = true;               //marks the char of s2 as read 
                        map[s1[i]] = s2[i];                 //store mapping of current characters
                    }
                    else if (map[s1[i]] != s2[i])
                        return false;
                }
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        private static void HighFive(int[,] items)
        {
            try
            {
                List<int> ids = new List<int>();            // initialize the list ids
                List<int> id_count = new List<int>();       // initialize the list id_count
                List<int> scores = new List<int>();         // initialize the list scores
                int avg = 0;                                // initialize the variables avg and ids to zero
                int idc = 0;
                foreach (int id in items)                  // stores all the ids in ids
                {
                    if (idc % 2 == 0)
                        ids.Add(id);
                    idc++;
                }

                for (int i = 0; i < ids.Count; i++)         //removes all duplicate elements in ids and stores in a different list
                {
                    bool isDuplicate = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (ids[i] == ids[j])
                        {
                            isDuplicate = true;
                            break;
                        }
                    }
                    if (!isDuplicate)
                        id_count.Add(ids[i]);
                }

                for (int i = 0; i < id_count.Count; i++)
                {
                    int c1 = 0;
                    for (int j = 0; j < items.Length / 2; j++)              //scores are checked with the ids and added to the scores list
                    {
                        if (items[j, 0] == id_count[i])
                        {
                            scores.Add(items[j, 1]);
                            c1++;
                        }
                    }

                    scores.Sort();
                    scores.Reverse();                                       //sorts the list in descending order. Makes is easier to take the top 5 scores
                    if (c1 != 0)
                    {
                        int scrcount = 0;

                        foreach (int score in scores)
                        {
                            if (scrcount >= 5)
                            { break; }
                            else
                            {
                                avg += score;                           //sum of top 5 scores
                                scrcount++;
                            }
                        }
                    }
                    Console.WriteLine(id_count[i] + "," + avg / 5);
                    scores.Clear();                                 //list is emptied to calculate the score of the next id
                    avg = 0;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 8
        //    /// <summary>
        //    /// Write an algorithm to determine if a number n is happy.
        //    ///A happy number is a number defined by the following process:
        //    ///•	Starting with any positive integer, replace the number by the sum of the squares of its digits.
        //    ///•	Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        //    ///•	Those numbers for which this process ends in 1 are happy.
        //    ///Return true if n is a happy number, and false if not.
        //    ///Example 1:
        //    ///Input: n = 19
        //    ///Output: true
        //    ///Explanation:
        //    ///12 + 92 = 82
        //    ///82 + 22 = 68
        //    ///62 + 82 = 100
        //    ///12 + 02 + 02 = 1
        //    ///Example 2:
        //    ///Input: n = 2
        //    ///Output: false
        //    ///Constraints:
        //    ///1 <= n <= 231 - 1
        //    /// </summary>

        private static bool HappyNumber(int n)
        {
            try
            {
                
                HashSet<int> useNums = new HashSet<int>();              // initialize the hashset to store number n
                List<int> digits = new List<int>();                     // store the digits
                while (n != 1)
                {
                    useNums.Add(n);                                     // adding the numner to the hashset
                    while (n != 0)
                    {
                        digits.Add(n % 10);
                        n /= 10;
                    }
                    foreach (var digit in digits)                       // looping the digits list
                    {
                        n += digit * digit;
                    }
                    if (useNums.Contains(n))
                    {
                        return false;
                    }
                    digits.Clear();
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Question 9
        //    /// <summary>
        //    /// Professor Manish is planning to invest in stocks. He has the data of the price of a stock for the next n days.  
        //    /// Tell him the maximum profit he can earn from the given stock prices.Choose a single day to buy a stock and choose another day in the future to sell the stock for a profit
        //    /// If you cannot achieve any profit return 0.
        //    /// Example 1:
        //    /// Input: prices = [7,1,5,3,6,4]
        //    /// Output: 5
        //    /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        //    /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        //    /// Example 2:
        //    /// Input: prices = [7,6,4,3,1]
        //    /// Output: 0
        //    ///Explanation: In this case, no transactions are done and the max profit = 0.
        //    ///Try to solve it in O(n) time complexity.
        //    /// </summary>

        private static int Stocks(int[] prices)
        {
            try
            {
                if (prices == null || prices.Length < 2)                    // checking the value of prices
                    return 0;
                int sum = 0;                                               // initialize the values
                int max = 0;
                for (int i = 1; i < prices.Length; i++)                   // loop the prices array
                {
                    sum += (prices[i] - prices[i - 1]);                  //  calculate profit

                    if (sum < 0)                                          
                    {                                                   // if sum less than zero initialize sum to zero
                        sum = 0;
                    }
                    else if (max < sum)
                    {
                        max = sum;
                    }
                }

                return max;                                            //return profit
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 10
        //    /// <summary>
        //    /// Professor Clinton is climbing the stairs in the Muma College of Business. He generally takes one or two steps at a time.
        //    /// One day he came across an idea and wanted to find the total number of unique ways that he can climb the stairs. Help Professor Clinton.
        //    /// Print the number of unique ways. 
        //    /// Example 1:
        //    ///Input: n = 2
        //    ///Output: 2
        //    ///Explanation: There are two ways to climb to the top.
        //    ///1. 1 step + 1 step
        //    ///2. 2 steps
        //    ///Example 2:
        //    ///Input: n = 3
        //    ///Output: 3
        //    ///Explanation: There are three ways to climb to the top.
        //    ///1. 1 step + 1 step + 1 step
        //    ///2. 1 step + 2 steps
        //    ///3. 2 steps + 1 step
        //    ///Hint : Use the concept of Fibonacci series.
        //    /// </summary>

        private static void Stairs(int steps)
        {
            try
            {
                if (steps == 0)
                    Console.WriteLine(steps);                               // checking the condition for steps
                if (steps == 1)
                    Console.WriteLine(steps);
                if (steps == 2)
                    Console.WriteLine(steps);

                var preStep = 1;                                           // initialzing the values
                var pre = 2;

                for (int i = 2; i < steps; i++)
                {                                                         // Using the concept of Fibonacci series.
                    var cur = preStep + pre;
                    preStep = pre;
                    pre = cur;
                }

                Console.WriteLine(pre);                                 // returning the value of pre
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
