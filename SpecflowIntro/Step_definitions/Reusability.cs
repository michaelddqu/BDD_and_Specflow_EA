using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowIntro.Step_definitions
{
    //------------------- Lesson 19-Calling steps from step definitions -------------
    [Binding]
    public sealed class Reusability : Steps
    {
        [Given(@"I login to application")]
        public void GivenILoginToApplication(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            Console.WriteLine(data.UserName);
            Console.WriteLine(data.Password);
        }

        [Given(@"I enter following details")]
        public void GivenIEnterFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            Console.WriteLine(data.Title);
            Console.WriteLine(data.Initial);
            Console.WriteLine(data.FirstName);
        }

        [Given(@"I login and enter user details")]
        public void GivenILoginAndEnterUserDetails()
        {
            //Table table = new Table();
            string[] header = { "UserName", "Password" };
            string[] row = { "admin", "admin" };

            Table table = new Table(header);
            table.AddRow(row);
            Given("I login to application", table);
            //Console.WriteLine(table.UserName);
        }

        [Then(@"I click save button")]
        public void ThenIClickSaveButton()
        {
            //Console.WriteLine(data.UserName);
        }

    }
}
