using System;
using Sirh3e.LogicGates.Lib.Components;
using Sirh3e.LogicGates.Lib.Gates;

namespace Sirh3e.LogicGates.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            ILever a = new Lever(true);
            ILever b = new Lever(true);

            IGate gate = new NandGate(a, b);
            Console.WriteLine(gate.State);
        }
    }
}