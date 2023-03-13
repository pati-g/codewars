using CodeWars;

namespace CodeWarsTests
{
    public class TicTacToeTest
    {
        [Fact]
        public void ReturnsMinusOneWhenBoardHasZeroes()
        {
            var board = new int[,] { { 0, 0, 2 }, { 0, 0, 0 }, { 1, 0, 1 } };
            Assert.Equal(-1, TicTacToe.IsSolved(board));
        }
    }
}
