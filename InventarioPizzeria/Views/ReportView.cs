using CsvHelper;
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
        private List<RecordDTO> records;
        public ReportView()
        {
            InitializeComponent();
            LoadRecordFile();
            doughDA = new DoughDA();
            productDA = new ProductDA();
            reportDA = new ReportDA();
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

        private void calculateReportValues()
        {
            
            var doughsForDate = doughDA.getDoughsForDate(datePicker.Value);
            var products = productDA.getProducts();
            var initialDough = doughsForDate.Where(d => d.Operation.Equals(DoughOperation.Initial)).FirstOrDefault();
            var remainingDough = doughsForDate.Where(d => d.Operation.Equals(DoughOperation.Remaining)).FirstOrDefault();
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
            records.ForEach(r =>
            {
                var product = products.Where(p => p.Code.ToUpperInvariant() == r.Portion.ToUpperInvariant()).FirstOrDefault();
                if (product != null)
                {
                    spentDough += product.DoughGrams;
                    spentCheese += product.CheeseGrams;
                }
            });

            var remainingDoughQuantity = 0;
            var burntDoughQuantity = 0;
            var initialDoughQuantity = 0;
            if(initialDough != null)
            {
                initialDoughQuantity = initialDough.Grams;
            }

            if(remainingDough != null)
            {
                remainingDoughQuantity = remainingDough.Grams;
            }

            if(burntDough != null)
            {
                burntDoughQuantity = burntDough.Sum(b => b.Grams);
            }

            var report = new ReportDTO(spentDough, initialDoughQuantity, remainingDoughQuantity, burntDoughQuantity, spentCheese);
            reportDA.saveReport(report);
            report.print();
        }

        private void generateReportBtn_Click(object sender, EventArgs e)
        {
            calculateReportValues();
        }
    }
}
