using FluentAssertions;
using Sirh3e.LogicGates.Lib.Components;
using Xunit;

namespace Sirh3e.LogicGates.Tests.Components
{
    public class LeverUnitTest
    {
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Should_Pass_When_All_State_Are_Equal(bool state)
        {
            var lever = new Lever(state);
            
            lever.State.Should().Be(state);
        }
        
        [Theory]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public void Should_Pass_When_All_State_Are_Equal_To_Result(bool state, bool result)
        {
            var lever = new Lever(state);
            
            lever.Switch().Should().Be(result);
            lever.State.Should().Be(result);
        }
    }
}