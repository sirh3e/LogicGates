using System.Collections.Generic;
using FluentAssertions;
using Sirh3e.LogicGates.Lib.Gates;
using Sirh3e.LogicGates.Tests.Helpers;
using Xunit;

namespace Sirh3e.LogicGates.Tests.Data
{
    public class MatrixTheoryData : TheoryData<(IGate, IGate), bool>
    {
        public MatrixTheoryData(IReadOnlyList<(bool, bool)> inputs, IReadOnlyList<bool> results)
        {
            inputs.Should().NotBeNull();
            results.Should().NotBeNull();

            inputs.Count.Should().Be(results.Count);

            for (var i = 0; i < inputs.Count; i++)
            {
                Add(Helper.CreateGates(inputs[i]), results[i]);
            }
        }
    }
}