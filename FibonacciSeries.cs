using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentDay6
{
    class FibonacciSeries
    {
        public void Fibonacciseries()
        {
            int FirstNum = 0, SecondNum = 1, ThirdNum;
            Console.WriteLine("enter number of elements");
            int element = Convert.ToInt32(Console.ReadLine());
            Console.Write(FirstNum + " " + SecondNum + " ");
            for (int i = 2; i <= element; i++)
            {
                ThirdNum = FirstNum + SecondNum;
                Console.Write(ThirdNum + " ");
                FirstNum = SecondNum;
                SecondNum = ThirdNum;
            }
        }
    }
}