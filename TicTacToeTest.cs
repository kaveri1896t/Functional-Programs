using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programs
{

    public class TicTacToeTest 
    {
        public const int X = 1, O = -1;
        public const int EMPTY = 0;

        public static int player = X;
        public int[,] board = new int[3, 3];
        public Boolean isEmpty = false;

        public void PlayTicTacToeTest()
        {
            int x=0,y=0;
			do
			{
				Console.WriteLine(player==X?"Player X turn":"Player O turn");
				Console.WriteLine("Enter x coordinate");
				x=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter y coordinate");
				y=Convert.ToInt32(Console.ReadLine());
				
				putSign(x, y);
				Console.WriteLine(toString());
				Console.WriteLine("_____________________________");
				displayWinner();
				
			}while(isEmpty);
        }

        public void putSign(int x, int y)      // put x & y on board
        {
            if (x < 0 || x > 2 || y < 0 || y > 2)
            {
                Console.WriteLine("Invalid board position");
                return;
            }
            if (board[x, y] != EMPTY)
            {
                Console.WriteLine("Board position occupied");
                return;
            }
            board[x, y] = player;
            player = -player;
        }

        public Boolean isWin(int player)           //check win condition
        {
            return ((board[0, 0] + board[0, 1] + board[0, 2] == player * 3) ||
                    (board[1, 0] + board[1, 1] + board[1, 2] == player * 3) ||
                    (board[2, 0] + board[2, 1] + board[2, 2] == player * 3) ||
                    (board[0, 0] + board[1, 0] + board[2, 0] == player * 3) ||
                    (board[0, 1] + board[1, 1] + board[2, 1] == player * 3) ||
                    (board[0, 2] + board[1, 2] + board[2, 2] == player * 3) ||
                    (board[0, 0] + board[1, 1] + board[2, 2] == player * 3) ||
                    (board[2, 0] + board[1, 1] + board[0, 2] == player * 3));
        }

        public void displayWinner()            // display board
        {
            if (isWin(X))
            {
                Console.WriteLine("\n X wins...!!");
                isEmpty = false;
            }
            else if (isWin(O))
            {
                Console.WriteLine("\n O wins...!!");
                isEmpty = false;
            }
            else
            {
                if (!isEmpty)
                {
                    Console.WriteLine("its a tie");
                }

            }
        }

        public String toString()               //Append sign on board
		{
			StringBuilder s = new StringBuilder();
			isEmpty = false;
			for(int i=0;i<3;i++)
			{
				for(int j=0;j<3;j++)
				{
					switch(board[i,j])
					{
					case X: 
						s.Append(" X ");
						break;
					case O: 
						s.Append(" O ");
						break;
					case EMPTY: 
						s.Append("   ");
						isEmpty=true;
						break;
					}
					if(j<2)
					{
						s.Append("|");
					}
					
				}
				if(i<2)
				{
					s.Append("\n-----------\n");
				}
			}
			return s.ToString();
		}
			
			
			
		}
}
 
	

