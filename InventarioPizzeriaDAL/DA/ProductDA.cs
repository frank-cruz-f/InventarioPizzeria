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
    public class ProductDA : DataAccess
    {
        public ProductDA():
            base()
        {
            
        }

        public List<ProductDTO> getProducts()
        {
            return Mapper.Map<List<Product>, List<ProductDTO>>(context.Products.ToList());
        }

        public bool saveProduct(ProductDTO productDto)
        {
            bool result;
            try
            {
                var product = Mapper.Map<ProductDTO, Product>(productDto);
                Product productToSave;
                if (!productDto.ID.Equals(0))
                {
                    productToSave = context.Products.Where(p => productDto.ID.Equals(p.ID)).FirstOrDefault();
                    productToSave = productToSave.copyValues(product);
                }
                else
                {
                    productToSave = new Product();
                    productToSave = product;
                    context.Entry(productToSave).State = EntityState.Added;
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

        public void deleteProduct(int productId)
        {
            var product = context.Products.Where(p => productId.Equals(p.ID)).FirstOrDefault();
            context.Products.Remove(product);
            context.SaveChanges();
        }

        public ProductDTO getProduct(int productId)
        {
            return Mapper.Map<ProductDTO>(context.Products.Where(p => p.ID.Equals(productId)).FirstOrDefault());
        }
    }
}
