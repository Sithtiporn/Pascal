using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the Pascal's triangle row number: ");
        int rowNumber;

        while (!int.TryParse(Console.ReadLine(), out rowNumber) || rowNumber < 0)
        {
            Console.WriteLine("Invalid Pascal's triangle row number.");
            Console.Write("Enter a valid row number: ");
        }

        for (int row = 0; row <= rowNumber; row++)
        {
            for (int space = 0; space <= rowNumber - row; space++)
            {
                Console.Write("  ");
            }

            for (int col = 0; col <= row; col++)
            {
                Console.Write("{0,4} ", GetPascalNumber(row, col));
            }

            Console.WriteLine();
        }
    }

    static int GetPascalNumber(int row, int col)
    {
        if (col == 0 || col == row)
        {
            return 1;
        }
        else
        {
            return GetPascalNumber(row - 1, col - 1) + GetPascalNumber(row - 1, col);
        }
    }
}
