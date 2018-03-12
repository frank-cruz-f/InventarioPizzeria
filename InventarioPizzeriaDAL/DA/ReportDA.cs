using AutoMapper;
using InventarioPizzeriaDAL.DTO;
using InventarioPizzeriaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioPizzeriaDAL.DA
{
    public class ReportDA : DataAccess
    {
        public ReportDA():
            base()
        {

        }

        public void saveReport(ReportDTO report)
        {
            var reportEntity = Mapper.Map<Report>(report);
            context.Reports.Add(reportEntity);
            context.SaveChanges();
        }

        public ReportDTO getCallCenterReport(int currentShop, DateTime initialDate, DateTime finalDate)
        {
            var report = context.Reports.Include(r => r.Shop).FirstOrDefault(r => r.ShopId == currentShop && DbFunctions.TruncateTime(r.InitialDate) == DbFunctions.TruncateTime(initialDate) && DbFunctions.TruncateTime(r.FinalDate) == DbFunctions.TruncateTime(finalDate) && r.IsCallCenterReport);
            return report != null ? Mapper.Map<ReportDTO>(report) : null;
        }
    }
}
