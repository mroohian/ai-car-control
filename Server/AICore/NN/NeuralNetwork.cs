using System;
using System.Linq;
using AICore.Utilities;

namespace AICore.NN
{
    public class NeuralNetwork
    {
        public Layer[] Layers { get; set; }
        public int LayerCount => Layers.Length;

        public NeuralNetwork(int[] layers, double[] weights = null)
        {
            // set to true if needs to load data
            var hasWeight = weights != null;
            var readIndex = 0;

            // At least we need input and output layers
            if (layers.Length < 2)
            {
                throw new ArgumentException(nameof(layers));
            }

            // if we need to load weights check the number of them are correct.
            if (hasWeight)
            {
                if (weights.Length != CalculateWeightsCount(layers))
                {
                    throw new ArgumentException(nameof(weights));
                }
            }

            this.Layers = new Layer[layers.Length];

            for (int l = 0; l < layers.Length; l++)
            {
                Layer layer = new Layer(layers[l]);
                this.Layers[l] = layer;

                for (int n = 0; n < layers[l]; n++)
                {
                    var nDandrites = l > 0 ? layers[l - 1] : 0;
                    var param = new NeuronParam(nDandrites);

                    if (l == 0)
                    {
                        param.Bias = 0;
                    } else
                    {
                        if (hasWeight)
                        {
                            // Load data from weights
                            param.Bias = weights[readIndex++];

                            for (int d = 0; d < nDandrites; d++)
                            {
                                param.Weights[d] = weights[readIndex++];
                            }
                        } else
                        {
                            // Set random data
                            param.Bias = new CryptoRandom().RandomValue;

                            for (int d = 0; d < nDandrites; d++)
                            {
                                param.Weights[d] = new CryptoRandom().RandomValue;
                            }
                        }
                    }

                    layer.Neurons[n] = new Neuron(param);
                }
            }
        }

        private static int CalculateWeightsCount(int[] layers)
        {
            int nWeights;
            var nPossibleBiases = layers.Sum() - layers[0];

            var nPossibleWeights = 0;

            for (int i = 1; i < layers.Length; i++)
            {
                nPossibleWeights += layers[i] * layers[i - 1];
            }

            nWeights = nPossibleBiases + nPossibleWeights;
            return nWeights;
        }

        public double[] GetWeights()
        {
            var nWeight = CalculateWeightsCount(Layers.Select(l => l.NeuronCount).ToArray());

            var weights = new double[nWeight];
            var writeIndex = 0;

            for (int l = 1; l < LayerCount; l++)
            {
                var layer = Layers[l];
                for (int n = 0; n < layer.NeuronCount; n++)
                {
                    var neuron = layer.Neurons[n];

                    weights[writeIndex++] = neuron.Bias;

                    for (int d = 0; d < neuron.DendriteCount; d++)
                    {
                        var dandrite = neuron.Dendrites[d];
                        weights[writeIndex++] = dandrite.Weight;
                    }
                }
            }

            return weights;
        }
    }
}