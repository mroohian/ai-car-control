namespace AICore.NN
{
    public class NeuronParam
    {
        public double Bias { get; internal set; }
        public int DendriteCount => Weights.Length;
        public double[] Weights;

        public NeuronParam(int nDandrites)
        {
            this.Weights = new double[nDandrites];
        }
    }
}