using Sirh3e.LogicGates.Lib.Components;
using Sirh3e.LogicGates.Lib.Gates;

namespace Sirh3e.LogicGates.Tests.Helpers
{
    public static class Helper
    {
        public static (IGate, IGate) CreateGates((bool Left, bool Right) inputs)
            => CreateGates(inputs.Left, inputs.Right);
                
        public static (IGate, IGate) CreateGates(bool left, bool right)
            => (new Lever(left), new Lever(right));
    }
}