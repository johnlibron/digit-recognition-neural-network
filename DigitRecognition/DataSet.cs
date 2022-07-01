namespace DigitRecognition
{
    class DataSet
    {
        public int Label { get; }
        public double[] Inputs { get; }

        public DataSet(int label, double[] data)
        {
            Label = label;
            Inputs = data;
        }
    }
}
