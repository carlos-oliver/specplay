using Microsoft.Playwright;
using SpecFlow.Actions.Playwright;
using System.Threading.Tasks;

namespace SpecFlowCalculator.Specs.PageObject
{
    public class BasePage
    {
        public readonly Task<IPage> _page;
        public BasePage(BrowserDriver browserDriver)
        {
            _page = CreatePageAsync(browserDriver.Current);
        }

        private async Task<IPage> CreatePageAsync(Task<IBrowser> browser)
        {
            return await (await browser).NewPageAsync();
        }
    }
}
