using FluentAssertions;
using SpecFlowCalculator.Specs.PageObject;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly CalculatorPage calculatorPage;
        public CalculatorStepDefinitions(CalculatorPage calculatorPage)
        {
            this.calculatorPage = calculatorPage;
        }

        [Given("the first number is (.*)")]
        public async Task GivenTheFirstNumberIs(string number)
        {
            await this.calculatorPage.EnterFirstNumberAsync(number);
        }

        [Given("the second number is (.*)")]
        public async Task GivenTheSecondNumberIs(string number)
        {
            await this.calculatorPage.EnterSecondNumberAsync(number);
        }

        [When("the two numbers are added")]
        public async Task WhenTheTwoNumbersAreAdded()
        {
            await this.calculatorPage.ClickAddAsync();
        }

        [Then("the result should be (.*)")]
        public async Task ThenTheResultShouldBe(string result)
        {
            var actionresult = await this.calculatorPage.WaitForNonEmptyResultAsync();

            actionresult.Should().Be(result);
        }
    }
}
