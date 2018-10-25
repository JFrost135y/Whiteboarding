using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Whiteboarding
{
    class Program
    {
        static void Main(string[] args)
        {

            

            
        }


        //this takes numbers from an array and calculates the average.
        //infinite number of parameters because of the "params" keyword
        static void Average(params double[] nums)
        {
            double sum = 0;

            foreach (double item in nums)
            {
                sum += item;
            }

            double average = sum / nums.Length;
            Console.WriteLine("Your average is:" + average);
        }

        //Copies an array using -
        static T[] CopyArray<T>(T[] inputArray)
        {
            T[] copiedArray = inputArray;
            copiedArray = inputArray;
            return copiedArray;
        }

        //this copies first two letters of a string four times
        static void Stringlength()
        {
            Console.WriteLine("Enter a word: ");
            string input = Console.ReadLine();
            if (input.Length <= 2)
            {
                Console.WriteLine(input);
            }

            else
            {
                string change = input.Substring(0, 2);

                for (int i = 0; i < 3; i++)
                {
                    change += change;
                }
                Console.WriteLine(change);
                Console.ReadLine();
            }
        }

        //checks 2 integers True if one is negative and one is positive
        //returns false if the above condition is not met
        static void Positivetest()
        {
            Console.WriteLine("Enter first number: ");
            int int1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int int2 = Convert.ToInt32(Console.ReadLine());

            if ((int1 > 0 && int2 < 0) || (int2 > 0 && int1 < 0))
            {
                Console.WriteLine("True");
            }

            else
            {
                Console.WriteLine("False");
            }

            Console.ReadLine();
        }

        //n # of values in array, reverse array without using array.reverse
        //then display the reverse
        static void ReverseNarray()
        {
            Console.WriteLine("Input size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter number: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int j = 0; j < array.Length / 2; j++)
            {
                int tmp = array[j];
                array[j] = array[array.Length - j - 1];
                array[array.Length - j - 1] = tmp;

            }
            Console.WriteLine();

            for (int k = 0; k < array.Length; k++)
            {
                Console.WriteLine(array[k]);
            }

            Console.ReadLine();
        }

        //adding numbers in jagged array where position i and j is greater than 0
        //if number is under the 0 it will not add
        //i = which array in matrix
        //j = index of that array
        static void matrix()
        {
            Console.WriteLine("The sum of the Matrix is: ");
            int[][] matrix = new int[][]
            {
                new int[]{0,2,3,2},
                new int[]{0,6,0,1},
                new int[]{4,0,3,0}
            };

            int x = 0;
            for (int i = 0; i < matrix[0].Length; i++)
            {
                for (int j = 0; j < matrix.Length && matrix[j][i] > 0; j++)
                {
                    x += matrix[j][i];
                }
            }

            Console.WriteLine(x);
            Console.ReadLine();
        }




    }
}
