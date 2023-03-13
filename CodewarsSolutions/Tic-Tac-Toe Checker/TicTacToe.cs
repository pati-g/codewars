namespace CodeWars
{
    internal class TicTacToe
    {
        public static int IsSolved(int[,] board)
        {
            int winner = 0;
            if (board[1, 1] != 0 && (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) || (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]))
            {
                return board[1, 1];
            }
            else
            {
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    if (board[i, 0] != 0 && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    {
                        return board[i, 0];
                    }
                    else if (board[0, i] != 0 && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    {
                        return board[0, i];
                    }
                    else if (board[i, 0] == 0 || board[i, 1] == 0 || board[i, 2] == 0)
                    {
                        winner = -1;
                    }
                }
            }
            return winner;
        }
    }
}
