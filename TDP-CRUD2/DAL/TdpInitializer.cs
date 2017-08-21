using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TDP_CRUD2.Models;

namespace TDP_CRUD2.DAL
{
    public class TdpInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TdpContext>
    {
        protected override void Seed(TdpContext context)
        {
            var products = new List<Product>
            {
            new Product{Name="Aqualight",Description="botella de agua sin gas", categoryID=1},
            new Product{Name="Doritos",Description="piqueos", categoryID=2},
            new Product{Name="Cusqueña",Description="Bebida con alcohol", categoryID=3},
            };

            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
            var categories = new List<Category>
            {
                new Category{CategoryID=1,Name="Bebidas",Description="Bebidas refrescantes" },
            new Category{CategoryID=2,Name="piqueos", Description="Snacks para picar"},
            new Category{CategoryID=3,Name="Tragos", Description="Bebidas con alcohol"},
  
            };

        }
    }
}