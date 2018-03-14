using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {//page62
        static void Main(string[] args)
        {
            //arrays

            //create const to store length of array so it
            //doesnt change. use all caps for naming consts.
            const int SCORE_SIZE = 1000;

            //create array
            int[] scores = new int[SCORE_SIZE];
            for (int i = 0; i < SCORE_SIZE; i++)
            {
                //**scores[i] = readInt("score : ", 0, 1000);
            }

            //two dimentional array
            int[,] board = new int[3, 3];
            board[1, 1] = 1;

        }
        //helper methods below.
        static string readString(string prompt)
        {
            string result;
            do
            {
                Console.Write(prompt);
                result = Console.ReadLine();
            } while (result == "");
            return result;
        }

        static int readInt(string prompt, int low, int high)
        {
            int result;
            do
            {
                string intString = readString(prompt);
                result = int.Parse(intString);
            } while ((result < low) || (result > high));
            return result;
        }


    }
}
