using AICore.NN;
using AICore.Utilities;
using System;

namespace AICore.Evaluation
{
    public class NeuralNetworkExecutor
    {
        private NeuralNetwork _neuralNetwork;

        public NeuralNetworkExecutor(NeuralNetwork neuralNetwork)
        {
            this._neuralNetwork = neuralNetwork;
        }

        public double[] Run(double[] input)
        {
            if (input.Length != _neuralNetwork.Layers[0].NeuronCount)
            {
                throw new ArgumentOutOfRangeException(nameof(input));
            }

            for (int l = 0; l < _neuralNetwork.LayerCount; l++)
            {
                var layer = _neuralNetwork.Layers[l];

                for (int n = 0; n < layer.NeuronCount; n++)
                {
                    var neuron = layer.Neurons[n];

                    if (l == 0)
                    {
                        neuron.Value = input[n];
                    } else
                    {
                        neuron.Value = 0;
                        for (int np = 0; np < _neuralNetwork.Layers[l - 1].NeuronCount; np++)
                        {
                            neuron.Value = neuron.Value +
                                _neuralNetwork.Layers[l - 1].Neurons[np].Value * neuron.Dendrites[np].Weight;
                        }

                        neuron.Value = MathUtil.Sigmoid(neuron.Value + neuron.Bias);
                    }
                }
            }

            var last = _neuralNetwork.Layers[_neuralNetwork.LayerCount - 1];
            int numOutput = last.NeuronCount;
            double[] output = new double[numOutput];
            for (int i = 0; i < last.NeuronCount; i++)
            {
                output[i] = last.Neurons[i].Value;
            }

            return output;
        }

    }
}