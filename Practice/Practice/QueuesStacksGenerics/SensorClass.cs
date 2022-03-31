using System;
using System.Net.Mime;

namespace Practice.QueuesStacksGenerics
{
    public class SensorClass
    {
        double x;
        public double Measure()
        {
            x += 0.01;
            return Math.Sin(x);
        }
    }
    
    // public class Program
    // {
    //     public static void MainX()
    //     {
    //         var sensor = new SensorClass();
    //         // var averager = new Averager(sensor, 1000);
    //
    //         var chart = new Chart();
    //         chart.ChartAreas.Add(new ChartArea());
    //         var raw = new Series();
    //
    //         for (int i = 0; i < 1000; i++)
    //             raw.Points.Add(new DataPoint(i, sensor.Measure()));
    //         // raw.Points.Add(new DataPoint(i, averager.Measure()));
    //
    //         raw.ChartType = SeriesChartType.FastLine;
    //         raw.Color = Color.Red;
    //         chart.Series.Add(raw);
    //
    //         chart.Dock = System.Windows.Forms.DockStyle.Fill;
    //         var form = new Form();
    //         form.Controls.Add(chart);
    //         form.WindowState = FormWindowState.Maximized;
    //         MediaTypeNames.Application.Run(form);
    //     }
    // }
}