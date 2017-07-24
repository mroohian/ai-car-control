using System.Diagnostics;

namespace AICore.NN
{
    [DebuggerDisplay("Dendrite: {Weight}")]
    public class Dendrite
    {
        public double Weight { get; set; }

        public Dendrite(double weight)
        {
            this.Weight = weight;
        }        
    }
}