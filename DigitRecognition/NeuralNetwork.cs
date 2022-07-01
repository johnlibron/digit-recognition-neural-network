using System;
using System.Linq;

namespace DigitRecognition
{
    class NeuralNetwork
    {
        private readonly int numInput;
        private readonly int numHidden;
        private readonly int numOutput;

        // input-hidden
        private readonly double[][] ihWeights;
        private readonly double[] hBiases;
        private readonly double[] hSignals;
        private readonly double[] hOutputs;

        // input-hidden gradients
        private readonly double[][] ihWeightGrads;
        private readonly double[] hBiasGrads;

        // input-hidden deltas
        private readonly double[][] ihPrevWeightsDelta;
        private readonly double[] hPrevBiasesDelta;

        // hidden-output
        private readonly double[][] hoWeights;
        private readonly double[] oBiases;
        private readonly double[] oSignals;
        private double[] outputs;

        // hidden-output gradients
        private readonly double[][] hoWeightGrads;
        private readonly double[] oBiasGrads;

        // hidden-output deltas
        private readonly double[][] hoPrevWeightsDelta;
        private readonly double[] oPrevBiasesDelta;
        
        private readonly double learningRate;
        private readonly double momentum;

        public double Error { get; set; }
        public int Correct { get; set; }
        public int Incorrect { get; set; }

        public NeuralNetwork(int numInput, int numHidden, int numOutput, double learningRate, double momentum)
        {
            this.numInput = numInput;
            this.numHidden = numHidden;
            this.numOutput = numOutput;
            this.learningRate = learningRate;
            this.momentum = momentum;

            // input-hidden
            ihWeights = MakeMatrix(numInput, numHidden);
            hBiases = new double[numHidden];
            hSignals = new double[numHidden];
            hOutputs = new double[numHidden];

            // input-hidden gradients
            ihWeightGrads = MakeMatrix(numInput, numHidden);
            hBiasGrads = new double[numHidden];

            // input-hidden deltas
            ihPrevWeightsDelta = MakeMatrix(numInput, numHidden);
            hPrevBiasesDelta = new double[numHidden];

            // hidden-output
            hoWeights = MakeMatrix(numHidden, numOutput);
            oBiases = new double[numOutput];
            oSignals = new double[numOutput];
            outputs = new double[numOutput];

            // hidden-output gradients
            hoWeightGrads = MakeMatrix(numHidden, numOutput);
            oBiasGrads = new double[numOutput];

            // hidden-output deltas
            hoPrevWeightsDelta = MakeMatrix(numHidden, numOutput);
            oPrevBiasesDelta = new double[numOutput];

            InitializeWeights();
        }

        private static double[][] MakeMatrix(int rows, int cols)
        {
            double[][] result = new double[rows][];
            for (int i = 0; i < rows; i++)
            {
                result[i] = new double[cols];
            }
            return result;
        }

        private void InitializeWeights()
        {
            Random random = new Random();

            double inputHidden = Math.Sqrt(Convert.ToDouble(decimal.Divide(1, numInput)));
            double hiddenOutput = Math.Sqrt(Convert.ToDouble(decimal.Divide(1, numHidden)));

            // input-hidden weights
            for (int i = 0; i < numInput; i++)
            {
                for (int j = 0; j < numHidden; j++)
                {
                    ihWeights[i][j] = random.NextDouble() * inputHidden;
                }
            }

            // hidden biases
            for (int j = 0; j < numHidden; j++)
            {
                hBiases[j] = random.NextDouble() * inputHidden;
            }

            // hidden-output weights
            for (int j = 0; j < numHidden; j++)
            {
                for (int k = 0; k < numOutput; k++)
                {
                    hoWeights[j][k] = random.NextDouble() * hiddenOutput;
                }
            }

            // output biases
            for (int k = 0; k < numOutput; k++)
            {
                oBiases[k] = random.NextDouble() * hiddenOutput;
            }
        }

        public double[] Query(double[] inputs)
        {
            double[] outputs = ComputeOutputs(inputs);
            return outputs;
        }

