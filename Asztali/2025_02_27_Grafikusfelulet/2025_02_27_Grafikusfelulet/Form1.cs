using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace _2025_02_27_Grafikusfelulet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            AdatokFeltoltese();
            GrafikonKeszites();
            
        }
        private void AdatokFeltoltese()
        {
            listBox1.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                listBox1.Items.Add(r.Next(10, 99));
            }
        }
        private void GrafikonKeszites()
        {
            chart1.Series.Clear();
            chart1.Series.Add("számok");
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            for (int i = 0;i < numericUpDown1.Value; i++)
            {
                chart1.Series[0].Points.Add(Convert.ToInt32(listBox1.Items[i]));
            }
        }
    }
}
