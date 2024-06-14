Playwright Example
==================

This is a simple example of how to use Playwright to automate a browser.

See https://playwright.dev/dotnet/docs/library

## How to create a new Playwright project

먼저 Console Project를 생성한다.

```bash
dotnet new console
```

PlayWright Package를 설치한다.

```bash
dotnet add package Microsoft.Playwright
```

`build`를 통하여 `playwright.ps1`을 생성한다.

```bash
dotnet build
```

`playwright.ps1`을 실행하여 필요한 브라우저를 설치한다.

```bash
pwsh bin/Debug/net8.0/playwright.ps1 install
```

`pwsh`가 없는 경우, `brew install powershell/tap/powershell`을 통해서 설치할 수 있다.

코드를 실행하면 브라우저가 실행되고, `screenshot.png`가 생성된다.

```bash
dotnet run
```

## 설치된 Chrome 및 MS Edge를 사용하는 방법

아래와 같이 `BrowserTypeLaunchOptions`를 사용하여 브라우저를 선택할 수 있다.

```csharp
var options = new BrowserTypeLaunchOptions
{
    Channel = "chrome" // or "msedge"
};
```

`LaunchAsync`를 호출할 때, `options`를 전달한다.
```csharp
await using var browser = await playwright.Chromium.LaunchAsync(
    options
);
```
