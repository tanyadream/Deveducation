using System;
using TechTalk.SpecFlow;

namespace Calculate
{
    [Binding]
    public class UnknownSteps
    {
        [Given(@"Vasya have (.*) liters of water")]
        public void GivenVasyaHaveLitersOfWater(int p0)
        {
            Vasya vasyok = new Vasya();
            vasyok.water = 100;
        }
        
        [Given(@"Vasya have (.*) friends")]
        public void GivenVasyaHaveFriends(int p0)
        {
            Friend fr1 = new Friend();
            Friend fr2 = new Friend();
            Friend fr3 = new Friend();
            Friend fr4 = new Friend();
        }
        
        [Given(@"Vasya have (.*) apples")]
        public void GivenVasyaHaveApples(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Vasya drinking (.*) liters water in day and his friends drinking (.*) liters water in day for week")]
        public void WhenVasyaDrinkingLitersWaterInDayAndHisFriendsDrinkingLitersWaterInDayForWeek(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Vasya drinking (.*) liters water in day for week")]
        public void WhenVasyaDrinkingLitersWaterInDayForWeek(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Vasya eating (.*) apples in day for week")]
        public void WhenVasyaEatingApplesInDayForWeek(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Vasya drinking (.*) liters water in day and eating (.*) apples in day for week")]
        public void WhenVasyaDrinkingLitersWaterInDayAndEatingApplesInDayForWeek(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Vasya's friends drinking (.*) liters water in day and eating (.*) apples in day for week")]
        public void WhenVasyaSFriendsDrinkingLitersWaterInDayAndEatingApplesInDayForWeek(int p0, Decimal p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Vasya left (.*) liters of water")]
        public void ThenVasyaLeftLitersOfWater(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Vasya left (.*) liters of water and (.*) apples")]
        public void ThenVasyaLeftLitersOfWaterAndApples(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
