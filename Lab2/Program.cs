using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {   
            //problem 1: store your age in age variable and print the value to the user.
            int age = 24;

            Console.WriteLine("I am " + age + " years old!\n");

            //problem 2:
            //declare and initialize variables
            const int MaxScore = 100;
            int score = 72;

            float percent = (float)score / MaxScore;

            //print the percent value to the user.
            Console.WriteLine("Percentage: " + percent + "\n");
        }
    }
}
