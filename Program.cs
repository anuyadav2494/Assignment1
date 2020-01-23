using System;

namespace Assignment1_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            PrintPattern(n);

            int n2 = 6;
            PrintSeries(n2);

            string s = "09:15:35PM";
            string t = UsfTime(s);
            Console.WriteLine(t);
         

            int n3 = 110;
            int k = 11;
            UsfNumbers(n3, k);

            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            PalindromePairs(words);
            Console.ReadLine();


        }


        private static void PrintPattern(int n)
        {
            try
            {
                for(int i=0;i<n;i++)
                {
                    for(int j=0;j<n-i;j++)
                    {
                        int k = n - i - j;
                        Console.Write(k);

                    }
                    Console.WriteLine(Environment.NewLine);
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }
        }


        private static void PrintSeries(int n2)
        {
            try
                
            {
                int k = 0;
                Console.Write("Series is:");
                for (int i=1;i<=n2;i++)
                {
                    
                   // int number;
                    k = k + i;
                    if (k == 1) {
                        Console.Write( k);
                    }
                    else
                    {
                        Console.Write("," + k);
                    }
                   

                }
              
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
                string[] time = s.Split(':');
                int e_hours = Int32.Parse(time[0]);
                int e_minutes = Int32.Parse(time[1]);
                string seconds = time[2].Remove(2,2);
                int e_seconds = Int32.Parse(seconds);
                int e_hours_24hr;
                if (s.Contains("PM"))
                {
                     e_hours_24hr = e_hours + 12;
                }
                else
                {
                    e_hours_24hr = e_hours;
                }
                Console.WriteLine(Environment.NewLine);
                    int total_seconds = e_hours_24hr* 60 * 60 + e_minutes * 60 + e_seconds;
                    int USF_hours = total_seconds / (60 * 45);
                    int USF_minutes = (total_seconds % (60 * 45)) / 45;
                    int USF_seconds = (total_seconds % (60 * 45)) % 45;     
                Console.WriteLine("The time in USF planet is " + USF_hours + " : " + USF_minutes + " : " + USF_seconds);

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
                for(int  i=1;i<=n3;i++)
                {
                    if (i % k != 0)
                    {

                        
                        if (i % 3 == 0 && i % 5 == 0)
                        {
                            Console.Write(" US ");
                        }
                        else if (i % 5 == 0 && i % 7 == 0)
                        {
                            Console.Write(" SF ");
                        }
                        else if (i % 3 == 0 && i % 7 == 0)
                        {
                            Console.Write(" UF ");

                        }
                        else if (i % 3 == 0)
                        {
                            Console.Write(" U ");
                        }
                        else if (i % 5 == 0)
                        {
                            Console.Write(" S ");
                        }
                        else if (i % 7 == 0)
                        {
                            Console.Write(" F ");
                        }

                        else
                        {
                            Console.Write(" " + i + " ");
                        }

                    }
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
                // Write your code here
            }
            catch
            {

                Console.WriteLine("Exception occured while computing     PalindromePairs()");
            }
        }

        public static void Stones(int n4)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }


    }
}

