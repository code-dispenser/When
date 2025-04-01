namespace When.Core.Extensions;

/// <summary>
/// Provides extension methods for executing actions based on boolean values.
/// </summary>
public static class BooleanExtensions
{
    /// <summary>
    /// Executes the specified action if the boolean value is <c>true</c>.
    /// </summary>
    /// <param name="boolValue">The boolean value to evaluate.</param>
    /// <param name="act_whenTrue">The action to execute when the value is <c>true</c>.</param>
    public static void WhenTrue(this bool boolValue, Action act_whenTrue)
    {
        if (true == boolValue) act_whenTrue();
    }

    /// <summary>
    /// Executes the specified action if the boolean value is <c>false</c>.
    /// </summary>
    /// <param name="boolValue">The boolean value to evaluate.</param>
    /// <param name="act_whenFalse">The action to execute when the value is <c>false</c>.</param>
    public static void WhenFalse(this bool boolValue, Action act_whenFalse)
    {
        if (false == boolValue) act_whenFalse();
    }

    /// <summary>
    /// Executes one of the specified actions based on the boolean value.
    /// </summary>
    /// <param name="boolValue">The boolean value to evaluate.</param>
    /// <param name="act_whenTrue">The action to execute when the value is <c>true</c>.</param>
    /// <param name="act_whenFalse">The action to execute when the value is <c>false</c>.</param>
    public static void WhenTrueElse(this bool boolValue, Action act_whenTrue, Action act_whenFalse)
    {
        if (true == boolValue) act_whenTrue(); else act_whenFalse();
    }
}

