using AutoMapper;
using InventarioPizzeriaDAL.DTO;
using InventarioPizzeriaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioPizzeriaDAL.Enums;
using System.Data.Entity.Core.Objects;

namespace InventarioPizzeriaDAL.DA
{
    public class DoughDA : DataAccess
    {
        public DoughDA():
            base()
        {

        }

        public bool saveDough(DoughDTO doughDto)
        {
            bool result;
            try
            {
                var dough = Mapper.Map<DoughDTO, Dough>(doughDto);
                Dough doughToSave;
                if (!doughDto.ID.Equals(0))
                {
                    doughToSave = context.Doughs.Where(p => doughDto.ID.Equals(p.ID)).FirstOrDefault();
                    doughToSave = doughToSave.copyValues(dough);
                }
                else
                {
                    doughToSave = new Dough();
                    doughToSave = dough;
                    context.Entry(doughToSave).State = EntityState.Added;
                }
                context.SaveChanges();
                var saveResult = context.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public List<DoughDTO> getOperationDough(DoughOperation operation, int currentShop, DateTime from, DateTime to)
        {
            return getDoughsForDate(from, to, currentShop)?.Where(d => d.Operation == operation)?.OrderByDescending(d => d.Date).ToList();
        }

        public void deleteDough(int doughId)
        {
            var dough = context.Doughs.Where(d => doughId.Equals(d.ID)).FirstOrDefault();
            context.Doughs.Remove(dough);
            context.SaveChanges();
        }

        public DoughDTO getDough(int doughId)
        {
            return Mapper.Map<DoughDTO>(context.Doughs.Where(d => d.ID.Equals(doughId)).FirstOrDefault());
        }

        public List<DoughDTO> getDoughsForDate(DateTime initialDate, DateTime finalDate, int currentShop)
        {
            return Mapper.Map<List<DoughDTO>>(context.Doughs.Where(d => DbFunctions.TruncateTime(d.Date) >= DbFunctions.TruncateTime(initialDate) && DbFunctions.TruncateTime(d.Date) <= DbFunctions.TruncateTime(finalDate) && d.ShopId == currentShop).ToList().OrderBy(d => d.Operation));
        }
    }
}
