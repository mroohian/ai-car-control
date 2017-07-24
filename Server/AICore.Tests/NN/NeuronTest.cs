using AICore.NN;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AICore.Tests.NN
{
    [TestClass]
    public class NeuronTest
    {
        [TestMethod]
        public void TestNeuronMetadata()
        {
            var newParam = new NeuronParam(0);

            var neuron = new Neuron(newParam);

            neuron.Metadata.MyValue = 12;

            Assert.AreEqual(12, neuron.Metadata.MyValue);
        }
    }
}
