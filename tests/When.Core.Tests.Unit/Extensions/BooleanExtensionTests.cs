using FluentAssertions;
using When.Core.Extensions;

namespace When.Core.Tests.Unit.Extensions;

public class BooleanExtensionTests
{
    [Fact]
    public void When_the_value_is_true_and_when_true_is_called_the_action_should_be_executed()
    {
        var actionExecuted = false; 

        true.WhenTrue(() => actionExecuted = true);

        actionExecuted.Should().BeTrue();
    }
    [Fact]
    public void When_the_value_is_false_and_when_true_is_called_the_action_should_not_be_executed()
    {
        var actionExecuted = false;

        false.WhenTrue(() => actionExecuted = true);

        actionExecuted.Should().BeFalse();

    }
    [Fact]
    public void When_the_value_is_false_and_when_false_is_called_the_action_should_be_executed()
    {
        var actionExecuted = true;

        false.WhenFalse(() => actionExecuted = false);

        actionExecuted.Should().BeFalse();
    }
    [Fact]
    public void When_the_value_is_true_and_when_false_is_called_the_action_should_not_be_executed()
    {
        var actionExecuted = false;

        true.WhenFalse(() => actionExecuted = true);

        actionExecuted.Should().BeFalse();

    }
    [Fact]
    public void When_the_value_is_true_and_when_true_else_is_called_the_true_action_should_be_executed()
    {
        var actionExecuted = false;

        true.WhenTrueElse(() => actionExecuted = true, () => actionExecuted = false);

        actionExecuted.Should().BeTrue();
    }
    [Fact]
    public void When_the_value_is_false_and_when_true_else_is_called_the_else_action_should_be_executed()
    {
        var actionExecuted = true;

        false.WhenTrueElse(() => actionExecuted = true, () => actionExecuted = false);

        actionExecuted.Should().BeFalse();
    }

}
