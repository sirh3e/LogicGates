namespace Sirh3e.LogicGates.Lib.Gates
{
    public class NandGate : BaseGate
    {
        public NandGate(IGate left, IGate right) : this((left, right))
        {
        }
        
        public NandGate((IGate left, IGate right) gates) : base(gates)
        {
        }

        public override bool State
            => (Left.State, Right.State) switch
            {
                (true, true) => false,
                _ => true
            };
    }
}