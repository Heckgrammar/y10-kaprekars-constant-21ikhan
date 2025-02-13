using System;
using System.Linq;

namespace Y10_Challenge_Kaprikars_Constant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kaprekar's Constant is 6174
            // 1. Take a 4 digit start number using at least two different digits...e.g. 9218
            // 2. Order the digits descending 4321, then ascending to get two 4 digit numbers (add leading zeros if needed)
            // 3. Subtract smaller number from bigger number e.g. 9821-1289=8532
            // 4. Go back to step 2 replacing start number with result of step 3, repeat until numbers converge to 6174

            // Task: Write a program to compute Kaprekar's constant using any four digit start number
            // Ext: Display the number of iterations needed until 6174 is reached

            Console.WriteLine("Hello, Type a four-digit number:");
            string x = Console.ReadLine();

            // Convert input to character array
            char[] myarr = x.ToCharArray();
            bool anysorts = true;
            char temp = ' ';

            // Bubble sort in descending order
            while (anysorts)
            {
                anysorts = false;
                for (int i = 0; i < myarr.Length - 1; i++)
                {
                    if (myarr[i] < myarr[i + 1])
                    {
                        temp = myarr[i];
                        myarr[i] = myarr[i + 1];
                        myarr[i + 1] = temp;
                        anysorts = true;
                    }
                }
            }

            // Reverse the sorted array
            char[] myarrReverse = myarr.Reverse().ToArray();
            string xReverse = new string(myarrReverse);
            string xNotAnArr = new string(myarr);
            // Print the sorted array and the reversed array
            Console.WriteLine("Sorted in descending order: " + xNotAnArr);
            Console.WriteLine("Reversed order: " + xReverse);
            x = Convert.ToString(Convert.ToInt32(xReverse) - Convert.ToInt32(xNotAnArr));
        }
    }
}
