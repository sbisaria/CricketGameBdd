using System;
using CricketGame;
using Xunit;


namespace CricketGame.Tests
{
   
    public class BattingScoreTests
    {
        [Fact]
        public void When_A_Batsman_Gets_Out_Score_Should_Remain_Unchanged()
        {
            var game = new Game();
            game.Score(3);
            game.Score(-1);
            Assert.True(game.TotalScore==3);
        }
    }
}
