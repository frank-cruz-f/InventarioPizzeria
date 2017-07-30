using AutoMapper;
using InventarioPizzeriaDAL.DTO;
using InventarioPizzeriaDAL.Entities;
using System;
using System.Collections.Generic;
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
    }
}
