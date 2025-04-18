﻿namespace When.Core.Extensions;

/// <summary>
/// Provides extension methods for executing asynchronous actions that return <see cref="ValueTask"/> based on boolean values.
/// </summary>
public static class BooleanValueTaskExtensions
{
    /// <summary>
    /// Asynchronously executes the specified action if the boolean value is <c>true</c>.
    /// </summary>
    /// <param name="boolValue">The boolean value to evaluate.</param>
    /// <param name="do_whenTrue">The asynchronous action returning <see cref="ValueTask"/> to execute when the value is <c>true</c>.</param>
    /// <returns>A <see cref="ValueTask"/> representing the asynchronous operation.</returns>
    public static async ValueTask WhenTrue(this bool boolValue, Func<ValueTask> do_whenTrue)
    {
        if (boolValue == true) await do_whenTrue();
    }

    /// <summary>
    /// Asynchronously executes the specified action if the boolean value is <c>false</c>.
    /// </summary>
    /// <param name="boolValue">The boolean value to evaluate.</param>
    /// <param name="do_whenFalse">The asynchronous action returning <see cref="ValueTask"/> to execute when the value is <c>false</c>.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    public static async Task WhenFalse(this bool boolValue, Func<ValueTask> do_whenFalse)
    {
        if (false == boolValue) await do_whenFalse();
    }

    /// <summary>
    /// Asynchronously executes one of the specified actions based on the boolean value.
    /// </summary>
    /// <param name="boolValue">The boolean value to evaluate.</param>
    /// <param name="do_whenTrue">The asynchronous action returning <see cref="ValueTask"/> to execute when the value is <c>true</c>.</param>
    /// <param name="do_whenFalse">The asynchronous action returning <see cref="ValueTask"/> to execute when the value is <c>false</c>.</param>
    /// <returns>A <see cref="ValueTask"/> representing the asynchronous operation.</returns>
    public static async ValueTask WhenTrueElse(this bool boolValue, Func<ValueTask> do_whenTrue, Func<ValueTask> do_whenFalse)
    {
        if (boolValue == true) await do_whenTrue(); else await do_whenFalse();
    }
}

