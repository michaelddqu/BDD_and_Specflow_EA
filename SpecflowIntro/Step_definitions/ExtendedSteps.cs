using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

//-------------Lesson 12-Context Injection-----------------------

namespace SpecflowIntro.Step_definitions
{
    [Binding]
    public sealed class ExtendedSteps
    {
        // Step 1: Create your POCOs (simple .NET classes) representing the SHARED DATA
        public readonly EmployeeDetails employee;

        // Step 2: Define them as constructor parameters in every binding class you need them
        public ExtendedSteps(EmployeeDetails emp) // use it as ctor parameter
        {
            this.employee = emp;
        }

        // Step 3: you can use them in the step definitions
        [Then(@"I should get the same value from Extened steps")]
        public void ThenIShouldGetTheSameValueFromExtenedSteps()
        {
            Console.WriteLine(employee.Name); // read from shared data
            Console.WriteLine(employee.Age);
            Console.WriteLine(employee.Phone);
            Console.WriteLine(employee.Email);
        }

    }
}
