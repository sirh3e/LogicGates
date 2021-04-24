namespace Sirh3e.LogicGates.Lib.Components
{
    public class Lever : ILever
    {
        public bool State { get; protected set; }
        public Lever(bool state = false)
        {
            State = state;
        }

        public bool Switch()
            => State = !State;
    }
}