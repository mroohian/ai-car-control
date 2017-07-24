using AICore.NN;
using AICore.Evaluation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AICore.Tests.Evaluation
{
    [TestClass]
    public class NeuralNetworkExecutorTest
    {
        [TestMethod]
        public void TestRun()
        {
            var layers = new[] { 2, 3, 2 };

            var neuralNetwork = new NeuralNetwork(layers);

            var executer = new NeuralNetworkExecutor(neuralNetwork);

            var input = new[] { 1.0, 0.0 };

            var output = executer.Run(input);

            Assert.AreEqual(2, output.Length);
        }
    }
}
