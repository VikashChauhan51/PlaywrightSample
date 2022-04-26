
using PlaywrightSample.Utils;
using System.Text.Json.Serialization;

namespace PlaywrightSample.Core;


public class BrowserOptions
{
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = BrowserType.Chromium;
    [JsonPropertyName("headed")]
    public string Headed { get; set; } = "0";
}
public class PlaywrightConfiguration
{
    public readonly BrowserOptions browserOptions;
    public readonly BrowserNewContextOptions browserNewContextOptions;

    private class Config
    {
        [JsonInclude]
        public BrowserOptions Browser { get; set; } = new BrowserOptions();
        [JsonInclude]
        public BrowserNewContextOptions BrowserContextOptions { get; set; } = new BrowserNewContextOptions();
    }
    public PlaywrightConfiguration()
    {
         var config= JsonReader.Read<Config>("configuration.json");
        browserOptions = config.Browser;
        browserNewContextOptions = config.BrowserContextOptions;

    }
}
