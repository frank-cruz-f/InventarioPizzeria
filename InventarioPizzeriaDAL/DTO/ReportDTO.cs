using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace InventarioPizzeriaDAL.DTO
{
    public class ReportDTO
    {
        private PrintDocument pdoc = null;
        public int SpentDough { get; set; }
        public int InitialDough { get; set; }
        public int RemainingDough { get; set; }
        public int BurntDough { get; set; }
        public int SpentCheese { get; set; }
        public string Date { get; set; }
        public int SplitDough { get; set; }
        public int ShopId { get; set; }
        public ShopDTO Shop { get; set; }
        public bool IsCallCenterReport { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }

        public ReportDTO()
        {

        }

        public ReportDTO(int spentDough, int initialDough, int remainingDough, int burntDough, int splitDough, int spentCheese, int shopId)
        {
            this.SpentDough = spentDough;
            this.InitialDough = initialDough;
            this.RemainingDough = remainingDough;
            this.BurntDough = burntDough;
            this.SpentCheese = spentCheese;
            this.SplitDough = splitDough;
            this.ShopId = shopId;
        }

        public void addCallCenterValues(ReportDTO callCenterReport)
        {
            this.SpentCheese += callCenterReport.SpentCheese;
            this.InitialDough += callCenterReport.InitialDough;
            this.SplitDough += callCenterReport.SplitDough;
            this.SpentDough += callCenterReport.SpentDough;
            this.RemainingDough += callCenterReport.RemainingDough;
            this.BurntDough += callCenterReport.BurntDough;
            this.Shop = callCenterReport.Shop;
        }
    }
}
