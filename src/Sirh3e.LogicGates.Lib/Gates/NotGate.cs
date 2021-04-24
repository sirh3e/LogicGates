namespace Sirh3e.LogicGates.Lib.Gates
{
    public class NotGate : BaseGate
    {
        public NotGate(IGate left) : base(left)
        {
        }

        public override bool State
            => !Left.State;
    }
}