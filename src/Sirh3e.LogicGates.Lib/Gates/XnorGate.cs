namespace Sirh3e.LogicGates.Lib.Gates
{
    public class XnorGate : BaseGate
    {
        public XnorGate(IGate left, IGate right) : base((left, right))
        {
        }
        
        public XnorGate((IGate Left, IGate Right) gates) : base(gates)
        {
        }
        
        public override bool State
            => Left.State == Right.State;
    }
}