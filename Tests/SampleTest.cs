

namespace PlaywrightSample.Tests;

[Parallelizable(ParallelScope.Self)]
public class SampleTest : TestBase
{
    [Test]
    public async Task SampleBingSearch()
    {
        using (var searchPage = new SearchPage(Page))
        {
            await searchPage.Goto();
            await searchPage.Search("Vikash Chauhan onn github");
        }
    }
}
