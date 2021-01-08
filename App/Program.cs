using System;

namespace App
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int [,] arr = new int[3, 3];
            Sudoku s = new Sudoku();
            s.newSudoku(arr);

           
        }
    }
}
