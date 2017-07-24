namespace AICore.Trainer
{
    public interface INeuralNetworkTrainer {
        bool Train(double[] input, double[] output);
    }
}