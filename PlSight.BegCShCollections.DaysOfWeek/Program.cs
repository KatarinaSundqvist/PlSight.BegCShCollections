﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlSight.BegCShCollections.DaysOfWeek {
    class Program {
        static void Main(string[] args) {
            
            string[] daysOfWeek = {
                "Monday",
                "Tuesday",
                "Wnesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            Console.WriteLine("Before correction:");
            foreach (string day in daysOfWeek) {
                Console.WriteLine(day);
            }

            daysOfWeek[2] = "Wednesday";

            Console.WriteLine("\r\nAfter correction:");
            foreach (string day in daysOfWeek) {
                Console.WriteLine(day);
            }

            //Console.WriteLine("Which day do you want to display?");
            //Console.Write("(Monday = 1, etc.) > ");
            //int iDay = int.Parse(Console.ReadLine());

            //string chosenDay = daysOfWeek[iDay - 1];
            //Console.WriteLine($"That day is {chosenDay}");
        }
    }
}
