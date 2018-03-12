using CsvHelper;
using InventarioPizzeriaDAL;
using InventarioPizzeriaDAL.DA;
using InventarioPizzeriaDAL.DTO;
using InventarioPizzeriaDAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioPizzeria.Views
{
    public partial class ReportView : Form
    {
        private DoughDA doughDA;
        private ProductDA productDA;
        private ReportDA reportDA;
        private ShopDA shopDA;
        private List<RecordDTO> records;
        public ReportView()
        {
            InitializeComponent();
            LoadRecordFile();
            doughDA = new DoughDA();
            productDA = new ProductDA();
            reportDA = new ReportDA();
            shopDA = new ShopDA();
        }

        private void LoadRecordFile()
        {
            Stream fileStream = null;
            //Update - remove parenthesis
            using (var selectFileDialog = new OpenFileDialog())
            {
                selectFileDialog.Filter = "Archivos de reporte | *.csv";
                if (selectFileDialog.ShowDialog() == DialogResult.OK && (fileStream = selectFileDialog.OpenFile()) != null)
                {
                    LoadRecords(fileStream);
                }
            }
        }

        private void LoadRecords(Stream fileStream)
        {
            var reader = new StreamReader(fileStream);
            var csv = new CsvReader(reader);
            csv.Configuration.UseNewObjectForNullReferenceProperties = true;
            /*var culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            var dateTimeFormat = new DateTimeFormatInfo();
            dateTimeFormat.FullDateTimePattern = "dd/MM/yyyy hh:mm tt";
            dateTimeFormat.AMDesignator = "a.m.";
            dateTimeFormat.PMDesignator = "p.m.";
            culture.DateTimeFormat = dateTimeFormat;
            csv.Configuration.CultureInfo = culture;
            csv.Configuration.TrimFields = true;*/
            records = csv.GetRecords<RecordDTO>().ToList();
        }

        private ReportDTO calculateReportValues(int shopId, List<RecordDTO> recordsForReport, bool isCallCenterReport)
        {

            var doughsForDate = doughDA.getDoughsForDate(initialDatePicker.Value, finalDatePicker.Value, shopId);
            var products = productDA.getProducts();
            var initialDough = doughsForDate.Where(d => d.Operation.Equals(DoughOperation.Initial));
            var remainingDough = doughsForDate.Where(d => d.Operation.Equals(DoughOperation.Remaining));
            var burntDough = doughsForDate.Where(d => d.Operation.Equals(DoughOperation.Burnt)).ToList();
            var splitDough = doughsForDate.Where(d => d.Operation.Equals(DoughOperation.Split)).ToList();
            var spentDough = 0;
            var spentCheese = 0;
            burntDough.ForEach(b =>
            {
                spentDough += b.Grams;
            });
            splitDough.ForEach(s =>
            {
                spentDough += s.Grams;
            });
            recordsForReport.ForEach(rep =>
            {
                var product = products.Where(p => rep.Portion.ToUpperInvariant().Contains(p.Code.ToUpperInvariant()));
                if (product != null)
                {
                    product.ToList().ForEach(prod =>
                    {
                        spentDough += prod.DoughGrams;
                        spentCheese += prod.CheeseGrams;
                    });
                }
            });

            var remainingDoughQuantity = 0;
            var burntDoughQuantity = 0;
            var initialDoughQuantity = 0;
            var splitDoughQuantity = 0;
            if (initialDough != null)
            {
                initialDoughQuantity = initialDough.Sum(i => i.Grams); ;
            }

            if (remainingDough != null)
            {
                remainingDoughQuantity = remainingDough.Sum(r => r.Grams);
            }

            if (burntDough != null)
            {
                burntDoughQuantity = burntDough.Sum(b => b.Grams);
            }

            if (splitDough != null)
            {
                splitDoughQuantity = splitDough.Sum(s => s.Grams);
            }

            var report = new ReportDTO(spentDough, initialDoughQuantity, remainingDoughQuantity, burntDoughQuantity, splitDoughQuantity, spentCheese, shopId);
            report.InitialDate = initialDatePicker.Value;
            report.FinalDate = finalDatePicker.Value;
            report.IsCallCenterReport = isCallCenterReport;
            if (!isCallCenterReport)
            {
                var callCenterReport = reportDA.getCallCenterReport(shopId, initialDatePicker.Value, finalDatePicker.Value);
                if (callCenterReport != null)
                {
                    report.addCallCenterValues(callCenterReport);
                }
            }
            report.Date = DateTime.Now.ToString("dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);
            reportDA.saveReport(report);
            return report;
        }


        private void generateReportBtn_Click(object sender, EventArgs e)
        {
            var callCenterId = shopDA.getCallCenterId();
            if(Global.CurrentShop == callCenterId)
            {
                generateCallCenterReport();
            }
            else
            {
                var report = calculateReportValues(Global.CurrentShop, records, false);
                var util = new Util();
                util.printList = new List<ReportDTO>() { report };
                util.print();
            }
            
        }

        private void generateCallCenterReport()
        {
            var shopRecords = new Dictionary<int, List<RecordDTO>>();
            var bills = new Dictionary<int, List<RecordDTO>>();
            var util = new Util();
            util.printList = new List<ReportDTO>();
            foreach(var record in records)
            {
                List<RecordDTO> recordsForBill;
                if(bills.TryGetValue(record.TicketNumber, out recordsForBill))
                {
                    recordsForBill.Add(record);
                    bills[record.TicketNumber] = recordsForBill;
                }
                else
                {
                    bills.Add(record.TicketNumber, new List<RecordDTO>() { record });
                }
            }

            bills.ToList().ForEach(bill =>
            {
                var shopId = findShopIdFromRecords(bill.Value);
                List<RecordDTO> shopRecordList;
                if(shopRecords.TryGetValue(shopId, out shopRecordList))
                {
                    shopRecordList.AddRange(bill.Value);
                    shopRecords[shopId] = shopRecordList;
                }
                else
                {
                    shopRecords[shopId] = bill.Value;
                }
            });
            shopRecords.ToList().ForEach(shop =>
            {
                var report = calculateReportValues(shop.Key, shop.Value, true);
                util.printList.Add(report);
            });
            util.print();
        }

        private int findShopIdFromRecords(List<RecordDTO> records)
        {
            var shops = shopDA.getShops();
            foreach(var shop in shops)
            {
                if (records.Any(rec => rec.Name.ToUpperInvariant().Contains(shop.Name.ToUpperInvariant()) || shop.Name.ToUpperInvariant().Contains(rec.Name.ToUpperInvariant())))
                {
                    return shop.ID;
                }
            }
            return 0;
        }
    }
}
