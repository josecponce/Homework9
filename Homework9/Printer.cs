using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Homework9 {
    public class Printer : IDisposable {
        private Chart chart;
        private PrintPreviewDialog printPreviewDialog;
        private PrintDocument pd;

        public Printer(Chart chart) {
            this.chart = chart;
            printPreviewDialog = new PrintPreviewDialog();

            // Create new PrintDocument 
            pd = new PrintDocument();
            printPreviewDialog.Document = pd;

            // Add a PrintPageEventHandler for the document 
            pd.PrintPage += pd_PrintPage;
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev) {
            try {
                // Create and initialize print font 
                using (Font printFont = new Font("Arial", 10)) {
                    // Draw a line of text, followed by the chart 
                    ev.Graphics.DrawString("Line before chart", printFont, Brushes.Black, 10, 10);
                }
                // Create Rectangle structure, used to set the position of the chart Rectangle 
                var myRec = new Rectangle(100, 100, chart.Bounds.Right, chart.Bounds.Bottom);
                chart.Printing.PrintPaint(ev.Graphics, myRec);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public void ShowDialog() {
            Task.Run(() => pd.Print());
            printPreviewDialog.ShowDialog();
        }

        public void Dispose() {
            pd?.Dispose();            
        }
    }
}

