using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConnectFour
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckForWin_NoWinner_EmptyBoard()
        {
            // Arrange
            GameState state = new GameState();

            // Act
            GameState.WinState result = state.CheckForWin();

            // Assert
            Assert.Equals(GameState.WinState.No_Winner, result);
        }

        [TestMethod]
        public void CheckForWin_TieGame()
        {
            // Arrange
            var gameState = new GameState();
            for (int i = 0; i < 42; i++)
            {
                gameState.TheBoard.Add(i % 2 + 1);
            }

            // Act
            var result = gameState.CheckForWin();

            // Assert
            Assert.Equals(GameState.WinState.Tie, result);
        }
    }
}