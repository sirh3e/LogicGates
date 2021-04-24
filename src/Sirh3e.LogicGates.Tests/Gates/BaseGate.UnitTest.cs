using Sirh3e.LogicGates.Tests.Data;

namespace Sirh3e.LogicGates.Tests.Gates
{
    public abstract class BaseGateUnitTest
    {
        public static (bool, bool)[] Inputs =
        {
            (false, false),
            (false, true),
            (true, false),
            (true, true)
        };

        public static bool[] Results;
        public static MatrixTheoryData TheoryData;
    }
}