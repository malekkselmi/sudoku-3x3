using System;
using System.Collections.Generic;
using System.Text;


namespace App
{
    class Sudoku
    {
        public void newSudoku(int[,] arr)
        {
            // New sudoku
            Random rnd = new Random();
            int x = rnd.Next(0, 3);
            int y = rnd.Next(0, 3);
            int z = rnd.Next(0, 3);
            arr[x, y] = rnd.Next(1, 3);
            arr[y, z] = rnd.Next(3, 5);
            arr[z, x] = rnd.Next(5, 7);

            Console.WriteLine("NEW");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }

            // solve sudoku

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(arr[i,j] == 0)
                    {
                        int r = rnd.Next(1, 10);
                        if(Sudoku.exist(r,arr) == false)
                        {
                            arr[i, j] = r;
                        }
                        else
                        {
                            while(Sudoku.exist(r, arr) == true)
                                r = rnd.Next(1, 10);
                                 arr[i, j] = r;
                        }


                    }

                }
            }

            Console.WriteLine("SOLVE");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }


        }

        public static Boolean exist(int x , int [,]arr)
        {
            bool test = false;
            for(int i = 0; i <3; i++)
            {
                for(int j=0; j <3; j++)
                {
                    if(arr[i,j]== x)
                    {
                        test = true;
                        break;
                    }
                   
                }
            }
            return test;
        }
       


    }
}
