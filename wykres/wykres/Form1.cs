using System;

using System.Windows.Forms;

namespace wykres
{
    public partial class Form1 : Form
    {
        
        static int valA, valB, valC;

        public Form1()
        {
            InitializeComponent();
        }

        int calculate(int x)
        {
                       
            return ((valA*x*x)+(valB *x) + valC );
        }
        
            private void Button1_Click(object sender, EventArgs e)
        {

            try { valA = int.Parse(a.Text); }
            catch
            {
                valA = 0;
            };


            try { valB = int.Parse(b.Text); }
            catch
            {
                valB = 0;
            };

            try { valC = int.Parse(c.Text); }
            catch
            {
                valC = 0;
            };

            chartGraphic.Series[0].Points.Clear();
     
            // Margin
            chartGraphic.ChartAreas[0].Position.Auto = false;
            chartGraphic.ChartAreas[0].Position.X = 10;
            chartGraphic.ChartAreas[0].Position.Y = 10;
            chartGraphic.ChartAreas[0].Position.Width = 80;
            chartGraphic.ChartAreas[0].Position.Height = 80;

            // Both
            chartGraphic.ChartAreas[0].AxisX.Crossing = 0;
            chartGraphic.ChartAreas[0].AxisY.Crossing = 0;

            // Axis X
            chartGraphic.ChartAreas[0].CursorX.IsUserEnabled = false;
            chartGraphic.ChartAreas[0].CursorX.IsUserSelectionEnabled = false;
            chartGraphic.ChartAreas[0].AxisX.ScaleView.Zoomable = false;
            chartGraphic.ChartAreas[0].AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartGraphic.ChartAreas[0].AxisX.LineWidth = 2;
           


            // Axis Y
            chartGraphic.ChartAreas[0].AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartGraphic.ChartAreas[0].AxisY.LineWidth = 2;
           
            
            
               // chartGraphic.ChartAreas[0].AxisX.Interval = 50;
               // chartGraphic.ChartAreas[0].AxisY.Interval = 500;
            

            for (int i = -29; i <= 31; i++)
            {
                chartGraphic.Series[0].Points.AddXY(i, calculate(i));
                chartGraphic.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
    }
}
