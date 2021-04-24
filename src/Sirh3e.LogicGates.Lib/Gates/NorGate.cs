namespace Sirh3e.LogicGates.Lib.Gates
{
    public class NorGate : BaseGate
    {
        public NorGate(IGate left, IGate right) : base((left, right))
        {
        }
        
        public NorGate((IGate Left, IGate Right) gates) : base(gates)
        {
        }
        
        public override bool State
            => !Left.State && !Right.State;
    }
}