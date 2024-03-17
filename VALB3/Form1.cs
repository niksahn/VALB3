namespace VALB3
{
    public partial class Form1 : Form
    {
        int rootNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }

        delegate double Function(double x);

        double f(double x)
        {
            return Math.Pow(Math.E, (1.5 * x)) + 3.0 * x - 4.5;
        }

        List<(double, double)> getIntervals(int A, int B, double n, Function f)
        {
            double h = (B - A) / n;
            List<(double, double)> intervals = new List<(double, double)>();
            for (int i = 0; i < n; i++)
            {
                if (f(A + i * h) * f(A + (i + 1) * h) < 0)
                {
                    intervals.Add((A + i * h, (A + (i + 1) * h)));
                }
            }
            return intervals;
        }

        List<double> BinSearch(double A, double B, double e, Function f)
        {
            double Start = A;
            double End = B;
            double x = (A + B) / 2.0;
            List<double> iters = new List<double>();
            while (f(x) != 0 && End - Start > e)
            {
                iters.Add(x);
                if (f(x) * f(Start) < 0)
                {
                    End = x;
                }
                else
                {
                    Start = x;
                }
                x = (End + Start) / 2.0;
            }
            return iters;
        }

        List<double> Secush(double A, double B, double e, Function f)
        {
            double predX = A;
            double x = A + 2.0 * e;
            double nextX = x - (x - predX) / (f(x) - f(predX)) * f(x);
            List<double> iters = new List<double>();
            while (Math.Abs(predX - x) > e)
            {
                nextX = x - ((x - predX) / (f(x) - f(predX))) * f(x);
                iters.Add(nextX);
                predX = x;
                x = nextX;
            }
            return iters;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var intervals = getIntervals((int)A.Value, (int)B.Value, 20.0, f);
            if ((int)A.Value > (int)B.Value) { MessageBox.Show("А больше B"); }
            else
            {
                dataGridView1.Rows.Clear();
                foreach (var i in intervals)
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add(i);
                }
                if (intervals.Count > 0)
                {
                    var startTime = Environment.TickCount;
                    var binRez = BinSearch(intervals[rootNumber].Item1, intervals[rootNumber].Item2, (double)E.Value, f);
                    textBox1.Text = (Environment.TickCount - startTime).ToString();
                    rezult.Text = binRez.Last().ToString();
                    startTime = Environment.TickCount;
                    var secushRez = Secush(intervals[rootNumber].Item1, intervals[rootNumber].Item2, (double)E.Value, f);
                    textBox2.Text = (Environment.TickCount - startTime).ToString();
                    secRez.Text = secushRez.Last().ToString();
                    fillTable(binRez, secushRez);
                    fillTable(binRez, secushRez);
                }
                else
                {
                    MessageBox.Show("На выбранном участке нет корней");
                }
            }
        }

        private void fillTable(List<double> bin, List<double> sec)
        {
            int n = Math.Max(bin.Count, sec.Count);
            for (int i = 0; i < n; i++)
            {
                if (i >= dataGridView1.Rows.Count) dataGridView1.Rows.Add();
                if (i < bin.Count - 1) dataGridView1.Rows[i].Cells[0].Value = bin[i];
                if (i < sec.Count - 1) dataGridView1.Rows[i].Cells[1].Value = sec[i];
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rootNumber = comboBox1.SelectedIndex;
        }
    }
}