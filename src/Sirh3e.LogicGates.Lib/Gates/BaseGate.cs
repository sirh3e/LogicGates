using System;

namespace Sirh3e.LogicGates.Lib.Gates
{
    public abstract class BaseGate : IGate
    {
        public readonly IGate Left; 
        public readonly IGate Right; 
        protected BaseGate(IGate left) : this((left, left))
        {
        }

        protected BaseGate((IGate Left, IGate Right) inputs)
        {
            Left = inputs.Left ?? throw new ArgumentNullException(nameof( inputs.Left));
            Right = inputs.Right ?? throw new ArgumentNullException(nameof(inputs.Right)); 
        }

        public abstract bool State { get; }
    }
}