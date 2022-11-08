﻿using System;
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

            DisplayMap(10);

            Console.ReadKey(true);
        }
        
        static void DisplayMap(int scale)
        {
            //loop
            int y;
            int x;

            Console.Write("+");
            for (x = 0; x <= scale; x = x + 1)
            {
                Console.Write("-");
                

            }
            Console.Write("+");
            Console.WriteLine("");
            /////////////////////////////////////map
            for (y = 0; y <= scale; y = y + 1)
            {

                Console.Write("|");
                for (x = 0; x <= scale; x = x + 1)
                {
                   
                    Console.Write(map[y, x]);

                }
                Console.WriteLine("|");
            }
            ///////////////////////////////////map

            
            Console.Write("+");
            for (x = 0; x <= scale; x = x + 1)
            {
                Console.Write("-");


            }
            Console.Write("+");



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
