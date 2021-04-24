namespace Sirh3e.LogicGates.Lib.Gates
{
    public class AndGate : BaseGate
    {
        public AndGate(IGate left, IGate right) : base((left, right))
        {
        }
        
        public AndGate((IGate Left, IGate Right) gates) : base(gates)
        {
        }
        
        public override bool State
            => Left.State && Right.State;
    }
}