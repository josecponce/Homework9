using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Homework9
{
    public class Printer
    {
        Chart chart;
        PrintPreviewDialog printPreviewDialog;

        public Printer(Chart chart)
        {
            this.chart = chart;
            printPreviewDialog = new PrintPreviewDialog();

            // Create new PrintDocument 
            PrintDocument pd = new PrintDocument();
            printPreviewDialog.Document = pd;

            // Add a PrintPageEventHandler for the document 
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);


        }  

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            try
            {
                // Create and initialize print font 
                System.Drawing.Font printFont = new System.Drawing.Font("Arial", 10);

                // Create Rectangle structure, used to set the position of the chart Rectangle 
                var myRec = new System.Drawing.Rectangle(100, 100, chart.Bounds.Right, chart.Bounds.Bottom);
                // Draw a line of text, followed by the chart 
                ev.Graphics.DrawString("Line before chart", printFont, Brushes.Black, 10, 10);
                chart.Printing.PrintPaint(ev.Graphics, myRec);
              
            } catch (Exception e)
            { Console.WriteLine(e.Message); }
        }

        public void ShowDialog()
        {
            printPreviewDialog.ShowDialog();
        }












    }
}
