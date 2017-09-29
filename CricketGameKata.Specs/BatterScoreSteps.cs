using System;
using TechTalk.SpecFlow;
using CricketGame;
using Xunit;

namespace CricketGameKata.Specs
{
    [Binding]
    public class BatterScoreSteps
    {
        Game game;

        [Given(@"I have started a new game")]
        public void GivenIHaveStartedANewGame()
        {
            game = new Game();
        }
        
        [When(@"Batsman gets out")]
        public void WhenBatsmanGetsOut()
        {
            game.Score(-1);
        }
        
        [Then(@"Batsman score should be (.*)")]
        public void ThenBatsmanScoreShouldBe(int p0)
        {
            Assert.True(game.TotalScore==0);
        }
    }
}
