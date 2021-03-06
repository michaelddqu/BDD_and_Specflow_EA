﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecflowIntro.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SampleFeature")]
    public partial class SampleFeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SampleFeature.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SampleFeature", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add two numbers")]
        [NUnit.Framework.CategoryAttribute("SmokeTest")]
        public virtual void AddTwoNumbers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add two numbers", new string[] {
                        "SmokeTest"});
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("I have entered 50 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.And("I have entered 70 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.When("I press add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
 testRunner.Then("the result should be 120 on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a new employee with mandatary details")]
        public virtual void CreateANewEmployeeWithMandataryDetails()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a new employee with mandatary details", ((string[])(null)));
#line 10
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Phone",
                        "Email"});
            table3.AddRow(new string[] {
                        "Karithik",
                        "28",
                        "9098023842",
                        "karthik@executeautiomation.com"});
            table3.AddRow(new string[] {
                        "John",
                        "29",
                        "9098023843",
                        "john@executeautiomation.com"});
            table3.AddRow(new string[] {
                        "Cathy",
                        "30",
                        "9098023844",
                        "cathy@executeautiomation.com"});
#line 13
 testRunner.Then("I fill all the mandatory details in form", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if I could get the details entered via Table from Extended Steps")]
        public virtual void CheckIfICouldGetTheDetailsEnteredViaTableFromExtendedSteps()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if I could get the details entered via Table from Extended Steps", ((string[])(null)));
#line 33
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Phone",
                        "Email"});
            table4.AddRow(new string[] {
                        "ShareName",
                        "30",
                        "01234567890",
                        "sharename@qq.com"});
            table4.AddRow(new string[] {
                        "AdminName",
                        "40",
                        "01234567891",
                        "adminname@qq.com"});
#line 34
 testRunner.When("I fill all th mandatory detals in form", ((string)(null)), table4, "When ");
#line 38
    testRunner.Then("I should get the same value from Extened steps", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a new employee with mandatary details for different iterations")]
        [NUnit.Framework.TestCaseAttribute("Karithik", "28", "9098023842", new string[0])]
        [NUnit.Framework.TestCaseAttribute("John", "29", "9098023843", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Cathy", "30", "9098023844", new string[0])]
        public virtual void CreateANewEmployeeWithMandataryDetailsForDifferentIterations(string name, string age, string phone, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a new employee with mandatary details for different iterations", exampleTags);
#line 21
 this.ScenarioSetup(scenarioInfo);
#line 24
 testRunner.Then(string.Format("I fill all the mandatory details in form {0}, {1}, {2}", name, age, phone), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
