﻿using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            // int, decimal, float, double, bool = Value Types  --> only Stack

            int number1 = 10;
            int number2 = 30;

            number1 = number2;
            number2 = 65;

            // sayi1 ?



            // Arrays, Class, Interface = Reference Types  --> Stack & Heap

            int[] numbers1 = new int[] { 10, 20, 30};
            int[] numbers2 = new int[] { 100, 200, 300};

            numbers1 = numbers2;
            numbers2[0] = 999;

            // numbers1[0] ?


            Console.ReadLine();

        }
    }
}
