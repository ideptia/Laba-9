using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считываем с формы требуемые значения 
            double a = 10.2, b = 1.25;
            double Xmin = double.Parse(textBox1.Text);
            double Xmax = double.Parse(textBox2.Text);
            double Step = double.Parse(textBox3.Text);
            // Количество точек графика 
            int count = (int)Math.Ceiling((Xmax - Xmin)/Step)+1;
            // Массив значений X – общий для обоих графиков 
            double[] x = new double[count];
            // Два массива Y – по одному для каждого графика 
            double[] y1 = new double[count];
            double[] y2 = new double[count];

// Расчитываем точки для графиков функции 
for (int i = 0; i < count; i++)
            {
                // Вычисляем значение X 
                x[i] = Xmin + Step * i;
                // Вычисляем значение функций в точке X 
                y1[i] = 0.1*a*Math.Pow(x[i],3)*Math.Tan(a-b*x[i]);
                
            }
            // Настраиваем оси графика 
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            // Определяем шаг сетки 
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
            // Добавляем вычисленные значения в графики 
            chart1.Series[0].Points.DataBindXY(x, y1);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
