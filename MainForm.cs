namespace ProgrammingTechnologiesLaboratoryWork3
{
    public partial class MainForm : Form
    {
        private double _maxX;
        private double _minX;
        private double _maxY;
        private double _minY;
        private double _stepX;
        private double _stepY;
        private int _cycleSize;
        private double[] _arrayOfArgumentsX = null!;
        private double[] _arrayOfValuesY = null!;
        private double[,] _arrayOfValuesZ = null!;
        private DateTime _startTime;
        private DateTime _finishTime;
        public TimeSpan durationOfProcess;

        public MainForm()
        {
            InitializeComponent();
            _startTime = DateTime.Now;
            _finishTime = DateTime.Now;
        }

        private double Function13(double x, double y)
        {
            double numerator = Math.Exp(x) * (Math.Sin(y) - Math.Pow(Math.Cos(y), 2));
            double denominator = Math.Pow(Math.Sin(x), 2) + Math.Cos(x);
            return numerator / denominator;
        }

        private void DoWork()
        {
            _arrayOfValuesZ = new double[_cycleSize, _cycleSize];

            for (int i = 0; i < _cycleSize; i++) {
                for (int j = 0; j < _cycleSize; j++) {
                    _arrayOfValuesZ[i, j] = Function13(_arrayOfArgumentsX[i], _arrayOfValuesY[j]);
                    labelResults.Text += $"x:{_arrayOfArgumentsX[i]}; y:{_arrayOfValuesY[j]}; z:{_arrayOfValuesZ[i, j]}\n";
                    labelResults.Refresh();
                }
            }

            using (var writer = new StreamWriter("Results.txt")) {
                for (int i = 0; i < _cycleSize; i++) {
                    for (int j = 0; j < _cycleSize; j++) {
                        writer.Write($"arrayZ[{i}][{j}] = {_arrayOfValuesZ[i, j]}; ");
                    }
                    writer.WriteLine();
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            _startTime = DateTime.Now;
            labelStartTime.Text = _startTime.ToLongTimeString();
            labelStartTime.Refresh();

            labelResults.Text = "";
            labelResults.Refresh();

            _minX = Convert.ToDouble(textBoxMinX.Text);
            _minY = Convert.ToDouble(textBoxMinY.Text);
            _maxY = Convert.ToDouble(textBoxMaxY.Text);
            _maxX = Convert.ToDouble(textBoxMaxX.Text);
            _cycleSize = Convert.ToInt32(textBoxCycleSize.Text);

            progressBar.Maximum = _cycleSize;
            progressBar.Step = _cycleSize / 100;
            progressBar.Minimum = 0;
            progressBar.Value = 0;

            _arrayOfArgumentsX = new double[_cycleSize];
            _arrayOfValuesY = new double[_cycleSize];

            _stepX = (_maxX - _minX) / (_cycleSize - 1);
            _stepY = (_maxY - _minY) / (_cycleSize - 1);

            for (int i = 0; i < _cycleSize; i++) {
                _arrayOfArgumentsX[i] = _minX + i * _stepX;
            }

            for (int i = 0; i < _cycleSize; i++) {
                _arrayOfValuesY[i] = _minY + i * _stepY;
            }

            DoWork();

            _finishTime = DateTime.Now;
            durationOfProcess = _finishTime - _startTime;
            labelDuration.Text = durationOfProcess.ToString();
            labelDuration.Refresh();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}