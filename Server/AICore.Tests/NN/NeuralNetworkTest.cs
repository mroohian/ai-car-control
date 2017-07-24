using AICore.NN;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AICore.Tests.NN
{
    [TestClass]
    public class NeuralNetworkTest
    {
        [TestMethod]
        public void TestRunWithWeights()
        {
            var layers = new[] { 2, 3, 2 };

            var weights = Enumerable.Range(1, 17).Select(i => 1.0 / i).ToArray();

            var neuralNetwork = new NeuralNetwork(layers, weights);

            Assert.IsTrue(neuralNetwork != null);
        }

        [TestMethod]
        public void TestSaveNeuralNetwork()
        {
            var layers = new[] { 2, 3, 2 };

            var neuralNetwork = new NeuralNetwork(layers);

            var weights = neuralNetwork.GetWeights();

            Assert.AreEqual(17, weights.Length);
        }
    }
}
