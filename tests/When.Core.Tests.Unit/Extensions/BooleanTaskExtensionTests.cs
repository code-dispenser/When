﻿using FluentAssertions;
using When.Core.Extensions;

namespace When.Core.Tests.Unit.Extensions;

public class BooleanTaskExtensionTests
{
    [Fact]
    public async Task When_the_value_is_true_and_when_true_is_called_the_async_func_should_be_executed()
    {
        var funcExecuted = false;

        await BooleanTaskExtensions.WhenTrue(true, async () => { funcExecuted = true; await Task.CompletedTask;});

        funcExecuted.Should().BeTrue();
    }
    [Fact]
    public async Task When_the_value_is_false_and_when_true_is_called_the_async_func_should_not_be_executed()
    {
        var funcExecuted = false;

        await BooleanTaskExtensions.WhenTrue(false, async () => { funcExecuted = true; await Task.CompletedTask;});

        funcExecuted.Should().BeFalse();

    }
    [Fact]
    public async Task When_the_value_is_false_and_when_false_is_called_the_async_func_should_be_executed()
    {
        var funcExecuted = true;

        await BooleanTaskExtensions.WhenFalse(false, async () => { funcExecuted = false; await Task.CompletedTask;});

        funcExecuted.Should().BeFalse();
    }
    [Fact]
    public async Task When_the_value_is_true_and_when_false_is_called_the_async_func_should_not_be_executed()
    {
        var funcExecuted = false;

        await BooleanTaskExtensions.WhenFalse(true, async () => { funcExecuted = true; await Task.CompletedTask;});

        funcExecuted.Should().BeFalse();

    }
    [Fact]
    public async Task When_the_value_is_true_and_when_true_else_is_called_the_true_async_func_should_be_executed()
    {
        var funcExecuted = false;

        await BooleanTaskExtensions.WhenTrueElse(true, async () => { funcExecuted = true; await Task.CompletedTask; }, async () => { funcExecuted = false; await Task.CompletedTask; });

        funcExecuted.Should().BeTrue();
    }
    [Fact]
    public async Task When_the_value_is_false_and_when_true_else_is_called_the_else_async_func_should_be_executed()
    {
        var funcExecuted = true;

        await BooleanTaskExtensions.WhenTrueElse(false, async () => { funcExecuted = true; await Task.CompletedTask; }, async () => { funcExecuted = false; await Task.CompletedTask; });

        funcExecuted.Should().BeFalse();
    }
}
