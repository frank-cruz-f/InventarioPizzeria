using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace InventarioPizzeriaDAL.DTO
{
    public class ReportDTO
    {
        private PrintDocument pdoc = null;
        private int spentDough;
        private int initialDough;
        int remainingDough;
        int burntDough;
        int spentCheese;
        private string date;
        private int splitDough;

        public int SpentDough
        {
            get
            {
                return spentDough;
            }

            set
            {
                spentDough = value;
            }
        }

        public int InitialDough
        {
            get
            {
                return initialDough;
            }

            set
            {
                initialDough = value;
            }
        }

        public int RemainingDough
        {
            get
            {
                return remainingDough;
            }

            set
            {
                remainingDough = value;
            }
        }

        public int BurntDough
        {
            get
            {
                return burntDough;
            }

            set
            {
                burntDough = value;
            }
        }

        public int SpentCheese
        {
            get
            {
                return spentCheese;
            }

            set
            {
                spentCheese = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public int SplitDough
        {
            get
            {
                return splitDough;
            }

            set
            {
                splitDough = value;
            }
        }

        public ReportDTO()
        {

        }

        public ReportDTO(int spentDough, int initialDough, int remainingDough, int burntDough, int splitDough, int spentCheese)
        {
            this.spentDough = spentDough;
            this.initialDough = initialDough;
            this.remainingDough = remainingDough;
            this.burntDough = burntDough;
            this.spentCheese = spentCheese;
            this.splitDough = splitDough;
        }

        public void print()
        {
            PrintDialog pd = new PrintDialog();
            pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Courier New", 15);


            PaperSize psize = new PaperSize("Custom", 100, 200);
            //ps.DefaultPageSettings.PaperSize = psize;



            pd.Document = pdoc;
            pd.Document.DefaultPageSettings.PaperSize = psize;
            //pdoc.DefaultPageSettings.PaperSize.Height =320;
            pdoc.DefaultPageSettings.PaperSize.Height = 820;

            pdoc.DefaultPageSettings.PaperSize.Width = 520;

            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);

            DialogResult result = pd.ShowDialog();
            if (result == DialogResult.OK)
            {
                PrintPreviewDialog pp = new PrintPreviewDialog();
                pp.Document = pdoc;
                result = pp.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pdoc.Print();
                }
            }

        }
        void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 10);
            String underLine = "------------------------------------------";
            float fontHeight = font.GetHeight();
            int startX = 50;
            int startY = 55;
            int Offset = 40;
            graphics.DrawString("Jerry's Pizza", new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Fecha :" + Date, new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString(underLine, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Queso gastado = " + spentCheese, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString(underLine, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Masa inicial = " + initialDough, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Masa gastada = " + spentDough, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Masa quemada = " + burntDough, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Cortes de masa = " + splitDough, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Masa sobrante = " + remainingDough, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString(underLine, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            String Grosstotal = "Diferencia de masa = " + (initialDough - spentDough - remainingDough - burntDough - splitDough);
            graphics.DrawString(Grosstotal, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
        }
    }
}
