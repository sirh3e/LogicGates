namespace Sirh3e.LogicGates.Lib.Gates
{
    public class XorGate : BaseGate
    {
        public XorGate(IGate left, IGate right) : base((left, right))
        {
        }
        
        public XorGate((IGate left, IGate right) gates) : base(gates)
        {
        }
        
        public override bool State
            => (Left.State, Right.State) switch
            {
                (false, true) => true,
                (true, false) => true,
                _ => false
            };
    }
}