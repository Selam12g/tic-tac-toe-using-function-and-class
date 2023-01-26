using System;

class TicTacToe
{
    static char[,] board = new char[3, 3];

    static void Main(string[] args)
    {
        InitializeBoard();
        PrintBoard();

        while (true)
        {
            Console.WriteLine("Player 1 turn (X): ");
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            board[row, col] = 'X';

            PrintBoard();
            if (CheckForWin('X'))
            {
                Console.WriteLine("Player 1 wins!");
                break;
            }
            if (CheckForTie())
            {
                Console.WriteLine("It's a tie!");
                break;
            }

            Console.WriteLine("Player 2 turn (O): ");
            row = int.Parse(Console.ReadLine());
            col = int.Parse(Console.ReadLine());
            board[row, col] = 'O';

            PrintBoard();
            if (CheckForWin('O'))
            {
                Console.WriteLine("Player 2 wins!");
                break;
            }
            if (CheckForTie())
            {
                Console.WriteLine("It's a tie!");
                break;
            }
        }
    }

    static void InitializeBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = '-';
            }
        }
    }

    static void PrintBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static bool CheckForWin(char player)
    {
        // Check rows
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
                return true;
        }

        // Check columns
        for (int i = 0; i < 3; i++)
        {
            if (board[0, i] == player && board[1, i] == player && board[2, i] == player)
                return true;
        }

        // Check diagonals
        if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
            return true;
        if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
            return true;

        return false;
    }
    static bool CheckForTie()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == '-')
                {
                    return false;
                }
            }
        }
        return true;
    }

}