        public void Train(double[] inputs, double[] targets)
        {
            // *************** Forward propagation ***************

            // input-hidden
            for (int j = 0; j < numHidden; j++)
            {
                double sum = 0.0;
                for (int i = 0; i < numInput; i++)
                {
                    sum += inputs[i] * ihWeights[i][j];
                }
                sum += hBiases[j];
                hOutputs[j] = Sigmoid(sum, false);
            }

            double[] oSums = new double[numOutput];

            // hidden-output
            for (int k = 0; k < numOutput; k++)
            {
                for (int j = 0; j < numHidden; j++)
                {
                    oSums[k] += hOutputs[j] * hoWeights[j][k];
                }
                oSums[k] += oBiases[k];
            }

            outputs = Softmax(oSums);

            // *************** Back propagation ***************

            // output error signals
            for (int k = 0; k < numOutput; k++)
            {
                oSignals[k] = (targets[k] - outputs[k]) * Sigmoid(outputs[k], true);
            }

            // hidden error signals
            for (int j = 0; j < numHidden; j++)
            {
                double sum = 0.0;
                for (int k = 0; k < numOutput; k++)
                {
                    sum += oSignals[k] * hoWeights[j][k];
                }
                hSignals[j] = Sigmoid(hOutputs[j], true) * sum;
            }

            // *************** Compute weight and bias gradients ***************

            // hidden-output weight gradients
            for (int j = 0; j < numHidden; j++)
            {
                for (int k = 0; k < numOutput; k++)
                {
                    hoWeightGrads[j][k] = oSignals[k] * hOutputs[j] * learningRate;
                }
            }

            // output bias gradients
            for (int k = 0; k < numOutput; k++)
            {
                oBiasGrads[k] = oSignals[k] * 1.0 * learningRate;
            }

            // input-hidden weight gradients
            for (int i = 0; i < numInput; i++)
            {
                for (int j = 0; j < numHidden; j++)
                {
                    ihWeightGrads[i][j] = hSignals[j] * inputs[i] * learningRate;
                }
            }

            // hidden bias gradients
            for (int j = 0; j < numHidden; j++)
            {
                hBiasGrads[j] = hSignals[j] * 1.0 * learningRate;
            }

            // *************** Update weights and biases ***************

            // update hidden-output weights
            for (int j = 0; j < numHidden; j++)
            {
                for (int k = 0; k < numOutput; k++)
                {
                    hoWeights[j][k] += hoWeightGrads[j][k];
                    hoWeights[j][k] += hoPrevWeightsDelta[j][k] * momentum;
                    hoPrevWeightsDelta[j][k] = hoWeightGrads[j][k];
                }
            }

            // update output node biases
            for (int k = 0; k < numOutput; k++)
            {
                oBiases[k] += oBiasGrads[k];
                oBiases[k] += oPrevBiasesDelta[k] * momentum;
                oPrevBiasesDelta[k] = oBiasGrads[k];
            }

            // update input-hidden weights
            for (int i = 0; i < numInput; i++)
            {
                for (int j = 0; j < numHidden; j++)
                {
                    ihWeights[i][j] += ihWeightGrads[i][j];
                    ihWeights[i][j] += ihPrevWeightsDelta[i][j] * momentum;
                    ihPrevWeightsDelta[i][j] = ihWeightGrads[i][j];
                }
            }

            // update hidden biases
            for (int j = 0; j < numHidden; j++)
            {
                hBiases[j] += hBiasGrads[j];
                hBiases[j] += hPrevBiasesDelta[j] * momentum;
                hPrevBiasesDelta[j] = hBiasGrads[j];
            }

            // *************** Calculate error function ***************

            for (int k = 0; k < numOutput; k++)
            {
                Error += Math.Pow(targets[k] - outputs[k], 2);
            }

            // *************** Calculate accuracy ***************

            int index = MaxIndex(outputs);
            int expectedIndex = MaxIndex(targets);

            if (index == expectedIndex)
            {
                Correct++;
            }
            else
            {
                Incorrect++;
            }
        }

        private double[] ComputeOutputs(double[] inputs)
        {
            double[] hOutputs = new double[numHidden];
            double[] outputs = new double[numOutput];

            // input-hidden
            for (int j = 0; j < numHidden; j++)
            {
                double sum = 0.0;
                for (int i = 0; i < numInput; i++)
                {
                    sum += inputs[i] * ihWeights[i][j];
                }
                sum += hBiases[j];
                hOutputs[j] = Sigmoid(sum, false);
            }

            double[] oSums = new double[numOutput];

            // hidden-output
            for (int k = 0; k < numOutput; k++)
            {
                for (int j = 0; j < numHidden; j++)
                {
                    oSums[k] += hOutputs[j] * hoWeights[j][k];
                }
                oSums[k] += oBiases[k];
            }

            outputs = Softmax(oSums);
            return outputs;
        }

        private static int MaxIndex(double[] output)
        {
            int index = 0;
            double maxValue = output[0];
            for (int i = 1; i < output.Length; i++)
            {
                if (output[i] > maxValue)
                {
                    maxValue = output[i];
                    index = i;
                }
            }
            return index;
        }

        private static double Sigmoid(double x, bool derivative)
        {
            if (derivative)
            {
                return x * (1 - x);
            }
            return 1 / (1 + Math.Exp(-x));
        }

        private static double Tanh(double x, bool derivative)
        {
            if (derivative)
            {
                return 1 - Math.Pow(x, 2);
            }
            return Math.Tanh(x);
        }

        private static double Relu(double x, bool derivative)
        {
            if (derivative)
            {
                if (x > 0)
                {
                    return 1;
                }
                return 0;
            }
            return Math.Max(0, x);
        }

        private static double[] Softmax(double[] x)
        {
            int maxIndex = MaxIndex(x);
            double max = x[maxIndex];

            double sum = 0.0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += Math.Exp(x[i] - max);
            }

            double[] result = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                result[i] = Math.Exp(x[i] - max) / sum;
            }
            return result;
        }
    }
}
