using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowIntro.Step_definitions
{
    [Binding]
    //-------------------------Lesson 16 - SpecFlow + Excel -------------------------
    public sealed class SpecFlowExcel
    {
        [Given(@"I have input (.*) into the calculator")]
        public void GivenIHaveInputIntoTheCalculator(string p0)
        {
            Console.WriteLine("Number is: " + p0);
        }

        [When(@"I press add button")]
        public void WhenIPressAddButton()
        {
            Console.WriteLine("Press Add button.");
        }

        [Then(@"I will get (.*)")]
        public void ThenIWillGet(string p0)
        {
            Console.WriteLine("The result is: " + p0);
        }

    }
}
