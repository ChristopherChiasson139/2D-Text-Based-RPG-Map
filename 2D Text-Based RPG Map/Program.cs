using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Text_Based_RPG_Map
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            DisplayMap(2);
            Console.ReadKey(true);
            Console.Clear();
            DisplayMap(3);
            Console.ReadKey(true);
            Console.Clear();
            DisplayMap(10);
            Console.ReadKey(true);
            Console.Clear();
            DisplayMap(10000000);
            Console.ReadKey(true);
        }
        
        static void DisplayMap(int scale)
        {
            //DEBUG
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("map scale = " + scale);
            if (scale > 11)
            {
                scale = 11;
            }
            //loop
            int y;
            int x;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Console.Write("+");
            for (x = 0; x <= scale; x = x + 1)
            {

                Console.Write("-");

            }
            Console.Write("+");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            /////////////////////////////////////map
            for (y = 0; y <= scale; y = y + 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("|");
                for (x = 0; x <= scale; x = x + 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(map[y, x]);

                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("|");
            }
            ///////////////////////////////////map

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("+");
            for (x = 0; x <= scale; x = x + 1)
            {

                Console.Write("-");

            }
            Console.Write("+");
            Console.ForegroundColor = ConsoleColor.White;


        }
        static char[,] map = new char[,] // dimensions defined by following data:
    {
        {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
        {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
        {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
        {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
    };
        // map legend:
        // ^ = mountain
        // ` = grass
        // ~ = water
        // * = trees

    }
}
