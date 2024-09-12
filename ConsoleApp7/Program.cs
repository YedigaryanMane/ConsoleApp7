using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
/*1*/   public static int SumTwoNum(int x1,int x2)
        {
            return x1 + x2;
        }

/*2*/  public static int ReturnEra(int num)
        {
            if(num%10 == 0)
            {
                num /= 100;
                return num;
            }
            else
            {
                num /= 100;
                return num + 1;
            }
        }

/*3*/ public static int ChekIsPalindrome(string str)
        {
            char[] arr = str.ToCharArray();
            string binary = "";
            for (int i = 0; i < arr.Length; i++)
            {
                binary = arr[i] + binary;
            }
            if(binary == str)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        /*4*/
        public static void ContainLongest(string[] str)
        {
            string tmp = "";

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i].Length > str[j].Length)
                    {
                        tmp = str[i];
                        str[i] = str[j];
                        str[j] = tmp;
                    }
                }
            }
            string binary1 = "";

            for(int i = 0;i < str.Length;i++)
            {
                if (str[0].Length == str[i].Length)
                {
                    binary1 = binary1 + " " + str[i];                    
                }
            }

            Console.Write(binary1);
        }
        /*5*/




        //---------------------------------------------





        public static void ReturnLuckNum(int n)
        {
            int count = 0;
            int y = 0;
            int x = n;
            int c = 0;
            while(n > 0)
            {
                y = y * 10 + n % 10;
                count++;
                n /= 10;
               
            }
            int k = 0;
          
            for(int i = 0; i < count/2;i++)
            {
                k = x / 10;
                x /= 10;
                
                
            }
            for(int i = 0;i< count/2;i++)
            {
                c = y / 10;
                y /= 10;
            }
            int sum = 0;
            int v = 0;
            for(int i = 0;i<count/2;i++)
            {
                v = k % 10;
                sum += v;
                k /= 10;
            }
            int sum2 = 0;
            int v2 = 0;
            for(int i = 0;i < count/2;i++)
            {
                v2 = c % 10;
                sum2+= v2;
                c /= 10;
            }
            if(sum==sum2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        

/*6*/  public static void CalculateSeconds(int day)
        {
            Console.WriteLine(day*86400);
        }

/*7*/ public static void CalculateSum(int x1,int x2)
        {
            Console.WriteLine(x1+x2);
        }

        /*8*/
        public static void Calculate3NumSum(int x1, int x2, int x3)
        { 
            Console.WriteLine(x1+x2+x3);
        }

        /*9*/
        public static void DetermineOldAge(int age)
        {
            if(age >= 1900)
            {
                Console.WriteLine("You are young.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }

        /*10*/
        public static void ChekMark(int num)
        { 
            if(num >=0)
            {
                Console.WriteLine("Num is positive.");
            }
            else
            {
                Console.WriteLine("Num is negative.");
            }
        }

/*11*/ public static void ReturnAnswer(int age)
        {
            if(age > 0 && age <= 18)
            {
                Console.WriteLine("You are under age.");
            }
            else
            {
                Console.WriteLine("You are adult.");
            }
        }

/*12*/ public static void CalculatePowerOfNum(int num)
        {
            while(num > 0)
            {
                int y = 1;
                int index = 0;
               for(int i = index; ; i++)
                {
                     y *=num;
                    index++;
                    Console.WriteLine("Shall we continue?");
                    string x = Console.ReadLine();
                    string answer = "y";
                    string answer1 = "Y";
                    if(x == answer || x == answer1)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
               
            }
        }
        /*13*/
        public static void ReturnNum(int n, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++) 
            {
                if(arr[i] == n)
                {
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    Console.WriteLine(-1);
                    break;
                }
            }
        }

/*14*/ public static void ReturnBool(int[] arr,int n)
        {
  
            for (int i = 0; i < arr.Length; i++)
            { 
                if(arr[i] == n)
                {
                    Console.WriteLine("true");
                    break;
                }
                else
                {
                    Console.WriteLine(" true");
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            //1
            //int x1 = Convert.ToInt32(Console.ReadLine());
            //int x2 = Convert.ToInt32(Console.ReadLine());
            //int sum = SumTwoNum(x1, x2);
            //Console.WriteLine(sum);

            //2
            //int num = Convert.ToInt32(Console.ReadLine());
            //int x = ReturnEra(num);
            //Console.WriteLine(x);

            //3
            //string str = Console.ReadLine();
            //int y = ChekIsPalindrome(str);
            //Console.WriteLine(y);

            //4
            //string[] str = { "abak", "ba", "ha", "baba" };
            //ContainLongest(str);

            //5
            //int n = Convert.ToInt32(Console.ReadLine());
            //ReturnLuckNum(n);

            //6
            //int day = Convert.ToInt32(Console.ReadLine());
            //CalculateSeconds(day);

            //7
            //int x1 = Convert.ToInt32(Console.ReadLine());
            //int x2 = Convert.ToInt32(Console.ReadLine());
            // CalculateSum(x1,x2);

            //8
            //int x1 = Convert.ToInt32(Console.ReadLine());
            //int x2 = Convert.ToInt32(Console.ReadLine());
            //int x3 = Convert.ToInt32(Console.ReadLine());
            //Calculate3NumSum (x1, x2, x3);

            //9
            //int age = Convert.ToInt32(Console.ReadLine());
            //DetermineOldAge (age);

            //10
            //int num = Convert.ToInt32(Console.ReadLine());
            //ChekMark(num);

            //11
            //int age = Convert.ToInt32(Console.ReadLine());
            //ReturnAnswer(age);

            //12
            //int num = Convert.ToInt32(Console.ReadLine());
            //CalculatePowerOfNum(num);

            //13
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = { 4, 6, 9, 45, 97 };
            //ReturnNum(n, arr);

            //14
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = { 4, 6, 9, 45, 97 };
            //ReturnBool(arr, n);

            Console.ReadLine();

        }
    }
}
