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
    public class BurntDoughDA : DataAccess
    {
        public BurntDoughDA():
            base()
        {

        }

        public bool saveDough(BurntDoughDTO doughDto)
        {
            bool result;
            try
            {
                var dough = Mapper.Map<BurntDoughDTO, BurntDough>(doughDto);
                BurntDough doughToSave;
                if (!doughDto.ID.Equals(0))
                {
                    doughToSave = context.BurntDoughs.Where(p => doughDto.ID.Equals(p.ID)).FirstOrDefault();
                    doughToSave = doughToSave.copyValues(dough);
                }
                else
                {
                    doughToSave = new BurntDough();
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

        public void deleteDough(int doughId)
        {
            var dough = context.BurntDoughs.Where(d => doughId.Equals(d.ID)).FirstOrDefault();
            context.BurntDoughs.Remove(dough);
            context.SaveChanges();
        }

        public BurntDoughDTO getDough(int doughId)
        {
            return Mapper.Map<BurntDoughDTO>(context.BurntDoughs.Where(d => d.ID.Equals(doughId)).FirstOrDefault());
        } 
    }
}
