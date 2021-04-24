namespace Sirh3e.LogicGates.Lib.Gates
{
    public class OrGate : BaseGate
    {
        public OrGate(IGate left, IGate right) : base((left, right))
        {
        }
        
        public OrGate((IGate Left, IGate Right) gates) : base(gates)
        {
        }
        
        public override bool State
            => Left.State || Right.State;
    }
}