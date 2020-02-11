
//Console Window Link- https://github.com/vidhi-adp/DIS-Assignment-1/blob/master/DIS-Assignment1-Solution.PNG

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Assignment1_Spring2020
{
    class Program
    {
        // Time Taken: 40 minutes
        // Learnings : Built clear understanding of a method calling itself and recursion
        // Recommendation : Could try on building the function in one method 
        private static void PrintPattern(int n)
        {
            try
            {
                if (n == 0)
                {
                    return;
                }
                PrintEachLine(n);       // Calling below method with n=5, 4, 3, 2, 1
                Console.WriteLine();    
                PrintPattern(n - 1);    // Function calls itself
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }

        }
        private static void PrintEachLine(int j)
        {
            if (j == 0)
            {
                return;                 // If j=0, goes back to above method - PrintPattern()
            } 
            Console.Write(j + " ");     // Prints integers until n is not 0 on the same line
            PrintEachLine(j - 1);       // Print integer value, deccrement and calls itself
        }
        
        // Time Taken: 30 minutes
        // Learnings : Learnt about the logic of printing numbers based on different logics as required
        // Recommendation : Can work on more complex patterns for the next round
        private static void PrintSeries(int n2)
        {
            try
            {
                int m = 0;                      // Initializing a variable
                for (int n = 1; n <= n2; n++)   // Loop to print values input(n2) times
                {
                    m = m + n;                  // Adding previous m value to n and storing it in m
                    Console.Write(m + ",");     // Printing m
                }
                Console.WriteLine("...");
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
            } 
        }
        
        // Time Taken: 40 minutes
        // Learnings : Familiarised myself with the substring and split functions
        // Recommendation : Liked the idea of explporing hypothetical timezone 
        public static string UsfTime(string s)
        {
            try
            {
                string[] t1 = s.Split(":");                             // Splitting earth time based on semicolon (:)
                string t1_st35 = t1[2].Substring(0, 2);                 // Putting 35 of 35PM in variable t1_st35 
                string t1_PM = t1[2].Substring(2, 2);                   // Putting PM of 35PM in variable t1_PM
                int t1_09 = Convert.ToInt32(t1[0]);                     // First value of t1 from string to integer
                int t1_15 = Convert.ToInt32(t1[1]);                     // Second value of t1 from string to integer
                int t1_35 = Convert.ToInt32(t1_st35);                   // First part of t1_st35 from string to integer
                if (t1_PM == "PM")                                      // If earth time is in PM, add 12 to hours
                    t1_09 += 12;
                int t1_s = (t1_09 * 60 * 60) + (t1_15 * 60) + (t1_35);  //Convert earth time to seconds
                Console.WriteLine(t1_s+" seconds");

                int t1_U = t1_s / (60 * 45);                            // Convert earth seconds to 36U in variable t1_U
                int t1_mod_U = t1_s % (60 * 45);                        // Remainder in variable t1_mod_U 
                int t1_S = t1_mod_U / 45;                               // Calculate S as per 60S in t1_S
                int t1_F = t1_mod_U % 45;                               // Calculate F as per 45F in t1_F

                return (t1_U + ":" + t1_S + ":" + t1_F);                // Return USF time to main method for display

            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;
        }
        
        // Time Taken: 20 minutes
        // Learnings : Handled various cases based on for and if loops
        // Recommendation : Could reduce if loops and consolidate the code
        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                int x = 1;                                          // Initialize a variable to display 11 values in each line
                for (int i = 1; i <= n3; i++)                       // For loop to print values upto n3(110)
                {


                    if (i % 3 == 0 & i % 5 == 0 & i % 7 == 0)       // To check if integer is a multiple of 3,5 and 7
                    {
                        Console.Write("USF ");                      // Print USF if condition is true in place of i
                    }
                    else if (i % 3 == 0 & i % 5 == 0)               // To check if integer is a multiple of 3 and 5
                        {
                        Console.Write("US ");                       // Print US if condition is true in place of i
                    }
                        else if (i % 5 == 0 & i % 7 == 0)           // To check if integer is a multiple of 5 and 7
                    {
                        Console.Write("SF ");                       // Print SF if condition is true in place of i
                    }
                    else if (i % 3 == 0 & i % 7 == 0)               // To check if integer is a multiple of 3 and 7
                    {
                        Console.Write("UF ");                       // Print UF if condition is true in place of i
                    }
                    else if (i % 3 == 0)                            // To check if integer is a multiple of 3
                    {
                        Console.Write("U ");                        // Print U if condition is true in place of i
                    }
                    else if (i % 5 == 0)                            // To check if integer is a multiple of 5
                    {
                        Console.Write("S ");                        // Print S if condition is true in place of i
                    }
                    else if (i % 7 == 0)                            // To check if integer is a multiple of 7
                    {
                        Console.Write("F ");                        // Print F if condition is true in place of i
                    }
                    else
                    {
                        Console.Write(i + " ");                     // To print integer i
                    }
                    x = x + 1;                                      // Increment value of x
                    if (x > k)                                      // Check if x is greater that k(11)
                    {
                        x = 1;                                      // Reset x to 1 if it is above 11
                        Console.WriteLine();                        // Print new line
                    }
                }
                Console.WriteLine();

            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }
        
        // Time Taken: 1 hour
        // Learnings : Familiarised myself with the list, concatenating words and checking palindrome thereafter
        // Recommendation : Was able to go astep ahead of just checking single words and can try with three words as well
        static Boolean isPalindrome(string a)
        {
            int len = a.Length;                                              // Put length of each pair of words into variable len
            for (int k = 0; k < len / 2; k++)                                // Loop through first half of pair of words
            {
                if (a[k] != a[len - k - 1])                                  // Check if first half of pair of words is equal to second half
                    return false;                                            // If condition not satisfied return false
            }
            return true;                                                     // If condition not satisfied return true
        }
        public static void PalindromePairs(string[] words)
        {

            try
            {
                string s = "";                                               // Initialize a string s
                for (int i = 0; i < words.Length; i++)                       // Loop each words of list
                {
                    for (int j = 0; j < words.Length; j++)                   // Loop each word of a list             
                    {
                        if (i != j)                                          // Take the 2 words at positions i,j where i,j are not equal
                        {

                            String a = words[i] + words[j];                  // Concatenate each pair of words in the list
                            if (isPalindrome(a))                             // If condition satisfied, enter if loop
                            {
                                s = s + ("[" + i + "," + j + "]" + ",");     // Print position of palindrome words into pairs
                            }
                        }
                    }
                }
                Console.Write("[" + s.Substring(0, (s.Length - 1)) + "]\n"); // Removing the last comma ',' in s
            }
            catch
            {
                Console.WriteLine("Exception occured while computing PalindromePairs()");
            }
        }
        
        // Time Taken:3 hours
        // Learnings : Learnt about the logic of nim game and was able to implement it to quite an extent but require more code optimization
        // Recommendation : Would like to receive the ideal logic and guage better understanding
        public static void Stones(int n4)
        {
            try
            {
                if (n4 % 4 == 0)                                        // Check if number of stones is a multiple of 4
                {
                    Console.WriteLine("False");                         // If condition is true, player 1 looses and prints False
                }
                else
                {
                    List<int> myInts = new List<int>();                 // Initialize a new lis t
                    {
                        int sum = 0;                                    // Initialize integer variable sum
                        int pl1 = n4 % 4;                               // Put number of stones picked up by player 1 in variable pl1
                        myInts.Add(pl1);                                // Add pl1 value to a list
                        int pl2 = n4 - pl1;                             // Put remaining values in variable pl2
                        for (int i = 1; i <= pl2; i++)                  // For loop to print remaining stones
                        {
                            myInts.Add(1);                              // Add 1 to a list uptil pl2
                        }
                        foreach (int li in myInts)                      // Iterate through each integer value in the list
                        {
                            sum = myInts.Sum();                         // Add all values of the list
                        }
                        if (sum == n4)
                        {
                            int[] terms = myInts.ToArray();             // Put values of list to array
                            Console.Write("[");                         // Printing '[' as required for output
                            for (int k = 0; k < terms.Length; k++)      // Iterating through each value upto array length in the terms array
                            {   
                                Console.Write("{0}", terms[k]);         // Print values to the array terms
                                if (k != (terms.Length - 1))            // If k is not the last value in the array, remove ','
                                {
                                    Console.Write(",");
                                }

                                else
                                {
                                    break;
                                }
                            }
                            Console.Write("] \n");                      // Prints the closing bracket ']' at the end
                        }
                    }

                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }

        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine("Q1 - Printed decreasing number in traingular pattern as below -\n");
            PrintPattern(n);

            int n2 = 6;
            Console.WriteLine("\nQ2 - Wrote code to print following series - \n");
            PrintSeries(n2);

            string s = "09:15:35PM";
            Console.WriteLine("\nQ3 - Printed a new time zone with U-36, S-45 and F-60 -\n");
            Console.WriteLine("09:15:35 PM");
            string t = UsfTime(s);
            Console.WriteLine(t);

            int n3 = 110;
            int k = 11;
            Console.WriteLine("\nQ4 - Prints the numbers 1 to 110, 11 numbers per line with USF under specific conditions - \n");
            UsfNumbers(n3, k);

            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            Console.WriteLine("\nQ5 - Displaying indices of palindrome pair of words in a list- \n");
            PalindromePairs(words);

            int n4 = 5;
            Console.WriteLine("\nQ6 - Nim game to print False if Player 1 looses, and print turns otherwise - \n");
            Stones(n4);
        }
    }
}


