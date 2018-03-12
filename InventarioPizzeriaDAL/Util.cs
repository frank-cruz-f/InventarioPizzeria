using InventarioPizzeriaDAL.DA;
using InventarioPizzeriaDAL.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioPizzeriaDAL
{
    public class Util
    {
        public List<ReportDTO> printList { get; set; }
        private ShopDA shopDA { get; set; }

        public void print()
        {
            shopDA = new ShopDA();
            PrintDocument pdoc;
            PrintDialog pd = new PrintDialog();
            pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Courier New", 13);

            PaperSize psize = new PaperSize("Custom", 100, 1500);
            //ps.DefaultPageSettings.PaperSize = psize;

            pd.Document = pdoc;
            pd.Document.DefaultPageSettings.PaperSize = psize;
            //pdoc.DefaultPageSettings.PaperSize.Height =320;
            pdoc.DefaultPageSettings.PaperSize.Height = 1500;

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
            var date = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 10);
            String underLine = "------------------------------------------";
            String sepLine = "******************************************";
            float fontHeight = font.GetHeight();
            int startX = 30;
            int startY = 55;
            int Offset = 40;
            graphics.DrawString("Jerry's Pizza", new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Fecha :", new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString(date, new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString(underLine, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            foreach (var report in printList)
            {
                var shopName = shopDA.getShopNameById(report.ShopId);
                graphics.DrawString(shopName, new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString("Queso gastado = " + report.SpentCheese, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString(underLine, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString("M. inicial = " + report.InitialDough, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString("M. gastada = " + report.SpentDough, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString("M. quemada = " + report.BurntDough, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString("Cortes = " + report.SplitDough, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString("M. sobrante = " + report.RemainingDough, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString(underLine, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                String Grosstotal = "Dif de masa = " + (report.InitialDough - report.SpentDough - report.RemainingDough - report.BurntDough - report.SplitDough);
                graphics.DrawString(Grosstotal, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString(sepLine, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;

            }
            
        }
    }
}
