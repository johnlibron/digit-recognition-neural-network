using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DigitRecognition
{
    public partial class FormDigitRecognition : Form
    {
        private BackgroundWorker workerThread;

        private NeuralNetwork network;
        private string[][] trainImages;
        private string[][] testImages;

        private DataSet[] trainDataSet;
        private DataSet[] testDataSet;

        private int maxEpoch;
        private Random random;

        public FormDigitRecognition()
        {
            InitializeComponent();

            // inputs, hidden, outputs, learning rate, momentum
            network = new NeuralNetwork(784, 128, 10, 0.2, 0.9);

            maxEpoch = 100;
            random = new Random();

            string[] trainMnist = File.ReadAllLines(Environment.CurrentDirectory + "//mnist_train.csv");
            string[] testMnist = File.ReadAllLines(Environment.CurrentDirectory + "//mnist_test.csv");
            trainImages = trainMnist.Select(x => x.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)).Take(10000).ToArray();
            testImages = testMnist.Select(x => x.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)).ToArray();

            progressBarTraining.Maximum = trainImages.Length;

            workerThread = new BackgroundWorker();
            workerThread.DoWork += WorkerThread_DoWork;
            workerThread.RunWorkerCompleted += WorkerThread_RunWorkerCompleted;

            // Get train datas (10k image sets)
            trainDataSet = new DataSet[trainImages.Length];
            for (int i = 0; i < trainDataSet.Length; i++)
            {
                int label = int.Parse(trainImages[i][0]);
                double[] inputs = new double[784];
                for (int j = 1; j < trainImages[0].Length; j++)
                    {
                    inputs[j - 1] = double.Parse(trainImages[i][j]);
                }
                trainDataSet[i] = new DataSet(label, inputs);
            }
            
            // Get test datas (10k image sets)
            testDataSet = new DataSet[testImages.Length];
            for (int i = 0; i < testDataSet.Length; i++)
            {
                int label = int.Parse(testImages[i][0]);
                double[] inputs = new double[784];
                for (int j = 1; j < testImages[0].Length; j++)
                {
                    inputs[j - 1] = double.Parse(testImages[i][j]);
                }
                testDataSet[i] = new DataSet(label, inputs);
            }
        }

        private static double[] NormalizeInput(double[] input)
        {
            double mean = input.Average();
            double variance = input.Sum(v => Math.Pow(v - mean, 2)) / (input.Length - 1);
            double standardDeviation = Math.Sqrt(variance);

            return input.Select(y => (y - mean) / standardDeviation).ToArray();
        }

        private void WorkerThread_DoWork(object sender, DoWorkEventArgs e)
        {
            double errorThreshold = 0.001;
            double totalError = 0;
            int epoch = 0;

            do
            {
                epoch++;
                network.Error = 0;
                network.Correct = 0;
                network.Incorrect = 0;
                labelEpoch.Invoke(new Action(() => labelEpoch.Text = "Epoch : " + epoch + " / " + maxEpoch));

                DataSet[] shuffleTrainDatas = trainDataSet.Shuffle().ToArray();

                for (int i = 0; i < shuffleTrainDatas.Length; i++)
                {
                    progressBarTraining.Invoke(new Action(() => progressBarTraining.Value = i + 1));

                    double[] targets = new double[10];
                    targets[shuffleTrainDatas[i].Label] = 1;

                    network.Train(NormalizeInput(shuffleTrainDatas[i].Inputs), targets);
                }

                totalError = network.Error / shuffleTrainDatas.Length;

                double accuracy = (network.Correct * 1.0) / (network.Correct + network.Incorrect);
                Console.WriteLine("Epoch : " + epoch + " - Error : " + String.Format("{0:0.00000}", totalError) + " - Accuracy : " + String.Format("{0:0.00000}", accuracy) + " - Correct : " + network.Correct + " - Incorrect : " + network.Incorrect);

            } while (totalError > errorThreshold && epoch < maxEpoch);
        }

        private static byte[] ReadAllBytes(Stream stream)
        {
            byte[] data;
            using (var memoryStream = new MemoryStream())
            {
                stream.CopyTo(memoryStream);
                data = memoryStream.ToArray();
            }
            return data;
        }

        private void WorkerThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            buttonTrain.Enabled = true;
        }

        private void ButtonTrain_Click(object sender, EventArgs e)
        {
            progressBarTraining.Value = 0;
            buttonTrain.Enabled = false;
            workerThread.RunWorkerAsync();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            pictureBoxCanvas.Image = null;
            panelDrawer.Refresh();
        }

        private void ButtonTrainImage_Click(object sender, EventArgs e)
        {
            int randomInt = random.Next(0, trainDataSet.Length);
            Identify(trainDataSet[randomInt].Inputs);
        }

        private void ButtonTestImage_Click(object sender, EventArgs e)
        {
            int randomInt = random.Next(0, testDataSet.Length);
            Identify(testDataSet[randomInt].Inputs);
        }

        private void Identify(double[] inputs)
        {
            panelDrawer.Refresh();

            Bitmap bm = new Bitmap(28, 28);

            int count = 0;

            for (int y = 0; y < 28; y++)
            {
                for (int x = 0; x < 28; x++)
                {
                    if (inputs[count] > 0)
                    {
                        int gray = (int)(255 - inputs[count]);
                        bm.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                    }
                    count++;
                }
            }

            pictureBoxCanvas.Image = new Bitmap(bm, new Size(pictureBoxCanvas.Width, pictureBoxCanvas.Height));

            double[] confidences = network.Query(NormalizeInput(inputs));

            labelZero.Text = "0 - " + String.Format("{0:0.00}", confidences[0] * 100) + "%";
            labelOne.Text = "1 - " + String.Format("{0:0.00}", confidences[1] * 100) + "%";
            labelTwo.Text = "2 - " + String.Format("{0:0.00}", confidences[2] * 100) + "%";
            labelThree.Text = "3 - " + String.Format("{0:0.00}", confidences[3] * 100) + "%";
            labelFour.Text = "4 - " + String.Format("{0:0.00}", confidences[4] * 100) + "%";
            labelFive.Text = "5 - " + String.Format("{0:0.00}", confidences[5] * 100) + "%";
            labelSix.Text = "6 - " + String.Format("{0:0.00}", confidences[6] * 100) + "%";
            labelSeven.Text = "7 - " + String.Format("{0:0.00}", confidences[7] * 100) + "%";
            labelEight.Text = "8 - " + String.Format("{0:0.00}", confidences[8] * 100) + "%";
            labelNine.Text = "9 - " + String.Format("{0:0.00}", confidences[9] * 100) + "%";

            progressBarZero.Value = Convert.ToInt32(confidences[0] * 100);
            progressBarOne.Value = Convert.ToInt32(confidences[1] * 100);
            progressBarTwo.Value = Convert.ToInt32(confidences[2] * 100);
            progressBarThree.Value = Convert.ToInt32(confidences[3] * 100);
            progressBarFour.Value = Convert.ToInt32(confidences[4] * 100);
            progressBarFive.Value = Convert.ToInt32(confidences[5] * 100);
            progressBarSix.Value = Convert.ToInt32(confidences[6] * 100);
            progressBarSeven.Value = Convert.ToInt32(confidences[7] * 100);
            progressBarEight.Value = Convert.ToInt32(confidences[8] * 100);
            progressBarNine.Value = Convert.ToInt32(confidences[9] * 100);

            float x1 = 7.0F;
            float y1 = -10.0F;
            Graphics g = panelDrawer.CreateGraphics();
            Font drawFont = new Font("Arial", 120);
            SolidBrush drawBrush = new SolidBrush(Color.Green);
            String character = GetCharacter(confidences).ToString();
            g.DrawString(character, drawFont, drawBrush, x1, y1);
            drawFont.Dispose();
            drawBrush.Dispose();
            g.Dispose();
        }

        private char GetCharacter(double[] confidences)
        {
            int index = 0;
            double value = confidences[0];
            for (int i = 1; i < confidences.Length; i++)
            {
                if (confidences[i] > value)
                {
                    index = i;
                    value = confidences[i];
                }
            }
            return Convert.ToString(index)[0];
        }
    }
}
