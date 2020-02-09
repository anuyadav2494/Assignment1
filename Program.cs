using System;
using System.Collections;

namespace Assignment1_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Output for Question 1-------");
            int n = 5;
            PrintPattern(n);

            Console.WriteLine("------Output for Question 2-------");
            int n2 = 4; 
            PrintSeries(n2);

            Console.WriteLine();
            Console.WriteLine("------Output for Question 3-------");
            string s = "09:15:35PM";
            string t = UsfTime(s);
            Console.WriteLine(t);

            Console.WriteLine();
            Console.WriteLine("------Output for Question 4-------");
            int n3 = 110;
            int k = 11;
            UsfNumbers(n3, k);

            Console.WriteLine();
            Console.WriteLine("------Output for Question 5-------");
            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
          
            PalindromePairs(words);

            Console.WriteLine();
            Console.WriteLine("------Output for Question 6-------");
            int n4 = 4;
            Stones(n4);
            Console.ReadLine();


        }


        static void PrintPattern(int n)
        { 
           
            try
            {
                
                Console.WriteLine();
                // corner case to check if n is a positive number
                if (n < 1) 
                    return;
                // Prints the numbers of nth row 
                PrintPatternRecursion(n);
                // Moves to next line
                Console.WriteLine();
               //Prints the numbers of remaining rows recursively
                PrintPattern(n - 1);
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }

        }
        
        static void PrintPatternRecursion(int n)
        {   // corner case to check if n is a positive number
            if (n < 1)
            return;
            //Print the numbers of remaining rows recursively
            Console.Write(n + " ");
            PrintPatternRecursion(n - 1);
        }





        private static void PrintSeries(int n2)
        {
            try
                
            {
                
           
                //Checking if n2 is a positive number
                if (n2 < 1)
                    return;
                // initialize k = 0
                int k = 0;
                Console.Write("Series is:");
                // Run the series from 1 to n2
                for (int i=1;i<=n2;i++)
                {    // Increasing k by i everytime
                    k = k + i;
                    if (k == 1) {
                        Console.Write( k);
                    }
                    else
                    {   // Printing k
                        Console.Write("," + k);
                    }
                }
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
            }
        }


        public static string UsfTime(string s)
        {
            try
            {
               
               //Splitting the input based on delimiter ":" and creates a array of substring
                string[] time = s.Split(':');
                //Storing the element at index 0 in the array as e_hours and converting to int
                int e_hours = Int32.Parse(time[0]);
                //Storing the element at index 1 in the array as e_minutes and converting to int
                int e_minutes = Int32.Parse(time[1]);
                /*The element at index 2 is in the form of 35PM(Seconds and AM/PM) ,we are removing the AM/PM from
                the string and converting the seconds into int*/
                string seconds = time[2].Remove(2, 2);
                int e_seconds = Int32.Parse(seconds);
                int e_hours_24hr;
                //Check if the time entered is valid
                if ((0.00 <= e_hours && e_hours <= 12.00) && (e_minutes >= 0 && e_minutes <= 59) && (e_seconds >= 0 && e_seconds <= 59))
                { //Check if time is PM,then convert to 24 hr format,since input is in 12 hr format
                    if (s.Contains("PM"))
                    {
                        //add 12 hours to input if time entered is in PM
                        e_hours_24hr = e_hours + 12;
                    }
                    else
                    {
                        e_hours_24hr = e_hours;
                    }
                   // Console.WriteLine(Environment.NewLine);
                    //Calculate total numbers of seconds of input
                    int total_seconds = e_hours_24hr * 60 * 60 + e_minutes * 60 + e_seconds;
                    //Convert the total seconds to hours in USF system(USF system 36hrs,60minutes and 45 seconds)
                    int USF_hours = total_seconds / (60 * 45);
                    //Convert the remainder of hours to minutes
                    int USF_minutes = (total_seconds % (60 * 45)) / 45;
                    //Convert the remainder of minutes to seconds
                    int USF_seconds = (total_seconds % (60 * 45)) % 45;
                    //Print the time in USF system
                    Console.WriteLine("The time in USF planet is " + USF_hours + " : " + USF_minutes + " : " + USF_seconds);

                }

                else
                {
                    Console.WriteLine("Enter valid earth time");
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;
        }


        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                //Check if n3 and k are valid
                if (n3 < 1)
                    return;
                if (k < 1)
                    return;
                Console.WriteLine();
                

                for(int  i=1;i<=n3;i++)
                {
                    //if the number is not a multiple of k
                    if (i % k != 0)
                    { 
                        //the number is multiple of 3 and 5,print US
                        if (i % 3 == 0 && i % 5 == 0)
                        {
                            Console.Write(" US ");
                        }
                        //the number is multiple of 5 and 7,print SF
                        else if (i % 5 == 0 && i % 7 == 0)
                        {
                            Console.Write(" SF ");
                        }
                        //the number is multiple of 3 and 7,print UF
                        else if (i % 3 == 0 && i % 7 == 0)
                        {
                            Console.Write(" UF ");

                        }
                        //the number is multiple of 3 ,print U
                        else if (i % 3 == 0)
                        {
                            Console.Write(" U ");
                        }
                        //the number is multiple of 5 ,print S
                        else if (i % 5 == 0)
                        {
                            Console.Write(" S ");
                        }
                        //the number is multiple of 7 ,print F
                        else if (i % 7 == 0)
                        {
                            Console.Write(" F ");
                        }
                        //else print the number if it is not multiple of any mentioned above
                        else
                        {
                            Console.Write(" " + i + " ");
                        }

                    }
                    //if the number is multiple of k,print i and move to next line
                    else
                    {
                        Console.Write(i);
                        Console.WriteLine("\r\n");
                    }
                    
                }  
                
            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }



        public static void PalindromePairs(string[] words)
        {
            try
            {
                Console.WriteLine();
                
                int n = words.Length;
                Console.Write("[");
                
                for(int i=0;i<n;i++)
                {
                    for(int j=i+1;j<n;j++)
                    {
                        //p contains the string which is combination of two words at indices i and j
                        string p = words[i] + words[j];
                        //p contains the string which is combination of two words at indices j and i
                        string q = words[j] + words[i];
                        //Convert the string to array 
                        char[] temp = p.ToCharArray();
                        char[] temp1 = q.ToCharArray();
                        //Reverse
                        Array.Reverse(temp);
                        Array.Reverse(temp1);
                        //Convert to string
                        string b = new string(temp);
                        string c = new string(temp1);
                        // if original string and reverse string are equal,then the word is a palindrome
                        if (p.Equals(b) )
                        {
                            //Print the indices together
 
                                Console.Write(" [" + i + "," + j + "]" );
                               
                        }
                         
                        if (q.Equals(c))
                        {
                            Console.Write(" [" + j + "," + i + "]");
                         
                        }

                    }
                }
               
                Console.Write("]");
                Console.WriteLine();
                Console.Write("Palindromes are : [");
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        //string reverse;
                        string p = words[i] + words[j];
                        string q = words[j] + words[i];
                        char[] temp = p.ToCharArray();
                        char[] temp1 = q.ToCharArray();
                        Array.Reverse(temp);
                        Array.Reverse(temp1);
                        string b = new string(temp);
                        string c = new string(temp1);
                        //If the word is a palindrome,print the word
                        if (p.Equals(b))
                        {
                            Console.Write(  p + " ");

                        }
    
                        if (q.Equals(c))
                        {
                             Console.Write( q+ " ");
                           
                        }
    
                    }
                }
                Console.Write(" ]");
                Console.WriteLine();
            }
            catch
            {

                Console.WriteLine("Exception occured while computing  PalindromePairs()");
            }
        }
        
        public static void Stones(int n4)
        {
            try
            {  
                //Console.WriteLine();
              
                ArrayList a = new ArrayList();
                Random randomNumbers = new Random();
                /*As player 1 can pick any stomes from 1 to 3,
                we are storing random number in the range(1,3) in i variable*/
                int i = randomNumbers.Next(1, 3 + 1);
                //Add value of i in arraylist
                
                // Now P2 can pick from the remaining stones i.e (totalstones-number of stones picked by P1)
                int m = (n4 - i);
                a.Add(i);
                //If 3 or less than 3 stones are left in the bag,then P2 wins
                if(m <= 3)
                {
                    a.Add(m);
                    
                }
                /*If number of stones left after P1 picks is greater than 3,then P2 can pick to continue the game
                else P2 wins(if stones left are less or equal to 3 then P2 wins)*/
                while (m > 3)
                  {
                        //Number of stones picked by P2 is generated randomly within the range(1,3)
                        int p = randomNumbers.Next(1, 3 + 1);
                    // Add value of p in list
                        a.Add(p);
                    // Now calculate remaining stones
                        m = m - p;
                    //If remaining stones are less or equal to 3, then P1 wins else game continues
                        if (m <= 3)
                        {   //Add value of m to ArrayList
                            a.Add(m);
                        }

                  }
                   /* After getting the elements of arrayList,if the array has even number of elements
                    then P2 wins as P2 picks the last stone else P1 wins*/
                    int total = a.Count;
                    if (total % 2 == 0)
                    {
                        Console.Write("Array of moves of both players [");
                    //Print the array
                        foreach (int z in a)
                            Console.Write(" " + z );
                        Console.Write("]");
                        Console.WriteLine();
                        Console.WriteLine("Result of the Game :You Loose");
                    }
                    else
                    {
                        Console.Write(" Array of moves of both players [");
                        foreach (int z in a)
                            Console.Write(" " + z);
                        Console.Write("]");
                        Console.WriteLine();
                        Console.WriteLine("Result of the Game : You Win");
                    }


                
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }


    }
}

