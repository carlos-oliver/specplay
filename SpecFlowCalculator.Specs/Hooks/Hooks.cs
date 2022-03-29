using SpecFlowCalculator.Specs.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeScenario("Calculator")]
        public async Task BeforeScenarioAsync(CalculatorPage calculatorPage)
        {
            await calculatorPage.EnsureCalculatorIsOpenAndResetAsync();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
