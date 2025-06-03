namespace ProgrammingTechnologiesLaboratoryWork3
{
    partial class MainForm
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
            labelMinX = new Label();
            textBoxMinX = new TextBox();
            progressBar = new ProgressBar();
            buttonClose = new Button();
            textBoxMinY = new TextBox();
            labelMinY = new Label();
            textBoxMaxY = new TextBox();
            labelMaxY = new Label();
            textBoxMaxX = new TextBox();
            labelMaxX = new Label();
            textBoxCycleSize = new TextBox();
            labelCycleSize = new Label();
            labelStatus = new Label();
            labelStartTime = new Label();
            labelDurationLabel = new Label();
            labelDuration = new Label();
            labelResultsLabel = new Label();
            labelResults = new Label();
            buttonStart = new Button();

            SuspendLayout();

            // labelMinX
            labelMinX.AutoSize = true;
            labelMinX.Location = new Point(570, 9);
            labelMinX.Name = "labelMinX";
            labelMinX.Size = new Size(122, 13);
            labelMinX.Text = "Начальное значение X";

            // textBoxMinX
            textBoxMinX.Location = new Point(592, 25);
            textBoxMinX.Name = "textBoxMinX";
            textBoxMinX.Size = new Size(100, 20);
            textBoxMinX.Text = "1";

            // progressBar
            progressBar.Location = new Point(15, 219);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(1037, 23);

            // buttonClose
            buttonClose.Location = new Point(977, 646);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.Text = "Закрыть";
            buttonClose.Click += buttonClose_Click;

            // textBoxMinY
            textBoxMinY.Location = new Point(592, 64);
            textBoxMinY.Name = "textBoxMinY";
            textBoxMinY.Size = new Size(100, 20);
            textBoxMinY.Text = "5";

            // labelMinY
            labelMinY.AutoSize = true;
            labelMinY.Location = new Point(570, 48);
            labelMinY.Name = "labelMinY";
            labelMinY.Size = new Size(122, 13);
            labelMinY.Text = "Начальное значение Y";

            // textBoxMaxY
            textBoxMaxY.Location = new Point(755, 64);
            textBoxMaxY.Name = "textBoxMaxY";
            textBoxMaxY.Size = new Size(100, 20);
            textBoxMaxY.Text = "15";

            // labelMaxY
            labelMaxY.AutoSize = true;
            labelMaxY.Location = new Point(740, 48);
            labelMaxY.Name = "labelMaxY";
            labelMaxY.Size = new Size(115, 13);
            labelMaxY.Text = "Конечное значение Y";

            // textBoxMaxX
            textBoxMaxX.Location = new Point(755, 25);
            textBoxMaxX.Name = "textBoxMaxX";
            textBoxMaxX.Size = new Size(100, 20);
            textBoxMaxX.Text = "10";

            // labelMaxX
            labelMaxX.AutoSize = true;
            labelMaxX.Location = new Point(740, 9);
            labelMaxX.Name = "labelMaxX";
            labelMaxX.Size = new Size(115, 13);
            labelMaxX.Text = "Конечное значение X";

            // textBoxCycleSize
            textBoxCycleSize.Location = new Point(952, 25);
            textBoxCycleSize.Name = "textBoxCycleSize";
            textBoxCycleSize.Size = new Size(100, 20);
            textBoxCycleSize.Text = "4";

            // labelCycleSize
            labelCycleSize.AutoSize = true;
            labelCycleSize.Location = new Point(924, 9);
            labelCycleSize.Name = "labelCycleSize";
            labelCycleSize.Size = new Size(128, 13);
            labelCycleSize.Text = "Размерность массива";

            // labelStatus
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(12, 9);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(44, 13);
            labelStatus.Text = "Статус";

            // labelStartTime
            labelStartTime.AutoSize = true;
            labelStartTime.Location = new Point(128, 9);
            labelStartTime.Name = "labelStartTime";
            labelStartTime.Size = new Size(13, 13);
            labelStartTime.Text = "0";

            // labelDurationLabel
            labelDurationLabel.AutoSize = true;
            labelDurationLabel.Location = new Point(12, 87);
            labelDurationLabel.Name = "labelDurationLabel";
            labelDurationLabel.Size = new Size(111, 13);
            labelDurationLabel.Text = "Продолжительность";

            // labelDuration
            labelDuration.AutoSize = true;
            labelDuration.Location = new Point(128, 87);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(13, 13);
            labelDuration.Text = "0";

            // labelResultsLabel
            labelResultsLabel.AutoSize = true;
            labelResultsLabel.Location = new Point(12, 260);
            labelResultsLabel.Name = "labelResultsLabel";
            labelResultsLabel.Size = new Size(140, 13);
            labelResultsLabel.Text = "Промежуточные значения";

            // labelResults
            labelResults.AutoSize = true;
            labelResults.Location = new Point(158, 260);
            labelResults.Name = "labelResults";
            labelResults.Size = new Size(13, 13);
            labelResults.Text = "";

            // buttonStart
            buttonStart.Location = new Point(15, 190);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(1037, 23);
            buttonStart.Text = "Начать";
            buttonStart.Click += buttonStart_Click;

            // MainForm
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(labelMinX);
            Controls.Add(textBoxMinX);
            Controls.Add(progressBar);
            Controls.Add(buttonClose);
            Controls.Add(textBoxMinY);
            Controls.Add(labelMinY);
            Controls.Add(textBoxMaxY);
            Controls.Add(labelMaxY);
            Controls.Add(textBoxMaxX);
            Controls.Add(labelMaxX);
            Controls.Add(textBoxCycleSize);
            Controls.Add(labelCycleSize);
            Controls.Add(labelStatus);
            Controls.Add(labelStartTime);
            Controls.Add(labelDurationLabel);
            Controls.Add(labelDuration);
            Controls.Add(labelResultsLabel);
            Controls.Add(labelResults);
            Controls.Add(buttonStart);
            Name = "MainForm";
            Text = "Function Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMinX;
        private TextBox textBoxMinX;
        private ProgressBar progressBar;
        private Button buttonClose;
        private TextBox textBoxMinY;
        private Label labelMinY;
        private TextBox textBoxMaxY;
        private Label labelMaxY;
        private TextBox textBoxMaxX;
        private Label labelMaxX;
        private TextBox textBoxCycleSize;
        private Label labelCycleSize;
        private Label labelStatus;
        private Label labelStartTime;
        private Label labelDurationLabel;
        private Label labelDuration;
        private Label labelResultsLabel;
        private Label labelResults;
        private Button buttonStart;
    }
} 