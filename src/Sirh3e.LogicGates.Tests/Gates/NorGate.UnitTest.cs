using FluentAssertions;
using Sirh3e.LogicGates.Lib.Gates;
using Sirh3e.LogicGates.Tests.Data;
using Xunit;

namespace Sirh3e.LogicGates.Tests.Gates
{
    public class NorGateUnitTest : BaseGateUnitTest
    {
        public new static bool[] Results => new [] { true, false, false, false};
        public new static MatrixTheoryData TheoryData = new(Inputs, Results);
        
        [Theory]
        [MemberData(nameof(TheoryData))]
        public void Should_Pass_When_All_State_Are_Equal((IGate, IGate) gates, bool result)
        {
            var gate = new NorGate(gates);
            
            gate.State.Should().Be(result);
        }
    }
}