using AIShared;
using AICore.NN;
using AICore.Evaluation;

namespace AIServer.AI
{
    public class AI_Logic {
        private readonly NeuralNetwork _neuralNetwork;

        public AI_Logic()
        {
            var layers = new[] { 7, 4 };

            _neuralNetwork = new NeuralNetwork(layers);
        }

        internal AI_Output RunAI(AI_InputRequest inputRequest)
        {
            var executer = new NeuralNetworkExecutor(_neuralNetwork);

            var output = executer.Run(AiHelper.AiInputToDoubleArray(inputRequest.Input));

            var aiOutput = AiHelper.DoubleArrayToAiOutput(output);

            return aiOutput;
        }
    }
}
