using Microsoft.Playwright;

using var playwright = await Playwright.CreateAsync();

var options = new BrowserTypeLaunchOptions
{
    Channel = "chrome"
};

await using var browser = await playwright.Chromium.LaunchAsync(
    options
);
var page = await browser.NewPageAsync();
await page.GotoAsync("https://playwright.dev/dotnet");
await page.ScreenshotAsync(new()
{
    Path = "screenshot.png"
});
