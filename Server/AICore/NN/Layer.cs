using System.Diagnostics;

namespace AICore.NN
{
    [DebuggerDisplay("Layer: Size={NeuronCount}")]
    public class Layer
    {
        public Neuron[] Neurons { get; set; }
        public int NeuronCount => Neurons.Length;

        public Layer(int numNeurons)
        {
            Neurons = new Neuron[numNeurons];
        }
    }
}