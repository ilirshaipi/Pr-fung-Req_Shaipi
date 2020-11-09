using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Prüfung_Req_Shaipi
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        double number, number2;
        [Given(@"the first number is PI")]
        public void GivenTheFirstNumberIsPI()
        {
            number = Math.PI;
        }

        [When(@"sinus is taken")]
        public void WhenSinusIsTaken()
        {
            number2 = Math.Sin(number);
        }

        [When(@"cosinus is taken")]
        public void WhenCosinusIsTaken()
        {
            number2 = Math.Cos(number);
        }

        [When(@"tangens is taken")]
        public void WhenTangensIsTaken()
        {
            number2 = Math.Tan(number);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.Equal(p0, number2, 5);
        }
    }
}
