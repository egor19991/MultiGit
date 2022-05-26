using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MorLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private Series s2 = new Series();
        private Series s3 = new Series();
        private Mathematic _math = new Mathematic {};

        private void buildGraphics_Click(object sender, EventArgs e)
        {
            
            double h = 0.1, y, x , x1, y1 , y2;
            chart1.ChartAreas[0].AxisX.Maximum = _math.Maximum;
            chart1.ChartAreas[0].AxisX.Minimum = _math.Minimum;
            chart1.ChartAreas[0].AxisX.Interval = _math.Interval;
            s3.Points.Clear();
            this.chart1.Series[0].Points.Clear();
            x = _math.Minimum;
            while (x<_math.Maximum)
            {
                y = _math.function(x);
                y2 = _math.derivative(x);
                this.chart1.Series[0].Points.AddXY(x, y);
                s3.Points.AddXY(x, y2);
                x = x + h;
            }

            x1 = 0;
            this.chart1.Series[1].Points.Clear();
            try
            {
                x1 = _math.MethodPaull(_math.SearchPoint, _math.Step, 100, _math.EpsX, _math.EpsY);
                y1 = _math.function(x1);
                s2.Points.AddXY(x1, y1);
                textBoxMessage.Text = _math.Message;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                textBoxMessage.Text = String.Empty;
            }
            // this.chart1.Series["Series 2"].Points.AddXY(x1, y1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxA.Text = _math.Minimum.ToString();
            textBoxB.Text = _math.Maximum.ToString();
            textBoxH.Text = _math.Step.ToString();
            textBoxInterval.Text = _math.Interval.ToString();
            textBoxSearchPoint.Text = _math.SearchPoint.ToString();
            textBoxEpsX.Text = _math.EpsX.ToString();
            textBoxEpsY.Text = _math.EpsY.ToString();
            textBoxMantissa.Text = _math.Mantissa.ToString();
            s2.MarkerStyle = MarkerStyle.Circle;
            s2.ChartType = SeriesChartType.Spline;
            chart1.Series.Add(s2);
            //s3.MarkerStyle = MarkerStyle.Circle;
            s3.ChartType = SeriesChartType.Spline;
            chart1.Series.Add(s3);
            //chart1.ChartAreas[0].AxisX.Maximum = _math.Maximum;
            //chart1.ChartAreas[0].AxisX.Minimum = _math.Minimum;
            //chart1.ChartAreas[0].AxisX.Interval = 1;
        }

        private void textBoxB_Leave(object sender, EventArgs e)
        {
            try
            {
                _math.Maximum = double.Parse(textBoxB.Text);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void textBoxA_Leave(object sender, EventArgs e)
        {
            try
            {
                _math.Minimum = double.Parse(textBoxA.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void textBoxH_Leave(object sender, EventArgs e)
        {
            try
            {
                _math.Step = double.Parse(textBoxH.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void textBoxInterval_Leave(object sender, EventArgs e)
        {
            try
            {
                _math.Interval = double.Parse(textBoxInterval.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void textBoxSearchPoint_Leave(object sender, EventArgs e)
        {
            try
            {
                _math.SearchPoint = double.Parse(textBoxSearchPoint.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void textBoxEpsX_Leave(object sender, EventArgs e)
        {
            try
            {
                _math.EpsX = double.Parse(textBoxEpsX.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void textBoxEpsY_Leave(object sender, EventArgs e)
        {
            try
            {
                _math.EpsY = double.Parse(textBoxEpsY.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMantissa_Leave(object sender, EventArgs e)
        {
            try
            {
                _math.Mantissa = int.Parse(textBoxMantissa.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
