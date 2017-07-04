using SpecflowIntro.Step_definitions;
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecFlow.Assist.Dynamic;

namespace SpecflowIntro
{
    [Binding]
    //-------------------- Lesson 11 Binding --------------------
    class SpecFlowFeatureSteps     // this test is for Fake functionality!!!
    {
        //-------------------- Caculator --------------------
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int numbers)
        {
            Console.WriteLine(numbers);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("Pressed Add button.");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            if (result == 120) //Grab the object which has the value 120 in the UI of your real applicaiton and repalce that.
                Console.WriteLine("The test PASS.");
            else
            {
                Console.WriteLine("The test FAIL.");
                throw new Exception("The test result is different.");
            }
        }


        [Then(@"I fill all the mandatory details in form")]
        public void ThenIFillAllTheMandatoryDetailsInForm(Table table)
        {
            //-------------------- Lesson 7-Static Table --------------------
            //EmployeeDetails EmpDetails = table.CreateInstance<EmployeeDetails>();
            //IEnumerable<EmployeeDetails> EmpDetailsAll = table.CreateSet<EmployeeDetails>();
            //foreach (EmployeeDetails item in EmpDetailsAll)
            //{
            //    Console.WriteLine("-----This is " + e.Name + "'s information-----");
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Age);
            //    Console.WriteLine(item.Phone);
            //    Console.WriteLine(item.Email);
            //}

            //-------------------- Lesson 10-Dynamic Table --------------------
            Console.WriteLine("Dynamic Tables:");
            IEnumerable<dynamic> dynamicEmpList = table.CreateDynamicSet();
            foreach (dynamic item in dynamicEmpList)
            {
                Console.WriteLine("-----This is " + item.Name + "'s information-----");
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Age);
                Console.WriteLine(item.Phone);
                Console.WriteLine(item.Email);
            }
            Console.WriteLine("Dynamic Tables OK.");

            //------------------- Lesson 15-Dynamic Table Conversion ----------------
            Console.WriteLine("Lesson 15");
            Console.WriteLine(dynamicEmpList.First().Name);
            Console.WriteLine(dynamicEmpList.First().Age);
            Console.WriteLine(dynamicEmpList.First().Phone);
            Console.WriteLine(dynamicEmpList.First().Email);
            Console.WriteLine(dynamicEmpList.ElementAt(0).Name);
            Console.WriteLine(dynamicEmpList.ElementAt(0).Age);
            Console.WriteLine(dynamicEmpList.ElementAt(0).Phone);
            Console.WriteLine(dynamicEmpList.ElementAt(0).Email);
        }

        //-------------------- Lesson 8-Scenario Outline --------------------
        [Then(@"I fill all the mandatory details in form (.*), (.*), (.*)")]
        public void ThenIFillAllTheMandatoryDetailsInFormKarithik(string name, int age, Int64 phone)
        {
            Console.WriteLine("Scenario Outline:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Phone: " + phone);

        //-------------------- Lesson 9-Scenario Context --------------------
            Console.WriteLine("Scenario Context:");
            //Current scenario context, will be refreshed after this current scenario execution is finished.
            ScenarioContext.Current["Test Result"] = "PASS"; //store PASS to Test Result.
            Console.WriteLine(ScenarioContext.Current["Test Result"]);

            //1.Get information from Feature/Webpage UI to save in Dictionary. Hard code for learning here.
            List<EmployeeDetails> empDetails = new List<EmployeeDetails>() {
                new EmployeeDetails() { Name = "aaa", Age = 21, Phone = 13941500001 },  //hard code
                new EmployeeDetails() { Name = "bbb", Age = 22, Phone = 13941500002 },
                new EmployeeDetails() { Name = "ccc", Age = 23, Phone = 13941500003 }
            };

            //2.Add the value in ScenarioContext with a KEY.
            ScenarioContext.Current.Add("EmpDetails", empDetails);

            //3.Call the value from ScenarioContext by its KEY. Then save it in Dictionary (Get return type)
            IEnumerable<EmployeeDetails> emp = ScenarioContext.Current.Get<IEnumerable<EmployeeDetails>>("EmpDetails");
            foreach (EmployeeDetails item in emp)
            {
                Console.WriteLine("*************************");
                Console.WriteLine("Name: " + item.Name);
                Console.WriteLine("Age: " + item.Age);
                Console.WriteLine("Phone: " + item.Phone);
            }
        }

        //-------------------------Lesson 12 Context Injection----------------------
        // Step 1: Create your POCOs (simple .NET classes) representing the SHARED DATA
        public readonly EmployeeDetails employee;

        // Step 2: Define them as constructor parameters in every binding class you need them
        public SpecFlowFeatureSteps(EmployeeDetails emp) // use it as ctor parameter
        {
            this.employee = emp;
        }

        // Step 3: Save the constructor argument to instance fields, so you can use them in the step definitions
        [When(@"I fill all th mandatory detals in form")]
        public void WhenIFillAllThMandatoryDetalsInForm(Table table)
        {
           IEnumerable<dynamic> shareEmpList = table.CreateDynamicSet();
            foreach (dynamic item in shareEmpList)
            {
              employee.Name = item.Name; // write into the shared data
              employee.Age = item.Age;
              employee.Phone = item.Phone;
              employee.Email = item.Email;
            }
        }


        //----------------- Lesson 20-Getting Feature, Step and Scenario info -----------------
        [BeforeScenario]
        public void beforeScenario()
        {
            string featureTitle = FeatureContext.Current.FeatureInfo.Title;
            string scenarioTitle = ScenarioContext.Current.ScenarioInfo.Title;

            Console.WriteLine("Feature Title is ----- " + featureTitle);
            Console.WriteLine("Scenario Title is ----- " + scenarioTitle);
        }

        [BeforeStep]
        public void beforeStep()
        {
            string stepInfo = ScenarioStepContext.Current.StepInfo.Text;
            //string stepInfo = ScenarioContext.Current.StepContext.StepInfo.Text;
            Console.WriteLine("Step Info is ----- " + stepInfo);
        }
    }
}
