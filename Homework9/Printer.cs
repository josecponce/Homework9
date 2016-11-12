using System;
using System.Drawing;
using System.Drawing.Printing;


namespace Homework9
{
    public class Printer
    {
        PointF[] chart;

        public Printer(Chart chart)
        {
            this.chart = chart;
            // Create new PrintDocument 
            PrintDocument pd = new PrintDocument();

            // Add a PrintPageEventHandler for the document 
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);

            // Print the document 
            pd.Print();

        }  

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            try
            {
                // Create and initialize print font 
                System.Drawing.Font printFont = new System.Drawing.Font("Arial", 10);

                // Create Rectangle structure, used to set the position of the chart Rectangle 
                var myRec = new System.Drawing.Rectangle(10, 30, 150, 150);
                // Draw a line of text, followed by the chart, and then another line of text 
                ev.Graphics.DrawString("Line before chart", printFont, Brushes.Black, 10, 10);
                chart.Printing.PrintPaint(ev.Graphics, myRec);
                ev.Graphics.DrawString("Line after chart", printFont, Brushes.Black, 10, 200);
            } catch (Exception e)
            { }
        }












    }
}
