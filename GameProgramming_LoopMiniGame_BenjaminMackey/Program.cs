using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgramming_LoopMiniGame_BenjaminMackey
{
    internal class Program
    {
        static int ten = 10;

        static int Clamp(int num, int minVal, int maxVal)
        {
            int clamped = num;
            if (num > maxVal) clamped = maxVal;
            else if (num < minVal) clamped = minVal;
            return clamped;
        }

        static bool[,] bools =
        {
            {false, false, false, false, false, false, false, false, false, false},
            {false, false, false, false, false, false, false, false, false, false},
            {false, false, false, false, false, false, false, false, false, false},
            {false, false, false, false, false, false, false, false, false, false},
            {false, false, false, false, false, false, false, false, false, false},
            {false, false, false, false, false, false, false, false, false, false},
            {false, false, false, false, false, false, false, false, false, false},
            {false, false, false, false, false, false, false, false, false, false},
            {false, false, false, false, false, false, false, false, false, false},
            {false, false, false, false, false, false, false, false, false, false},
     
           
         // max value is 15,15
        };

        static void setAllToFalse()
        {
            
            for (int i = 0; i < ten ; i++)
            {
                for (int j = 0; j < ten; j++)
                {
                    bools[i, j] = false;
                    Console.SetCursorPosition(i +1, j + 1);
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.Write(" ");
                }

            }

        }

        static bool updateScreen(ConsoleColor color)
        {

            for (int i = 0; i < ten; i++)
            {
                for (int j = 0; j < ten; j++)
                {
                    if (bools[i, j] == true)
                    {
                        Debug.Write("h");
                        Console.SetCursorPosition(i, j);
                        Console.BackgroundColor = color;
                        Console.Write(" ");
                    }
                }

            }

       
            Console.SetCursorPosition(redicalPos[0], redicalPos[1]);
            if (bools[redicalPos[0], redicalPos[1]] == true) return true;
            bools[redicalPos[0], redicalPos[1]] = true;
            Console.WriteLine(0);
            return false;
            

        }

        static int[] redicalPos = {7, 7}; //diy vector 2

        static void moveRedical(ConsoleKey givenDirection)
        {
            switch (givenDirection)
            {
                case ConsoleKey.DownArrow:
                    redicalPos[1] = Clamp(redicalPos[1] + 1, 0, 9);
                    Debug.Write("down");
                    break;
                case ConsoleKey.UpArrow:
                    redicalPos[1] = Clamp(redicalPos[1] - 1, 0, 9);
                    Debug.Write("up");
                    break;
                case ConsoleKey.LeftArrow:
                    redicalPos[0] = Clamp(redicalPos[0] - 1, 0, 9);
                    break;
                case ConsoleKey.RightArrow:
                    redicalPos[0] = Clamp(redicalPos[0] + 1, 0, 9);
                    break;
            
            }

        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(50, 50);
            setAllToFalse();
            Console.SetCursorPosition(7, 7);
            while (true)
            { 
                ConsoleKeyInfo key = Console.ReadKey();
                moveRedical(key.Key);
                bool carCrash = updateScreen(ConsoleColor.Magenta);
                if (key.Key <= ConsoleKey.Escape | carCrash == true)
                {
                    break;
                }
            }


        }
    }
}
