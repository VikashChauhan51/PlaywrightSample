

namespace PlaywrightSample.Pages;

public class SearchPage: PageBase
{
    private readonly ILocator _searchTermInput;

    public SearchPage(IPage page) : base(page)
    {
        _searchTermInput = page.Locator("[aria-label='Enter your search term']");
    }

    public async Task Goto()
    {
        await page.GotoAsync("/");
    }

    public async Task Search(string text)
    {
        await _searchTermInput.FillAsync(text);
        await _searchTermInput.PressAsync("Enter");
    }
}
