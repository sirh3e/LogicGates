using FluentAssertions;
using Sirh3e.LogicGates.Lib.Gates;
using Sirh3e.LogicGates.Tests.Data;
using Xunit;

namespace Sirh3e.LogicGates.Tests.Gates
{
    public class NotGateUnitTest: BaseGateUnitTest
    {
        public new static bool[] Results => new [] { true, true, false, false};
        public new static MatrixTheoryData TheoryData = new(Inputs, Results);
        
        [Theory]
        [MemberData(nameof(TheoryData))]
        public void Should_Pass_When_All_State_Are_Equal_To_Left_Gate((IGate, IGate) gates, bool result)
        {
            var (left, _) = gates;
            
            var gate = new NotGate(left);
            gate.State.Should().Be(result);
        }
        
        [Theory]
        [MemberData(nameof(TheoryData))]
        public void Should_Pass_When_All_State_Are_Equal_To_Right_State_Inverted((IGate, IGate) gates, bool result)
        {
            var (_, right) = gates;
            
            var gate = new NotGate(right);
            gate.State.Should().Be(!right.State);
        }
    }
}