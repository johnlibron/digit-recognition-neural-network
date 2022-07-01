namespace DigitRecognition
{
    partial class FormDigitRecognition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDrawer = new System.Windows.Forms.Panel();
            this.buttonTrainImage = new System.Windows.Forms.Button();
            this.labelZero = new System.Windows.Forms.Label();
            this.labelOne = new System.Windows.Forms.Label();
            this.labelTwo = new System.Windows.Forms.Label();
            this.labelThree = new System.Windows.Forms.Label();
            this.labelFour = new System.Windows.Forms.Label();
            this.labelFive = new System.Windows.Forms.Label();
            this.labelNine = new System.Windows.Forms.Label();
            this.labelEight = new System.Windows.Forms.Label();
            this.labelSeven = new System.Windows.Forms.Label();
            this.labelSix = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonTrain = new System.Windows.Forms.Button();
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.progressBarNine = new System.Windows.Forms.ProgressBar();
            this.progressBarEight = new System.Windows.Forms.ProgressBar();
            this.progressBarSeven = new System.Windows.Forms.ProgressBar();
            this.progressBarSix = new System.Windows.Forms.ProgressBar();
            this.progressBarFive = new System.Windows.Forms.ProgressBar();
            this.progressBarFour = new System.Windows.Forms.ProgressBar();
            this.progressBarThree = new System.Windows.Forms.ProgressBar();
            this.progressBarTwo = new System.Windows.Forms.ProgressBar();
            this.progressBarOne = new System.Windows.Forms.ProgressBar();
            this.progressBarZero = new System.Windows.Forms.ProgressBar();
            this.progressBarTraining = new System.Windows.Forms.ProgressBar();
            this.labelEpoch = new System.Windows.Forms.Label();
            this.buttonTestImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDrawer
            // 
            this.panelDrawer.BackColor = System.Drawing.Color.White;
            this.panelDrawer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDrawer.Location = new System.Drawing.Point(235, 31);
            this.panelDrawer.Margin = new System.Windows.Forms.Padding(0);
            this.panelDrawer.Name = "panelDrawer";
            this.panelDrawer.Size = new System.Drawing.Size(200, 200);
            this.panelDrawer.TabIndex = 3;
            // 
            // buttonTrainImage
            // 
            this.buttonTrainImage.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrainImage.Location = new System.Drawing.Point(29, 239);
            this.buttonTrainImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTrainImage.Name = "buttonTrainImage";
            this.buttonTrainImage.Size = new System.Drawing.Size(200, 39);
            this.buttonTrainImage.TabIndex = 5;
            this.buttonTrainImage.Text = "From Train Set";
            this.buttonTrainImage.UseVisualStyleBackColor = true;
            this.buttonTrainImage.Click += new System.EventHandler(this.ButtonTrainImage_Click);
            // 
            // labelZero
            // 
            this.labelZero.AutoSize = true;
            this.labelZero.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZero.Location = new System.Drawing.Point(458, 33);
            this.labelZero.Name = "labelZero";
            this.labelZero.Size = new System.Drawing.Size(81, 19);
            this.labelZero.TabIndex = 6;
            this.labelZero.Text = "0 - 0.00%";
            // 
            // labelOne
            // 
            this.labelOne.AutoSize = true;
            this.labelOne.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOne.Location = new System.Drawing.Point(458, 63);
            this.labelOne.Name = "labelOne";
            this.labelOne.Size = new System.Drawing.Size(81, 19);
            this.labelOne.TabIndex = 7;
            this.labelOne.Text = "1 - 0.00%";
            // 
            // labelTwo
            // 
            this.labelTwo.AutoSize = true;
            this.labelTwo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTwo.Location = new System.Drawing.Point(458, 92);
            this.labelTwo.Name = "labelTwo";
            this.labelTwo.Size = new System.Drawing.Size(81, 19);
            this.labelTwo.TabIndex = 8;
            this.labelTwo.Text = "2 - 0.00%";
            // 
            // labelThree
            // 
            this.labelThree.AutoSize = true;
            this.labelThree.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThree.Location = new System.Drawing.Point(458, 123);
            this.labelThree.Name = "labelThree";
            this.labelThree.Size = new System.Drawing.Size(81, 19);
            this.labelThree.TabIndex = 9;
            this.labelThree.Text = "3 - 0.00%";
            // 
            // labelFour
            // 
            this.labelFour.AutoSize = true;
            this.labelFour.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFour.Location = new System.Drawing.Point(458, 151);
            this.labelFour.Name = "labelFour";
            this.labelFour.Size = new System.Drawing.Size(81, 19);
            this.labelFour.TabIndex = 10;
            this.labelFour.Text = "4 - 0.00%";
            // 
            // labelFive
            // 
            this.labelFive.AutoSize = true;
            this.labelFive.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFive.Location = new System.Drawing.Point(458, 182);
            this.labelFive.Name = "labelFive";
            this.labelFive.Size = new System.Drawing.Size(81, 19);
            this.labelFive.TabIndex = 11;
            this.labelFive.Text = "5 - 0.00%";
            // 
            // labelNine
            // 
            this.labelNine.AutoSize = true;
            this.labelNine.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNine.Location = new System.Drawing.Point(458, 302);
            this.labelNine.Name = "labelNine";
            this.labelNine.Size = new System.Drawing.Size(81, 19);
            this.labelNine.TabIndex = 15;
            this.labelNine.Text = "9 - 0.00%";
            // 
            // labelEight
            // 
            this.labelEight.AutoSize = true;
            this.labelEight.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEight.Location = new System.Drawing.Point(458, 272);
            this.labelEight.Name = "labelEight";
            this.labelEight.Size = new System.Drawing.Size(81, 19);
            this.labelEight.TabIndex = 14;
            this.labelEight.Text = "8 - 0.00%";
            // 
            // labelSeven
            // 
            this.labelSeven.AutoSize = true;
            this.labelSeven.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeven.Location = new System.Drawing.Point(458, 241);
            this.labelSeven.Name = "labelSeven";
            this.labelSeven.Size = new System.Drawing.Size(81, 19);
            this.labelSeven.TabIndex = 13;
            this.labelSeven.Text = "7 - 0.00%";
            // 
            // labelSix
            // 
            this.labelSix.AutoSize = true;
            this.labelSix.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSix.Location = new System.Drawing.Point(458, 212);
            this.labelSix.Name = "labelSix";
            this.labelSix.Size = new System.Drawing.Size(81, 19);
            this.labelSix.TabIndex = 12;
            this.labelSix.Text = "6 - 0.00%";
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(234, 239);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(200, 39);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // buttonTrain
            // 
            this.buttonTrain.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrain.Location = new System.Drawing.Point(29, 365);
            this.buttonTrain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTrain.Name = "buttonTrain";
            this.buttonTrain.Size = new System.Drawing.Size(200, 38);
            this.buttonTrain.TabIndex = 19;
            this.buttonTrain.Text = "Train";
            this.buttonTrain.UseVisualStyleBackColor = true;
            this.buttonTrain.Click += new System.EventHandler(this.ButtonTrain_Click);
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.BackColor = System.Drawing.Color.White;
            this.pictureBoxCanvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCanvas.Location = new System.Drawing.Point(29, 31);
            this.pictureBoxCanvas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxCanvas.TabIndex = 20;
            this.pictureBoxCanvas.TabStop = false;
            // 
            // progressBarNine
            // 
            this.progressBarNine.Location = new System.Drawing.Point(565, 300);
            this.progressBarNine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarNine.MarqueeAnimationSpeed = 0;
            this.progressBarNine.Name = "progressBarNine";
            this.progressBarNine.Size = new System.Drawing.Size(181, 25);
            this.progressBarNine.TabIndex = 40;
            // 
            // progressBarEight
            // 
            this.progressBarEight.Location = new System.Drawing.Point(565, 271);
            this.progressBarEight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarEight.MarqueeAnimationSpeed = 0;
            this.progressBarEight.Name = "progressBarEight";
            this.progressBarEight.Size = new System.Drawing.Size(181, 25);
            this.progressBarEight.TabIndex = 39;
            // 
            // progressBarSeven
            // 
            this.progressBarSeven.Location = new System.Drawing.Point(565, 241);
            this.progressBarSeven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarSeven.MarqueeAnimationSpeed = 0;
            this.progressBarSeven.Name = "progressBarSeven";
            this.progressBarSeven.Size = new System.Drawing.Size(181, 25);
            this.progressBarSeven.TabIndex = 38;
            // 
            // progressBarSix
            // 
            this.progressBarSix.Location = new System.Drawing.Point(565, 210);
            this.progressBarSix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarSix.MarqueeAnimationSpeed = 0;
            this.progressBarSix.Name = "progressBarSix";
            this.progressBarSix.Size = new System.Drawing.Size(181, 25);
            this.progressBarSix.TabIndex = 37;
            // 
            // progressBarFive
            // 
            this.progressBarFive.Location = new System.Drawing.Point(565, 181);
            this.progressBarFive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarFive.MarqueeAnimationSpeed = 0;
            this.progressBarFive.Name = "progressBarFive";
            this.progressBarFive.Size = new System.Drawing.Size(181, 25);
            this.progressBarFive.TabIndex = 36;
            // 
            // progressBarFour
            // 
            this.progressBarFour.Location = new System.Drawing.Point(565, 151);
            this.progressBarFour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarFour.MarqueeAnimationSpeed = 0;
            this.progressBarFour.Name = "progressBarFour";
            this.progressBarFour.Size = new System.Drawing.Size(181, 25);
            this.progressBarFour.TabIndex = 35;
            // 
            // progressBarThree
            // 
            this.progressBarThree.Location = new System.Drawing.Point(565, 122);
            this.progressBarThree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarThree.MarqueeAnimationSpeed = 0;
            this.progressBarThree.Name = "progressBarThree";
            this.progressBarThree.Size = new System.Drawing.Size(181, 25);
            this.progressBarThree.TabIndex = 34;
            // 
            // progressBarTwo
            // 
            this.progressBarTwo.Location = new System.Drawing.Point(565, 92);
            this.progressBarTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarTwo.MarqueeAnimationSpeed = 0;
            this.progressBarTwo.Name = "progressBarTwo";
            this.progressBarTwo.Size = new System.Drawing.Size(181, 25);
            this.progressBarTwo.TabIndex = 33;
            // 
            // progressBarOne
            // 
            this.progressBarOne.Location = new System.Drawing.Point(565, 62);
            this.progressBarOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarOne.MarqueeAnimationSpeed = 0;
            this.progressBarOne.Name = "progressBarOne";
            this.progressBarOne.Size = new System.Drawing.Size(181, 25);
            this.progressBarOne.TabIndex = 32;
            // 
            // progressBarZero
            // 
            this.progressBarZero.Location = new System.Drawing.Point(565, 32);
            this.progressBarZero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarZero.MarqueeAnimationSpeed = 0;
            this.progressBarZero.Name = "progressBarZero";
            this.progressBarZero.Size = new System.Drawing.Size(181, 25);
            this.progressBarZero.TabIndex = 31;
            // 
            // progressBarTraining
            // 
            this.progressBarTraining.Location = new System.Drawing.Point(235, 365);
            this.progressBarTraining.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarTraining.MarqueeAnimationSpeed = 0;
            this.progressBarTraining.Maximum = 60000;
            this.progressBarTraining.Name = "progressBarTraining";
            this.progressBarTraining.Size = new System.Drawing.Size(511, 38);
            this.progressBarTraining.TabIndex = 41;
            // 
            // labelEpoch
            // 
            this.labelEpoch.AutoSize = true;
            this.labelEpoch.Font = new System.Drawing.Font("Arial", 8F);
            this.labelEpoch.Location = new System.Drawing.Point(234, 343);
            this.labelEpoch.Name = "labelEpoch";
            this.labelEpoch.Size = new System.Drawing.Size(56, 16);
            this.labelEpoch.TabIndex = 42;
            this.labelEpoch.Text = "Epoch :";
            // 
            // buttonTestImage
            // 
            this.buttonTestImage.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTestImage.Location = new System.Drawing.Point(29, 282);
            this.buttonTestImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTestImage.Name = "buttonTestImage";
            this.buttonTestImage.Size = new System.Drawing.Size(200, 39);
            this.buttonTestImage.TabIndex = 43;
            this.buttonTestImage.Text = "From Test Set";
            this.buttonTestImage.UseVisualStyleBackColor = true;
            this.buttonTestImage.Click += new System.EventHandler(this.ButtonTestImage_Click);
            // 
            // FormDigitRecognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(781, 437);
            this.Controls.Add(this.buttonTestImage);
            this.Controls.Add(this.labelEpoch);
            this.Controls.Add(this.progressBarTraining);
            this.Controls.Add(this.progressBarNine);
            this.Controls.Add(this.progressBarEight);
            this.Controls.Add(this.progressBarSeven);
            this.Controls.Add(this.progressBarSix);
            this.Controls.Add(this.progressBarFive);
            this.Controls.Add(this.progressBarFour);
            this.Controls.Add(this.progressBarThree);
            this.Controls.Add(this.progressBarTwo);
            this.Controls.Add(this.progressBarOne);
            this.Controls.Add(this.pictureBoxCanvas);
            this.Controls.Add(this.buttonTrain);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelNine);
            this.Controls.Add(this.labelEight);
            this.Controls.Add(this.labelSeven);
            this.Controls.Add(this.labelSix);
            this.Controls.Add(this.labelFive);
            this.Controls.Add(this.labelFour);
            this.Controls.Add(this.labelThree);
            this.Controls.Add(this.labelTwo);
            this.Controls.Add(this.labelOne);
            this.Controls.Add(this.labelZero);
            this.Controls.Add(this.buttonTrainImage);
            this.Controls.Add(this.panelDrawer);
            this.Controls.Add(this.progressBarZero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDigitRecognition";
            this.Text = "Digit Recognition";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelDrawer;
        private System.Windows.Forms.Button buttonTrainImage;
        private System.Windows.Forms.Label labelZero;
        private System.Windows.Forms.Label labelOne;
        private System.Windows.Forms.Label labelTwo;
        private System.Windows.Forms.Label labelThree;
        private System.Windows.Forms.Label labelFour;
        private System.Windows.Forms.Label labelFive;
        private System.Windows.Forms.Label labelNine;
        private System.Windows.Forms.Label labelEight;
        private System.Windows.Forms.Label labelSeven;
        private System.Windows.Forms.Label labelSix;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonTrain;
        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.ProgressBar progressBarNine;
        private System.Windows.Forms.ProgressBar progressBarEight;
        private System.Windows.Forms.ProgressBar progressBarSeven;
        private System.Windows.Forms.ProgressBar progressBarSix;
        private System.Windows.Forms.ProgressBar progressBarFive;
        private System.Windows.Forms.ProgressBar progressBarFour;
        private System.Windows.Forms.ProgressBar progressBarThree;
        private System.Windows.Forms.ProgressBar progressBarTwo;
        private System.Windows.Forms.ProgressBar progressBarOne;
        private System.Windows.Forms.ProgressBar progressBarZero;
        private System.Windows.Forms.ProgressBar progressBarTraining;
        private System.Windows.Forms.Label labelEpoch;
        private System.Windows.Forms.Button buttonTestImage;
    }
}

