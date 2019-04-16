//--------------------------------------------------------------------------------------------------------------------
// <copyright file="TicTacToeTest.cs" company="BridgeLabz">
// copyright @2019 
// </copyright>
// <creater name="Kaveri Tekawade"/>
//------------------------------------------------------------------------------------------------------------------
namespace Functional_Programs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Tic-Tac-Toe Game of two players
    /// </summary>
    public class TicTacToeTest
    {
        /// <summary>
        /// The x and o are the sign for two player
        /// </summary>
        private const int X = 1, O = -1;

        /// <summary>
        /// The empty is set to 0
        /// </summary>
        private const int EMPTY = 0;

        /// <summary>
        /// The player is set to X
        /// </summary>
        private static int player = X;

        /// <summary>
        /// The board is the 3*3 matrix
        /// </summary>
        private int[,] board = new int[3, 3];

        /// <summary>
        /// The is empty
        /// </summary>
        private bool isEmpty = false;

        /// <summary>
        /// Plays the game
        /// </summary>
        public void PlayTicTacToeTest()
        {
            int x = 0, y = 0;
            do
            {
                try
                {
                    Console.WriteLine(player == X ? "Player X turn" : "Player O turn");
                    Console.WriteLine("Enter x coordinate");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter y coordinate");
                    y = Convert.ToInt32(Console.ReadLine());
                    this.PutSign(x, y);
                    Console.WriteLine(this.AppendString());
                    Console.WriteLine("_____________________________");
                    this.DisplayWinner();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (this.isEmpty);
        }

        /// <summary>
        /// Puts the sign on the Board.
        /// </summary>
        /// <param name="x">The x is the row index.</param>
        /// <param name="y">The y is the column index.</param>
        public void PutSign(int x, int y)
        {
            ////Checks for valid board position
            if (x < 0 || x > 2 || y < 0 || y > 2)
            {
                Console.WriteLine("Invalid board position");
                return;
            }

            ////Check for the empty cell
            if (this.board[x, y] != EMPTY)
            {
                Console.WriteLine("Board position occupied");
                return;
            }

            this.board[x, y] = player;
            player = -player;
        }

        /// <summary>
        /// Determines whether the specified player is win.
        /// </summary>
        /// <param name="player">The player.</param>
        /// <returns>
        ///   <c>true</c> if the specified player is win; otherwise, <c>false</c>.
        /// </returns>
        public bool IsWin(int player)
        {
             return this.board[0, 0] + this.board[0, 1] + this.board[0, 2] == player * 3 ||
                    this.board[1, 0] + this.board[1, 1] + this.board[1, 2] == player * 3 ||
                    this.board[2, 0] + this.board[2, 1] + this.board[2, 2] == player * 3 ||
                    this.board[0, 0] + this.board[1, 0] + this.board[2, 0] == player * 3 ||
                    this.board[0, 1] + this.board[1, 1] + this.board[2, 1] == player * 3 ||
                    this.board[0, 2] + this.board[1, 2] + this.board[2, 2] == player * 3 ||
                    this.board[0, 0] + this.board[1, 1] + this.board[2, 2] == player * 3 ||
                    this.board[2, 0] + this.board[1, 1] + this.board[0, 2] == player * 3;
        }

        /// <summary>
        /// Displays the winner.
        /// </summary>
        public void DisplayWinner()
        {
            if (this.IsWin(X))
            {
                Console.WriteLine("\n X wins...!!");
                this.isEmpty = false;
            }
            else if (this.IsWin(O))
            {
                Console.WriteLine("\n O wins...!!");
                this.isEmpty = false;
            }
            else
            {
                if (!this.isEmpty)
                {
                    Console.WriteLine("its a tie");
                }
            }
        }

        /// <summary>
        /// To the string.
        /// </summary>
        /// <returns>returns the signed board</returns>
        public string AppendString()
        {
            StringBuilder s = new StringBuilder();
            this.isEmpty = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    switch (this.board[i, j])
                    {
                        case X:
                            s.Append(" X ");
                            break;
                        case O:
                            s.Append(" O ");
                            break;
                        case EMPTY:
                            s.Append("   ");
                            this.isEmpty = true;
                            break;
                    }

                    if (j < 2)
                    {
                        s.Append("|");
                    }
                }

                if (i < 2)
                {
                    s.Append("\n-----------\n");
                }
            }

            return s.ToString();
        }
    }
}