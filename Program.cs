using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace task2712
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxnums = nums(15, 35, 20);
            Console.WriteLine(maxnums);

            var sumarray = sums(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine(sumarray);
            Console.WriteLine(findfirstIndex("thanks", 't'));
            Console.WriteLine(findlastIndex("narmin", 'n'));
            Console.WriteLine(maxarraynums(new int[] { 43, 24, 63, 84, 35 }));
            Console.WriteLine(nums(45));
            var countnums = numcount(new int[] { 27, 12, 20, 23 });
            Console.WriteLine(countnums);
            Console.WriteLine(text1("    salam   necesen"));
            Console.WriteLine(text2("salam   necesen     "));
        }


        static int nums(int num1, int num2, int num3)
        {
            //Verilmiş 3 ədədin cəmini tapan method(həm int, həm double ədədlər üçün)
            if (num1 > num2)
            {
                if (num1 > num3) return num1;
                else return num3;
            }
            else if (num2 > num3) return num2;
            else return num3;

        }
        static double nums(double num1, double num2, double num3)
        {    //Verilmiş 3 ədədin cəmini tapan method(həm int, həm double ədədlər üçün)
            if (num1 > num2)
            {
                if (num1 > num3) return num1;
                else return num3;
            }
            else if (num2 > num3) return num2;
            else return num3;
        }

        static int sums(int[] array)
        {
            //Verilmiş ədədlər siyahısındaki bütün ədədlərin cəmini tapan method(həm int, həm double ədədlər üçün)
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;

        }
        static double sums(double[] array)
        {
            //Verilmiş ədədlər siyahısındaki bütün ədədlərin cəmini tapan method(həm int, həm double ədədlər üçün)
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;

        }
        static int findfirstIndex(string text, char wantchar)
        {
            //Verilmiş yazıda veirlmiş charın yerləşdiyi ilk indexi tapan method(yoxdursa -1 qaytarı)

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == wantchar)
                    return i;

            }
            return -1;
        }
        static int findlastIndex(string text, char wantchar)
        {
            //Verilmiş yazıda veirlmiş charın yerləşdiyi son indexi tapan method(yoxdursa - 1 qaytarı)

            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (text[i] == wantchar)
                    return i;
            }
            return -1;
        }
        static int maxarraynums(int[] array)
        {
            //Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan method
            int result = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > result)
                {
                    result = array[i];

                }
            }
            return result;
        }

        static bool nums(int num)
        {
            //Verilmiş ədədin müsbət və cüt olub olmadığını tapan method
            if (num > 0 && num % 2 == 0) return true;
            else
                return false;

        }
        static int numcount(int[] nums)
        {
            //Verilmiş ədədlər siyahısındaki müsbət və cüt ədədlərin sayını tapan method
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0 && nums[i] % 2 == 0)
                    count++;
            }
            return count;

        }

        static string text1(string str)
        {
            //Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən method


            string newStr = "";

            int startIndex = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    startIndex = i;
                    break;
                }
            }

            for (int i = startIndex; i < str.Length; i++)
            {
                newStr += str[i];
            }
            return newStr;

        }
        static string text2(string str)
        {
            //Verilmiş yazıdan sonundaki boşluqlar silinmiş yeni string düzəldən method

            string newStr = "";
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                count++;

            }
            {
                for (int i = count - 1; i >= 0; i--)
                    if (str[i] == ' ')
                        newStr += str[i];
            }

            return str;

        }
       
        
     
    }

}

