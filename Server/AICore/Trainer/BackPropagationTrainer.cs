using AICore.NN;
using AICore.Evaluation;

namespace AICore.Trainer
{
    public class BackPropagationTrainer : INeuralNetworkTrainer
    {
        private double _learningRate { get; set; }
        private NeuralNetwork _neuralNetwork;
        private NeuralNetworkExecutor _executor;

        public BackPropagationTrainer(double learningRate, NeuralNetwork neuralNetwork)
        {
            this._neuralNetwork = neuralNetwork;

            this._executor = new NeuralNetworkExecutor(neuralNetwork);
        }


        public bool Train(double[] input, double[] output)
        {
            if ((input.Length != _neuralNetwork.Layers[0].NeuronCount) || 
                (output.Length != _neuralNetwork.Layers[_neuralNetwork.LayerCount - 1].NeuronCount))
            {
                return false;
            }

            this._executor.Run(input);

            for (int i = 0; i < this._neuralNetwork.Layers[this._neuralNetwork.LayerCount - 1].NeuronCount; i++)
            {
                Neuron neuron = this._neuralNetwork.Layers[this._neuralNetwork.LayerCount - 1].Neurons[i];

                neuron.Metadata.Delta = neuron.Value * (1 - neuron.Value) * (output[i] - neuron.Value);

                for (int j = this._neuralNetwork.LayerCount - 2; j > 2; j--)
                {
                    for (int k = 0; k < this._neuralNetwork.Layers[j].NeuronCount; k++)
                    {
                        Neuron n = this._neuralNetwork.Layers[j].Neurons[k];

                        n.Metadata.Delta = n.Value *
                                  (1 - n.Value) *
                                  this._neuralNetwork.Layers[j + 1].Neurons[i].Dendrites[k].Weight *
                                  this._neuralNetwork.Layers[j + 1].Neurons[i].Metadata.Delta;
                    }
                }
            }

            for (int i = this._neuralNetwork.LayerCount - 1; i > 1; i--)
            {
                for (int j = 0; j < this._neuralNetwork.Layers[i].NeuronCount; j++)
                {
                    Neuron n = this._neuralNetwork.Layers[i].Neurons[j];
                    n.Bias = n.Bias + (this._learningRate * n.Metadata.Delta);

                    for (int k = 0; k < n.DendriteCount; k++)
                        n.Dendrites[k].Weight = n.Dendrites[k].Weight + 
                            (this._learningRate * this._neuralNetwork.Layers[i - 1].Neurons[k].Value * n.Metadata.Delta);
                }
            }

            return true;
        }
    }
}