[![.NET](https://github.com/code-dispenser/When/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/code-dispenser/When/actions/workflows/dotnet.yml) [![Coverage Status](https://coveralls.io/repos/github/code-dispenser/When/badge.svg?branch=main)](https://coveralls.io/github/code-dispenser/When?branch=main) [![Nuget download][download-image]][download-url]

[download-image]: https://img.shields.io/nuget/dt/When.Core
[download-url]: https://www.nuget.org/packages/When.Core

<h1>
<img src="https://raw.githubusercontent.com/code-dispenser/When/main/assets/icon-64.png" align="center" alt="When icon" /> When
</h1>
<!--
# ![icon](https://raw.githubusercontent.com/code-dispenser/When/main/assets/icon-64.png) When
-->
<!-- H1 for git hub, but for nuget the markdown is fine as it centers the image, uncomment as appropriate and do the same at the bottom of this file for the icon author -->

## Overview
**When** is a minimalist C# library designed for developers who prefer to avoid the verbosity of traditional `if` statements, especially when dealing with single-line conditions. By offering extension methods for the `bool` type, **When** enables the execution of synchronous and asynchronous actions based on boolean evaluations, resulting in cleaner and more readable code.

## Features

- **Synchronous Execution:** Execute actions when a boolean value is `true`, `false`, or based on either condition.

- **Asynchronous Support:** Handle asynchronous tasks with `Task` and `ValueTask` return types, facilitating seamless integration with modern async programming patterns.


## Example Usage
 
If you hate how this codes looks

```csharp
public async Task DoSomething(bool condition)
{
    if (condition)
    {
        await Console.Out.WriteLineAsync("Condition is true.");
    }
    else
    {
        await Console.Out.WriteLineAsync("Condition is false.");
    }
}

// Or even simpler synchronous code like

public void DoSomething(bool condition)
{
    if (condition) Console.WriteLine("Condition is true.");
}

```

because you really want to write code like
```csharp
using When.Core.Extensions;

public async Task DoSomething(bool condition)

    => await condition.WhenTrueElse(() => Console.Out.WriteLineAsync("Condition is true."), () =>  Console.Out.WriteLineAsync("Condition is false."))

public void DoSomething(bool condition)

    => condition.WhenTrue(() => Console.WriteLine("Condition is true."));   
```

Then you might like **When**.

Its probably one of the most trivial nuget packages that you will ever stumble across, but it keeps me happy so I thought I would share it. 