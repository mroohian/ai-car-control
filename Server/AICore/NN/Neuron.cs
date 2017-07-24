using System.Dynamic;
using System.Diagnostics;

namespace AICore.NN
{
    [DebuggerDisplay("Neuron: B={Bias} D={DendriteCount} V={Value}")]
    public class Neuron
    {
        private ExpandoObject _metadata;

        public Dendrite[] Dendrites { get; set; }
        public double Bias { get; set; }
        public dynamic Metadata => _metadata;
        public double Value { get; set; }

        public int DendriteCount => Dendrites.Length;

        public Neuron(NeuronParam neuronParam)
        {
            this._metadata = new ExpandoObject();

            this.Bias = neuronParam.Bias;

            this.Dendrites = new Dendrite[neuronParam.DendriteCount];

            for (int d = 0; d < neuronParam.DendriteCount; d++)
            {
                this.Dendrites[d] = new Dendrite(neuronParam.Weights[d]);
            }
        }
    }
}